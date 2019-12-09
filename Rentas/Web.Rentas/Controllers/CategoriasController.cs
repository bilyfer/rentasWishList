using BL.Rentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Rentas.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            var categoriasBL = new CategoriasBL();
            var listaCategorias = categoriasBL.ObtenerCategorias();

            return View(listaCategorias);
        }
    }
}