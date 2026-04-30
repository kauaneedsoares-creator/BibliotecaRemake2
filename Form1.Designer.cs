namespace BibliotecaRemake
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcControle = new MaterialSkin.Controls.MaterialTabControl();
            this.TpTelaPricipal = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tpFuncionarios = new System.Windows.Forms.TabPage();
            this.tpLivros = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.tpEmpréstimo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.tcEmprestimo = new MaterialSkin.Controls.MaterialTabControl();
            this.tpEPrincipal = new System.Windows.Forms.TabPage();
            this.tpEmprestar = new System.Windows.Forms.TabPage();
            this.tpDevolver = new System.Windows.Forms.TabPage();
            this.tpConsutar = new System.Windows.Forms.TabPage();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnEmpréstimo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.tcControle.SuspendLayout();
            this.TpTelaPricipal.SuspendLayout();
            this.tpEmpréstimo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tcEmprestimo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcControle
            // 
            this.tcControle.Controls.Add(this.TpTelaPricipal);
            this.tcControle.Controls.Add(this.tpFuncionarios);
            this.tcControle.Controls.Add(this.tpLivros);
            this.tcControle.Controls.Add(this.tpUsuarios);
            this.tcControle.Controls.Add(this.tpEmpréstimo);
            this.tcControle.Depth = 0;
            this.tcControle.Location = new System.Drawing.Point(191, 4);
            this.tcControle.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcControle.Multiline = true;
            this.tcControle.Name = "tcControle";
            this.tcControle.SelectedIndex = 0;
            this.tcControle.Size = new System.Drawing.Size(609, 449);
            this.tcControle.TabIndex = 0;
            // 
            // TpTelaPricipal
            // 
            this.TpTelaPricipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.TpTelaPricipal.Controls.Add(this.label1);
            this.TpTelaPricipal.Location = new System.Drawing.Point(4, 22);
            this.TpTelaPricipal.Name = "TpTelaPricipal";
            this.TpTelaPricipal.Padding = new System.Windows.Forms.Padding(3);
            this.TpTelaPricipal.Size = new System.Drawing.Size(601, 423);
            this.TpTelaPricipal.TabIndex = 0;
            this.TpTelaPricipal.Text = "Tela Pricipal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Tela inicio";
            // 
            // tpFuncionarios
            // 
            this.tpFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(6)))), ((int)(((byte)(153)))));
            this.tpFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionarios.Name = "tpFuncionarios";
            this.tpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarios.Size = new System.Drawing.Size(601, 423);
            this.tpFuncionarios.TabIndex = 2;
            this.tpFuncionarios.Text = "Funcionarios";
            // 
            // tpLivros
            // 
            this.tpLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(6)))), ((int)(((byte)(153)))));
            this.tpLivros.Location = new System.Drawing.Point(4, 22);
            this.tpLivros.Name = "tpLivros";
            this.tpLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tpLivros.Size = new System.Drawing.Size(601, 423);
            this.tpLivros.TabIndex = 3;
            this.tpLivros.Text = "Livros";
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(6)))), ((int)(((byte)(153)))));
            this.tpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuarios.Size = new System.Drawing.Size(601, 423);
            this.tpUsuarios.TabIndex = 4;
            this.tpUsuarios.Text = "Usuarios";
            // 
            // tpEmpréstimo
            // 
            this.tpEmpréstimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.tpEmpréstimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpEmpréstimo.Controls.Add(this.tableLayoutPanel2);
            this.tpEmpréstimo.Location = new System.Drawing.Point(4, 22);
            this.tpEmpréstimo.Name = "tpEmpréstimo";
            this.tpEmpréstimo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmpréstimo.Size = new System.Drawing.Size(601, 423);
            this.tpEmpréstimo.TabIndex = 5;
            this.tpEmpréstimo.Text = "Empréstimo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tcEmprestimo, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(595, 417);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.78778F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.12733F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnDevolver, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEmprestar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnConsulta, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSelecionar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(589, 27);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(444, 3);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(141, 21);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnEmprestar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmprestar.FlatAppearance.BorderSize = 0;
            this.btnEmprestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestar.ForeColor = System.Drawing.Color.White;
            this.btnEmprestar.Location = new System.Drawing.Point(296, 3);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(141, 21);
            this.btnEmprestar.TabIndex = 2;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = false;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(150, 3);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(140, 21);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelecionar.FlatAppearance.BorderSize = 0;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(3, 3);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(141, 21);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // tcEmprestimo
            // 
            this.tcEmprestimo.Controls.Add(this.tpEPrincipal);
            this.tcEmprestimo.Controls.Add(this.tpEmprestar);
            this.tcEmprestimo.Controls.Add(this.tpDevolver);
            this.tcEmprestimo.Controls.Add(this.tpConsutar);
            this.tcEmprestimo.Depth = 0;
            this.tcEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEmprestimo.Location = new System.Drawing.Point(3, 36);
            this.tcEmprestimo.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcEmprestimo.Name = "tcEmprestimo";
            this.tcEmprestimo.SelectedIndex = 0;
            this.tcEmprestimo.Size = new System.Drawing.Size(589, 378);
            this.tcEmprestimo.TabIndex = 0;
            // 
            // tpEPrincipal
            // 
            this.tpEPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.tpEPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpEPrincipal.Name = "tpEPrincipal";
            this.tpEPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpEPrincipal.Size = new System.Drawing.Size(581, 352);
            this.tpEPrincipal.TabIndex = 0;
            this.tpEPrincipal.Text = "Principal";
            // 
            // tpEmprestar
            // 
            this.tpEmprestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.tpEmprestar.Location = new System.Drawing.Point(4, 22);
            this.tpEmprestar.Name = "tpEmprestar";
            this.tpEmprestar.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestar.Size = new System.Drawing.Size(581, 352);
            this.tpEmprestar.TabIndex = 1;
            this.tpEmprestar.Text = "Emprestar";
            // 
            // tpDevolver
            // 
            this.tpDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.tpDevolver.Location = new System.Drawing.Point(4, 22);
            this.tpDevolver.Name = "tpDevolver";
            this.tpDevolver.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolver.Size = new System.Drawing.Size(581, 352);
            this.tpDevolver.TabIndex = 2;
            this.tpDevolver.Text = "Devolver";
            // 
            // tpConsutar
            // 
            this.tpConsutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.tpConsutar.Location = new System.Drawing.Point(4, 22);
            this.tpConsutar.Name = "tpConsutar";
            this.tpConsutar.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsutar.Size = new System.Drawing.Size(581, 352);
            this.tpConsutar.TabIndex = 3;
            this.tpConsutar.Text = "Consultar";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Location = new System.Drawing.Point(3, 3);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(183, 50);
            this.btnFuncionarios.TabIndex = 14;
            this.btnFuncionarios.Text = "😒Funcionarios";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnEmpréstimo
            // 
            this.btnEmpréstimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnEmpréstimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpréstimo.FlatAppearance.BorderSize = 0;
            this.btnEmpréstimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpréstimo.ForeColor = System.Drawing.Color.White;
            this.btnEmpréstimo.Location = new System.Drawing.Point(3, 171);
            this.btnEmpréstimo.Name = "btnEmpréstimo";
            this.btnEmpréstimo.Size = new System.Drawing.Size(183, 51);
            this.btnEmpréstimo.TabIndex = 13;
            this.btnEmpréstimo.Text = "Empréstimo";
            this.btnEmpréstimo.UseVisualStyleBackColor = false;
            this.btnEmpréstimo.Click += new System.EventHandler(this.btnEmpréstimo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnEmpréstimo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLivros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnHome, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnFuncionarios, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUsuarios, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(189, 276);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnLivros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(3, 59);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(183, 56);
            this.btnLivros.TabIndex = 11;
            this.btnLivros.Text = "📚 Livros\r\n";
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(3, 228);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(183, 45);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "🏠Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 121);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(183, 44);
            this.btnUsuarios.TabIndex = 10;
            this.btnUsuarios.Text = "🧌Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tcControle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcControle.ResumeLayout(false);
            this.TpTelaPricipal.ResumeLayout(false);
            this.TpTelaPricipal.PerformLayout();
            this.tpEmpréstimo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tcEmprestimo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcControle;
        private System.Windows.Forms.TabPage TpTelaPricipal;
        private System.Windows.Forms.TabPage tpFuncionarios;
        private System.Windows.Forms.TabPage tpLivros;
        private System.Windows.Forms.TabPage tpUsuarios;
        private System.Windows.Forms.TabPage tpEmpréstimo;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnEmpréstimo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnDevolver;
        private MaterialSkin.Controls.MaterialTabControl tcEmprestimo;
        private System.Windows.Forms.TabPage tpEPrincipal;
        private System.Windows.Forms.TabPage tpEmprestar;
        private System.Windows.Forms.TabPage tpDevolver;
        private System.Windows.Forms.TabPage tpConsutar;
    }
}

