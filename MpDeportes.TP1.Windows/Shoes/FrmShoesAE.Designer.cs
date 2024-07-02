namespace MpDeportes.TP1.Windows.Shoes
{
    partial class FrmShoesAE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShoesAE));
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TexboxPrice = new TextBox();
            label5 = new Label();
            TexboxDescripcion = new TextBox();
            label6 = new Label();
            TexboxModel = new TextBox();
            label7 = new Label();
            ComboboxBrand = new ComboBox();
            ComboboxGenre = new ComboBox();
            ComboboxColor = new ComboBox();
            ComboboxSport = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Image = (Image)resources.GetObject("ButtonCancelar.Image");
            ButtonCancelar.Location = new Point(278, 299);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(73, 45);
            ButtonCancelar.TabIndex = 8;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Image = (Image)resources.GetObject("ButtonAceptar.Image");
            ButtonAceptar.Location = new Point(27, 299);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(73, 45);
            ButtonAceptar.TabIndex = 7;
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 11;
            label1.Text = "Brand: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 60);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 15;
            label2.Text = "Genre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 139);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 19;
            label3.Text = "Color: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 100);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 17;
            label4.Text = "Sport:";
            // 
            // TexboxPrice
            // 
            TexboxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TexboxPrice.Location = new Point(93, 254);
            TexboxPrice.Name = "TexboxPrice";
            TexboxPrice.PlaceholderText = "Ingrese el precio...";
            TexboxPrice.Size = new Size(258, 29);
            TexboxPrice.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 257);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 25;
            label5.Text = "Price: ";
            // 
            // TexboxDescripcion
            // 
            TexboxDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TexboxDescripcion.Location = new Point(93, 215);
            TexboxDescripcion.Name = "TexboxDescripcion";
            TexboxDescripcion.PlaceholderText = "Ingrese la descripcion...";
            TexboxDescripcion.Size = new Size(258, 29);
            TexboxDescripcion.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 218);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 23;
            label6.Text = "Desc:";
            // 
            // TexboxModel
            // 
            TexboxModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TexboxModel.Location = new Point(93, 175);
            TexboxModel.Name = "TexboxModel";
            TexboxModel.PlaceholderText = "Ingrese el modelo...";
            TexboxModel.Size = new Size(258, 29);
            TexboxModel.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 178);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 21;
            label7.Text = "Model: ";
            // 
            // ComboboxBrand
            // 
            ComboboxBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxBrand.FormattingEnabled = true;
            ComboboxBrand.Location = new Point(93, 19);
            ComboboxBrand.Name = "ComboboxBrand";
            ComboboxBrand.Size = new Size(258, 23);
            ComboboxBrand.TabIndex = 0;
            ComboboxBrand.SelectedIndexChanged += ComboboxBrand_SelectedIndexChanged;
            // 
            // ComboboxGenre
            // 
            ComboboxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxGenre.FormattingEnabled = true;
            ComboboxGenre.Location = new Point(93, 62);
            ComboboxGenre.Name = "ComboboxGenre";
            ComboboxGenre.Size = new Size(258, 23);
            ComboboxGenre.TabIndex = 1;
            ComboboxGenre.SelectedIndexChanged += ComboboxGenre_SelectedIndexChanged;
            // 
            // ComboboxColor
            // 
            ComboboxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxColor.FormattingEnabled = true;
            ComboboxColor.Location = new Point(93, 143);
            ComboboxColor.Name = "ComboboxColor";
            ComboboxColor.Size = new Size(258, 23);
            ComboboxColor.TabIndex = 3;
            ComboboxColor.SelectedIndexChanged += ComboboxColor_SelectedIndexChanged;
            // 
            // ComboboxSport
            // 
            ComboboxSport.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxSport.FormattingEnabled = true;
            ComboboxSport.Location = new Point(93, 100);
            ComboboxSport.Name = "ComboboxSport";
            ComboboxSport.Size = new Size(258, 23);
            ComboboxSport.TabIndex = 2;
            ComboboxSport.SelectedIndexChanged += ComboboxSport_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmShoesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 365);
            Controls.Add(ComboboxColor);
            Controls.Add(ComboboxSport);
            Controls.Add(ComboboxGenre);
            Controls.Add(ComboboxBrand);
            Controls.Add(TexboxPrice);
            Controls.Add(label5);
            Controls.Add(TexboxDescripcion);
            Controls.Add(label6);
            Controls.Add(TexboxModel);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Controls.Add(label1);
            Name = "FrmShoesAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmShoesAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TexboxPrice;
        private Label label5;
        private TextBox TexboxDescripcion;
        private Label label6;
        private TextBox TexboxModel;
        private Label label7;
        private ComboBox ComboboxBrand;
        private ComboBox ComboboxGenre;
        private ComboBox ComboboxColor;
        private ComboBox ComboboxSport;
        private ErrorProvider errorProvider1;
    }
}