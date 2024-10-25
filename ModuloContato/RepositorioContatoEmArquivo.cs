using eAgenda.Pessoal.WinFormsApp.Compartilhado;
using eAgenda.Pessoal.WinFormsApp.ModuloCompromisso;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.Pessoal.WinFormsApp.ModuloContato
{
    internal class RepositorioContatoEmArquivo : RepositorioBaseEmArquivo<Contato>, IRepositorioContato
    {
        public RepositorioContatoEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Contatos.Any())
                contadorId = contexto.Contatos.Max(c => c.Id) + 1;
        }

        protected override List<Contato> ObterRegistros()
        {
            return contexto.Contatos;
        }
    }
}
