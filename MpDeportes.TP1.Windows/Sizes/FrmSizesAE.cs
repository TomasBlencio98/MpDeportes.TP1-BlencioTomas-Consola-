using MpDeportes.TP1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Size = MpDeportes.TP1.Entidades.Size;

namespace MpDeportes.TP1.Windows.Sizes
{
    public partial class FrmSizesAE : Form
    {
        private Size? size;
        public FrmSizesAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (size != null)
            {
                TextBoxSizeNumber.Text = size.SizeNumber.ToString();
            }
        }
        public Size? GetSize()
        {
            return size;
        }

        public void SetSize(Size? sizee)
        {
            size = sizee;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (size == null)
                {
                    size = new Size();
                }
                size.SizeNumber = decimal.Parse(TextBoxSizeNumber.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (!decimal.TryParse(TextBoxSizeNumber.Text, out decimal number) ||
                (number <= 0))
            {
                valid = false;
                errorProvider1.SetError(TextBoxSizeNumber, "Talle no válido o mal ingresado");
            }
            return valid;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
