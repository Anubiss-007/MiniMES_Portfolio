using System;
using System.ComponentModel.DataAnnotations;

namespace MiniMES_Portfolio.Models
{
    public class MachineStatus
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? MachineName { get; set; }
        
        [Required]
        public string? CurrentStatus { get; set; } 
        
        public DateTime LastUpdated { get; set; }
    }
}