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
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lboConsuta = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Digite um livro  para consutar";
            // 
            // txtConsuta
            // 
            this.txtConsuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtConsuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsuta.Location = new System.Drawing.Point(21, 85);
            this.txtConsuta.Name = "txtConsuta";
            this.txtConsuta.Size = new System.Drawing.Size(478, 20);
            this.txtConsuta.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Empretimo ";
            // 
            // lboConsuta
            // 
            this.lboConsuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.lboConsuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboConsuta.ForeColor = System.Drawing.Color.White;
            this.lboConsuta.FormattingEnabled = true;
            this.lboConsuta.Location = new System.Drawing.Point(21, 139);
            this.lboConsuta.Name = "lboConsuta";
            this.lboConsuta.Size = new System.Drawing.Size(478, 195);
            this.lboConsuta.TabIndex = 94;
          
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
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.btnDevolucao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConsuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lboConsuta);
            this.Controls.Add(this.label4);
            this.Name = "Devolucao";
            this.Size = new System.Drawing.Size(523, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboConsuta;
        private System.Windows.Forms.Label label4;
    }
}
