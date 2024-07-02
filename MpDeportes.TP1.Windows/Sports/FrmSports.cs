using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MpDeportes.TP1.Windows.Helpers;
using MpDeportes.TP1.Windows.Genres;
using MpDeportes.TP1.Windows.Shoes;

namespace MpDeportes.TP1.Windows.Sports
{
    public partial class FrmSports : Form
    {
        private readonly IServicioSport _servicio;
        private readonly IServicioShoe _servicioShoe;
        private List<Sport>? listaSports;
        private List<ShoeListDto>? listaShoesDto;
        private List<Shoe>? listaShoes;
        public FrmSports(IServicioSport servicio,
            IServicioShoe servicioShoe)
        {
            InitializeComponent();
            _servicio = servicio;
            _servicioShoe = servicioShoe;
        }

        private void FrmSports_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                listaSports = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelpers.LimpiarGrilla(dgvDatos);
            if (listaSports is not null)
            {
                foreach (var item in listaSports)
                {
                    DataGridViewRow r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, item);
                    GridHelpers.AgregarFila(r, dgvDatos);
                }
            }
        }

        private void MostrarCantidadRegistros()
        {
            TextBoxCantRegistros.Text = _servicio.GetCantidad().ToString();

        }

        private void ToolButtonNuevo_Click(object sender, EventArgs e)
        {
            FrmSportsAE frm = new FrmSportsAE() { Text = "Agregar Deporte" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Sport? sport = frm.GetSport();
                if (sport == null) return;
                if (!_servicio.Existe(sport))
                {
                    _servicio.Guardar(sport);
                    var r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, sport);
                    GridHelpers.AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro Agregado!!!", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Registro Duplicado", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TsButtonBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Sport? sport = r.Tag as Sport;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el deporte {sport?.SportName}?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (sport == null) return;
                if (!_servicio.EstaRelacionado(sport))
                {
                    _servicio.Borrar(sport);
                    GridHelpers.QuitarFila(r, dgvDatos);
                    MessageBox.Show("Registro Borrado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Registro Relacionado...Baja denegada!!!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsButtonEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Sport? sport = r.Tag as Sport;
            FrmSportsAE frm = new FrmSportsAE() { Text = "Editar Deporte" };
            frm.SetSport(sport);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                sport = frm.GetSport();
                if (sport == null) return;
                if (!_servicio.Existe(sport))
                {
                    _servicio.Guardar(sport);
                    GridHelpers.SetearFila(r, sport);
                    MessageBox.Show("Registro Editado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro duplicado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsButtonFiltrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Sport? sport = r.Tag as Sport;
            if (sport == null) return;
            var sportEnDB = _servicio.GetSportPorId(sport.SportId);
            listaShoes = _servicio.GetShoes(sportEnDB);
            if (listaShoes == null) return;
            listaShoesDto = _servicioShoe.PasarListaDto(listaShoes);
            FrmMostrarShoes frm = new FrmMostrarShoes();
            frm.SetLista(listaShoesDto);
            frm.ShowDialog(this);
        }

        private void TsButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
