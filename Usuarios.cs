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
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            var obterUsuarios = from linha in usuarios.GetData() select linha;
            foreach (var usuario in obterUsuarios) lboUsuarios.Items.Add(usuario);
        }

        
    }
}
