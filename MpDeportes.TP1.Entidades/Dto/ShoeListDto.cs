using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Entidades.Dto
{
    public class ShoeListDto
    {
        public int ShoeId { get; set; }
        public string Brand { get; set; } = null!;
        public string Sport { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string Color { get; set; } = null!;
        public decimal Size { get; set; } = 0!;
        public string Model { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int Cantidad { get; set; } = 0!;
    }
}
