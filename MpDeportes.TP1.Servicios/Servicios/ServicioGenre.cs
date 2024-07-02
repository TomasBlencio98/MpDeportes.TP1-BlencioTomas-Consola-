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
    public class ServicioGenre : IServicioGenre
    {
        private readonly IRepositorioGenre _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ServicioGenre(IRepositorioGenre repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public void Borrar(Genre genre)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Borrar(genre);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool EstaRelacionado(Genre genre)
        {
            try
            {
                return _repository.EstaRelacionado(genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Genre genre)
        {
            try
            {
                return _repository.Existe(genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(Func<Genre, bool>? filtro = null)
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

        public Genre? GetGenrePorId(int id)
        {
            try
            {
                return _repository.GetGenrePorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Genre> GetLista()
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

        public List<Genre> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            return _repository.GetListaPaginadaOrdenada(page, pageSize, orden);
        }

        public List<Shoe>? GetShoes(Genre? genre)
        {
            return _repository.GetShoes(genre);
        }

        public void Guardar(Genre genre)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (genre.GenreId==0)
                {
                    _repository.Agregar(genre);
                }
                else
                {
                    _repository.Editar(genre);
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
