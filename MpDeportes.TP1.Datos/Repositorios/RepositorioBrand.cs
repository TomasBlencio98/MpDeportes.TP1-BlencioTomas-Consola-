using Microsoft.EntityFrameworkCore;
using MpDeportes.TP1.Datos.Interfaces;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Datos.Repositorios
{
    public class RepositorioBrand : IRepositorioBrand
    {
        private readonly MpDeportesDbContext _context;
        public RepositorioBrand(MpDeportesDbContext context)
        {
            _context = context;
        }
        public void Agregar(Brand brand)
        {
            _context.Brands.Add(brand);
        }

        public void Borrar(Brand brand)
        {
            _context.Brands.Remove(brand);
        }

        public void Editar(Brand brand)
        {
            _context.Brands.Update(brand);
        }

        public bool EstaRelacionado(Brand brand)
        {
            return _context.Shoes.Any(b=>b.BrandId==brand.BrandId);
        }

        public bool Existe(Brand brand)
        {
            if (brand.BrandId==0)
            {
                //return _context.Brands.Any(b => b.BrandId == brand.BrandId);
                return _context.Brands.Any(b => b.BrandName == brand.BrandName);
            }
            return _context.Brands.Any(b => b.BrandName == brand.BrandName && 
                    b.BrandId != brand.BrandId);
        }

        public Brand? GetBrandPorId(int id)
        {
            return _context.Brands.FirstOrDefault(b=>b.BrandId== id);
        }

        public int GetCantidad(Func<Brand, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _context.Brands.Count(filtro);
            }
            else
            {
                return _context.Shoes.Count();
            }
        }

        public int GetCantidad()
        {
            return _context.Brands.Count();
        }

        public List<Brand> GetLista()
        {
            return _context.Brands.AsNoTracking()
                .OrderBy(b => b.BrandName).ToList();
        }

        public List<Brand> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Brand> query = _context.Brands.AsNoTracking();

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(b => b.BrandName);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(b => b.BrandName);
                        break;
                    default:
                        break;
                }
            }

            List<Brand> listaPaginada = query
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            return listaPaginada;
        }

        public List<Shoe>? GetShoes(Brand? brand)
        {
            if (brand != null)
            {
                _context.Entry(brand)
                                .Collection(tp => tp.Shoes)
                                .Query()
                                .Include(p => p.Brand)
                                .Include(p => p.Sport)
                                .Include(p => p.Genre)
                                .Include(p => p.Color)
                                .Load();
                var shoes = brand.Shoes.ToList();

                return shoes;
            }
            return null;
        }
    }
}
