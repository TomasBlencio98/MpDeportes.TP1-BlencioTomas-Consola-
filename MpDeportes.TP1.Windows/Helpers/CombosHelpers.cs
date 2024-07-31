using Microsoft.Extensions.DependencyInjection;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = MpDeportes.TP1.Entidades.Color;
using Size = MpDeportes.TP1.Entidades.Size;

namespace MpDeportes.TP1.Windows.Helpers
{
    public static class CombosHelpers
    {
        public static void CargarComboSizes(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioSize>();
            var lista = servicio?.GetLista();
            var defaultSize = new Size
            {
                SizeNumber = 0
            };
            lista?.Insert(0, defaultSize);
            cbo.DataSource = lista;
            cbo.DisplayMember = "SizeNumber";
            cbo.ValueMember = "SizeId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboBrands(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioBrand>();
            var lista = servicio?.GetLista();
            var defaultBrand = new Brand
            {
                BrandName = "Seleccione"
            };
            lista?.Insert(0, defaultBrand);
            cbo.DataSource = lista;
            cbo.DisplayMember = "BrandName";
            cbo.ValueMember = "BrandId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboGenres(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioGenre>();
            var lista = servicio?.GetLista();
            var defaultGenre = new Genre
            {
                GenreName = "Seleccione"
            };
            lista?.Insert(0, defaultGenre);
            cbo.DataSource = lista;
            cbo.DisplayMember = "GenreName";
            cbo.ValueMember = "GenreId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboColors(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioColor>();
            var lista = servicio?.GetLista();
            var defaultColor = new Color
            {
                ColorName = "Seleccione"
            };
            lista?.Insert(0, defaultColor);
            cbo.DataSource = lista;
            cbo.DisplayMember = "ColorName";
            cbo.ValueMember = "ColorId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboSports(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioSport>();
            var lista = servicio?.GetLista();
            var defaultSport = new Sport
            {
                SportName = "Seleccione"
            };
            lista?.Insert(0, defaultSport);
            cbo.DataSource = lista;
            cbo.DisplayMember = "SportName";
            cbo.ValueMember = "SportId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarCombosPaginas(int pageCount, ref ComboBox cbo)
        {
            cbo.Items.Clear();
            for (int page = 1; page <= pageCount; page++)
            {
                cbo.Items.Add(page.ToString());
            }
            cbo.SelectedIndex = 0;
        }
    }
}
