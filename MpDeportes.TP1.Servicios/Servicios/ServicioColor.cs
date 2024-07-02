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
    public class ServicioColor : IServicioColor
    {
        private readonly IRepositorioColor _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ServicioColor(IRepositorioColor repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public void Borrar(Color color)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(color);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Color color)
        {
            try
            {
                return _repository.EstaRelacionado(color);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Color color)
        {
            try
            {
                return _repository.Existe(color);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(Func<Color, bool>? filtro = null)
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

        public Color? GetColorPorId(int id)
        {
            try
            {
                return _repository.GetColorPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Color> GetLista()
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

        public List<Color> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            return _repository.GetListaPaginadaOrdenada(page, pageSize, orden);
        }

        public List<Shoe>? GetShoes(Color? color)
        {
            return _repository.GetShoes(color);
        }

        public void Guardar(Color color)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (color.ColorId==0)
                {
                    _repository.Agregar(color);
                }
                else
                {
                    _repository.Editar(color);
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
