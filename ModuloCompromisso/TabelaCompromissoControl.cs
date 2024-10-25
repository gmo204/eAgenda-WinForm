using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;

namespace eAgenda.Pessoal.WinFormsApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }
        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();
            
            foreach (Compromisso c in compromissos)
                grid.Rows.Add(c.Id, c.Assunto, c.Local, c.HoraInicio.ToString(@"hh\:mm"), c.HoraTermino.ToString(@"hh\:mm"), c.Data.ToString(@"dd/MM/yyyy"), c.Contato);
        }
        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }
        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Assunto", HeaderText = "Assunto" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Local", HeaderText = "Local" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Inicio", HeaderText = "Hora Inicio" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Termino", HeaderText = "Hora Termino" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Contato", HeaderText = "Contato" },

            };
        }
    }
}
