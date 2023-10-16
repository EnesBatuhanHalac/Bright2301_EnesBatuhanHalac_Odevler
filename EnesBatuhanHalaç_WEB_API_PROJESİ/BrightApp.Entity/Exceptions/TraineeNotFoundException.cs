using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.Exceptions
{
    public sealed class TraineeNotFoundException : NotFoundException
    {
        public TraineeNotFoundException(int id) : base($"this id Trainee could not found{id}")
        {
        }
    }
}
