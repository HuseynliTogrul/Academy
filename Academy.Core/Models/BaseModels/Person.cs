
namespace Academy.Core.Models.BaseModels
{
    public abstract class Person
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person()
        {
            _id++;
            Id = _id;
        }
    }
}
