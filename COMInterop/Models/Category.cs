using LinqToDB.Mapping;

namespace COMInterop.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Categories")]
    public class Category
    {
        [System.ComponentModel.DataAnnotations.Schema.Column("CategoryID")]
        [PrimaryKey]
        [Identity]
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("CategoryName")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column]
        public string Description { get; set; }
    }
}
