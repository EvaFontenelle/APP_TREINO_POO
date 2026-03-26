namespace APP_TREINO_POO
{
    partial class frmTelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel9 = new Panel();
            panel8 = new Panel();
            btnLogin = new Button();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            lblSenha = new Label();
            lblMatricula = new Label();
            lblUsuario = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            txtMatricula = new TextBox();
            panel3 = new Panel();
            logo = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel9, 2, 2);
            tableLayoutPanel1.Controls.Add(panel8, 1, 2);
            tableLayoutPanel1.Controls.Add(panel7, 0, 2);
            tableLayoutPanel1.Controls.Add(panel6, 2, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(1100, 643);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Location = new Point(773, 452);
            panel9.Name = "panel9";
            panel9.Size = new Size(324, 188);
            panel9.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnLogin);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(333, 452);
            panel8.Name = "panel8";
            panel8.Size = new Size(434, 188);
            panel8.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(145, 40);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 32);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 452);
            panel7.Name = "panel7";
            panel7.Size = new Size(324, 188);
            panel7.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Location = new Point(773, 260);
            panel6.Name = "panel6";
            panel6.Size = new Size(324, 186);
            panel6.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(324, 186);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Aquamarine;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(773, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 251);
            panel4.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 251);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblMatricula);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtMatricula);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(333, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 186);
            panel1.TabIndex = 0;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(33, 145);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 17;
            lblSenha.Text = "Senha";
            // 
            // lblMatricula
            // 
            lblMatricula.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(33, 73);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 16;
            lblMatricula.Text = "Matrícula";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(30, 1);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 15;
            lblUsuario.Text = "Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(33, 163);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(374, 23);
            txtSenha.TabIndex = 14;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(30, 19);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(374, 23);
            txtUsuario.TabIndex = 12;
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMatricula.Location = new Point(30, 91);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(374, 23);
            txtMatricula.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(logo);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(333, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 251);
            panel3.TabIndex = 2;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logo.BackgroundImageLayout = ImageLayout.None;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.InitialImage = (Image)resources.GetObject("logo.InitialImage");
            logo.Location = new Point(76, -3);
            logo.Name = "logo";
            logo.Size = new Size(287, 251);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // frmTelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(1100, 643);
            Controls.Add(tableLayoutPanel1);
            Name = "frmTelaLogin";
            Text = "Aplicativo Treino POO cs: Tela de login";
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label lblSenha;
        private Label lblMatricula;
        private Label lblUsuario;
        private TextBox txtSenha;
        private TextBox txtMatricula;
        private TextBox txtUsuario;
        private Button btnLogin;
        private PictureBox logo;
    }
}
