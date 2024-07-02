using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Windows.Helpers;

namespace MpDeportes.TP1.Windows.Shoes
{
    public partial class FrmMostrarShoes : Form
    {
        private List<ShoeListDto>? lista;
        public FrmMostrarShoes()
        {
            InitializeComponent();
        }

        public void SetLista(List<ShoeListDto>? listaShoes)
        {
            lista = listaShoes;
        }

        private void FrmMostrarShoes_Load(object sender, EventArgs e)
        {
            if (lista != null)
            {
                TextBoxCantidadShoes.Text = lista.Count().ToString();
                MostrarShoesEnGrilla();
            }
        }

        private void MostrarShoesEnGrilla()
        {
            if (lista == null) return;
            GridHelpers.LimpiarGrilla(dgvDatos);
            foreach (var item in lista)
            {
                var r = GridHelpers.ConstruirFila(dgvDatos);
                GridHelpers.SetearFila(r, item);
                GridHelpers.AgregarFila(r, dgvDatos);
            }
        }
    }
}
