using Color = MpDeportes.TP1.Entidades.Color;

namespace MpDeportes.TP1.Windows.Colors
{
    public partial class FrmColorsAE : Form
    {
        private Color? color;
        public FrmColorsAE()
        {
            InitializeComponent();
        }
        public Color? GetColor()
        {
            return color;
        }

        public void SetColor(Color? colorr)
        {
            color = colorr;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (color == null)
                {
                    color = new Color();

                }
                color.ColorName = TextBoxColorName.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TextBoxColorName.Text))
            {
                valid = false;
                errorProvider1.SetError(TextBoxColorName, "El color es requerido!!!");
            }
            else if (double.TryParse(TextBoxColorName.Text, out _))
            {
                valid = false;
                errorProvider1.SetError(TextBoxColorName, "El color no debe ser un número!!!");
            }
            return valid;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (color != null)
            {
                TextBoxColorName.Text = color.ColorName;
            }
        }
    }
}
