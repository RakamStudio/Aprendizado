using System;

namespace RakamStudio.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        // Itens totais no Banco de Dados
        public int ItensTotal { get; set; }

        // Itens que eu quero na página
        public int ItensPorPagina { get; set; }

        // Definiar página atual para manipular na tela (Pagina exibida no momento)
        public int PaginaAtual { get; set; }

        // Total de paginas na Paginação que teremos
        public int TotalPaginas
        {
            get { return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina); }
        }
    }
}