namespace eAgenda.Pessoal.WinFormsApp.ModuloTarefa
{
    public interface IRepositorioTarefa
    {
        void Cadastrar(Tarefa novaTarefa);
        bool Editar(int id, Tarefa tarefaEditada);
        bool Excluir(int id);
        int PegarId();
        Tarefa SelecionarPorId(int idSelecionado);
        List<Tarefa> SelecionarTodos();
    }
}
