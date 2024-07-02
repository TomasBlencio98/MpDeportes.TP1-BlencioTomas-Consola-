using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = MpDeportes.TP1.Entidades.Color;

namespace MpDeportes.TP1.Datos.Interfaces
{
    public interface IRepositorioColor
    {
        int GetCantidad(Func<Color, bool>? filtro = null);
        void Agregar(Color color);
        void Editar(Color color);
        void Borrar(Color color);
        List<Color> GetLista();
        List<Shoe>? GetShoes(Color? color);
        bool Existe(Color color);
        Color? GetColorPorId(int id);
        bool EstaRelacionado(Color color);
        int GetCantidad();
        List<Color> GetListaPaginadaOrdenada(int page, int pageSize,
            Orden? orden = null);
    }
}
