using Microsoft.EntityFrameworkCore;
using MpDeportes.TP1.Datos.Interfaces;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Datos.Repositorios
{
    public class RepositorioShoe : IRepositorioShoe
    {
        private readonly MpDeportesDbContext _context;
        public RepositorioShoe(MpDeportesDbContext context)
        {
            _context = context;
        }

        public void ActualizarShoeSize(ShoeSize shoeSize)
        {
            _context.Set<ShoeSize>().Update(shoeSize);
        }

        public void Agregar(Shoe shoe)
        {
            var brandExistenteBd = _context.Brands.
                FirstOrDefault(b=>b.BrandId==shoe.BrandId);
            if (brandExistenteBd!=null)
            {
                _context.Attach(brandExistenteBd);
                shoe.Brand=brandExistenteBd;
            }

            var genreExistenteBd = _context.Genres.
                FirstOrDefault(b => b.GenreId == shoe.GenreId);
            if (genreExistenteBd != null)
            {
                _context.Attach(genreExistenteBd);
                shoe.Genre = genreExistenteBd;
            }

            var colorExistenteBd = _context.Colors.
                FirstOrDefault(b => b.ColorId == shoe.ColorId);
            if (colorExistenteBd != null)
            {
                _context.Attach(colorExistenteBd);
                shoe.Color = colorExistenteBd;
            }

            var sportExistenteBd = _context.Sports.
                FirstOrDefault(b => b.SportId == shoe.SportId);
            if (sportExistenteBd != null)
            {
                _context.Attach(sportExistenteBd);
                shoe.Sport = sportExistenteBd;
            }

            _context.Shoes.Add(shoe);
        }

        public void AgregarSHOESIZE(ShoeSize shoeSize)
        {  
            _context.Set<ShoeSize>().Add(shoeSize);
        }

        public void Borrar(Shoe shoe)
        {
            _context.Shoes.Remove(shoe);
        }

        public void Editar(Shoe shoe)
        {
            var brandExistenteBd = _context.Brands.
                FirstOrDefault(b => b.BrandId == shoe.BrandId);
            if (brandExistenteBd != null)
            {
                _context.Attach(brandExistenteBd);
                shoe.Brand = brandExistenteBd;
            }

            var genreExistenteBd = _context.Genres.
                FirstOrDefault(b => b.GenreId == shoe.GenreId);
            if (genreExistenteBd != null)
            {
                _context.Attach(genreExistenteBd);
                shoe.Genre = genreExistenteBd;
            }

            var colorExistenteBd = _context.Colors.
                FirstOrDefault(b => b.ColorId == shoe.ColorId);
            if (colorExistenteBd != null)
            {
                _context.Attach(colorExistenteBd);
                shoe.Color = colorExistenteBd;
            }

            var sportExistenteBd = _context.Sports.
                FirstOrDefault(b => b.SportId == shoe.SportId);
            if (sportExistenteBd != null)
            {
                _context.Attach(sportExistenteBd);
                shoe.Sport = sportExistenteBd;
            }

            _context.Shoes.Update(shoe);
        }

        public bool Existe(Shoe shoe)
        {
            if (shoe.ShoeId==0)
            {
                return _context.Shoes.Any
                    (
                        s => s.BrandId == shoe.BrandId &&
                        s.ColorId == shoe.ColorId &&
                        s.GenreId == shoe.GenreId &&
                        s.SportId == shoe.SportId &&
                        s.Model == shoe.Model &&
                        s.Description == shoe.Description &&
                        s.Price == shoe.Price
                    );
            }
            return _context.Shoes.Any
                    (
                        s => s.BrandId == shoe.BrandId &&
                        s.ColorId == shoe.ColorId &&
                        s.GenreId == shoe.GenreId &&
                        s.SportId == shoe.SportId &&
                        s.Model == shoe.Model &&
                        s.Description == shoe.Description &&
                        s.Price == shoe.Price &&
                        s.ShoeId==shoe.ShoeId
                    );
        }

        public bool ExisteRelacion(Shoe shoe, Size size)
        {
            if (shoe == null || size == null) return false;

            return _context.ShoesSizes.Any(pp => pp.ShoeId == shoe.ShoeId
                && pp.SizeId == size.SizeId);
        }

        public int GetCantidad(Func<Shoe, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _context.Shoes.Count(filtro);
            }
            else
            {
                return _context.Shoes.Count();
            }
        }

        public List<Shoe> GetLista()
        {
            return _context.Shoes.AsNoTracking().ToList();
        }

        public List<ShoeListDto> GetListaDto()
        {
            return _context.Shoes
                .Include(p => p.Brand)
                .Include(p => p.Genre)
                .Include(p => p.Color)
                .Include(p => p.Sport)
                .Select(n => new ShoeListDto
                {
                    ShoeId=n.ShoeId,
                    Brand=n.Brand !=null ? n.Brand.BrandName : string.Empty,
                    Genre = n.Genre != null ? n.Genre.GenreName : string.Empty,
                    Color = n.Color != null ? n.Color.ColorName : string.Empty,
                    Sport = n.Sport != null ? n.Sport.SportName : string.Empty,
                    Model=n.Model,
                    Description=n.Description,
                    Price=n.Price,
                }).ToList(); ;
        }

        public List<Shoe> GetListaOrdenadaFiltradaEntreRangoPrecios
            (Orden? orden = null, Brand? brand = null, Sport? sport = null, 
            Genre? genre = null, Color? colour = null, decimal? maximo = null, 
            decimal? minimo = null)
        {
            IQueryable<Shoe> query = _context.Shoes
                .Include(s => s.Brand)
                .Include(s => s.Sport)
                .Include(s => s.Genre)
                .Include(s => s.Color)
                .AsNoTracking();

            if (brand != null)
            {
                query = query
                    .Where(s => s.BrandId == brand.BrandId);
            }
            if (sport != null)
            {
                query = query
                    .Where(s => s.SportId == sport.SportId);
            }
            if (genre != null)
            {
                query = query
                    .Where(s => s.GenreId == genre.GenreId);
            }
            if (colour != null)
            {
                query = query
                    .Where(s => s.ColorId == colour.ColorId);
            }

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(s => s.Model);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(s => s.Model);
                        break;
                    case Orden.MenorPrecio:
                        query = query.OrderBy(s => s.Price);
                        break;
                    case Orden.MayorPrecio:
                        query = query.OrderByDescending(s => s.Price);
                        break;
                    default:
                        break;
                }
            }

            if (maximo != null && minimo != null)
            {
                query = query
                    .Where(s => s.Price <= maximo)
                    .Where(s => s.Price >= minimo);
            }

            return query.ToList();
        }

        public List<ShoeListDto> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Shoe> query = _context.Shoes
            .Include(s => s.Color)
            .Include(s => s.Genre)
            .Include(s => s.Sport)
            .Include(s => s.Brand)
            .AsNoTracking();

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(s => s.Brand != null ? s.Brand.BrandName : string.Empty);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(s => s.Brand != null ? s.Brand.BrandName : string.Empty);
                        break;
                    case Orden.MenorPrecio:
                        query = query.OrderBy(s => s.Price);
                        break;
                    case Orden.MayorPrecio:
                        query = query.OrderByDescending(s => s.Price);
                        break;
                    default:
                        break;
                }
            }

            List<Shoe> listaPaginada = query
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            List<ShoeListDto> listaDto = listaPaginada
                .Select(s => new ShoeListDto
                {
                    ShoeId = s.ShoeId,
                    Description = s.Description,
                    Color = s.Color?.ColorName ?? "",
                    Genre = s.Genre?.GenreName ?? "",
                    Sport = s.Sport?.SportName ?? "",
                    Brand = s.Brand?.BrandName ?? "",
                    Price = s.Price
                })
                .ToList();

            return listaDto;
        }

        public Shoe? GetShoePorId(int id)
        {
            return _context.Shoes
                .Include(s => s.Brand)
                .Include(s => s.Genre)
                .Include(s => s.Color)
                .Include(s => s.Sport)
                .FirstOrDefault(s => s.ShoeId == id);
        }

        public List<ShoeSize> GetShoesConTalles()
        {
            return _context.ShoesSizes
                   .Include(ss => ss.Shoe).ThenInclude(s => s.Brand)
                   .Include(ss => ss.Shoe).ThenInclude(s => s.Sport)
                   .Include(ss => ss.Shoe).ThenInclude(s => s.Genre)
                   .Include(ss => ss.Shoe).ThenInclude(s => s.Color)
                   .Include(ss => ss.Size).ToList();
        }

        public ShoeSize? GetShoeSize(Shoe shoe, Size size)
        {
            return _context.ShoesSizes.FirstOrDefault
                (ss => ss.ShoeId == shoe.ShoeId && ss.SizeId == size.SizeId);
        }

        public List<ShoeListDto>? GetShoesSinTalles()
        {
            return _context.Shoes
                    .Include(s => s.Brand)
                    .Include(s => s.Sport)
                    .Include(s => s.Genre)
                    .Include(s => s.Color)
                    .Where(s => !s.ShoesSizes.Any())
                    .Select(s => new ShoeListDto
                    {
                        ShoeId = s.ShoeId,
                        Model = s.Model,
                        Brand = s.Brand == null ? "N/A" : s.Brand.BrandName,
                        Sport = s.Sport == null ? "N/A" : s.Sport.SportName,
                        Genre = s.Genre == null ? "N/A" : s.Genre.GenreName,
                        Color = s.Color == null ? "N/A" : s.Color.ColorName,
                        Price = s.Price
                    }).ToList();
        }

        public List<Size> GetTallesPorZapato(int shoeId)
        {
            return _context.ShoesSizes
                .Include(ss => ss.Size)
                .Where(ss => ss.ShoeId == shoeId)
                .Select(ss => ss.Size)
                .ToList();
        }

        public List<Shoe> GetZapatosPorTalle(int sizeId)
        {
            return _context.ShoesSizes
                .Include(ss => ss.Shoe)
                .Where(ss => ss.SizeId == sizeId)
                .Select(ss => ss.Shoe)
                .ToList();
        }

        public List<ShoeListDto> PasarListaDto(List<Shoe> listaShoes)
        {
            List<ShoeListDto> listaDto = new List<ShoeListDto>();
            foreach (var shoe in listaShoes)
            {
                ShoeListDto dto = new ShoeListDto
                {
                    ShoeId = shoe.ShoeId,
                    Brand = shoe.Brand?.BrandName ?? "", 
                    Sport = shoe.Sport?.SportName ?? "", 
                    Genre = shoe.Genre?.GenreName ?? "", 
                    Color = shoe.Color?.ColorName ?? "", 
                    Model = shoe.Model,
                    Description = shoe.Description,
                    Price = shoe.Price
                };

                listaDto.Add(dto);
            }
            return listaDto;
        }
    }
}
