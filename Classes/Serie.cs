using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }
        
        private string Titulo { get; set; }
        
        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }


        // Métodos

        public Serie(int id, Genero genero, string titulo, string descrição, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString() 
        {
            // Environnement.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.enviroment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " = this.Genero + Environnement.NewLine;
            retorno += "Titulo: " = this.Titulo + Environnement.NewLine;
            retorno += "Descrição: " = this.Descricao + Environnement.NewLine;
            retorno += "Ano de Inicio: " = this.Ano + Environnement.NewLine;
            retorno += "Excluido: " + this.Excluido;

            return retorno;

        }

        public string retornoTitulo() 
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
    
}