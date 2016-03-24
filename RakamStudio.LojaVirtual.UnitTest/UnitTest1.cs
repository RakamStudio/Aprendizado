using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using RakamStudio.LojaVirtual.Web.Models;
using RakamStudio.LojaVirtual.Web.HtmlHelpers;

namespace RakamStudio.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarPaginacao()
        {
            HtmlHelper html = null;

            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };


            
            Func<int, string> paginaUrl = i => "Pagina" + i;

            // Act
            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            // Assert

            Equals(
                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>"
                );
        }
    }
}
