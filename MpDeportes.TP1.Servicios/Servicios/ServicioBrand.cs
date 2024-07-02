using MpDeportes.TP1.Datos;
using MpDeportes.TP1.Datos.Interfaces;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Enums;
using MpDeportes.TP1.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Servicios.Servicios
{
    public class ServicioBrand : IServicioBrand
    {
        private readonly IRepositorioBrand _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ServicioBrand(IRepositorioBrand repository,IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public void Borrar(Brand brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(brand);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Brand brand)
        {
            try
            {
                return _repository.EstaRelacionado(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Brand brand)
        {
            try
            {
                return _repository.Existe(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Brand? GetBrandPorId(int id)
        {
            try
            {
                return _repository.GetBrandPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(Func<Brand, bool>? filtro = null)
        {
            return _repository.GetCantidad(filtro);
        }

        public int GetCantidad()
        {
            try
            {
                return _repository.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Brand> GetLista()
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

        public List<Brand> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            return _repository.GetListaPaginadaOrdenada(page, pageSize, orden);
        }

        public List<Shoe>? GetShoes(Brand? brand)
        {
            return _repository.GetShoes(brand);
        }

        public void Guardar(Brand brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (brand.BrandId==0)
                {
                    _repository.Agregar(brand);
                }
                else
                {
                    _repository.Editar(brand);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }
    }
}
