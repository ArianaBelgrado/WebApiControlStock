using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiControlStock.Data;
using WebApiControlStock.Models;

namespace WebApiControlStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly DbStockContext context;
        public ProductoController(DbStockContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            //return context.Productos.ToList();
            var result = context.Productos.Include(x => x.Categoria).ToList();
            return result;
        }

        [HttpPost]
        public ActionResult Post(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Productos.Add(producto);
            context.SaveChanges();
            return Ok();
        }
    }
}
