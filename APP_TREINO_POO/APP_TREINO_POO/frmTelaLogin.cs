namespace APP_TREINO_POO
{
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string NomeUsuario = txtUsuario.Text;
            string MatriculaUsuario = txtMatricula.Text;
            string SenhaUsuario = txtSenha.Text;

            CredenciaisUsuario cu = new CredenciaisUsuario(NomeUsuario, MatriculaUsuario, SenhaUsuario);

            if (cu.verificaCredenciais())
            {
                frmTelaPrincipal ftp = new frmTelaPrincipal();
                ftp.Show();
                this.Visible = false;
            }
            else 
            {
                MessageBox.Show("Dados incorretos, tente novamente!");
            }
        }
    }
}
