namespace eAgenda.Pessoal.WinFormsApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public Contato Contato { set { } get { return contato; } }
        public TelaContatoForm(int Id)
        {
            InitializeComponent();
            txtId.Text = Id.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, telefone, email, empresa, cargo);
        }
    }
}
