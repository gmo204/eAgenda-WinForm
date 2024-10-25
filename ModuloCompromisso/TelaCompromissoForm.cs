using eAgenda.Pessoal.WinFormsApp.ModuloContato;
using eAgenda.WinApp.ModuloCompromisso;

namespace eAgenda.Pessoal.WinFormsApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtAssunto.Text = value.Assunto;
                //txtData.Value = value.Data;
                //txtInicio.Value = value.Data.Date + value.HoraInicio;
                //txtTermino.Value = value.Data.Date + value.HoraTermino;

                boxContatos.SelectedItem = value.Contato;

                if (value.TipoCompromisso == TipoCompromissoEnum.Presencial)
                {
                    rdbPresencial.Checked = true;
                    txtLocal.Text = value.Local;
                }
                else
                {
                    rdbRemoto.Checked = true;
                    txtLink.Text = value.Link;
                }
            }
            get
            {
                return compromisso;
            }
        }
        public TelaCompromissoForm(int id)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
        }
        public void CarregarContatos(List<Contato> contatos)
        {
            boxContatos.Items.Clear();

            foreach (Contato c in contatos)
                boxContatos.Items.Add(c);
        }
        public void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            TimeSpan horaInicio = timeInicio.Value.TimeOfDay;
            TimeSpan horaTermino = timeTermino.Value.TimeOfDay;
            DateTime data = dateData.Value.Date;

            string local = txtLocal.Text;
            string link = txtLink.Text;

            Contato contato = (Contato)boxContatos.SelectedItem;

            compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
        }
        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPresencial.Checked)
            {
                txtLink.Text = string.Empty;
                txtLink.Enabled = false;
            }
            else
            {
                txtLink.Enabled = true;
            }
        }

        private void rdbRemoto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRemoto.Checked)
            {
                txtLocal.Text = string.Empty;
                txtLocal.Enabled = false;
            }
            else
            {
                txtLocal.Enabled = true;
            }
        }
    }
}
