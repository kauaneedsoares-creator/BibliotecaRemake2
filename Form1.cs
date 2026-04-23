using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaRemake
{
    public partial class Form1 : Form
    {
       
        private Funcionários funcionários;
        private Livros Livros;
        private Emprestimo emprestimo;
        private Usuarios usuarios;
        private Consulta consulta;
    
        
        public Form1()
        {
            InitializeComponent(); //
        }
       public void MudarCorDeBotoes()
       {
            Color corPadraoFundo = Color.FromArgb (32, 88, 150);
            Color corPadraoTexto = Color.White;
            btnHome.BackColor = corPadraoFundo;
            btnHome.ForeColor = corPadraoTexto;

            btnLivros.BackColor = corPadraoFundo;
            btnLivros.ForeColor = corPadraoTexto;

            btnUsuarios.BackColor = corPadraoFundo;
            btnUsuarios.ForeColor = corPadraoTexto;

            btnFuncionarios.BackColor = corPadraoFundo;
            btnFuncionarios.ForeColor = corPadraoTexto;
         
            btnEmpréstimo.BackColor = corPadraoFundo;
            btnEmpréstimo.ForeColor = corPadraoTexto;

            


       }
        private void VoltarTelaPrincipal(object sender, EventArgs e)
        {
            tcControle.SelectTab(TpTelaPricipal);
        }
       

        private void btnLivros_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((Button)sender).BackColor = Color.FromArgb(78, 88, 150);
            btnLivros.ForeColor = Color.White;
            if  (Livros != null) 
            Livros.Dispose(); //Vou limpar todos os elementos
            Livros = null; //Garantir que não mais referência ao controle antigo
            tpLivros.Controls.Clear(); //Limpar os controles do TapPage para eviter sobreposicão
            Livros = new Livros(); //cria um novo controle Livros
            Livros.Dock = DockStyle.Fill;
            tpLivros.Controls.Add(Livros); //Adicione o novo controle ao TabPage
            tcControle.SelectTab(tpLivros); //Agora entre na aba de livros
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((Button)sender).BackColor = Color.FromArgb(78, 88, 150);
            btnFuncionarios.ForeColor = Color.White; 
            funcionários = new Funcionários();
            funcionários.Dock = DockStyle.Fill;
            tpFuncionarios.Controls.Add(funcionários);
            tcControle.SelectTab(tpFuncionarios);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((Button)sender).BackColor = Color.FromArgb(78, 88, 150);
            btnUsuarios.ForeColor = Color.White;
            usuarios = new Usuarios();
            usuarios.Dock = DockStyle.Fill;
            tpUsuarios.Controls.Add(usuarios);
            tcControle.SelectTab(tpUsuarios);
        }

        private void btnEmpréstimo_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((Button)sender).BackColor = Color.FromArgb(78, 88, 150);
            btnEmpréstimo.ForeColor = Color.White;
            tcControle.SelectTab(tpEmpréstimo);
            emprestimo = new Emprestimo();
            emprestimo.Dock = DockStyle.Fill;
            tpEmpréstimo.Controls.Add(emprestimo);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((Button)sender).BackColor = Color.FromArgb(78, 88, 150);
            btnHome.ForeColor = Color.Black;
            tcControle.SelectTab(tpEmpréstimo);
            tcControle.SelectTab(TpTelaPricipal);
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((Button)sender).BackColor = Color.FromArgb(78, 88, 150);
            btnEmprestar.ForeColor = Color.White; 
            if (emprestimo != null) emprestimo.Dispose();
            emprestimo = new Emprestimo();
            emprestimo.Dock = DockStyle.Fill;
            tcEmprestimo.SelectTab(tpEmprestar);
            tpEmprestar.Controls.Add(emprestimo);

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            tcEmprestimo.SelectTab(tpEPrincipal);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((Button)sender).BackColor = Color.FromArgb(78, 88, 150);
            btnConsulta.ForeColor = Color.White;
            if (consulta != null) consulta.Dispose();
            consulta = new Consulta();
            consulta.Dock = DockStyle.Fill;
            tcEmprestimo.SelectTab(tpConsutar);
            tpConsutar.Controls.Add(consulta);
        }
    }
}
