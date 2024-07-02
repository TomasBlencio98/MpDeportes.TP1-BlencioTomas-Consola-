using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Entidades
{
    [Index(nameof(ColorName), IsUnique = true)]
    public class Color
    {
        public int ColorId { get; set; }
        [StringLength(50)]
        public string ColorName { get; set; } = null!;
        public bool Active { get; set; } = true;
        public ICollection<Shoe> Shoes { get; set; } = new List<Shoe>();
    }
}
