using CRUDApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApplication.Business.Abstract
{
    public interface ICourseBusiness : IBusiness<Course>
    {
        List<Course> GetCoursesByCategory(int id);
        List<Course> GetCoursesByInstructor(int id);
    }
}
