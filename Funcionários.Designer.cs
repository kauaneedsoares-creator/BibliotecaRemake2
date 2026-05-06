namespace BibliotecaRemake
{
    partial class Funcionários
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionarios = new System.Windows.Forms.TextBox();
            this.txtFuncionarios = new System.Windows.Forms.TextBox();
            this.lboFuncionarios = new System.Windows.Forms.ListBox();
            this.btnLimparSelecão = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnAcoess = new System.Windows.Forms.Button();
            this.btnAjustess = new System.Windows.Forms.Button();
            this.cbxAtivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.White;
            this.txtPesquisa.Location = new System.Drawing.Point(259, 47);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(143, 17);
            this.txtPesquisa.TabIndex = 70;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(254, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Pesquisar Funcionarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(34, 260);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(143, 17);
            this.txtSenha.TabIndex = 67;
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.ForeColor = System.Drawing.Color.White;
            this.lblEmail1.Location = new System.Drawing.Point(33, 191);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(38, 13);
            this.lblEmail1.TabIndex = 66;
            this.lblEmail1.Text = " Email ";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(31, 135);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 65;
            this.lblCargo.Text = "Cargo";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.lblNomeCompleto.Location = new System.Drawing.Point(31, 79);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompleto.TabIndex = 64;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Location = new System.Drawing.Point(31, 31);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNomeUsuario.TabIndex = 63;
            this.lblNomeUsuario.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(34, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 17);
            this.txtEmail.TabIndex = 62;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.White;
            this.txtCargo.Location = new System.Drawing.Point(34, 151);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(143, 17);
            this.txtCargo.TabIndex = 61;
            // 
            // txtNomeFuncionarios
            // 
            this.txtNomeFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtNomeFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionarios.ForeColor = System.Drawing.Color.White;
            this.txtNomeFuncionarios.Location = new System.Drawing.Point(34, 95);
            this.txtNomeFuncionarios.Name = "txtNomeFuncionarios";
            this.txtNomeFuncionarios.Size = new System.Drawing.Size(143, 17);
            this.txtNomeFuncionarios.TabIndex = 60;
            // 
            // txtFuncionarios
            // 
            this.txtFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.txtFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionarios.ForeColor = System.Drawing.Color.White;
            this.txtFuncionarios.Location = new System.Drawing.Point(34, 47);
            this.txtFuncionarios.Name = "txtFuncionarios";
            this.txtFuncionarios.Size = new System.Drawing.Size(143, 17);
            this.txtFuncionarios.TabIndex = 59;
            // 
            // lboFuncionarios
            // 
            this.lboFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(110)))));
            this.lboFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboFuncionarios.ForeColor = System.Drawing.Color.White;
            this.lboFuncionarios.FormattingEnabled = true;
            this.lboFuncionarios.Location = new System.Drawing.Point(222, 104);
            this.lboFuncionarios.Name = "lboFuncionarios";
            this.lboFuncionarios.Size = new System.Drawing.Size(236, 195);
            this.lboFuncionarios.TabIndex = 58;
            this.lboFuncionarios.SelectedIndexChanged += new System.EventHandler(this.lboFuncionarios_SelectedIndexChanged);
            // 
            // btnLimparSelecão
            // 
            this.btnLimparSelecão.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnLimparSelecão.FlatAppearance.BorderSize = 0;
            this.btnLimparSelecão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparSelecão.ForeColor = System.Drawing.Color.White;
            this.btnLimparSelecão.Location = new System.Drawing.Point(257, 328);
            this.btnLimparSelecão.Name = "btnLimparSelecão";
            this.btnLimparSelecão.Size = new System.Drawing.Size(187, 45);
            this.btnLimparSelecão.TabIndex = 73;
            this.btnLimparSelecão.Text = "Limpar Selecão";
            this.btnLimparSelecão.UseVisualStyleBackColor = false;
            this.btnLimparSelecão.Click += new System.EventHandler(this.btnLimparSelecão_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(77)))));
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.Location = new System.Drawing.Point(44, 333);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(97, 40);
            this.btnAjustes.TabIndex = 72;
            this.btnAjustes.Text = "Cadastrar";
            this.btnAjustes.UseVisualStyleBackColor = false;
            // 
            // btnAcoes
            // 
            this.btnAcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnAcoes.FlatAppearance.BorderSize = 0;
            this.btnAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcoes.ForeColor = System.Drawing.Color.White;
            this.btnAcoes.Location = new System.Drawing.Point(150, 333);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(97, 40);
            this.btnAcoes.TabIndex = 71;
            this.btnAcoes.Text = "Atulizar Lista";
            this.btnAcoes.UseVisualStyleBackColor = false;
            // 
            // btnAcoess
            // 
            this.btnAcoess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnAcoess.FlatAppearance.BorderSize = 0;
            this.btnAcoess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcoess.ForeColor = System.Drawing.Color.White;
            this.btnAcoess.Location = new System.Drawing.Point(154, 333);
            this.btnAcoess.Name = "btnAcoess";
            this.btnAcoess.Size = new System.Drawing.Size(97, 40);
            this.btnAcoess.TabIndex = 71;
            this.btnAcoess.Text = "Atulizar Lista";
            this.btnAcoess.UseVisualStyleBackColor = false;
            this.btnAcoess.Click += new System.EventHandler(this.btnAcoess_Click);
            // 
            // btnAjustess
            // 
            this.btnAjustess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnAjustess.FlatAppearance.BorderSize = 0;
            this.btnAjustess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustess.ForeColor = System.Drawing.Color.White;
            this.btnAjustess.Location = new System.Drawing.Point(34, 333);
            this.btnAjustess.Name = "btnAjustess";
            this.btnAjustess.Size = new System.Drawing.Size(111, 40);
            this.btnAjustess.TabIndex = 72;
            this.btnAjustess.Text = "Cadastrar";
            this.btnAjustess.UseVisualStyleBackColor = false;
            this.btnAjustess.Click += new System.EventHandler(this.btnAjustess_Click);
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.AutoSize = true;
            this.cbxAtivo.Location = new System.Drawing.Point(33, 292);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbxAtivo.TabIndex = 74;
            this.cbxAtivo.Text = "Ativo";
            this.cbxAtivo.UseVisualStyleBackColor = true;
            // 
            // Funcionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.Controls.Add(this.cbxAtivo);
            this.Controls.Add(this.btnLimparSelecão);
            this.Controls.Add(this.btnAjustess);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.btnAcoess);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblEmail1);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNomeFuncionarios);
            this.Controls.Add(this.txtFuncionarios);
            this.Controls.Add(this.lboFuncionarios);
            this.Name = "Funcionários";
            this.Size = new System.Drawing.Size(484, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtNomeFuncionarios;
        private System.Windows.Forms.TextBox txtFuncionarios;
        private System.Windows.Forms.ListBox lboFuncionarios;
        private System.Windows.Forms.Button btnLimparSelecão;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnAcoess;
        private System.Windows.Forms.Button btnAjustess;
        private System.Windows.Forms.CheckBox cbxAtivo;
    }
}
