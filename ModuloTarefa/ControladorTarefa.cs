using eAgenda.Pessoal.WinFormsApp.Compartilhado;

namespace eAgenda.Pessoal.WinFormsApp.ModuloTarefa
{
    public class ControladorTarefa(IRepositorioTarefa repositorioTarefa) : ControladorBase
    {
        private IRepositorioTarefa repositorioTarefa = repositorioTarefa;
        private TabelaTarefaControl listTarefas;

        #region ToolTips
        public override string TipoCadastro => "Tarefa";
        public override string ToolTipAdicionar => "Adicionar tarefa";
        public override string ToolTipEditar => "Editar tarefa";
        public override string ToolTipExcluir => "Excluit tarefa";
        #endregion

        public override void Adicionar() 
        {
            int Id = repositorioTarefa.PegarId();

            TelaTarefaForm telaTarefa = new(Id);

            DialogResult resultado = telaTarefa.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Tarefa novaTarefa = telaTarefa.Tarefa;

            repositorioTarefa.Cadastrar(novaTarefa);

            CarregarTarefas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaTarefa.Titulo}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = listTarefas.ObterIdSelecionado();

            TelaTarefaForm telaTarefa = new(idSelecionado);

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (SemSeleção(tarefaSelecionada)) return;

            telaTarefa.Tarefa = tarefaSelecionada;

            DialogResult resultado = telaTarefa.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Tarefa tarefaEditada = telaTarefa.Tarefa;

            repositorioTarefa.Editar(tarefaSelecionada.Id, tarefaEditada);

            CarregarTarefas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{tarefaEditada.Titulo}\" foi editado com sucesso!");
        }

        public override void Excluir() 
        {
            int idSelecionado = listTarefas.ObterIdSelecionado();

            Tarefa tarefaSelecionada =
                repositorioTarefa.SelecionarPorId(idSelecionado);

            if (SemSeleção(tarefaSelecionada)) return;

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{tarefaSelecionada.Titulo}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if  (resposta != DialogResult.Yes ) return;

            repositorioTarefa.Excluir(tarefaSelecionada.Id);

            CarregarTarefas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{tarefaSelecionada.Titulo}\" foi excluído com sucesso!");
        }
        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listTarefas.AtualizarRegistros(tarefas);
        }
        public override UserControl ObterListagem()
        {
            if (listTarefas == null)
                listTarefas = new();

            CarregarTarefas();

            return listTarefas;
        }
    }
}
