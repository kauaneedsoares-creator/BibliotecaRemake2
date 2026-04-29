using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaRemake
{
    public partial class Login : Form
    {
        public bool saida;
        public Login()
        {
            InitializeComponent();
        }

        private void lbllSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com");
        }

        private void btnEntre_Click(object sender, EventArgs e)
        {
           verificarAcessoTableAdapter consuta = new verificarAcessoTableAdapter();
            var usuario = (from linha in consuta.GetData(txtUsuarios.Text, txtSenha.Text)
                           select linha).FirstOrDefault();
            if (usuario == null )
            {
                MessageBox.Show("O login esta errado ou não existe. \nVericar com o suporte");
                return; 
            }
           saida = true;
           Close();
        }
    }
}
