using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace COMInterop.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Column("EmployeeID")]
        [PrimaryKey]
        [Identity]
        public int EmployeeId { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Association(ThisKey = nameof(EmployeeId), OtherKey = nameof(Models.Order.EmployeeId), CanBeNull = true)]
        public IEnumerable<Order> Orders { get; set; }
    }
}
