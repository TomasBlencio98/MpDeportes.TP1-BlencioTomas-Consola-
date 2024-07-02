using Microsoft.EntityFrameworkCore;
using MpDeportes.TP1.Datos.Interfaces;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Datos.Repositorios
{
    public class RepositorioSize : IRepositorioSize
    {
        private readonly MpDeportesDbContext _context;
        public RepositorioSize(MpDeportesDbContext context)
        {
            _context = context;
        }
        public void Agregar(Size size)
        {
            _context.Sizes.Add(size);
        }

        public void Borrar(Size size)
        {
            _context.Sizes.Remove(size);
        }

        public void Editar(Size size)
        {
            _context.Sizes.Update(size);
        }

        public bool EstaRelacionado(Size size)
        {
            return _context.ShoesSizes.Any(ss => ss.SizeId == size.SizeId);
        }

        public bool Existe(Size size)
        {
            if (size.SizeId == 0)
            {
                return _context.Sizes.Any(s => s.SizeNumber
                == size.SizeNumber);
            }
            return _context.Sizes.Any(s => s.SizeNumber
            == size.SizeNumber && s.SizeId != size.SizeId);
        }

        public int GetCantidad(Func<Size, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _context.Sizes.Count(filtro);
            }
            else
            {
                return _context.Shoes.Count();
            }
        }

        public int GetCantidad()
        {
            return _context.Sizes.Count();
        }

        public List<Size> GetLista()
        {
            return _context.Sizes.AsNoTracking().ToList();
        }

        public List<Size> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Size> query = _context.Sizes.AsNoTracking();
            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(s => s.SizeNumber);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(s => s.SizeNumber);
                        break;
                    default:
                        break;
                }
            }
            List<Size> listaPaginada = query.AsNoTracking()
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();
            return listaPaginada;
        }

        public List<Shoe>? GetShoes(Size? size)
        {
            if (size == null) return null;
            var shoes = _context.Shoes
                        .Include(s => s.Brand)
                        .Include(s => s.Sport)
                        .Include(s => s.Genre)
                        .Include(s => s.Color)
                        .Where(s => s.ShoesSizes.Any(ss => ss.Size.SizeNumber 
                        == size.SizeNumber))
                        .ToList();
            return shoes;
        }

        public Size? GetSizesPorId(int id)
        {
            return _context.Sizes.SingleOrDefault(s => s.SizeId == id);
        }
    }
}
