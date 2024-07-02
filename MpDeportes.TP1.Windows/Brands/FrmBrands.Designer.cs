﻿namespace MpDeportes.TP1.Windows.Brands
{
    partial class FrmBrands
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrands));
            toolStrip1 = new ToolStrip();
            ToolButtonNuevo = new ToolStripButton();
            TsButtonBorrar = new ToolStripButton();
            TsButtonEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsButtonFiltrar = new ToolStripButton();
            TsButtonSalir = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            ColumnaMarca = new DataGridViewTextBoxColumn();
            TextBoxCantRegistros = new TextBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { ToolButtonNuevo, TsButtonBorrar, TsButtonEditar, toolStripSeparator1, TsButtonFiltrar, TsButtonSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(680, 72);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // ToolButtonNuevo
            // 
            ToolButtonNuevo.Image = (Image)resources.GetObject("ToolButtonNuevo.Image");
            ToolButtonNuevo.ImageScaling = ToolStripItemImageScaling.None;
            ToolButtonNuevo.ImageTransparentColor = Color.Magenta;
            ToolButtonNuevo.Name = "ToolButtonNuevo";
            ToolButtonNuevo.Size = new Size(52, 69);
            ToolButtonNuevo.Text = "Nuevo";
            ToolButtonNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            ToolButtonNuevo.Click += ToolButtonNuevo_Click;
            // 
            // TsButtonBorrar
            // 
            TsButtonBorrar.Image = (Image)resources.GetObject("TsButtonBorrar.Image");
            TsButtonBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonBorrar.ImageTransparentColor = Color.Magenta;
            TsButtonBorrar.Name = "TsButtonBorrar";
            TsButtonBorrar.Size = new Size(52, 69);
            TsButtonBorrar.Text = "Borrar";
            TsButtonBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonBorrar.Click += TsButtonBorrar_Click;
            // 
            // TsButtonEditar
            // 
            TsButtonEditar.Image = (Image)resources.GetObject("TsButtonEditar.Image");
            TsButtonEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonEditar.ImageTransparentColor = Color.Magenta;
            TsButtonEditar.Name = "TsButtonEditar";
            TsButtonEditar.Size = new Size(52, 69);
            TsButtonEditar.Text = "Editar";
            TsButtonEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonEditar.Click += TsButtonEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 72);
            // 
            // TsButtonFiltrar
            // 
            TsButtonFiltrar.Image = (Image)resources.GetObject("TsButtonFiltrar.Image");
            TsButtonFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonFiltrar.ImageTransparentColor = Color.Magenta;
            TsButtonFiltrar.Name = "TsButtonFiltrar";
            TsButtonFiltrar.Size = new Size(54, 69);
            TsButtonFiltrar.Text = "Detalle";
            TsButtonFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonFiltrar.Click += TsButtonFiltrar_Click;
            // 
            // TsButtonSalir
            // 
            TsButtonSalir.Image = (Image)resources.GetObject("TsButtonSalir.Image");
            TsButtonSalir.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonSalir.ImageTransparentColor = Color.Magenta;
            TsButtonSalir.Name = "TsButtonSalir";
            TsButtonSalir.Size = new Size(52, 69);
            TsButtonSalir.Text = "Salir";
            TsButtonSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonSalir.Click += TsButtonSalir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 72);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TextBoxCantRegistros);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(680, 272);
            splitContainer1.SplitterDistance = 197;
            splitContainer1.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaMarca });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(680, 197);
            dgvDatos.TabIndex = 0;
            // 
            // ColumnaMarca
            // 
            ColumnaMarca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaMarca.HeaderText = "Marca";
            ColumnaMarca.Name = "ColumnaMarca";
            ColumnaMarca.ReadOnly = true;
            // 
            // TextBoxCantRegistros
            // 
            TextBoxCantRegistros.Enabled = false;
            TextBoxCantRegistros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxCantRegistros.Location = new Point(192, 20);
            TextBoxCantRegistros.Name = "TextBoxCantRegistros";
            TextBoxCantRegistros.Size = new Size(47, 29);
            TextBoxCantRegistros.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 4;
            label1.Text = "Cantidad de Registros: ";
            // 
            // FrmBrands
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 344);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            MaximumSize = new Size(696, 383);
            MinimumSize = new Size(696, 383);
            Name = "FrmBrands";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBrands";
            Load += FrmBrands_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton ToolButtonNuevo;
        private ToolStripButton TsButtonBorrar;
        private ToolStripButton TsButtonEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsButtonFiltrar;
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private Button ButtonUltimo;
        private Button ButtonSiguiente;
        private Button ButtonAnterior;
        private Button ButtonPrimero;
        private TextBox TextBoxCantPaginas;
        private TextBox TextBoxCantRegistros;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn ColumnaMarca;
        private ToolStripButton TsButtonSalir;
    }
}