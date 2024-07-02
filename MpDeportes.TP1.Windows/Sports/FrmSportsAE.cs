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

namespace MpDeportes.TP1.Windows.Sports
{
    public partial class FrmSportsAE : Form
    {
        private Sport? sports;
        public FrmSportsAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (sports != null)
            {
                TextBoxSportName.Text = sports.SportName;
            }
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (sports == null)
                {
                    sports = new Sport();

                }
                sports.SportName = TextBoxSportName.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TextBoxSportName.Text))
            {
                valid = false;
                errorProvider1.SetError(TextBoxSportName, "El deporte es requerido!!!");
            }
            else if (double.TryParse(TextBoxSportName.Text, out _))
            {
                valid = false;
                errorProvider1.SetError(TextBoxSportName, "El deporte no debe ser un número!!!");
            }
            return valid;
        }
        public Sport? GetSport()
        {
            return sports;
        }

        public void SetSport(Sport? sportt)
        {
            sports = sportt;
        }
    }
}
