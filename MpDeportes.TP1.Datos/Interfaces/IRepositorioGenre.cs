using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Datos.Interfaces
{
    public interface IRepositorioGenre
    {
        int GetCantidad(Func<Genre, bool>? filtro = null);
        void Agregar(Genre genre);
        void Editar(Genre genre);
        void Borrar(Genre genre);
        List<Genre> GetLista();
        List<Shoe>? GetShoes(Genre? genre);
        bool Existe(Genre genre);
        Genre? GetGenrePorId(int id);
        bool EstaRelacionado(Genre genre);
        int GetCantidad();
        List<Genre> GetListaPaginadaOrdenada(int page, int pageSize,
            Orden? orden = null);
    }
}
