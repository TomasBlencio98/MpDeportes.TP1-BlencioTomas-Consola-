using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MpDeportes.TP1.Entidades
{
    [Index(nameof(Model), nameof(Description),
        nameof(Price), IsUnique = true)]
    public class Shoe
    {
        public int ShoeId { get; set; }
        public int BrandId { get; set; }
        public int SportId { get; set; }
        public int GenreId { get; set; }
        public int ColorId { get; set; }

        [StringLength(150)]
        public string Model { get; set; } = null!;

        [MaxLength]
        public string Description { get; set; } = null!;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public bool Active { get; set; } = true;
        public Brand? Brand { get; set; }
        public Sport? Sport { get; set; }
        public Genre? Genre { get; set; }
        public Color? Color { get; set; }
        public ICollection<ShoeSize> ShoesSizes { get; set; } = new List<ShoeSize>();

    }
}
