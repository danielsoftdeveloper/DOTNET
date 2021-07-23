using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Sinopse { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        private string Produtora { get; set; }
        private int NotaAvaliacao { get; set; }

        public Serie(int id, Genero genero, string titulo, string sinopse, string produtora, int ano, int notaAvaliacao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.Produtora = produtora;
            this.Ano = ano;
            this.NotaAvaliacao = notaAvaliacao;
            this.Excluido = false;

        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Sinopse: " + this.Sinopse + Environment.NewLine;
            retorno += "Produtora: " + this.Produtora + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Nota de Avaliação: " + this.NotaAvaliacao + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
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