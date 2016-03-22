using RakamStudio.LojaVirtual.Dominio.Entidades;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RakamStudio.LojaVirtual.Dominio.Respositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos 
        {
            get { return _context.Produtos; }
        }

        //public void Incluir()
        //{
        //    _context.Produtos.Add
        //}

        
    }
}
