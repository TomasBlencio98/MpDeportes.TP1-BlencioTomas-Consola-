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
    public class RepositorioSport : IRepositorioSport
    {
        private readonly MpDeportesDbContext _context;
        public RepositorioSport(MpDeportesDbContext context)
        {
            _context= context;
        }
        public void Agregar(Sport sport)
        {
            _context.Sports.Add(sport);
        }

        public void Borrar(Sport sport)
        {
            _context.Sports.Remove(sport);

        }

        public void Editar(Sport sport)
        {
            _context.Sports.Update(sport);
        }

        public bool EstaRelacionado(Sport sport)
        {
            var sportId = sport.SportId;
            var exists = _context.Shoes.Any(s => s.SportId == sportId);
            Console.WriteLine($"Checking if SportId {sportId} exists in Shoes: {exists}");
            return exists;
        }

        public bool Existe(Sport sport)
        {
            if (sport.SportId == 0)
            {
                return _context.Sports.Any(s => s.SportId == sport.SportId);
            }
            return _context.Sports.Any(s => s.SportName == sport.SportName &&
                    s.SportId != sport.SportId);
        }

        public int GetCantidad(Func<Sport, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _context.Sports.Count(filtro);
            }
            else
            {
                return _context.Shoes.Count();
            }
        }

        public int GetCantidad()
        {
            return _context.Sports.Count();
        }

        public List<Sport> GetLista()
        {
            return _context.Sports.AsNoTracking().ToList();
        }

        public List<Sport> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Sport> query = _context.Sports.AsNoTracking();

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(b => b.SportName);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(b => b.SportName);
                        break;
                    default:
                        break;
                }
            }

            List<Sport> listaPaginada = query
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            return listaPaginada;
        }

        public List<Shoe>? GetShoes(Sport? sport)
        {
            if (sport != null)
            {
                _context.Entry(sport)
                                .Collection(tp => tp.Shoes)
                                .Query()
                                .Include(p => p.Brand)
                                .Include(p => p.Sport)
                                .Include(p => p.Genre)
                                .Include(p => p.Color)
                                .Load();
                var shoes = sport.Shoes.ToList();

                return shoes;
            }
            return null;
        }

        public Sport? GetSportPorId(int id)
        {
            return _context.Sports.FirstOrDefault(s => s.SportId == id);
        }
    }
}
