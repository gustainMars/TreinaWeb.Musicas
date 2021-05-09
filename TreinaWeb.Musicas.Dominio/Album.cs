using System;

namespace TreinaWeb.Musicas.Dominio
{
    public class Album
    {//Classe POCO, simples, sem dependências externas.
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Observacoes { get; set; }
    }
}
