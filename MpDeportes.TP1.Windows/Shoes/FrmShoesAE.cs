using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = MpDeportes.TP1.Entidades.Color;

namespace MpDeportes.TP1.Windows.Shoes
{
    public partial class FrmShoesAE : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Shoe? shoe;
        private Brand? brand;
        private Genre? genre;
        private Color? color;
        private Sport? sport;
        public FrmShoesAE(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelpers.CargarComboBrands(_serviceProvider, ref ComboboxBrand);
            CombosHelpers.CargarComboGenres(_serviceProvider, ref ComboboxGenre);
            CombosHelpers.CargarComboColors(_serviceProvider, ref ComboboxColor);
            CombosHelpers.CargarComboSports(_serviceProvider, ref ComboboxSport);
            if (shoe != null)
            {
                TexboxDescripcion.Text = shoe.Description;
                TexboxModel.Text = shoe.Model;
                TexboxPrice.Text = shoe.Price.ToString();
                ComboboxBrand.SelectedValue = shoe?.BrandId;
                ComboboxColor.SelectedValue = shoe?.ColorId;
                ComboboxGenre.SelectedValue = shoe?.GenreId;
                ComboboxSport.SelectedValue = shoe?.SportId;
            }
        }
        public Shoe? GetShoe()
        {
            return shoe;
        }

        public void SetShoe(Shoe? shoee)
        {
            shoe = shoee;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (shoe == null)
                {
                    shoe = new Shoe();

                }
                shoe.Brand = brand;
                shoe.BrandId = brand?.BrandId ?? 0;
                shoe.Genre = genre;
                shoe.GenreId = genre?.GenreId ?? 0;
                shoe.Sport = sport;
                shoe.SportId = sport?.SportId ?? 0;
                shoe.Color = color;
                shoe.ColorId = color?.ColorId ?? 0;
                shoe.Description = TexboxDescripcion.Text;
                shoe.Model = TexboxModel.Text;
                shoe.Price = decimal.Parse(TexboxPrice.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TexboxDescripcion.Text) ||
                string.IsNullOrWhiteSpace(TexboxDescripcion.Text))
            {
                valido = false;
                errorProvider1.SetError(TexboxDescripcion, "La descripcion es requerido");
            }
            if (string.IsNullOrEmpty(TexboxModel.Text) ||
                string.IsNullOrWhiteSpace(TexboxModel.Text))
            {
                valido = false;
                errorProvider1.SetError(TexboxModel, "El modelo es requerido");
            }
            if (!decimal.TryParse(TexboxPrice.Text, out decimal price) ||
                (price <= 0))
            {
                valido = false;
                errorProvider1.SetError(TexboxPrice, "Precio no válido o mal ingresado");
            }
            if (ComboboxBrand.SelectedIndex == 0 && brand == null)
            {
                valido = false;
                errorProvider1.SetError(ComboboxBrand, "Debe seleccionar una marca");

            }
            if (ComboboxColor.SelectedIndex == 0 && color == null)
            {
                valido = false;
                errorProvider1.SetError(ComboboxColor, "Debe seleccionar un color");
            }
            if (ComboboxGenre.SelectedIndex == 0 && genre == null)
            {
                valido = false;
                errorProvider1.SetError(ComboboxGenre, "Debe seleccionar un genero");

            }
            if (ComboboxSport.SelectedIndex == 0 && sport == null)
            {
                valido = false;
                errorProvider1.SetError(ComboboxSport, "Debe seleccionar un deporte");
            }
            return valido;
        }

        private void ComboboxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboboxBrand.SelectedIndex > 0)
            {
                brand = ComboboxBrand.SelectedItem as Brand;
            }
            else
            {
                brand = null;
            }
        }

        private void ComboboxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboboxGenre.SelectedIndex > 0)
            {
                genre = ComboboxGenre.SelectedItem as Genre;
            }
            else
            {
                genre = null;
            }
        }

        private void ComboboxSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboboxSport.SelectedIndex > 0)
            {
                sport = ComboboxSport.SelectedItem as Sport;
            }
            else
            {
                sport = null;
            }
        }

        private void ComboboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboboxColor.SelectedIndex > 0)
            {
                color = ComboboxColor.SelectedItem as Color;
            }
            else
            {
                color = null;
            }
        }
    }
}
