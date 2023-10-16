using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.Exceptions
{
    public sealed class CourseNotFoundException : NotFoundException
    {
        public CourseNotFoundException(int id) : base($"this Course with id{id} could not found")
        {
        }
    }
}
