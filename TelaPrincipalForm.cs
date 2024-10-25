using eAgenda.Pessoal.WinFormsApp.Compartilhado;
using eAgenda.Pessoal.WinFormsApp.ModuloContato;
using eAgenda.Pessoal.WinFormsApp.ModuloCompromisso;
using eAgenda.Pessoal.WinFormsApp.ModuloTarefa;
using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;

namespace eAgenda.Pessoal.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;
        ContextoDados contexto;

        IRepositorioTarefa repositorioTarefa;
        IRepositorioContato repositorioContato;
        IRepositorioCompromisso repositorioCompromisso;

        public static TelaPrincipalForm Instancia { get; private set; }
        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            contexto = new ContextoDados(carregarDados: true);

            repositorioContato = new RepositorioContatoEmArquivo(contexto);
            repositorioCompromisso = new RepositorioCompromissoEmArquivo(contexto);
            repositorioTarefa = new RepositorioTarefaEmArquivo(contexto);

        }

        public void AtualizarRodape(string texto) => statusLabelPrincipal.Text = texto;

        private void contatosMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorContato(repositorioContato));
        private void compromissosMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato));
        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorTarefa(repositorioTarefa));

        private void btnAdicionar_Click(object sender, EventArgs e)
            => controlador.Adicionar();
        private void btnEditar_Click(object sender, EventArgs e)
            => controlador.Editar();
        private void btnExcluir_Click(object sender, EventArgs e)
            => controlador.Excluir();

        private void SelecionaModulo(ref ControladorBase controlador, Action controladorSelecionado)
        {
            controladorSelecionado();
            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolBox(controlador);
            ConfigurarListagem(controlador);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
        }
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato;

            listagemContato = controladorSelecionado.ObterListagem();

            listagemContato.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(listagemContato);
        }

    }
}
