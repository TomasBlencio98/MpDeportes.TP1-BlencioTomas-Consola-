using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Servicios.Interfaces;
using MpDeportes.TP1.Windows.Helpers;

namespace MpDeportes.TP1.Windows.Shoes
{
    public partial class FrmAsignarTalle : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IServicioShoe _servicio;
        private Shoe? shoe;
        private ShoeSize? shoeSize;
        private int stock = 1;
        public FrmAsignarTalle(IServiceProvider serviceProvider, IServicioShoe servicio)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = servicio;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelpers.CargarComboSizes(_serviceProvider, ref ComboBoxTalles);
            if (shoe != null)
            {
                TexboxDescripcion.Text = shoe.Description;
                TexboxModelo.Text = shoe.Model;
                TexboxPrice.Text = shoe.Price.ToString();
                TexBoxBrand.Text = shoe.Brand.BrandName;
                TexBoxColor.Text = shoe.Color.ColorName;
                TexBoxGenre.Text = shoe.Genre.GenreName;
                TexBoxSport.Text = shoe.Sport.SportName;
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                shoeSize = new ShoeSize();
                shoeSize.ShoeId = shoe.ShoeId;
                shoeSize.SizeId = (int)ComboBoxTalles.SelectedValue;
                stock = int.Parse(TexBoxStock.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (ComboBoxTalles.SelectedIndex == 0 && Size == null)
            {
                valido = false;
                errorProvider1.SetError(ComboBoxTalles, "Debe seleccionar un talle");
            }
            if (!int.TryParse(TexBoxStock.Text, out int stock) ||
                (stock <= 0))
            {
                valido = false;
                errorProvider1.SetError(TexBoxStock, "stock no válido o mal ingresado");
            }
            return valido;
        }

        public void SetShoe(Shoe? shoe)
        {
            this.shoe = shoe;
        }

        public ShoeSize? GetShoe()
        {
            return shoeSize;
        }

        public int GetStock()
        {
            return stock;
        }
    }
}
