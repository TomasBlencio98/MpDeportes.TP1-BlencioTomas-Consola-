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
    public class ServicioSport : IServicioSport
    {
        private readonly IRepositorioSport _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ServicioSport(IRepositorioSport repository, IUnitOfWork unitOfWork)
        {
            _repository= repository;   
            _unitOfWork= unitOfWork;
        }
        public void Borrar(Sport sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(sport);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Sport sport)
        {
            try
            {
                return _repository.EstaRelacionado(sport);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Sport sport)
        {
            try
            {
                return _repository.Existe(sport);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(Func<Sport, bool>? filtro = null)
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

        public List<Sport> GetLista()
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

        public List<Sport> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            return _repository.GetListaPaginadaOrdenada(page, pageSize, orden);
        }

        public List<Shoe>? GetShoes(Sport? sport)
        {
            return _repository.GetShoes(sport);
        }

        public Sport? GetSportPorId(int id)
        {
            try
            {
                return _repository.GetSportPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Sport sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (sport.SportId == 0)
                {
                    _repository.Agregar(sport);
                }
                else
                {
                    _repository.Editar(sport);
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
