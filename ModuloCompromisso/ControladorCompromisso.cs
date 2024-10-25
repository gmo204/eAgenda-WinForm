using eAgenda.Pessoal.WinFormsApp.Compartilhado;
using eAgenda.Pessoal.WinFormsApp.ModuloContato;
using eAgenda.WinApp.ModuloCompromisso;

namespace eAgenda.Pessoal.WinFormsApp.ModuloCompromisso
{
    internal class ControladorCompromisso(IRepositorioCompromisso repositorioCompromisso, IRepositorioContato repositorioContato) : ControladorBase
    {
        private IRepositorioCompromisso repositorioCompromisso = repositorioCompromisso;
        private IRepositorioContato repositorioContato = repositorioContato;
        private TabelaCompromissoControl tabelaCompromisso;

        #region ToolTips
        public override string TipoCadastro { get { return "Compromissos"; } }

        public override string ToolTipAdicionar { get { return "Adicionar compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um compromisso"; } }

        public override string ToolTipExcluir { get { return "Excluir um compromisso"; } }
        #endregion
        public override void Adicionar()
        {
            int id = repositorioCompromisso.PegarId();

            TelaCompromissoForm telaCompromisso = new(id);

            CarregarContatos(telaCompromisso);

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK) return;
            
            Compromisso novoCompromisso = telaCompromisso.Compromisso;

            repositorioCompromisso.Cadastrar(novoCompromisso);

            CarregarCompromissos();
         
            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoCompromisso.Assunto}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaCompromisso.ObterRegistroSelecionado();

            TelaCompromissoForm telaCompromissso = new(idSelecionado);

            Compromisso compromissoSelecionado = 
                repositorioCompromisso.SelecionarPorId(idSelecionado);

            if (SemSeleção(compromissoSelecionado)) return;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCompromissso.Compromisso = compromissoSelecionado;

            DialogResult resultado = telaCompromissso.ShowDialog();
            if (resultado != DialogResult.OK) return;

            Compromisso compromissoEditato = telaCompromissso.Compromisso;

            repositorioCompromisso.Editar(idSelecionado, compromissoEditato);

            CarregarCompromissos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{compromissoEditato.Assunto}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int id = tabelaCompromisso.ObterRegistroSelecionado();

            Compromisso compromissoSelecionado =
                repositorioCompromisso.SelecionarPorId(id);

            if (SemSeleção(compromissoSelecionado)) return;

            if (compromissoSelecionado == null)
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
                $"Você deseja realmente excluir o registro \"{compromissoSelecionado.Assunto}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if ( resposta != DialogResult.Yes ) return;

            repositorioCompromisso.Excluir(compromissoSelecionado.Id);

            CarregarCompromissos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{compromissoSelecionado.Assunto}\" foi excluído com sucesso!");

        }

        public void Filtrar()
        {
            TelaFiltroCompromissoForm telaFiltro = new TelaFiltroCompromissoForm();

            DialogResult resultado = telaFiltro.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            TipoFiltroCompromissoEnum filtroSelecionado = telaFiltro.FiltroSelecionado;

            List<Compromisso> compromissosSelecionados;

            if (filtroSelecionado == TipoFiltroCompromissoEnum.Passados)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosPassados();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Futuros)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosFuturos();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Periodo)
            {
                DateTime dataInicio = telaFiltro.InicioPeriodo;
                DateTime dataTermino = telaFiltro.TerminoPeriodo;

                compromissosSelecionados =
                    repositorioCompromisso.SelecionarCompromissosPorPeriodo(dataInicio, dataTermino);
            }

            else
                compromissosSelecionados = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissosSelecionados);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissosSelecionados.Count} registros...");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return tabelaCompromisso;
        }
        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }
        private void CarregarContatos(TelaCompromissoForm telaCompromisso)
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            telaCompromisso.CarregarContatos(contatos);
        }
    }
}
