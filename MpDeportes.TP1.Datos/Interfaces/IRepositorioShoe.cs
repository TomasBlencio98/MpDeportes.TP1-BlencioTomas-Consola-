using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Color = MpDeportes.TP1.Entidades.Color;
using Size = MpDeportes.TP1.Entidades.Size;

namespace MpDeportes.TP1.Datos.Interfaces
{
    public interface IRepositorioShoe
    {
        int GetCantidad(Func<Shoe, bool>? filtro = null);
        void Agregar(Shoe shoe);
        void Editar(Shoe shoe);
        void Borrar(Shoe shoe);
        List<Shoe> GetLista();
        bool Existe(Shoe shoe);
        Shoe? GetShoePorId(int id);
        List<ShoeListDto> GetListaDto();
        List<ShoeListDto> PasarListaDto(List<Shoe> listaShoes);
        List<ShoeListDto> GetListaPaginadaOrdenada(int page,int pageSize,
            Orden? orden = null);
        List<Shoe> GetListaOrdenadaFiltradaEntreRangoPrecios
           (Orden? orden = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Color? color = null,
            decimal? maximo = null,
            decimal? minimo = null);
        List<ShoeListDto>? GetShoesSinTalles();
        //void AgregarSizesAShoe(Shoe shoe, List<Size> sizes);
        void AgregarSHOESIZE(ShoeSize shoeSize);
        bool ExisteRelacion(Shoe shoe, Size size);
        ShoeSize? GetShoeSize(Shoe shoe,Size size);
        List<Size> GetTallesPorZapato(int shoeId);
        List<Shoe> GetZapatosPorTalle(int sizeId);
        void ActualizarShoeSize(ShoeSize shoeSize);
        List<ShoeListDto> GetShoesConTalles();
        List<ShoeListDto> ConvertToShoeListDto(List<ShoeSize> shoeSizes);
    }
}
