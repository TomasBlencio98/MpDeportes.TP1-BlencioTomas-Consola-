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
    public class RepositorioGenre : IRepositorioGenre
    {
        private readonly MpDeportesDbContext _context;
        public RepositorioGenre(MpDeportesDbContext context)
        {
            _context = context;
        }
        public void Agregar(Genre genre)
        {
            _context.Genres.Add(genre);
        }

        public void Borrar(Genre genre)
        {
            _context.Genres.Remove(genre);
        }

        public void Editar(Genre genre)
        {
            _context.Genres.Update(genre);
        }

        public bool EstaRelacionado(Genre genre)
        {
            return _context.Shoes.Any(s => s.GenreId == genre.GenreId);
        }

        public bool Existe(Genre genre)
        {
            if (genre.GenreId == 0)
            {
                //return _context.Genres.Any(s => s.GenreId == genre.GenreId);
                return _context.Genres.Any(s => s.GenreName == genre.GenreName);
            }
            return _context.Genres.Any(s => s.GenreName == genre.GenreName &&
                    s.GenreId != genre.GenreId);
        }

        public int GetCantidad(Func<Genre, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _context.Genres.Count(filtro);
            }
            else
            {
                return _context.Shoes.Count();
            }
        }

        public int GetCantidad()
        {
            return _context.Genres.Count();
        }

        public Genre? GetGenrePorId(int id)
        {
            return _context.Genres.FirstOrDefault(s => s.GenreId == id);
        }

        public List<Genre> GetLista()
        {
            return _context.Genres.AsNoTracking().ToList();
        }

        public List<Genre> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Genre> query = _context.Genres.AsNoTracking();

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(b => b.GenreName);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(b => b.GenreName);
                        break;
                    default:
                        break;
                }
            }

            List<Genre> listaPaginada = query
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            return listaPaginada;
        }

        public List<Shoe>? GetShoes(Genre? genre)
        {
            if (genre != null)
            {
                _context.Entry(genre)
                                .Collection(tp => tp.Shoes)
                                .Query()
                                .Include(p => p.Brand)
                                .Include(p => p.Sport)
                                .Include(p => p.Genre)
                                .Include(p => p.Color)
                                .Load();
                var shoes = genre.Shoes.ToList();

                return shoes;
            }
            return null;
        }
    }
}
