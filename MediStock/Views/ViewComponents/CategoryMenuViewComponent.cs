using BAL.Services;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MediStockWeb.ViewComponents
{
	public class CategoryMenuViewComponent : ViewComponent
	{

        #region Fields
        private readonly ICategoryService _categoryService;
        private readonly MediStockContext _context;
        //const int pageSize = 3;

        #endregion

        #region Ctor
        public CategoryMenuViewComponent(ICategoryService categoryService, MediStockContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }
        #endregion

        public IViewComponentResult Invoke()
		{
            var categories = _categoryService.GetAllCategories();
			//var categories = _context.Categories.ToList();
			return View(categories);
		}
	}

}
