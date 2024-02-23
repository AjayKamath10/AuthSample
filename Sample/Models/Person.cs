using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Sample.Models
{
    public class Person
    {
        public int PersonId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EmployeeId { get; set; }
    }
}
