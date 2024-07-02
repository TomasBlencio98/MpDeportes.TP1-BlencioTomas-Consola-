using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Servicios.Interfaces
{
    public interface IServicioBrand
    {
        int GetCantidad(Func<Brand, bool>? filtro = null);
        void Guardar(Brand brand);
        void Borrar(Brand brand);
        List<Brand> GetLista();
        List<Shoe>? GetShoes(Brand? brand);
        bool Existe(Brand brand);
        Brand? GetBrandPorId(int id);
        bool EstaRelacionado(Brand brand);
        int GetCantidad();
        List<Brand> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null);
    }
}
