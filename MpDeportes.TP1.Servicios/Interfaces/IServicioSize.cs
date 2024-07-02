using MpDeportes.TP1.Entidades.Enums;
using MpDeportes.TP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Servicios.Interfaces
{
    public interface IServicioSize
    {
        int GetCantidad(Func<Size, bool>? filtro = null);
        void Guardar(Size size);
        void Borrar(Size size);
        List<Size> GetLista();
        List<Shoe>? GetShoes(Size? size);
        bool Existe(Size size);
        Size? GetSizesPorId(int id);
        bool EstaRelacionado(Size size);
        int GetCantidad();
        List<Size> GetListaPaginadaOrdenada(int page, int pageSize,
            Orden? orden = null);
    }
}
