namespace MpDeportes.TP1.Windows.Shoes
{
    partial class FrmMostrarShoes
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
            panel1 = new Panel();
            dgvDatos = new DataGridView();
            ColumnaBrand = new DataGridViewTextBoxColumn();
            ColumnaGenre = new DataGridViewTextBoxColumn();
            ColumnaColor = new DataGridViewTextBoxColumn();
            ColumnaSport = new DataGridViewTextBoxColumn();
            ColumnaPrice = new DataGridViewTextBoxColumn();
            label1 = new Label();
            TextBoxCantidadShoes = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDatos);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 290);
            panel1.TabIndex = 0;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaBrand, ColumnaGenre, ColumnaColor, ColumnaSport, ColumnaPrice });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(683, 290);
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
            ColumnaPrice.HeaderText = "Price";
            ColumnaPrice.Name = "ColumnaPrice";
            ColumnaPrice.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 305);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 1;
            label1.Text = "Cantidad de Registros: ";
            // 
            // TextBoxCantidadShoes
            // 
            TextBoxCantidadShoes.Enabled = false;
            TextBoxCantidadShoes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxCantidadShoes.Location = new Point(187, 302);
            TextBoxCantidadShoes.Name = "TextBoxCantidadShoes";
            TextBoxCantidadShoes.Size = new Size(55, 29);
            TextBoxCantidadShoes.TabIndex = 2;
            // 
            // FrmMostrarShoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 344);
            Controls.Add(TextBoxCantidadShoes);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximumSize = new Size(703, 383);
            MinimumSize = new Size(703, 383);
            Name = "FrmMostrarShoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMostrarShoes";
            Load += FrmMostrarShoes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColumnaBrand;
        private DataGridViewTextBoxColumn ColumnaGenre;
        private DataGridViewTextBoxColumn ColumnaColor;
        private DataGridViewTextBoxColumn ColumnaSport;
        private DataGridViewTextBoxColumn ColumnaPrice;
        private Label label1;
        private TextBox TextBoxCantidadShoes;
    }
}