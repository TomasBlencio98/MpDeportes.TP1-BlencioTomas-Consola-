using MpDeportes.TP1.Entidades;

namespace MpDeportes.TP1.Windows.Brands
{
    public partial class FrmBrandsAE : Form
    {
        private Brand? brand;
        public FrmBrandsAE()
        {
            InitializeComponent();
        }
        public Brand? GetBrand()
        {
            return brand;
        }

        public void SetBrand(Brand? brandd)
        {
            brand = brandd;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (brand != null)
            {
                TextBoxBrandName.Text = brand.BrandName;
            }
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (brand == null)
                {
                    brand = new Brand();

                }
                brand.BrandName = TextBoxBrandName.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TextBoxBrandName.Text))
            {
                valid = false;
                errorProvider1.SetError(TextBoxBrandName, "La marca es requerido!!!");
            }
            else if (double.TryParse(TextBoxBrandName.Text, out _))
            // _ se utiliza como descartar cuando no necesitas
            // almacenar el valor de salida del método TryParse
            {
                valid = false;
                errorProvider1.SetError(TextBoxBrandName, "La marca no debe ser un número!!!");
            }
            return valid;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
