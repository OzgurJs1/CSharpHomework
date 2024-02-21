using CRUDApplication.Business.Abstract;
using CRUDApplication.DataAccess.Abstract;
using CRUDApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApplication.Business.Concrate
{
    public class CategoryManager : ICategoryBusiness
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category item)
        {
            _categoryDal.Add(item);
        }
        public void Delete(int id)
        {
            _categoryDal.Delete(id);
        }
        public Category Get(int id)
        {
            return _categoryDal.Get(id);  
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
        public void Update(Category item)
        {
            _categoryDal.Update(item);
        }
    }
}
