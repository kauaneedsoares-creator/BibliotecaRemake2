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
            foreach (var devolucao in obterDevolucao) lboDevolucao.Items.Add(devolucao);
            //
          
        }
        private void AtulizarLista() //issa vai atulizar seria como Salvar/Editar
        {
            lboDevolucao.Items.Clear();
            RequisicoesTableAdapter usuariosDados = new RequisicoesTableAdapter();
            var dados = from linha in usuariosDados.GetData()
                        select linha;
            foreach (RequisicoesRow dado in dados) lboDevolucao.Items.Add(dado);
        }



        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            var requisicaoSelecionada = lboDevolucao.SelectedItem as RequisicoesRow;

            if (requisicaoSelecionada == null)
            {
                MessageBox.Show(
                    "Selecione uma requisição para devolver.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                QueriesTableAdapter consulta = new QueriesTableAdapter();

                consulta.DevolverLivro(requisicaoSelecionada.RequisicaoID);

                MessageBox.Show(
                    $"Devolução realizada com sucesso!\n\n" +
                    $"Requisição ID: {requisicaoSelecionada.RequisicaoID}\n" +
                    $"Data de devolução: {DateTime.Now:dd/MM/yyyy}",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                //Atualiza lista
                AtulizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao realizar devolução",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }


        }

        private void lboDevolucao_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequisicoesRow requisicao = lboDevolucao.SelectedItem as RequisicoesRow;
            if (requisicao == null) return;
            lblDataEmprestimo.Text = requisicao.DataRequisicao.ToString();
            lblDataDevolucao.Text = requisicao.Devolucao;
            lblStatus.Text = requisicao.Status.ToString();
            LivrosTableAdapter livros = new LivrosTableAdapter();
            LivrosRow livro = (from linha in livros.GetData()
                               where linha.LivroID == requisicao.LivroID
                               select linha).FirstOrDefault();
            if (livro == null) return;
            lblTitulo.Text = livro.Titulo;
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            FuncionariosRow funcionario = (from linha in funcionarios.GetData()
                                           where linha.FuncionarioID == requisicao.FuncionarioID
                                           select linha).FirstOrDefault();
            if (funcionario == null) return;
            lblFuncionario.Text = funcionario.NomeCompleto;
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            UsuariosRow usuario = (from linha in usuarios.GetData()
                                   where linha.UsuarioID == requisicao.UsuarioID
                                   select linha).FirstOrDefault();
            if (usuario == null) return;
            lblUsuario.Text = usuario.Nome;
        }

       
    }
    

    
      
    
}
