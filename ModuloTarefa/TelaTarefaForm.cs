using System.Drawing.Text;

namespace eAgenda.Pessoal.WinFormsApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        public Tarefa Tarefa { set { } get { return tarefa; } }
        public TelaTarefaForm(int Id)
        {
            InitializeComponent();
            txtId.Text = Id.ToString();

            CarregarPrioridades();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            PrioridadeTarefaEnum prioridade =
                (PrioridadeTarefaEnum)cmbPrioridade.SelectedItem;

            tarefa = new Tarefa(titulo, prioridade);

            List<string> erros = tarefa.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
        private void CarregarPrioridades()
        {
            Array valoresEnum = Enum.GetValues(typeof(PrioridadeTarefaEnum));

            foreach  (var valor in valoresEnum) 
                cmbPrioridade.Items.Add(valor);

            cmbPrioridade.SelectedItem = PrioridadeTarefaEnum.Baixa;
        }
    }
}
