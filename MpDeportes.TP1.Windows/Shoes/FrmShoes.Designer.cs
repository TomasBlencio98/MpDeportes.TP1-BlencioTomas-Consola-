namespace MpDeportes.TP1.Windows.Shoes
{
    partial class FrmShoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShoes));
            toolStrip1 = new ToolStrip();
            ToolButtonNuevo = new ToolStripButton();
            TsButtonBorrar = new ToolStripButton();
            TsButtonEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsButtonFiltrar = new ToolStripButton();
            TsButtonActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            DropDownButtonOrdenar = new ToolStripDropDownButton();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            ColumnaBrand = new DataGridViewTextBoxColumn();
            ColumnaGenre = new DataGridViewTextBoxColumn();
            ColumnaColor = new DataGridViewTextBoxColumn();
            ColumnaSport = new DataGridViewTextBoxColumn();
            ColumnaPrice = new DataGridViewTextBoxColumn();
            ComboBoxPaginas = new ComboBox();
            TextBoxCantRegistros = new TextBox();
            label3 = new Label();
            ButtonUltimo = new Button();
            ButtonSiguiente = new Button();
            ButtonAnterior = new Button();
            ButtonPrimero = new Button();
            TxbCantRegistros = new TextBox();
            label2 = new Label();
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { ToolButtonNuevo, TsButtonBorrar, TsButtonEditar, toolStripSeparator1, TsButtonFiltrar, TsButtonActualizar, toolStripSeparator2, DropDownButtonOrdenar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(680, 70);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // ToolButtonNuevo
            // 
            ToolButtonNuevo.Image = (Image)resources.GetObject("ToolButtonNuevo.Image");
            ToolButtonNuevo.ImageScaling = ToolStripItemImageScaling.None;
            ToolButtonNuevo.ImageTransparentColor = Color.Magenta;
            ToolButtonNuevo.Name = "ToolButtonNuevo";
            ToolButtonNuevo.Size = new Size(52, 67);
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
            TsButtonBorrar.Size = new Size(52, 67);
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
            TsButtonEditar.Size = new Size(52, 67);
            TsButtonEditar.Text = "Editar";
            TsButtonEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonEditar.Click += TsButtonEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 70);
            // 
            // TsButtonFiltrar
            // 
            TsButtonFiltrar.Image = (Image)resources.GetObject("TsButtonFiltrar.Image");
            TsButtonFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonFiltrar.ImageTransparentColor = Color.Magenta;
            TsButtonFiltrar.Name = "TsButtonFiltrar";
            TsButtonFiltrar.Size = new Size(52, 67);
            TsButtonFiltrar.Text = "Filtrar";
            TsButtonFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TsButtonActualizar
            // 
            TsButtonActualizar.Image = (Image)resources.GetObject("TsButtonActualizar.Image");
            TsButtonActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonActualizar.ImageTransparentColor = Color.Magenta;
            TsButtonActualizar.Name = "TsButtonActualizar";
            TsButtonActualizar.Size = new Size(63, 67);
            TsButtonActualizar.Text = "Actualizar";
            TsButtonActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 70);
            // 
            // DropDownButtonOrdenar
            // 
            DropDownButtonOrdenar.Image = (Image)resources.GetObject("DropDownButtonOrdenar.Image");
            DropDownButtonOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            DropDownButtonOrdenar.ImageTransparentColor = Color.Magenta;
            DropDownButtonOrdenar.Name = "DropDownButtonOrdenar";
            DropDownButtonOrdenar.Size = new Size(63, 67);
            DropDownButtonOrdenar.Text = "Ordenar";
            DropDownButtonOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 70);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ComboBoxPaginas);
            splitContainer1.Panel2.Controls.Add(TextBoxCantRegistros);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(ButtonUltimo);
            splitContainer1.Panel2.Controls.Add(ButtonSiguiente);
            splitContainer1.Panel2.Controls.Add(ButtonAnterior);
            splitContainer1.Panel2.Controls.Add(ButtonPrimero);
            splitContainer1.Panel2.Controls.Add(TxbCantRegistros);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(680, 274);
            splitContainer1.SplitterDistance = 194;
            splitContainer1.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaBrand, ColumnaGenre, ColumnaColor, ColumnaSport, ColumnaPrice });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(680, 194);
            dgvDatos.TabIndex = 0;
            // 
            // ColumnaBrand
            // 
            ColumnaBrand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaBrand.HeaderText = "Brands";
            ColumnaBrand.Name = "ColumnaBrand";
            ColumnaBrand.ReadOnly = true;
            // 
            // ColumnaGenre
            // 
            ColumnaGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaGenre.HeaderText = "Genres";
            ColumnaGenre.Name = "ColumnaGenre";
            ColumnaGenre.ReadOnly = true;
            // 
            // ColumnaColor
            // 
            ColumnaColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaColor.HeaderText = "Colors";
            ColumnaColor.Name = "ColumnaColor";
            ColumnaColor.ReadOnly = true;
            // 
            // ColumnaSport
            // 
            ColumnaSport.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaSport.HeaderText = "Sports";
            ColumnaSport.Name = "ColumnaSport";
            ColumnaSport.ReadOnly = true;
            // 
            // ColumnaPrice
            // 
            ColumnaPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaPrice.HeaderText = "Prices";
            ColumnaPrice.Name = "ColumnaPrice";
            ColumnaPrice.ReadOnly = true;
            // 
            // ComboBoxPaginas
            // 
            ComboBoxPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPaginas.FormattingEnabled = true;
            ComboBoxPaginas.Location = new Point(81, 10);
            ComboBoxPaginas.Name = "ComboBoxPaginas";
            ComboBoxPaginas.Size = new Size(56, 23);
            ComboBoxPaginas.TabIndex = 13;
            // 
            // TextBoxCantRegistros
            // 
            TextBoxCantRegistros.Enabled = false;
            TextBoxCantRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxCantRegistros.Location = new Point(187, 43);
            TextBoxCantRegistros.Name = "TextBoxCantRegistros";
            TextBoxCantRegistros.Size = new Size(47, 25);
            TextBoxCantRegistros.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 46);
            label3.Name = "label3";
            label3.Size = new Size(169, 21);
            label3.TabIndex = 11;
            label3.Text = "Cantidad de Registros: ";
            // 
            // ButtonUltimo
            // 
            ButtonUltimo.Image = (Image)resources.GetObject("ButtonUltimo.Image");
            ButtonUltimo.Location = new Point(579, 20);
            ButtonUltimo.Name = "ButtonUltimo";
            ButtonUltimo.Size = new Size(67, 44);
            ButtonUltimo.TabIndex = 2;
            ButtonUltimo.UseVisualStyleBackColor = true;
            ButtonUltimo.Click += ButtonUltimo_Click;
            // 
            // ButtonSiguiente
            // 
            ButtonSiguiente.Image = (Image)resources.GetObject("ButtonSiguiente.Image");
            ButtonSiguiente.Location = new Point(506, 20);
            ButtonSiguiente.Name = "ButtonSiguiente";
            ButtonSiguiente.Size = new Size(67, 44);
            ButtonSiguiente.TabIndex = 2;
            ButtonSiguiente.UseVisualStyleBackColor = true;
            ButtonSiguiente.Click += ButtonSiguiente_Click;
            // 
            // ButtonAnterior
            // 
            ButtonAnterior.Image = (Image)resources.GetObject("ButtonAnterior.Image");
            ButtonAnterior.Location = new Point(390, 20);
            ButtonAnterior.Name = "ButtonAnterior";
            ButtonAnterior.Size = new Size(67, 44);
            ButtonAnterior.TabIndex = 2;
            ButtonAnterior.UseVisualStyleBackColor = true;
            ButtonAnterior.Click += ButtonAnterior_Click;
            // 
            // ButtonPrimero
            // 
            ButtonPrimero.Image = (Image)resources.GetObject("ButtonPrimero.Image");
            ButtonPrimero.Location = new Point(317, 20);
            ButtonPrimero.Name = "ButtonPrimero";
            ButtonPrimero.Size = new Size(67, 44);
            ButtonPrimero.TabIndex = 2;
            ButtonPrimero.UseVisualStyleBackColor = true;
            ButtonPrimero.Click += ButtonPrimero_Click;
            // 
            // TxbCantRegistros
            // 
            TxbCantRegistros.Enabled = false;
            TxbCantRegistros.Location = new Point(187, 10);
            TxbCantRegistros.Name = "TxbCantRegistros";
            TxbCantRegistros.Size = new Size(47, 23);
            TxbCantRegistros.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(141, 12);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 0;
            label2.Text = "de";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "Pagina: ";
            // 
            // FrmShoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 344);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            MaximumSize = new Size(696, 383);
            MinimumSize = new Size(696, 383);
            Name = "FrmShoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmShoes";
            Load += FrmShoes_Load;
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
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private ToolStripButton ToolButtonNuevo;
        private ToolStripButton TsButtonBorrar;
        private ToolStripButton TsButtonEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsButtonFiltrar;
        private ToolStripButton TsButtonActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton DropDownButtonOrdenar;
        private Button ButtonPrimero;
        private TextBox TxbCantRegistros;
        private Label label2;
        private Label label1;
        private Button ButtonAnterior;
        private Button ButtonUltimo;
        private Button ButtonSiguiente;
        private TextBox TextBoxCantRegistros;
        private Label label3;
        private DataGridViewTextBoxColumn ColumnaBrand;
        private DataGridViewTextBoxColumn ColumnaGenre;
        private DataGridViewTextBoxColumn ColumnaColor;
        private DataGridViewTextBoxColumn ColumnaSport;
        private DataGridViewTextBoxColumn ColumnaPrice;
        private ComboBox ComboBoxPaginas;
    }
}