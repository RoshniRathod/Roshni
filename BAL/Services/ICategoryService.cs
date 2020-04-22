using DAL.Domains;
using System.Collections.Generic;

namespace BAL.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();


        /// <summary>
        /// Gets a category
        /// </summary>
        /// <param name="categoryId">Category identifier</param>
        /// <returns>Category</returns>
        Category GetCategoryById(int Id);

        /// <summary>
        /// Inserts category
        /// </summary>
        /// <param name="category">Category</param>
        Category InsertCategory(Category categoryEntity);


        /// <summary>
        /// Updates the category
        /// </summary>
        /// <param name="category">Category</param>
        Category UpdateCategory(Category categoryEntity);


        /// <summary>
        /// Delete category
        /// </summary>
        /// <param name="category">Category</param>
        Category DeleteCategory(Category categoryEntity);


        IEnumerable<Category> GetCategoryByName(string categoryName);


        /// <summary>
        /// Gets all categories
        /// </summary>
        /// <param name="storeId">Store identifier; 0 if you want to get all records</param>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <returns>Categories</returns>
        //IList<Category> GetAllCategories(int storeId = 0, bool showHidden = false);

        /// <summary>
        /// Gets all categories
        /// </summary>
        /// <param name="categoryName">Category name</param>
        /// <param name="storeId">Store identifier; 0 if you want to get all records</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <param name="overridePublished">
        /// null - process "Published" property according to "showHidden" parameter
        /// true - load only "Published" products
        /// false - load only "Unpublished" products
        /// </param>
        /// <returns>Categories</returns>
        //IPagedList<Category> GetAllCategories(string categoryName, int storeId = 0,
            //int pageIndex = 0, int pageSize = int.MaxValue, bool showHidden = false, bool? overridePublished = null);

    }
}
