using MpDeportes.TP1.Datos.Interfaces;
using MpDeportes.TP1.Datos;
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
    public class ServicioSize : IServicioSize
    {
        private readonly IRepositorioSize _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ServicioSize(IRepositorioSize repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Borrar(Size size)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(size);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Size size)
        {
            try
            {
                return _repository.EstaRelacionado(size);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Size size)
        {
            try
            {
                return _repository.Existe(size);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(Func<Size, bool>? filtro = null)
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

        public List<Size> GetLista()
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

        public List<Size> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            return _repository.GetListaPaginadaOrdenada(page, pageSize, orden);
        }

        public List<Shoe>? GetShoes(Size? size)
        {
            return _repository.GetShoes(size);
        }

        public Size? GetSizesPorId(int id)
        {
            try
            {
                return _repository.GetSizesPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Size size)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (size.SizeId == 0)
                {
                    _repository.Agregar(size);
                }
                else
                {
                    _repository.Editar(size);
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
