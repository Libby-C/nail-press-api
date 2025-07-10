using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NailPressApi.Models
{
    [Index(nameof(Title), IsUnique = true)] 
    public class Listing
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;
    }
}