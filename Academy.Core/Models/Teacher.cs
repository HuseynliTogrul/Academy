
using Academy.Core.Models.BaseModels;

namespace Academy.Core.Models
{
    public class Teacher : Person
    {
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}/Surname:{Surname}/Age:{Age}/Salary:{Salary}";
        }
    }
}
