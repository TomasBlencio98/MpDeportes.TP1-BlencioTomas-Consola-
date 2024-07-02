using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Entidades
{
    [Index(nameof(GenreName), IsUnique = true)]
    public class Genre
    {
        public int GenreId { get; set; }
        [StringLength(10)]
        public string GenreName { get; set; } = null!;
        public ICollection<Shoe> Shoes { get; set; } = new List<Shoe>();
    }
}
