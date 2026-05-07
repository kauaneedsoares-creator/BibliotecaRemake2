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
    public partial class Funcionários : UserControl
    {
        public Funcionários()
        {
            InitializeComponent();
            AtulizarLista();
            lboFuncionarios.Items.Clear();
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var obterfuncionarios = from linha in funcionarios.GetData() select linha;
            foreach (var funcionario in obterfuncionarios) lboFuncionarios.Items.Add(funcionario);

        }
        private void AtulizarLista()
        {
            lboFuncionarios.Items.Clear();
            FuncionariosTableAdapter funcionariosdados = new FuncionariosTableAdapter();
            var dados = from linha in funcionariosdados.GetData() 
                        select linha;
            foreach (FuncionariosRow dado in dados) lboFuncionarios.Items.Add(dado);

        }
        private void LimparElementos()
        {
            txtFuncionarios.Text = "";
            txtNomeFuncionarios.Text = "";
            txtCargo.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
           
        }


        private void btnLimparSelecão_Click(object sender, EventArgs e)
        {
            lboFuncionarios.ClearSelected();

            LimparElementos();
            btnAcoess.Text = "Cadastrar";
            btnAjustess.Text = "Atulizar Lista";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

            TextBox pesquisa = sender as TextBox;
            if (pesquisa.Text == "")
            {
                return;
            }
            lboFuncionarios.ClearSelected();
            lboFuncionarios.Items.Clear();
            string textoDigitado = txtPesquisa.Text;
            FuncionariosTableAdapter dadosFuncionarios = new FuncionariosTableAdapter();
            var funcionarios = from linha in dadosFuncionarios.GetData()
                          where linha.NomeUsuario.ToLower()
                          .Contains(textoDigitado.ToLower())
                          select linha;
            foreach (var Funcionarios in funcionarios) lboFuncionarios.Items.Add(Funcionarios);
        }

        private void btnAjustess_Click(object sender, EventArgs e)
        {
            // Verifica se o botão está no modo "Cadastrar"
            if (btnAjustess.Text == "Cadastrar")
            {
                string nomeUsuario = txtFuncionarios.Text;
                string senha = txtSenha.Text;
                string nome = txtNomeFuncionarios.Text;
                string cargo = txtCargo.Text;
                string email = txtEmail.Text;
                bool ativo = cbxAtivo.Checked;
                FuncionariosTableAdapter funcionario = new FuncionariosTableAdapter();
                funcionario.Insert(nomeUsuario, senha, nome, cargo, email, ativo);
                LimparElementos();
                AtulizarLista();
            }
            // Caso não seja cadastro, então é atualização
            else
            {
                if (lboFuncionarios.SelectedItem == null)
                {
                    LimparElementos();
                    lboFuncionarios.ClearSelected();
                    return;
                }
                FuncionariosRow funcionário = lboFuncionarios.SelectedItem as FuncionariosRow;
                if (funcionário == null) return;
                funcionário.NomeUsuario = txtFuncionarios.Text;
                funcionário.SenhaHash = txtSenha.Text;
                funcionário.NomeCompleto = txtNomeFuncionarios.Text;
                funcionário.Cargo = txtCargo.Text;
                funcionário.Email = txtEmail.Text;
                funcionário.Ativo = cbxAtivo.Checked;
                FuncionariosTableAdapter funcionários = new FuncionariosTableAdapter();
                funcionários.Update(funcionário.FuncionarioID, funcionário.NomeUsuario, funcionário.SenhaHash, funcionário.NomeCompleto, funcionário.Cargo, funcionário.Email, funcionário.Ativo);
                // Volta os botões para o estado padrão
                btnAcoess.Text = "Cadastrar";
                btnAjustess.Text = "Atulizar Lista";
                LimparElementos();
                AtulizarLista();
            }
        }

        private void btnAcoess_Click(object sender, EventArgs e)
        {
            if (btnAcoess.Text == "Excluir") // Só faz alguma coisa se o texto do botão for "Excluir"
            {
                if (lboFuncionarios.SelectedItem == null) return;
                FuncionariosRow funcionario = lboFuncionarios.SelectedItem as FuncionariosRow;
                if (funcionario == null) return;
                // Conecta com o banco de dados e apaga o usuarios usando o ID dele
                FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                funcionarios.Delete(funcionario.FuncionarioID);
               
                LimparElementos();
                AtulizarLista();

                // Volta os botões para o estado normal (Cadastrar e Atualizar Lista)
                btnAcoess.Text = "Atulizar Lista";
                btnAjustess.Text = "Cadastrar";


            }
        }

        private void lboFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboFuncionarios.SelectedItem == null) return; // Pega as informações do usuarios  que foi clicado na lista
            // Identifica qual usuario foi clicado na lista
            FuncionariosRow funcionario = lboFuncionarios.SelectedItem as FuncionariosRow;
            if (funcionario == null) return;
            // Muda o texto dos botões para as opções de editar ou apagar
            btnAcoess.Text = "Excluir";
            btnAjustess.Text = "Atulizar";

            // Joga os dados do usuario para as listBox de texto na tela
            txtFuncionarios.Text = funcionario.NomeUsuario;
            txtNomeFuncionarios.Text = funcionario.NomeCompleto;
            txtCargo.Text = funcionario.Cargo;
            txtEmail.Text = funcionario.Email;
            cbxAtivo.Checked = funcionario.Ativo;

            


        }

       
    }
}
