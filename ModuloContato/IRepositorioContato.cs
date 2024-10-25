namespace eAgenda.Pessoal.WinFormsApp.ModuloContato
{
    public interface IRepositorioContato
    {
        void Cadastrar(Contato novoContato);
        bool Editar(int id, Contato contatoEditado);
        bool Excluir(int id);
        int PegarId();
        Contato SelecionarPorId(int idSelecionado);
        List<Contato> SelecionarTodos();
    }
}
