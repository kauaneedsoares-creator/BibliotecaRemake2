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
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
            AtulizarLista();

            //Isso só vai mostra as Informções 
          
           
        }
        private void AtulizarLista() //issa vai atulizar seria como Salvar/Editar
        {
            lboUsuarios.Items.Clear();
            UsuariosTableAdapter usuariosDados = new UsuariosTableAdapter();
            var dados = from linha in usuariosDados.GetData()
                        select linha;
            foreach (UsuariosRow dado in dados) lboUsuarios.Items.Add(dado);
        }

        private void LimparElementos()
        {
            txtNomeUsuario.Text = "";
            txtEmailUsuario.Text = "";
            txtTelefoneUsuario.Text = "";
           
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            // Verifica se o botão está no modo "Cadastrar"
            if (btnAjustes.Text == "Cadastrar")
            {
                string nome = txtNomeUsuario.Text;
                string email = txtEmailUsuario.Text;
                string telefone =txtTelefoneUsuario.Text;
                UsuariosTableAdapter usuario = new UsuariosTableAdapter();
                usuario.Insert(nome, email, telefone);
                LimparElementos();
                AtulizarLista();
            }
            // Caso não seja cadastro, então é atualização
            else
            {
                if (lboUsuarios.SelectedItem == null)
                {
                    LimparElementos();
                    lboUsuarios.ClearSelected();
                    return;
                }
                UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
                if (usuario == null) return;
                usuario.Nome = txtNomeUsuario.Text;
                usuario.Email = txtEmailUsuario.Text;
                usuario.Telefone = txtTelefoneUsuario.Text;
                 UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                    usuarios.Update(usuario.UsuarioID, usuario.Nome, usuario.Email, usuario.Telefone);
                // Volta os botões para o estado padrão
                btnAcoes.Text = "Cadastrar";
                    btnAjustes.Text = "Atulizar Lista";
                    LimparElementos();
                AtulizarLista();

            }
        }
        

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir") // Só faz alguma coisa se o texto do botão for "Excluir"
            {
                if (lboUsuarios.SelectedItem == null) return;
                UsuariosRow usuario = lboUsuarios.SelectedItem as UsuariosRow;
                if (usuario == null) return;
                // Conecta com o banco de dados e apaga o usuarios usando o ID dele
                UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                usuarios.Delete(usuario.UsuarioID);

                LimparElementos();
                AtulizarLista();

                // Volta os botões para o estado normal (Cadastrar e Atualizar Lista)
                btnAcoes.Text = "Atulizar Lista";
                btnAjustes.Text = "Cadastrar";


            }
        }

        private void btnLimparSelecão_Click(object sender, EventArgs e)
        {
            lboUsuarios.ClearSelected();
            
            LimparElementos();
            btnAcoes.Text = "Cadastrar";
            btnAjustes.Text = "Atulizar Lista";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisa = sender as TextBox;
            if (pesquisa.Text == "")
            {
                return;
            }
            lboUsuarios.ClearSelected();
            lboUsuarios.Items.Clear();
            string textoDigitado = txtPesquisa.Text;
            UsuariosTableAdapter dadosUsuarios = new UsuariosTableAdapter();
            var usuario = from linha in dadosUsuarios.GetData()
                         where linha.Nome.ToLower()
                         .Contains(textoDigitado.ToLower())
                         select linha;
            foreach (var Usuarios in usuario) lboUsuarios.Items.Add(Usuarios);
        }

        private void lboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return; // Pega as informações do usuarios  que foi clicado na lista
            // Identifica qual usuario foi clicado na lista
            UsuariosRow usuario  = lboUsuarios.SelectedItem as UsuariosRow;
            if (usuario == null) return;
            // Muda o texto dos botões para as opções de editar ou apagar
            btnAcoes.Text = "Excluir";
            btnAjustes.Text = "Atulizar";

            // Joga os dados do usuario para as listBox de texto na tela
            txtTelefoneUsuario.Text = usuario.Telefone;
            txtEmailUsuario.Text = usuario.Email;
            txtNomeUsuario.Text = usuario.Nome;
           
        }
    }
}
