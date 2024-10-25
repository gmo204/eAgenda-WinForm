using eAgenda.Pessoal.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Pessoal.WinFormsApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmMemoria : RepositorioBaseEmMemoria<Compromisso>, IRepositorioCompromisso
    {
        public List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return registros
                .FindAll(c => c.Data >= dataInicio && c.Data <= dataTermino);
        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            return registros.FindAll(c => c.Data >= DateTime.Today);
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            return registros.FindAll(c => c.Data < DateTime.Today);
        }
    }
}
