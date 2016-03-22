using RakamStudio.LojaVirtual.Dominio.Respositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RakamStudio.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        // Referencia a classe Repositorio de Produtos no Projeto Dominio
        private ProdutosRepositorio _repositorio;

        // GET: Produtos
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.Take(10);


            return View(produtos);
        }
    }
}