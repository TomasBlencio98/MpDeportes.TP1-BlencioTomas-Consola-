using Microsoft.Extensions.DependencyInjection;
using MpDeportes.TP1.Servicios.Interfaces;
using MpDeportes.TP1.Windows.Brands;
using MpDeportes.TP1.Windows.Colors;
using MpDeportes.TP1.Windows.Genres;
using MpDeportes.TP1.Windows.Shoes;
using MpDeportes.TP1.Windows.Sports;

namespace MpDeportes.TP1.Windows
{
    public partial class MenuPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public MenuPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void ButtonBrands_Click(object sender, EventArgs e)
        {
            var servicioBrand = _serviceProvider
                .GetService<IServicioBrand>();
            var servicioShoe = _serviceProvider
                .GetService<IServicioShoe>();
            if (servicioBrand == null || servicioShoe == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            FrmBrands frm = new FrmBrands(servicioBrand, servicioShoe);
            frm.ShowDialog();
        }

        private void ButtonColors_Click(object sender, EventArgs e)
        {
            var servicioColors = _serviceProvider
                .GetService<IServicioColor>();
            var servicioShoe = _serviceProvider
                .GetService<IServicioShoe>();
            if (servicioColors == null || servicioShoe == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmColors frm = new FrmColors(servicioColors, servicioShoe);
            frm.ShowDialog();
        }

        private void ButtonGenres_Click(object sender, EventArgs e)
        {
            var servicioGenres = _serviceProvider
               .GetService<IServicioGenre>();
            var servicioShoe = _serviceProvider
                .GetService<IServicioShoe>();
            if (servicioGenres == null || servicioShoe == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmGenres frm = new FrmGenres(servicioGenres, servicioShoe);
            frm.ShowDialog();
        }

        private void ButtonSports_Click(object sender, EventArgs e)
        {
            var servicioSports = _serviceProvider
               .GetService<IServicioSport>();
            var servicioShoe = _serviceProvider
                .GetService<IServicioShoe>();
            if (servicioSports == null || servicioShoe == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmSports frm = new FrmSports(servicioSports, servicioShoe);
            frm.ShowDialog();
        }

        private void ButtonShoes_Click(object sender, EventArgs e)
        {
            var servicioShoes = _serviceProvider
               .GetService<IServicioShoe>();
            if (servicioShoes == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmShoes frm = new FrmShoes(servicioShoes, _serviceProvider);
            frm.ShowDialog();
        }
    }
}
