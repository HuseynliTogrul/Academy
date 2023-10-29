
using Academy.Core.Models.BaseModels;

namespace Academy.Core.Models
{
    public class Student : Person
    {
        public int Average { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}/Surname:{Surname}/Age:{Age}/Average:{Average}";
        }
    }
}
