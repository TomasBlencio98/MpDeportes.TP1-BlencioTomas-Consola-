using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MpDeportes.TP1.Entidades
{
    [Index(nameof(BrandName), IsUnique = true)]
    public class Brand
    {
        public int BrandId { get; set; }

        [StringLength(50)]
        public string BrandName { get; set; } = null!;
        public bool Active { get; set; } = true;
        public ICollection<Shoe> Shoes { get; set; } = new List<Shoe>();
    }
}
