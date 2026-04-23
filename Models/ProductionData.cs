using System;
using System.ComponentModel.DataAnnotations;

namespace MiniMES_Portfolio.Models
{
    public class ProductionData
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime ProductionDate { get; set; }
        
        [Required]
        public string? ProductCode { get; set; }
        
        public int TargetQty { get; set; }
        public int ActualQty { get; set; }
        public int DefectQty { get; set; }
    }
}