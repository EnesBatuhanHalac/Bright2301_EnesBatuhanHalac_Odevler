using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.Exceptions
{
    public sealed class TrainerNotFoundException : NotFoundException
    {
        public TrainerNotFoundException(int id) : base($"This Trainer with id {id} could not found")
        {
        }
    }
}
