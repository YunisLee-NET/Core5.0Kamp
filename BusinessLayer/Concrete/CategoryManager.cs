using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository _categoryRepository;

        public CategoryManager(EfCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public Category GetByID(int id)
        {
            return _categoryRepository.GetByID(id);
        }

        public void TAdd(Category t)
        {
            _categoryRepository.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryRepository.Delete(t);
        }

        public List<Category> TGetList()
        {
            return _categoryRepository.GetListAll();
        }

        public void TUpdate(Category t)
        {
            _categoryRepository.Update(t);
        }
    }
}
