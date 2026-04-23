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
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var dados = from linha in funcionarios.GetData() select linha;
            foreach (FuncionariosRow linha in dados) lboFuncionarios.Items.Add(linha);
        }

      
    }
}
