namespace BibliotecaRemake
{
    partial class Usuarios
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
            this.btnLimparSelecão = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lboUsuarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTelefoneUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLimparSelecão
            // 
            this.btnLimparSelecão.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnLimparSelecão.FlatAppearance.BorderSize = 0;
            this.btnLimparSelecão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparSelecão.ForeColor = System.Drawing.Color.White;
            this.btnLimparSelecão.Location = new System.Drawing.Point(251, 288);
            this.btnLimparSelecão.Name = "btnLimparSelecão";
            this.btnLimparSelecão.Size = new System.Drawing.Size(187, 45);
            this.btnLimparSelecão.TabIndex = 45;
            this.btnLimparSelecão.Text = "Limpar Selecão";
            this.btnLimparSelecão.UseVisualStyleBackColor = false;
            this.btnLimparSelecão.Click += new System.EventHandler(this.btnLimparSelecão_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.Location = new System.Drawing.Point(38, 293);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(97, 40);
            this.btnAjustes.TabIndex = 44;
            this.btnAjustes.Text = "Cadastrar";
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnAcoes
            // 
            this.btnAcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnAcoes.FlatAppearance.BorderSize = 0;
            this.btnAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcoes.ForeColor = System.Drawing.Color.White;
            this.btnAcoes.Location = new System.Drawing.Point(144, 293);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(97, 40);
            this.btnAcoes.TabIndex = 43;
            this.btnAcoes.Text = "Atulizar Lista";
            this.btnAcoes.UseVisualStyleBackColor = false;
            this.btnAcoes.Click += new System.EventHandler(this.btnAcoes_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.White;
            this.txtPesquisa.Location = new System.Drawing.Point(255, 45);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(187, 17);
            this.txtPesquisa.TabIndex = 62;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(281, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Pesquisar Usuarios";
            // 
            // lboUsuarios
            // 
            this.lboUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.lboUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboUsuarios.ForeColor = System.Drawing.Color.White;
            this.lboUsuarios.FormattingEnabled = true;
            this.lboUsuarios.Location = new System.Drawing.Point(255, 68);
            this.lboUsuarios.Name = "lboUsuarios";
            this.lboUsuarios.Size = new System.Drawing.Size(187, 195);
            this.lboUsuarios.TabIndex = 47;
            this.lboUsuarios.SelectedIndexChanged += new System.EventHandler(this.lboUsuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Digite as informações do Usuarios";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(18, 178);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 68;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(35, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 67;
            this.lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(32, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 66;
            this.lblNome.Text = "Nome";
            // 
            // txtTelefoneUsuario
            // 
            this.txtTelefoneUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtTelefoneUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneUsuario.ForeColor = System.Drawing.Color.White;
            this.txtTelefoneUsuario.Location = new System.Drawing.Point(73, 167);
            this.txtTelefoneUsuario.Name = "txtTelefoneUsuario";
            this.txtTelefoneUsuario.Size = new System.Drawing.Size(143, 24);
            this.txtTelefoneUsuario.TabIndex = 65;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtEmailUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUsuario.ForeColor = System.Drawing.Color.White;
            this.txtEmailUsuario.Location = new System.Drawing.Point(73, 110);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(143, 24);
            this.txtEmailUsuario.TabIndex = 64;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.txtNomeUsuario.Location = new System.Drawing.Point(73, 59);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(143, 24);
            this.txtNomeUsuario.TabIndex = 63;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtTelefoneUsuario);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lboUsuarios);
            this.Controls.Add(this.btnLimparSelecão);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.btnAcoes);
            this.Name = "Usuarios";
            this.Size = new System.Drawing.Size(482, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimparSelecão;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lboUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtTelefoneUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
    }
}
