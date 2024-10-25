using eAgenda.Pessoal.WinFormsApp.Compartilhado;

namespace eAgenda.Pessoal.WinFormsApp.ModuloContato
{
    internal class ControladorContato(IRepositorioContato repositorioContato) : ControladorBase
    {

        private IRepositorioContato repositorioContato = repositorioContato;
        private TabelaContatoControl tabelaContato;
        
        public override string TipoCadastro { get { return "Contatos"; } }

        public override string ToolTipAdicionar { get { return "Cadadstar um novo contato"; } }

        public override string ToolTipEditar { get { return "Editar um contato"; } }

        public override string ToolTipExcluir { get { return "Excluir um contato"; } }
        
        public override void Adicionar()
        {
            int Id = repositorioContato.PegarId();

            TelaContatoForm telaContato = new TelaContatoForm(Id);

            DialogResult resultado = telaContato.ShowDialog();

            if (resultado != DialogResult.OK)
                return;
            
            Contato novoContato = telaContato.Contato;

            repositorioContato.Cadastrar(novoContato);

            CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoContato.Nome}\" foi criado com sucesso!");
        }
        public override void Editar()
        {
            int IdSelecionado = tabelaContato.ObterContatoSelecionado();

            TelaContatoForm telaContato = new(IdSelecionado);

            Contato contatoSelecionado = 
                repositorioContato.SelecionarPorId(IdSelecionado);

            if (SemSeleção(contatoSelecionado)) return;

            if (contatoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaContato.Contato = contatoSelecionado;

            DialogResult resultado = telaContato.ShowDialog();
            if (resultado != DialogResult.OK) return;

            Contato contatoEditado = telaContato.Contato;

            repositorioContato.Editar(contatoSelecionado.Id, contatoEditado);

            CarregarContatos();
            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{contatoEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int IdSelecionado = tabelaContato.ObterContatoSelecionado();

            Contato contatoSelecionado =
                repositorioContato.SelecionarPorId(IdSelecionado);

            if (SemSeleção(contatoSelecionado)) return;

            if (contatoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show
                (
                $"Você deseja realmente excluir o registro \"{contatoSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (resposta != DialogResult.Yes) return;

            repositorioContato.Excluir(contatoSelecionado.Id);

            CarregarContatos();

            TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"O registro \"{contatoSelecionado.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaContato == null)
                tabelaContato = new TabelaContatoControl();

            CarregarContatos();

            return tabelaContato;
        }
        public void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            tabelaContato.AtualizarRegistros(contatos);
        }
    }
}
