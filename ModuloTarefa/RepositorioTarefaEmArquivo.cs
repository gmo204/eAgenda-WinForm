using eAgenda.Pessoal.WinFormsApp.Compartilhado;
using eAgenda.Pessoal.WinFormsApp.ModuloContato;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.Pessoal.WinFormsApp.ModuloTarefa
{
    internal class RepositorioTarefaEmArquivo : RepositorioBaseEmArquivo<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Tarefas.Any())
                contadorId = contexto.Tarefas.Max(c => c.Id) + 1;
        }

        protected override List<Tarefa> ObterRegistros()
        {
            return contexto.Tarefas;
        }
    }
}
