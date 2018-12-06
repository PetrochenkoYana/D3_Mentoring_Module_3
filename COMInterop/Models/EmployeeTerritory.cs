using LinqToDB.Mapping;


namespace COMInterop.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("EmployeeTerritories")]
    public class EmployeeTerritory
    {
        [System.ComponentModel.DataAnnotations.Schema.Column("EmployeeID")]
        [NotNull]
        public int EmployeeId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("TerritoryID")]
        [NotNull]
        public int TerritoryId { get; set; }

        [Association(ThisKey = nameof(EmployeeId), OtherKey = nameof(Models.Employee.EmployeeId))]
        public Employee Employee { get; set; }

        [Association(ThisKey = nameof(TerritoryId), OtherKey = nameof(Models.Territory.TerritoryId))]
        public Territory Territory { get; set; }
    }
}
