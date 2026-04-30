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
    public partial class Devolucao : UserControl
    {
        public Devolucao()
        {
            InitializeComponent();
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var obterFuncionarios = from linha in funcionarios.GetData() select linha;
            foreach (var Funcionarios in obterFuncionarios) cboFuncionario.Items.Add(Funcionarios);
            cboFuncionario.SelectedIndex = 0;
            //ate aqui
            RequisicoesTableAdapter Devolucao = new RequisicoesTableAdapter();
            var obterDevolucao = from linha in Devolucao.GetData()
                                 select linha;
            foreach (var devolucao in obterDevolucao) lboConsuta.Items.Add(devolucao);
            //
          
        }



        private void btnDevolucao_Click(object sender, EventArgs e)
        {
           
        
            RequisicoesRow livroDevolver = lboConsuta.SelectedItem as RequisicoesRow;
            FuncionariosRow funcionarioSelecionado = cboFuncionario.SelectedItem as FuncionariosRow;

            if (livroDevolver == null)
            {
                MessageBox.Show("Selecione um empréstimo!");
                return;
            }

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show("Selecione um funcionário!");
                return;
            }

            QueriesTableAdapter consulta = new QueriesTableAdapter();

            consulta.DevolverLivro
            (
                livroDevolver.LivroID,
                livroDevolver.UsuarioID,
                funcionarioSelecionado.FuncionarioID
            );

            MessageBox.Show("Empréstimo devolvido com sucesso!");

            // remove da lista após devolver
            lboConsuta.Items.Remove(livroDevolver);
        }
    }

    
      
    
}
