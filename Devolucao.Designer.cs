namespace BibliotecaRemake
{
    partial class Devolucao
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
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.txtLivros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lboLivros = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lboUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(21, 35);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(478, 21);
            this.cboFuncionario.TabIndex = 102;
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnDevolucao.FlatAppearance.BorderSize = 0;
            this.btnDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucao.ForeColor = System.Drawing.Color.White;
            this.btnDevolucao.Location = new System.Drawing.Point(21, 340);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(478, 40);
            this.btnDevolucao.TabIndex = 101;
            this.btnDevolucao.Text = "Devolução";
            this.btnDevolucao.UseVisualStyleBackColor = false;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(260, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 100;
            this.label5.Text = "Digite um Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Digite um livro para consutar";
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarios.Location = new System.Drawing.Point(263, 85);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(236, 20);
            this.txtUsuarios.TabIndex = 98;
            // 
            // txtLivros
            // 
            this.txtLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtLivros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLivros.Location = new System.Drawing.Point(21, 85);
            this.txtLivros.Name = "txtLivros";
            this.txtLivros.Size = new System.Drawing.Size(227, 20);
            this.txtLivros.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Livros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 95;
            this.label1.Text = "Usuarios";
            // 
            // lboLivros
            // 
            this.lboLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.lboLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboLivros.ForeColor = System.Drawing.Color.White;
            this.lboLivros.FormattingEnabled = true;
            this.lboLivros.Location = new System.Drawing.Point(21, 139);
            this.lboLivros.Name = "lboLivros";
            this.lboLivros.Size = new System.Drawing.Size(227, 195);
            this.lboLivros.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 93;
            this.label4.Text = "Selecione quem é Você";
            // 
            // lboUsuarios
            // 
            this.lboUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.lboUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboUsuarios.ForeColor = System.Drawing.Color.White;
            this.lboUsuarios.FormattingEnabled = true;
            this.lboUsuarios.Location = new System.Drawing.Point(263, 139);
            this.lboUsuarios.Name = "lboUsuarios";
            this.lboUsuarios.Size = new System.Drawing.Size(236, 195);
            this.lboUsuarios.TabIndex = 92;
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.btnDevolucao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.txtLivros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboLivros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lboUsuarios);
            this.Name = "Devolucao";
            this.Size = new System.Drawing.Size(523, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.TextBox txtLivros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboLivros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lboUsuarios;
    }
}
