using Microsoft.EntityFrameworkCore;
using MpDeportes.TP1.Datos;
using MpDeportes.TP1.Datos.Interfaces;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades.Enums;
using MpDeportes.TP1.Servicios.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Servicios.Servicios
{
    public class ServicioShoe : IServicioShoe
    {
        private readonly IRepositorioShoe _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ServicioShoe(IRepositorioShoe repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void AsignarTalleAZapato(Shoe shoe, Size size, int stock = 0)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var shoeSize = _repository.GetShoeSize(shoe, size);
                if (shoeSize != null)
                {
                    shoeSize.QuantityInStock += stock;
                    _repository.ActualizarShoeSize(shoeSize);
                }
                else
                {
                    ShoeSize nuevaRelacion = new ShoeSize
                    {
                        ShoeId = shoe.ShoeId,
                        SizeId = size.SizeId,
                        QuantityInStock = stock
                    };
                    _repository.AgregarSHOESIZE(nuevaRelacion);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public void Borrar(Shoe shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(shoe);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool Existe(Shoe shoe)
        {
            try
            {
                return _repository.Existe(shoe);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(Func<Shoe, bool>? filtro = null)
        {
            return _repository.GetCantidad(filtro);
        }

        public List<Shoe> GetLista()
        {
            try
            {
               return _repository.GetLista();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ShoeListDto> GetListaDto()
        {
            try
            {
                return _repository.GetListaDto();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Shoe> GetListaOrdenadaFiltradaEntreRangoPrecios(Orden? orden = null, Brand? brand = null, Sport? sport = null, Genre? genre = null, Color? color = null, decimal? maximo = null, decimal? minimo = null)
        {
            try
            {
                return _repository.GetListaOrdenadaFiltradaEntreRangoPrecios
                    (orden, brand, sport, genre, color, maximo, minimo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ShoeListDto> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            return _repository.GetListaPaginadaOrdenada(page, pageSize,orden);
        }

        public Shoe? GetShoePorId(int id)
        {
            try
            {
                return _repository.GetShoePorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ShoeListDto> GetShoesConTalles()
        {
            return _repository.GetShoesConTalles();
        }

        public List<ShoeListDto>? GetShoesSinTalles()
        {
            return _repository.GetShoesSinTalles();
        }

        public int GetStockShoeSize(Shoe shoe, Size size)
        {
            var stock=0;
            if (_repository.ExisteRelacion(shoe,size))
            {
                var shoeSize=_repository.GetShoeSize(shoe, size);
                if (shoeSize == null) return 0; //lo hago por la advertencia, supuestamente
                                                //no hay forma que sea nul
                stock=shoeSize.QuantityInStock;
            }
            return stock;
        }

        public List<Size> GetTallesPorZapato(int shoeId)
        {
            try
            {
                return _repository.GetTallesPorZapato(shoeId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Shoe> GetZapatosPorTalle(int sizeId)
        {
            try
            {
                return _repository.GetZapatosPorTalle(sizeId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Shoe shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (shoe.ShoeId==0)
                {
                    _repository.Agregar(shoe);
                }
                else
                {
                    _repository.Editar(shoe);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public List<ShoeListDto> PasarListaDto(List<Shoe> listaShoes)
        {
            return _repository.PasarListaDto(listaShoes);
        }
    }
}
