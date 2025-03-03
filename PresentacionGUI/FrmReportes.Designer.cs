﻿
namespace PresentacionGUI
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            Bunifu.Framework.UI.BunifuTextbox TxtIngresos;
            this.PnlReporte = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtGastos = new Bunifu.Framework.UI.BunifuTextbox();
            this.TxtGanancia = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.DtgGastosRegistrados = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpPersonalizadoHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpPersonalizadoDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbMensualAyo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbMensualMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DtpFechaDiario = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChbPersonalidado = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChbMensual = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChbDiario = new Bunifu.Framework.UI.BunifuCheckbox();
            this.DtgIngresosRegistrados = new System.Windows.Forms.DataGridView();
            this.nn = new Bunifu.Framework.UI.BunifuCustomLabel();
            TxtIngresos = new Bunifu.Framework.UI.BunifuTextbox();
            this.PnlReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgGastosRegistrados)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgIngresosRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlReporte
            // 
            this.PnlReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlReporte.BackgroundImage")));
            this.PnlReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlReporte.Controls.Add(this.label10);
            this.PnlReporte.Controls.Add(this.label9);
            this.PnlReporte.Controls.Add(this.label8);
            this.PnlReporte.Controls.Add(this.TxtGastos);
            this.PnlReporte.Controls.Add(this.TxtGanancia);
            this.PnlReporte.Controls.Add(TxtIngresos);
            this.PnlReporte.Controls.Add(this.bunifuCustomLabel1);
            this.PnlReporte.Controls.Add(this.bunifuSeparator3);
            this.PnlReporte.Controls.Add(this.DtgGastosRegistrados);
            this.PnlReporte.Controls.Add(this.bunifuCustomLabel7);
            this.PnlReporte.Controls.Add(this.bunifuSeparator1);
            this.PnlReporte.Controls.Add(this.bunifuSeparator2);
            this.PnlReporte.Controls.Add(this.bunifuGradientPanel1);
            this.PnlReporte.Controls.Add(this.DtgIngresosRegistrados);
            this.PnlReporte.Controls.Add(this.nn);
            this.PnlReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlReporte.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.PnlReporte.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.PnlReporte.GradientTopLeft = System.Drawing.Color.Maroon;
            this.PnlReporte.GradientTopRight = System.Drawing.Color.MistyRose;
            this.PnlReporte.Location = new System.Drawing.Point(0, 0);
            this.PnlReporte.Name = "PnlReporte";
            this.PnlReporte.Quality = 10;
            this.PnlReporte.Size = new System.Drawing.Size(1300, 700);
            this.PnlReporte.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 597);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 22);
            this.label10.TabIndex = 56;
            this.label10.Text = "Ganancias totales ";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(64, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 22);
            this.label9.TabIndex = 55;
            this.label9.Text = "Gastos totales ";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(59, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 22);
            this.label8.TabIndex = 54;
            this.label8.Text = "Igresos totales ";
            // 
            // TxtGastos
            // 
            this.TxtGastos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtGastos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtGastos.BackgroundImage")));
            this.TxtGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtGastos.ForeColor = System.Drawing.Color.Black;
            this.TxtGastos.Icon = ((System.Drawing.Image)(resources.GetObject("TxtGastos.Icon")));
            this.TxtGastos.Location = new System.Drawing.Point(229, 553);
            this.TxtGastos.Name = "TxtGastos";
            this.TxtGastos.Size = new System.Drawing.Size(200, 26);
            this.TxtGastos.TabIndex = 53;
            this.TxtGastos.text = "";
            // 
            // TxtGanancia
            // 
            this.TxtGanancia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtGanancia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtGanancia.BackgroundImage")));
            this.TxtGanancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtGanancia.ForeColor = System.Drawing.Color.Black;
            this.TxtGanancia.Icon = ((System.Drawing.Image)(resources.GetObject("TxtGanancia.Icon")));
            this.TxtGanancia.Location = new System.Drawing.Point(229, 593);
            this.TxtGanancia.Name = "TxtGanancia";
            this.TxtGanancia.Size = new System.Drawing.Size(200, 26);
            this.TxtGanancia.TabIndex = 52;
            this.TxtGanancia.text = "";
            // 
            // TxtIngresos
            // 
            TxtIngresos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            TxtIngresos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtIngresos.BackgroundImage")));
            TxtIngresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            TxtIngresos.ForeColor = System.Drawing.Color.Black;
            TxtIngresos.Icon = ((System.Drawing.Image)(resources.GetObject("TxtIngresos.Icon")));
            TxtIngresos.Location = new System.Drawing.Point(229, 513);
            TxtIngresos.Name = "TxtIngresos";
            TxtIngresos.Size = new System.Drawing.Size(200, 26);
            TxtIngresos.TabIndex = 51;
            TxtIngresos.text = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AccessibleName = "";
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(745, 140);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 24);
            this.bunifuCustomLabel1.TabIndex = 50;
            this.bunifuCustomLabel1.Text = "GASTOS";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(683, 163);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(214, 10);
            this.bunifuSeparator3.TabIndex = 49;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // DtgGastosRegistrados
            // 
            this.DtgGastosRegistrados.BackgroundColor = System.Drawing.Color.White;
            this.DtgGastosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgGastosRegistrados.Location = new System.Drawing.Point(549, 176);
            this.DtgGastosRegistrados.Name = "DtgGastosRegistrados";
            this.DtgGastosRegistrados.Size = new System.Drawing.Size(497, 297);
            this.DtgGastosRegistrados.TabIndex = 48;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AccessibleName = "";
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(222, 134);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(116, 24);
            this.bunifuCustomLabel7.TabIndex = 47;
            this.bunifuCustomLabel7.Text = "INGRESOS";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(167, 161);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(214, 10);
            this.bunifuSeparator1.TabIndex = 46;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(372, 76);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(333, 10);
            this.bunifuSeparator2.TabIndex = 45;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.DtpPersonalizadoHasta);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.DtpPersonalizadoDesde);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.CmbMensualAyo);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.CmbMensualMes);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.DtpFechaDiario);
            this.bunifuGradientPanel1.Controls.Add(this.BtnGuardar);
            this.bunifuGradientPanel1.Controls.Add(this.ChbPersonalidado);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.ChbMensual);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.ChbDiario);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkSlateGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1062, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(238, 700);
            this.bunifuGradientPanel1.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Hasta";
            // 
            // DtpPersonalizadoHasta
            // 
            this.DtpPersonalizadoHasta.BackColor = System.Drawing.Color.Transparent;
            this.DtpPersonalizadoHasta.BorderRadius = 0;
            this.DtpPersonalizadoHasta.ForeColor = System.Drawing.Color.White;
            this.DtpPersonalizadoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtpPersonalizadoHasta.FormatCustom = null;
            this.DtpPersonalizadoHasta.Location = new System.Drawing.Point(16, 553);
            this.DtpPersonalizadoHasta.Name = "DtpPersonalizadoHasta";
            this.DtpPersonalizadoHasta.Size = new System.Drawing.Size(199, 37);
            this.DtpPersonalizadoHasta.TabIndex = 43;
            this.DtpPersonalizadoHasta.Value = new System.DateTime(2021, 4, 23, 23, 33, 21, 664);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Desde";
            // 
            // DtpPersonalizadoDesde
            // 
            this.DtpPersonalizadoDesde.BackColor = System.Drawing.Color.Transparent;
            this.DtpPersonalizadoDesde.BorderRadius = 0;
            this.DtpPersonalizadoDesde.ForeColor = System.Drawing.Color.White;
            this.DtpPersonalizadoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtpPersonalizadoDesde.FormatCustom = null;
            this.DtpPersonalizadoDesde.Location = new System.Drawing.Point(16, 495);
            this.DtpPersonalizadoDesde.Name = "DtpPersonalizadoDesde";
            this.DtpPersonalizadoDesde.Size = new System.Drawing.Size(199, 34);
            this.DtpPersonalizadoDesde.TabIndex = 41;
            this.DtpPersonalizadoDesde.Value = new System.DateTime(2021, 4, 23, 23, 33, 21, 664);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(153, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Año";
            // 
            // CmbMensualAyo
            // 
            this.CmbMensualAyo.FormattingEnabled = true;
            this.CmbMensualAyo.Location = new System.Drawing.Point(131, 339);
            this.CmbMensualAyo.Name = "CmbMensualAyo";
            this.CmbMensualAyo.Size = new System.Drawing.Size(95, 21);
            this.CmbMensualAyo.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mes";
            // 
            // CmbMensualMes
            // 
            this.CmbMensualMes.FormattingEnabled = true;
            this.CmbMensualMes.Location = new System.Drawing.Point(14, 339);
            this.CmbMensualMes.Name = "CmbMensualMes";
            this.CmbMensualMes.Size = new System.Drawing.Size(95, 21);
            this.CmbMensualMes.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fecha";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(86, 437);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(105, 18);
            this.bunifuCustomLabel5.TabIndex = 35;
            this.bunifuCustomLabel5.Text = "Personalizado";
            // 
            // DtpFechaDiario
            // 
            this.DtpFechaDiario.BackColor = System.Drawing.Color.Transparent;
            this.DtpFechaDiario.BorderRadius = 0;
            this.DtpFechaDiario.ForeColor = System.Drawing.Color.White;
            this.DtpFechaDiario.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtpFechaDiario.FormatCustom = null;
            this.DtpFechaDiario.Location = new System.Drawing.Point(27, 176);
            this.DtpFechaDiario.Name = "DtpFechaDiario";
            this.DtpFechaDiario.Size = new System.Drawing.Size(199, 29);
            this.DtpFechaDiario.TabIndex = 30;
            this.DtpFechaDiario.Value = new System.DateTime(2021, 4, 23, 23, 33, 21, 664);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 0;
            this.BtnGuardar.ButtonText = "    CONSULTAR";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = global::PresentacionGUI.Properties.Resources.consulta;
            this.BtnGuardar.Iconimage_right = null;
            this.BtnGuardar.Iconimage_right_Selected = null;
            this.BtnGuardar.Iconimage_Selected = null;
            this.BtnGuardar.IconMarginLeft = 0;
            this.BtnGuardar.IconMarginRight = 0;
            this.BtnGuardar.IconRightVisible = true;
            this.BtnGuardar.IconRightZoom = 0D;
            this.BtnGuardar.IconVisible = true;
            this.BtnGuardar.IconZoom = 50D;
            this.BtnGuardar.IsTab = false;
            this.BtnGuardar.Location = new System.Drawing.Point(60, 631);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(120, 26);
            this.BtnGuardar.TabIndex = 25;
            this.BtnGuardar.Text = "    CONSULTAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Textcolor = System.Drawing.Color.White;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ChbPersonalidado
            // 
            this.ChbPersonalidado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbPersonalidado.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChbPersonalidado.Checked = true;
            this.ChbPersonalidado.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbPersonalidado.ForeColor = System.Drawing.Color.White;
            this.ChbPersonalidado.Location = new System.Drawing.Point(60, 437);
            this.ChbPersonalidado.Name = "ChbPersonalidado";
            this.ChbPersonalidado.Size = new System.Drawing.Size(20, 20);
            this.ChbPersonalidado.TabIndex = 31;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AccessibleName = "";
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(36, 25);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(179, 18);
            this.bunifuCustomLabel2.TabIndex = 34;
            this.bunifuCustomLabel2.Text = "TIPOS DE  REPORTES ";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChbMensual
            // 
            this.ChbMensual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbMensual.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChbMensual.Checked = true;
            this.ChbMensual.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbMensual.ForeColor = System.Drawing.Color.White;
            this.ChbMensual.Location = new System.Drawing.Point(80, 275);
            this.ChbMensual.Name = "ChbMensual";
            this.ChbMensual.Size = new System.Drawing.Size(20, 20);
            this.ChbMensual.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Diario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(106, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mensual";
            // 
            // ChbDiario
            // 
            this.ChbDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbDiario.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChbDiario.Checked = true;
            this.ChbDiario.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbDiario.ForeColor = System.Drawing.Color.White;
            this.ChbDiario.Location = new System.Drawing.Point(89, 121);
            this.ChbDiario.Name = "ChbDiario";
            this.ChbDiario.Size = new System.Drawing.Size(20, 20);
            this.ChbDiario.TabIndex = 28;
            // 
            // DtgIngresosRegistrados
            // 
            this.DtgIngresosRegistrados.BackgroundColor = System.Drawing.Color.White;
            this.DtgIngresosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgIngresosRegistrados.Location = new System.Drawing.Point(21, 176);
            this.DtgIngresosRegistrados.Name = "DtgIngresosRegistrados";
            this.DtgIngresosRegistrados.Size = new System.Drawing.Size(522, 297);
            this.DtgIngresosRegistrados.TabIndex = 1;
            // 
            // nn
            // 
            this.nn.AccessibleName = "";
            this.nn.BackColor = System.Drawing.Color.Transparent;
            this.nn.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nn.Location = new System.Drawing.Point(452, 35);
            this.nn.Name = "nn";
            this.nn.Size = new System.Drawing.Size(190, 38);
            this.nn.TabIndex = 0;
            this.nn.Text = "REPORTES";
            this.nn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PnlReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.PnlReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgGastosRegistrados)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgIngresosRegistrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PnlReporte;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDatepicker DtpFechaDiario;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuCheckbox ChbPersonalidado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCheckbox ChbMensual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox ChbDiario;
        private System.Windows.Forms.DataGridView DtgIngresosRegistrados;
        private Bunifu.Framework.UI.BunifuCustomLabel nn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.DataGridView DtgGastosRegistrados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbMensualAyo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbMensualMes;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox TxtGastos;
        private Bunifu.Framework.UI.BunifuTextbox TxtGanancia;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker DtpPersonalizadoHasta;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker DtpPersonalizadoDesde;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}