using CRUDApplication.Business.Abstract;
using CRUDApplication.DataAccess.Abstract;
using CRUDApplication.DataAccess.Concrate;
using CRUDApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApplication.Business.Concrate
{
    public class CourseManager: ICourseBusiness
    {
        private ICourseDal _CourseDal;

        public CourseManager(ICourseDal CourseDal)
        {
            _CourseDal = CourseDal;
        }
        public void Add(Course item)
        {
            _CourseDal.Add(item);
        }
        public void Delete(int id)
        {
            _CourseDal.Delete(id);
        }
        public Course Get(int id)
        {
            return _CourseDal.Get(id);
        }
        public List<Course> GetAll()
        {
            return _CourseDal.GetAll();
        }
        public List<Course> GetCoursesByCategory(int id)
        {
            return _CourseDal.GetCoursesByCategory(id);
        }
        public List<Course> GetCoursesByInstructor(int id)
        {
            return _CourseDal.GetCoursesByInstructor(id);
        }
        public void Update(Course item)
        {
            _CourseDal.Update(item);
        }
    }
}
