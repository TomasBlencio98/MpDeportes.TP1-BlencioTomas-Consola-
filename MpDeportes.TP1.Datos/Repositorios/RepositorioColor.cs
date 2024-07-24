using Microsoft.EntityFrameworkCore;
using MpDeportes.TP1.Datos.Interfaces;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = MpDeportes.TP1.Entidades.Color;

namespace MpDeportes.TP1.Datos.Repositorios
{
    public class RepositorioColor : IRepositorioColor
    {
        private readonly MpDeportesDbContext _context;
        public RepositorioColor(MpDeportesDbContext context)
        {
            _context = context;
        }
        public void Agregar(Color color)
        {
            _context.Colors.Add(color);
        }

        public void Borrar(Color color)
        {
            _context.Colors.Remove(color);
        }

        public void Editar(Color color)
        {
            _context.Colors.Update(color);
        }

        public bool EstaRelacionado(Color color)
        {
            return _context.Shoes.Any(s => s.ColorId == color.ColorId);
        }

        public bool Existe(Color color)
        {
            if (color.ColorId == 0)
            {
                //return _context.Colors.Any(s => s.ColorId == color.ColorId);
                return _context.Colors.Any(s => s.ColorName == color.ColorName);
            }
            return _context.Colors.Any(s => s.ColorName == color.ColorName &&
                    s.ColorId != color.ColorId);
        }

        public int GetCantidad(Func<Color, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _context.Colors.Count(filtro);
            }
            else
            {
                return _context.Shoes.Count();
            }
        }

        public int GetCantidad()
        {
            return _context.Colors.Count();
        }

        public Color? GetColorPorId(int id)
        {
            return _context.Colors.FirstOrDefault(s => s.ColorId == id);
        }

        public List<Color> GetLista()
        {
            return _context.Colors.AsNoTracking().ToList();
        }

        public List<Color> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Color> query = _context.Colors.AsNoTracking();

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(b => b.ColorName);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(b => b.ColorName);
                        break;
                    default:
                        break;
                }
            }

            List<Color> listaPaginada = query
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            return listaPaginada;
        }

        public List<Shoe>? GetShoes(Color? color)
        {
            if (color != null)
            {
                _context.Entry(color)
                                .Collection(tp => tp.Shoes)
                                .Query()
                                .Include(p => p.Brand)
                                .Include(p => p.Sport)
                                .Include(p => p.Genre)
                                .Include(p => p.Color)
                                .Load();
                var shoes = color.Shoes.ToList();

                return shoes;
            }
            return null;
        }
    }
}
