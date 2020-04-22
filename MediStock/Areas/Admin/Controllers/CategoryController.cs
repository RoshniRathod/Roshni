using BAL.Services;
using DAL.Data;
using DAL.Domains;
using MediStockWeb.Areas.Admin.Controllers.Base;
using MediStockWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MediStockWeb.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        #region Fields
        private readonly ICategoryService _categoryService;
        private readonly MediStockContext _context;
        //const int pageSize = 3;

        #endregion

        #region Ctor
        public CategoryController(ICategoryService categoryService, MediStockContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }
        #endregion


        #region Methods

        public IActionResult List(int? page)
        {

            //get all categories all data.
            var categoryData = _categoryService.GetAllCategories();
            var categoryList = new List<CategoryModel>();
            foreach (var item in categoryData)
            {
                var lst = new CategoryModel();
                lst.Id = item.Id;
                lst.Name = item.Name;

                categoryList.Add(lst);
            }

            var pageNumber = page ?? 1;
            var pageSize = 3;//Show 10 rows every time
            return View(categoryList.ToPagedList(pageNumber, pageSize));
        }


        //public IActionResult PageList(int page=1)
        //{

        //    // pagination
        //    var categoryData = _context.Categories.OrderBy(c => c.Id).Skip((page - 1)*pageSize).Take(pageSize).ToList();

        //    ViewBag.CurrentPage = page;
        //    ViewBag.PageSize = pageSize;
        //    ViewBag.TotalPages = Math.Ceiling((double)_context.Categories.Count() / pageSize);

        //    return View(categoryData);


        //}


        //public async Task<IActionResult> PageList(int pageNumber = 1)
        //{
        //    return View(await PaginatedList<Category>.CreateAsync(_context.Categories,pageNumber,5));

        //}



        public IActionResult Create()
        {
            var model = new CategoryModel();
            return View(model);
            //return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            // Adding new user
            //Category category = new Category();

            if (ModelState.IsValid)
            {
                Category objCategory = new Category
                {
                    Name = model.Name,


                };

                _categoryService.InsertCategory(objCategory);
            }

            return RedirectToAction("List");

        }

        public IActionResult Edit(int id)
        {
            //var model = new CategoryModel();
            //return View();

            var categoryModel = _categoryService.GetCategoryById(id);

            CategoryModel model = new CategoryModel
            {
                Id = categoryModel.Id,
                Name = categoryModel.Name,
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(CategoryModel model)
        {

            Category adminCategoryModel = new Category
            {
                Id = model.Id,
                Name = model.Name,
            };

            var categoryModel = _categoryService.UpdateCategory(adminCategoryModel);

            if (categoryModel == null)
            {
                // Failed
                ViewBag.AddCategoryStatus = "Failed";
                return RedirectToAction("Edit");
            }
            else
            {
                // Success
                ViewBag.AddUserStatus = "Success";
                return RedirectToAction("List");
            }

            //return View(model);
        }

        public IActionResult Delete(Category categoryEntity)
        {

            var categoryData = _categoryService.DeleteCategory(categoryEntity);

            if (categoryData == null)
            {
                // Failed
                ViewBag.AddUserStatus = "Failed";
                return RedirectToAction("Create");
            }
            else
            {
                // Success
                ViewBag.AddUserStatus = "Success";
                return RedirectToAction("List");
            }

            //return View();
        }

        public ActionResult SearchCategory(string searchString)
        {

            // Get particular user data
            var categoryByName = _categoryService.GetCategoryByName(searchString);
            var categoryNameList = new List<CategoryModel>();
            foreach (var item in categoryByName)
            {
                var lst = new CategoryModel();
                lst.Id = item.Id;
                lst.Name = item.Name;

                categoryNameList.Add(lst);
            }

            if (categoryNameList == null)
            {
                return View("List", categoryNameList);
            }
            else
            {
                return View("List", categoryNameList);
            }
        }



        #endregion
    }
}