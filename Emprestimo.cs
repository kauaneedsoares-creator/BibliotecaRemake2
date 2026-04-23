using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaRemake.BibliotecaDBDataSet;

namespace BibliotecaRemake
{
    public partial class Emprestimo : UserControl
    {
        public Emprestimo()
        {
            InitializeComponent();
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var obterFuncionarios = from linha in funcionarios.GetData() select linha;
            foreach (var Funcionarios in obterFuncionarios) cboFuncionario.Items.Add(Funcionarios);
            cboFuncionario.SelectedIndex = 0;
            //ate aqui
            LivrosTableAdapter livros = new LivrosTableAdapter();
            var obterLivros = from linha in livros.GetData() 
                              select linha;
            foreach(var livro in obterLivros) lboLivros.Items.Add(livro);
            //
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            var obterUsuarios = from linha in usuarios.GetData() 
                                select linha;
            foreach (var usuario in obterUsuarios) lboUsuarios.Items.Add(usuario);
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
           LivrosRow livroSelecionado = lboLivros.SelectedItem as LivrosRow;
            UsuariosRow usuarioSelecionado = lboUsuarios.SelectedItem as UsuariosRow;
            FuncionariosRow funcionarioSelecionado = cboFuncionario.SelectedItem as FuncionariosRow;
            if (usuarioSelecionado == null) return;
            else if (livroSelecionado == null) return;
            else if (funcionarioSelecionado == null) ;
            QueriesTableAdapter consulta = new QueriesTableAdapter();
            consulta.EmprestarLivro
             (
               livroSelecionado.LivroID,
               funcionarioSelecionado.FuncionarioID,
               usuarioSelecionado.UsuarioID   
             );
            MessageBox.Show($"O EMPRESTIMO FICOU PARA SER DEVOLVIDO NO DIA{DateTime.Now.AddDays(7)}");
        }
    }
    
}
