using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Servicios.Interfaces
{
    public interface IServicioShoe
    {
        int GetCantidad(Func<Shoe, bool>? filtro = null);
        void Guardar(Shoe shoe);
        void Borrar(Shoe shoe);
        List<Shoe> GetLista();
        bool Existe(Shoe shoe);
        Shoe? GetShoePorId(int id);
        List<ShoeListDto> GetListaDto();
        List<ShoeListDto> PasarListaDto(List<Shoe> listaShoes);
        List<ShoeListDto> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null);
        List<Shoe> GetListaOrdenadaFiltradaEntreRangoPrecios
           (Orden? orden = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Color? color = null,
            decimal? maximo = null,
            decimal? minimo = null);
        List<ShoeListDto>? GetShoesSinTalles();
        void AsignarTalleAZapato(Shoe shoeSinSize, Size size, int stock=0);
        List<Size> GetTallesPorZapato(int shoeId);
        List<Shoe> GetZapatosPorTalle(int sizeId);
        int GetStockShoeSize(Shoe shoe, Size size);
        List<ShoeSize> GetShoesConTalles();
    }
}
