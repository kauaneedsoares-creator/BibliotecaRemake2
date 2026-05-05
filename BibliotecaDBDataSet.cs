using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace BibliotecaRemake
{

    partial class BibliotecaDBDataSet
    {
        partial class UsuariosRow
        {
            public override string ToString()
            {

                return Nome.ToString();

            }
        }

        partial class RequisicoesRow
        {
            public string Devolucao
            {
                get
                {
                    try
                    {

                        return DataDevolucao.ToString();

                    }
                    catch
                    {
                        return "Devolvido";
                    }
                    return Status.ToString();
                }
            }
            public override string ToString()
            {
                LivrosTableAdapter livros = new LivrosTableAdapter();
                LivrosRow livro = (from linha in livros.GetData()
                                   where linha.LivroID == this.LivroID
                                   select linha).FirstOrDefault();


                return livro.Titulo + " - " + this.Status;

            }

        
        }

    


        partial class FuncionariosRow
        {
            public override string ToString()
            {
                return NomeUsuario.ToString();
            }
        }

        partial class LivrosRow
        {
            public override string ToString()
            {
                return Titulo.ToString();
            }

        }
    }
}
