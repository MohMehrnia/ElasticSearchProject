using System.ComponentModel.DataAnnotations;

namespace ElasticSearchSampleProject.Core.Entities
{
    public class Products
    {
        [Key] public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
    }
}