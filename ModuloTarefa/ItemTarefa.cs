﻿namespace eAgenda.Pessoal.WinFormsApp.ModuloTarefa
{
    public class ItemTarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Concluido { get; set; }
        public Tarefa Tarefa { get; set; }

        public ItemTarefa()
        {
            
        }
        public ItemTarefa(string titulo)
        {
            this.Titulo = titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        public void MarcarPendente()
        {
            Concluido = false;
        }
    }
}
