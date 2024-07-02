using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Datos.Interfaces
{
    public interface IRepositorioSport
    {
        int GetCantidad(Func<Sport, bool>? filtro = null);
        void Agregar(Sport sport);
        void Editar(Sport sport);
        void Borrar(Sport sport);
        List<Sport> GetLista();
        List<Shoe>? GetShoes(Sport? sport);
        bool Existe(Sport sport);
        Sport? GetSportPorId(int  id);
        bool EstaRelacionado(Sport sport);
        int GetCantidad();
        List<Sport> GetListaPaginadaOrdenada(int page, int pageSize,
            Orden? orden = null);
    }
}
