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
    public partial class Livros : UserControl
    {
        public Livros()
        {
            InitializeComponent();
            AtulizarLista();
        }
        /// <summary>
        /// Pega todos os livros que estão salvos no banco de dados 
        /// e mostra eles dentro da lista (ListBox) na tela.
        /// </summary>
        private void AtulizarLista()
        {
            lboLivros.Items.Clear();
            LivrosTableAdapter LivrosDados = new LivrosTableAdapter();
            var dados = from linha in LivrosDados.GetData()
                        select linha;
            foreach (LivrosRow dado in dados) lboLivros.Items.Add(dado);
        }
        private void LimparElementos()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditora.Text = "";
            txtGenero.Text = "";
            txtISBN.Text = "";
            txtQuantidade.Text = "";
        }
        /// <summary>
        //Quando  clica em um livro na lista, esta parte faz os dados 
        /// dele aparecerem nas listBox da tela para  ver ou mudar.
        /// </summary>
        private void lboLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboLivros.SelectedItem == null) return; // Pega as informações do livro que foi clicado na lista
            // Identifica qual livro foi clicado na lista
            LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
            if (livro == null) return;
            // Muda o texto dos botões para as opções de editar ou apagar
            btnAcoes.Text = "Excluir";
            btnAjustes.Text = "Atulizar";

            // Joga os dados do livro para as listBox de texto na tela
            txtTitulo.Text = livro.Titulo;
            txtAutor.Text = livro.Autor;
            txtEditora.Text = livro.Editora;
            txtGenero.Text = livro.Genero;
            txtISBN.Text = livro.ISBN;
            txtQuantidade.Text = livro.QuantidadeDisponivel.ToString();
        }

        /// <summary>
        /// Faz a ação do botão: se estiver escrito "Excluir", ele apaga o livro 
        /// selecionado do banco de dados e limpa a tela.
        /// </summary>
        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir") // Só faz alguma coisa se o texto do botão for "Excluir"
            {
                if (lboLivros.SelectedItem == null) return;
                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                // Conecta com o banco de dados e apaga o livro usando o ID dele
                LivrosTableAdapter livros = new LivrosTableAdapter();
                livros.Delete(livro.LivroID);

                AtulizarLista();
                LimparElementos();

                // Volta os botões para o estado normal (Cadastrar e Atualizar Lista)
                btnAcoes.Text = "Atulizar Lista";
                btnAjustes.Text = "Cadastrar";


            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void btnAjustes_Click(object sender, EventArgs e)
        {
            //
            if (btnAjustes.Text == "Cadastrar")
            {
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string editora = txtEditora.Text;
                string genero = txtGenero.Text;
                string ISBN = txtISBN.Text;
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Insert(titulo, genero, autor, editora, ISBN, quantidade);
                    LimparElementos();
                    AtulizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name);
                }

            }
            //
            else
            {
                if (lboLivros.SelectedItem == null)
                {
                    AtulizarLista();
                    LimparElementos();
                    lboLivros.ClearSelected();
                    return;
                }
                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                livro.Titulo = txtTitulo.Text;
                livro.Autor = txtAutor.Text;
                livro.Editora = txtEditora.Text;
                livro.Genero = txtGenero.Text;
                livro.ISBN = txtISBN.Text;
                try
                {
                    livro.QuantidadeDisponivel = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Update(livro.LivroID, livro.Titulo, livro.Genero, livro.Autor, livro.Editora, livro.ISBN, livro.QuantidadeDisponivel);
                    btnAcoes.Text = "Cadastrar";
                    btnAjustes.Text = "Atulizar Lista";
                    AtulizarLista();
                    LimparElementos();
                }
                catch
                {
                    MessageBox.Show("NUMERO INAVALIDO", "ERRO DE DIGITACÃO");
                }
            }
        }

        private void btnLimparSelecão_Click(object sender, EventArgs e)
        {
            lboLivros.ClearSelected();
            AtulizarLista();
            LimparElementos();
            btnAcoes.Text = "Cadastrar";
            btnAjustes.Text = "Atulizar Lista";
        }

        /// <summary>
        /// Faz uma busca na lista de livros toda vez que você digita ou apaga
        /// </summary>
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisa = sender as TextBox;
            if (pesquisa.Text == "")
            {
                AtulizarLista();
                return;
            }
            lboLivros.ClearSelected();
            lboLivros.Items.Clear();
            string textoDigitado = txtPesquisa.Text;
            LivrosTableAdapter dados = new LivrosTableAdapter();
            var livros = from linha in dados.GetData()
                         where linha.Titulo.ToLower()
                         .Contains(textoDigitado.ToLower())
                         select linha;
            foreach (var livro in livros) lboLivros.Items.Add(livro);
        }
    }
}
