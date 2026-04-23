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
    public partial class Consulta : UserControl
    {
        public Consulta()
        {
            InitializeComponent();
           RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            lboConsulta.Items.AddRange(requisicoes.GetData().ToArray());
        }

        private void lboConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequisicoesRow requisicoes = lboConsulta.SelectedItem as RequisicoesRow;
            if (requisicoes == null) return;
            lblDataEmprestimo.Text = requisicoes.DataRequisicao.ToString();
            lblDataDevolucao.Text = requisicoes.Devolucao;
            lblStatus.Text = requisicoes.Status;
            LivrosTableAdapter livros = new LivrosTableAdapter();
            LivrosRow livro = (from linha in livros.GetData()
                where linha.LivroID == requisicoes.LivroID
                select linha).FirstOrDefault();

            if (livro == null) return;
            lblFuncionarios.Text = livro.Titulo;
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            FuncionariosRow funcionario = (from linha in funcionarios.GetData()
                                           where linha.FuncionarioID == requisicoes.FuncionarioID
                                           select linha).FirstOrDefault();

            if (funcionario == null) return;
            lblFuncionarios.Text = funcionario.NomeCompleto;
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            UsuariosRow usuario = (from linha in usuarios.GetData()
                                            where linha.UsuarioID == requisicoes.UsuarioID
                                            select linha).FirstOrDefault();
            if (usuario == null) return;
            lblUsuario.Text = usuario.Nome;
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text == " ")
            {
                RequisicoesTableAdapter dados = new RequisicoesTableAdapter();
                lboConsulta.Items.AddRange(dados.GetData().ToArray());
                return;
            }
            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            lboConsulta.Items.Clear();
            lboConsulta.Items.AddRange
            (
                (from linha in requisicoes.GetData()
                 where requisicoes.ToString().ToLower().Contains(txtConsulta.Text)
                 select linha).ToArray()
            );
        }
    }
}
