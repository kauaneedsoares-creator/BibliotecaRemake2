namespace BibliotecaRemake
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllSenha = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.txtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarios.Location = new System.Drawing.Point(22, 30);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(348, 20);
            this.txtUsuarios.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(22, 90);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(348, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // btnEntre
            // 
            this.btnEntre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(150)))));
            this.btnEntre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEntre.Location = new System.Drawing.Point(145, 142);
            this.btnEntre.Name = "btnEntre";
            this.btnEntre.Size = new System.Drawing.Size(75, 23);
            this.btnEntre.TabIndex = 2;
            this.btnEntre.Text = "ENTRAR";
            this.btnEntre.UseVisualStyleBackColor = false;
            this.btnEntre.Click += new System.EventHandler(this.btnEntre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite seu nome de usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite sua senha";
            // 
            // lbllSenha
            // 
            this.lbllSenha.AutoSize = true;
            this.lbllSenha.LinkColor = System.Drawing.Color.White;
            this.lbllSenha.Location = new System.Drawing.Point(22, 117);
            this.lbllSenha.Name = "lbllSenha";
            this.lbllSenha.Size = new System.Drawing.Size(118, 13);
            this.lbllSenha.TabIndex = 5;
            this.lbllSenha.TabStop = true;
            this.lbllSenha.Text = "Esqueceu sua Senha ?";
            this.lbllSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllSenha_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(405, 202);
            this.Controls.Add(this.lbllSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntre);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuarios);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbllSenha;
    }
}