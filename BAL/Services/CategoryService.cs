using DAL.Data;
using DAL.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BAL.Services
{
    public class CategoryService : ICategoryService
    {
       // MediStockContext db = new MediStockContext();
        private MediStockContext context;

        public CategoryService(MediStockContext context)
        {
            this.context = context;
        }

        public Category InsertCategory(Category categoryEntity)
        {
            //Add category data
            context.Categories.Add(categoryEntity);
            context.SaveChanges();

            Category result = new Category();
            result = context.Categories.Where(s => s.Name == categoryEntity.Name).FirstOrDefault();
            return result;

        }

        public Category DeleteCategory(Category categoryEntity)
        {
            context.Entry(categoryEntity).State = EntityState.Deleted;
            context.SaveChanges();

            return categoryEntity;
        }


        public IEnumerable<Category> GetAllCategories()
        {

            // var allCategories = db.Categorys.ToList();
            // return allCategories;

            IList<Category> categoryModel = new List<Category>();
            var query = from Category in context.Categories select Category;
            var categoryData = query.ToList();
            foreach (var item in categoryData)
            {
                categoryModel.Add(new Category()
                {
                    Id = item.Id,
                    Name = item.Name,
                });

            }
            return categoryModel;
        }

        public Category UpdateCategory(Category categoryEntity)
        {
            //categoryData.CategoryID = categoryEntity.CategoryID;
            //categoryData.name = categoryEntity.name;
            //categoryData.isActive = categoryEntity.isActive;
            //categoryData.isDeleted = categoryEntity.isDeleted;
            //categoryData.updatedOn = categoryEntity.updatedOn;
            //db.SaveChanges();


            context.Entry(categoryEntity).State = EntityState.Modified; 
            context.SaveChanges();

            return categoryEntity;
            // Verify weather user inserted(actually updated) or not.
            //Category presentCategory = context.Categories.SingleOrDefault(c => c.Id == categoryEntity.Id);
            //if (presentCategory != null)
            //{
            //    return presentCategory;
            //}
            //else
            //{
            //    return null;
            //}
        }


        /// <summary>
        /// Gets a category
        /// </summary>
        /// <param name="categoryId">Category identifier</param>
        /// <returns>Category</returns>
        public virtual Category GetCategoryById(int Id)
        {
            //ModelContext db = new ModelContext();
            //Category objCategory = new Category();
            //objCategory = db.Categorys.Where(a => a.CategoryID == CategoryID).FirstOrDefault();
            //return objCategory;

            var query = from c in context.Categories where c.Id == Id select c;
            var category = query.FirstOrDefault();
            var model = new Category()
            {
                Id = category.Id,
                Name = category.Name,
            };
            return model;
        }


        public IEnumerable<Category> GetCategoryByName(string categoryName)
        {
            List<Category> list = context.Categories.Where(t => t.Name.Contains(categoryName)).ToList();
            return list;
        }
    }
}
