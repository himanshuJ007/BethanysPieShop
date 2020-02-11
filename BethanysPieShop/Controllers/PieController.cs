using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        // GET: /<controller>/
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;

        }
        public IActionResult List()

        {
            PiesListViewModel pieListViewmodel = new PiesListViewModel();
            pieListViewmodel.Pies = _pieRepository.AllPies;
            pieListViewmodel.CurrentCategory = "Cheese cake";
          
            return View(pieListViewmodel);
        }
    }
}
