namespace BibliotecaRemake
{
    partial class Emprestimo
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboUsuarios = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lboLivros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLivros = new System.Windows.Forms.TextBox();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lboUsuarios
            // 
            this.lboUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.lboUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboUsuarios.ForeColor = System.Drawing.Color.White;
            this.lboUsuarios.FormattingEnabled = true;
            this.lboUsuarios.Location = new System.Drawing.Point(260, 131);
            this.lboUsuarios.Name = "lboUsuarios";
            this.lboUsuarios.Size = new System.Drawing.Size(236, 195);
            this.lboUsuarios.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Selecione quem é Você";
            // 
            // lboLivros
            // 
            this.lboLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.lboLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboLivros.ForeColor = System.Drawing.Color.White;
            this.lboLivros.FormattingEnabled = true;
            this.lboLivros.Location = new System.Drawing.Point(18, 131);
            this.lboLivros.Name = "lboLivros";
            this.lboLivros.Size = new System.Drawing.Size(227, 195);
            this.lboLivros.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Livros";
            // 
            // txtLivros
            // 
            this.txtLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtLivros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLivros.Location = new System.Drawing.Point(18, 77);
            this.txtLivros.Name = "txtLivros";
            this.txtLivros.Size = new System.Drawing.Size(227, 20);
            this.txtLivros.TabIndex = 86;
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarios.Location = new System.Drawing.Point(260, 77);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(236, 20);
            this.txtUsuarios.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Digite um livro para consutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(257, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 89;
            this.label5.Text = "Digite um Cliente";
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnEmprestar.FlatAppearance.BorderSize = 0;
            this.btnEmprestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestar.ForeColor = System.Drawing.Color.White;
            this.btnEmprestar.Location = new System.Drawing.Point(18, 332);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(478, 40);
            this.btnEmprestar.TabIndex = 90;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = false;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(18, 27);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(478, 21);
            this.cboFuncionario.TabIndex = 91;
            // 
            // Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.txtLivros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboLivros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lboUsuarios);
            this.Name = "Emprestimo";
            this.Size = new System.Drawing.Size(505, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lboUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lboLivros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLivros;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.ComboBox cboFuncionario;
    }
}
