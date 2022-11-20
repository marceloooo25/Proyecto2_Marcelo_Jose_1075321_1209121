
using System;
using System.Windows.Forms;

namespace Proyecto
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_CargarArchivo = new System.Windows.Forms.Button();
            this.Lbl_NombreArchivo = new System.Windows.Forms.Label();
            this.Ofd_NombreArchivo = new System.Windows.Forms.OpenFileDialog();
            this.Dgv_Tablero = new System.Windows.Forms.DataGridView();
            this.Img_Tablero = new System.Windows.Forms.ImageList(this.components);
            this.Tmr_Robot = new System.Windows.Forms.Timer(this.components);
            this.Btn_IngresoMaterial = new System.Windows.Forms.Button();
            this.Btn_SalidaMaterial = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Dgv_Maximos = new System.Windows.Forms.DataGridView();
            this.Dgv_Existencias = new System.Windows.Forms.DataGridView();
            this.Dgv_Disponibles = new System.Windows.Forms.DataGridView();
            this.Lbl_Maximos = new System.Windows.Forms.Label();
            this.Lbl_Existencias = new System.Windows.Forms.Label();
            this.LbL_Disponibilidad = new System.Windows.Forms.Label();
            this.Dgv_Salidas = new System.Windows.Forms.DataGridView();
            this.Lbl_Salidas = new System.Windows.Forms.Label();
            this.Dgv_Ingresos = new System.Windows.Forms.DataGridView();
            this.Lbl_Ingresos = new System.Windows.Forms.Label();
            this.Dgv_RobotBloques = new System.Windows.Forms.DataGridView();
            this.RobotVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_RobotIngresos = new System.Windows.Forms.DataGridView();
            this.RVA_Ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAC_Ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REE_Ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_RobotSalidas = new System.Windows.Forms.DataGridView();
            this.RVA_Salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAC_Salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REE_Salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_RobotIngresos = new System.Windows.Forms.Label();
            this.Lbl_RobotSalidas = new System.Windows.Forms.Label();
            this.Lbl_RobotBloques = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tablero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Maximos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Existencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Salidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RobotBloques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RobotIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RobotSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_CargarArchivo
            // 
            this.Btn_CargarArchivo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_CargarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CargarArchivo.Location = new System.Drawing.Point(138, 13);
            this.Btn_CargarArchivo.Name = "Btn_CargarArchivo";
            this.Btn_CargarArchivo.Size = new System.Drawing.Size(130, 28);
            this.Btn_CargarArchivo.TabIndex = 0;
            this.Btn_CargarArchivo.Text = "Cargar Archivo";
            this.Btn_CargarArchivo.UseVisualStyleBackColor = false;
            this.Btn_CargarArchivo.Click += new System.EventHandler(this.BtnCargarArchivo_Click);
            // 
            // Lbl_NombreArchivo
            // 
            this.Lbl_NombreArchivo.AutoSize = true;
            this.Lbl_NombreArchivo.Location = new System.Drawing.Point(283, 23);
            this.Lbl_NombreArchivo.Name = "Lbl_NombreArchivo";
            this.Lbl_NombreArchivo.Size = new System.Drawing.Size(83, 13);
            this.Lbl_NombreArchivo.TabIndex = 1;
            this.Lbl_NombreArchivo.Text = "Nombre Archivo";
            // 
            // Dgv_Tablero
            // 
            this.Dgv_Tablero.AllowUserToAddRows = false;
            this.Dgv_Tablero.AllowUserToDeleteRows = false;
            this.Dgv_Tablero.AllowUserToResizeColumns = false;
            this.Dgv_Tablero.AllowUserToResizeRows = false;
            this.Dgv_Tablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Tablero.ColumnHeadersVisible = false;
            this.Dgv_Tablero.Location = new System.Drawing.Point(138, 52);
            this.Dgv_Tablero.Name = "Dgv_Tablero";
            this.Dgv_Tablero.ReadOnly = true;
            this.Dgv_Tablero.RowHeadersVisible = false;
            this.Dgv_Tablero.RowHeadersWidth = 4;
            this.Dgv_Tablero.RowTemplate.Height = 100;
            this.Dgv_Tablero.Size = new System.Drawing.Size(503, 603);
            this.Dgv_Tablero.TabIndex = 2;
            // 
            // Img_Tablero
            // 
            this.Img_Tablero.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_Tablero.ImageStream")));
            this.Img_Tablero.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_Tablero.Images.SetKeyName(0, "Frio.jpeg");
            this.Img_Tablero.Images.SetKeyName(1, "Fragil.jpeg");
            this.Img_Tablero.Images.SetKeyName(2, "Normal.jpeg");
            this.Img_Tablero.Images.SetKeyName(3, "Robot VA.jpeg");
            this.Img_Tablero.Images.SetKeyName(4, "Robot AC.jpeg");
            this.Img_Tablero.Images.SetKeyName(5, "Robot EE.jpeg");
            this.Img_Tablero.Images.SetKeyName(6, "Pasillo.jpeg");
            this.Img_Tablero.Images.SetKeyName(7, "Entrada-Salida.jpeg");
            // 
            // Tmr_Robot
            // 
            this.Tmr_Robot.Interval = 2;
            this.Tmr_Robot.Tick += new System.EventHandler(this.TRobot_Tick);
            // 
            // Btn_IngresoMaterial
            // 
            this.Btn_IngresoMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_IngresoMaterial.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_IngresoMaterial.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IngresoMaterial.Location = new System.Drawing.Point(14, 52);
            this.Btn_IngresoMaterial.Name = "Btn_IngresoMaterial";
            this.Btn_IngresoMaterial.Size = new System.Drawing.Size(105, 56);
            this.Btn_IngresoMaterial.TabIndex = 3;
            this.Btn_IngresoMaterial.Text = "Ingreso de Materiales";
            this.Btn_IngresoMaterial.UseVisualStyleBackColor = false;
            this.Btn_IngresoMaterial.Click += new System.EventHandler(this.Btn_IngresoMaterial_Click);
            // 
            // Btn_SalidaMaterial
            // 
            this.Btn_SalidaMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_SalidaMaterial.BackColor = System.Drawing.Color.Khaki;
            this.Btn_SalidaMaterial.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalidaMaterial.Location = new System.Drawing.Point(14, 142);
            this.Btn_SalidaMaterial.Name = "Btn_SalidaMaterial";
            this.Btn_SalidaMaterial.Size = new System.Drawing.Size(105, 56);
            this.Btn_SalidaMaterial.TabIndex = 4;
            this.Btn_SalidaMaterial.Text = "Salida de Materiales";
            this.Btn_SalidaMaterial.UseVisualStyleBackColor = false;
            this.Btn_SalidaMaterial.Click += new System.EventHandler(this.Btn_SalidaMaterial_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(14, 599);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(105, 56);
            this.Btn_Cerrar.TabIndex = 5;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Dgv_Maximos
            // 
            this.Dgv_Maximos.AllowUserToAddRows = false;
            this.Dgv_Maximos.AllowUserToDeleteRows = false;
            this.Dgv_Maximos.AllowUserToResizeColumns = false;
            this.Dgv_Maximos.AllowUserToResizeRows = false;
            this.Dgv_Maximos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Maximos.ColumnHeadersVisible = false;
            this.Dgv_Maximos.Location = new System.Drawing.Point(661, 52);
            this.Dgv_Maximos.MultiSelect = false;
            this.Dgv_Maximos.Name = "Dgv_Maximos";
            this.Dgv_Maximos.ReadOnly = true;
            this.Dgv_Maximos.RowHeadersVisible = false;
            this.Dgv_Maximos.RowHeadersWidth = 4;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_Maximos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Maximos.RowTemplate.Height = 100;
            this.Dgv_Maximos.Size = new System.Drawing.Size(180, 215);
            this.Dgv_Maximos.TabIndex = 7;
            // 
            // Dgv_Existencias
            // 
            this.Dgv_Existencias.AllowUserToAddRows = false;
            this.Dgv_Existencias.AllowUserToDeleteRows = false;
            this.Dgv_Existencias.AllowUserToResizeColumns = false;
            this.Dgv_Existencias.AllowUserToResizeRows = false;
            this.Dgv_Existencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Existencias.ColumnHeadersVisible = false;
            this.Dgv_Existencias.Location = new System.Drawing.Point(859, 52);
            this.Dgv_Existencias.Name = "Dgv_Existencias";
            this.Dgv_Existencias.ReadOnly = true;
            this.Dgv_Existencias.RowHeadersVisible = false;
            this.Dgv_Existencias.RowHeadersWidth = 4;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_Existencias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Existencias.RowTemplate.Height = 100;
            this.Dgv_Existencias.Size = new System.Drawing.Size(180, 215);
            this.Dgv_Existencias.TabIndex = 8;
            // 
            // Dgv_Disponibles
            // 
            this.Dgv_Disponibles.AllowUserToAddRows = false;
            this.Dgv_Disponibles.AllowUserToDeleteRows = false;
            this.Dgv_Disponibles.AllowUserToResizeColumns = false;
            this.Dgv_Disponibles.AllowUserToResizeRows = false;
            this.Dgv_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Disponibles.ColumnHeadersVisible = false;
            this.Dgv_Disponibles.Location = new System.Drawing.Point(1054, 52);
            this.Dgv_Disponibles.Name = "Dgv_Disponibles";
            this.Dgv_Disponibles.ReadOnly = true;
            this.Dgv_Disponibles.RowHeadersVisible = false;
            this.Dgv_Disponibles.RowHeadersWidth = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_Disponibles.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Disponibles.RowTemplate.Height = 100;
            this.Dgv_Disponibles.Size = new System.Drawing.Size(180, 215);
            this.Dgv_Disponibles.TabIndex = 9;
            // 
            // Lbl_Maximos
            // 
            this.Lbl_Maximos.AutoSize = true;
            this.Lbl_Maximos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Maximos.Location = new System.Drawing.Point(658, 34);
            this.Lbl_Maximos.Name = "Lbl_Maximos";
            this.Lbl_Maximos.Size = new System.Drawing.Size(77, 16);
            this.Lbl_Maximos.TabIndex = 10;
            this.Lbl_Maximos.Text = "Maximos.:";
            // 
            // Lbl_Existencias
            // 
            this.Lbl_Existencias.AutoSize = true;
            this.Lbl_Existencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Existencias.Location = new System.Drawing.Point(856, 34);
            this.Lbl_Existencias.Name = "Lbl_Existencias";
            this.Lbl_Existencias.Size = new System.Drawing.Size(95, 16);
            this.Lbl_Existencias.TabIndex = 11;
            this.Lbl_Existencias.Text = "Existencias.:";
            // 
            // LbL_Disponibilidad
            // 
            this.LbL_Disponibilidad.AutoSize = true;
            this.LbL_Disponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_Disponibilidad.Location = new System.Drawing.Point(1051, 34);
            this.LbL_Disponibilidad.Name = "LbL_Disponibilidad";
            this.LbL_Disponibilidad.Size = new System.Drawing.Size(117, 16);
            this.LbL_Disponibilidad.TabIndex = 12;
            this.LbL_Disponibilidad.Text = "Disponibilidad.:";
            // 
            // Dgv_Salidas
            // 
            this.Dgv_Salidas.AllowUserToAddRows = false;
            this.Dgv_Salidas.AllowUserToDeleteRows = false;
            this.Dgv_Salidas.AllowUserToResizeColumns = false;
            this.Dgv_Salidas.AllowUserToResizeRows = false;
            this.Dgv_Salidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Salidas.ColumnHeadersVisible = false;
            this.Dgv_Salidas.Location = new System.Drawing.Point(859, 290);
            this.Dgv_Salidas.Name = "Dgv_Salidas";
            this.Dgv_Salidas.ReadOnly = true;
            this.Dgv_Salidas.RowHeadersVisible = false;
            this.Dgv_Salidas.RowHeadersWidth = 4;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_Salidas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Salidas.RowTemplate.Height = 100;
            this.Dgv_Salidas.Size = new System.Drawing.Size(180, 215);
            this.Dgv_Salidas.TabIndex = 13;
            // 
            // Lbl_Salidas
            // 
            this.Lbl_Salidas.AutoSize = true;
            this.Lbl_Salidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Salidas.Location = new System.Drawing.Point(856, 271);
            this.Lbl_Salidas.Name = "Lbl_Salidas";
            this.Lbl_Salidas.Size = new System.Drawing.Size(61, 16);
            this.Lbl_Salidas.TabIndex = 14;
            this.Lbl_Salidas.Text = "Salidas";
            // 
            // Dgv_Ingresos
            // 
            this.Dgv_Ingresos.AllowUserToAddRows = false;
            this.Dgv_Ingresos.AllowUserToDeleteRows = false;
            this.Dgv_Ingresos.AllowUserToResizeColumns = false;
            this.Dgv_Ingresos.AllowUserToResizeRows = false;
            this.Dgv_Ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Ingresos.ColumnHeadersVisible = false;
            this.Dgv_Ingresos.Location = new System.Drawing.Point(661, 290);
            this.Dgv_Ingresos.Name = "Dgv_Ingresos";
            this.Dgv_Ingresos.ReadOnly = true;
            this.Dgv_Ingresos.RowHeadersVisible = false;
            this.Dgv_Ingresos.RowHeadersWidth = 4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_Ingresos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Ingresos.RowTemplate.Height = 100;
            this.Dgv_Ingresos.Size = new System.Drawing.Size(180, 215);
            this.Dgv_Ingresos.TabIndex = 15;
            // 
            // Lbl_Ingresos
            // 
            this.Lbl_Ingresos.AutoSize = true;
            this.Lbl_Ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ingresos.Location = new System.Drawing.Point(658, 271);
            this.Lbl_Ingresos.Name = "Lbl_Ingresos";
            this.Lbl_Ingresos.Size = new System.Drawing.Size(76, 16);
            this.Lbl_Ingresos.TabIndex = 16;
            this.Lbl_Ingresos.Text = "Ingresos.:";
            // 
            // Dgv_RobotBloques
            // 
            this.Dgv_RobotBloques.AllowUserToDeleteRows = false;
            this.Dgv_RobotBloques.AllowUserToResizeColumns = false;
            this.Dgv_RobotBloques.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_RobotBloques.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_RobotBloques.ColumnHeadersHeight = 34;
            this.Dgv_RobotBloques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_RobotBloques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RobotVA,
            this.RobotAC,
            this.RobotEE});
            this.Dgv_RobotBloques.Location = new System.Drawing.Point(1054, 484);
            this.Dgv_RobotBloques.MultiSelect = false;
            this.Dgv_RobotBloques.Name = "Dgv_RobotBloques";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_RobotBloques.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Dgv_RobotBloques.RowHeadersVisible = false;
            this.Dgv_RobotBloques.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_RobotBloques.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Dgv_RobotBloques.ShowCellErrors = false;
            this.Dgv_RobotBloques.ShowCellToolTips = false;
            this.Dgv_RobotBloques.ShowEditingIcon = false;
            this.Dgv_RobotBloques.ShowRowErrors = false;
            this.Dgv_RobotBloques.Size = new System.Drawing.Size(180, 59);
            this.Dgv_RobotBloques.TabIndex = 19;
            // 
            // RobotVA
            // 
            this.RobotVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RobotVA.DefaultCellStyle = dataGridViewCellStyle7;
            this.RobotVA.Frozen = true;
            this.RobotVA.HeaderText = "Alta Velocidad";
            this.RobotVA.Name = "RobotVA";
            this.RobotVA.ReadOnly = true;
            this.RobotVA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RobotVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RobotVA.Width = 60;
            // 
            // RobotAC
            // 
            this.RobotAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RobotAC.DefaultCellStyle = dataGridViewCellStyle8;
            this.RobotAC.Frozen = true;
            this.RobotAC.HeaderText = "Alta Capacidad";
            this.RobotAC.Name = "RobotAC";
            this.RobotAC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RobotAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RobotAC.Width = 60;
            // 
            // RobotEE
            // 
            this.RobotEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RobotEE.DefaultCellStyle = dataGridViewCellStyle9;
            this.RobotEE.Frozen = true;
            this.RobotEE.HeaderText = "Robot Estandar";
            this.RobotEE.Name = "RobotEE";
            this.RobotEE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RobotEE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RobotEE.Width = 60;
            // 
            // Dgv_RobotIngresos
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_RobotIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_RobotIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RobotIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RVA_Ingresos,
            this.RAC_Ingresos,
            this.REE_Ingresos});
            this.Dgv_RobotIngresos.Location = new System.Drawing.Point(1054, 309);
            this.Dgv_RobotIngresos.Name = "Dgv_RobotIngresos";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_RobotIngresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Dgv_RobotIngresos.RowHeadersVisible = false;
            this.Dgv_RobotIngresos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_RobotIngresos.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.Dgv_RobotIngresos.Size = new System.Drawing.Size(180, 58);
            this.Dgv_RobotIngresos.TabIndex = 18;
            // 
            // RVA_Ingresos
            // 
            this.RVA_Ingresos.Frozen = true;
            this.RVA_Ingresos.HeaderText = "Alta Velocidad";
            this.RVA_Ingresos.Name = "RVA_Ingresos";
            this.RVA_Ingresos.ReadOnly = true;
            this.RVA_Ingresos.Width = 60;
            // 
            // RAC_Ingresos
            // 
            this.RAC_Ingresos.Frozen = true;
            this.RAC_Ingresos.HeaderText = "Alta Capacidad";
            this.RAC_Ingresos.Name = "RAC_Ingresos";
            this.RAC_Ingresos.ReadOnly = true;
            this.RAC_Ingresos.Width = 60;
            // 
            // REE_Ingresos
            // 
            this.REE_Ingresos.Frozen = true;
            this.REE_Ingresos.HeaderText = "Normal Estandar";
            this.REE_Ingresos.Name = "REE_Ingresos";
            this.REE_Ingresos.ReadOnly = true;
            this.REE_Ingresos.Width = 60;
            // 
            // Dgv_RobotSalidas
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_RobotSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.Dgv_RobotSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_RobotSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RVA_Salidas,
            this.RAC_Salidas,
            this.REE_Salidas});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_RobotSalidas.DefaultCellStyle = dataGridViewCellStyle19;
            this.Dgv_RobotSalidas.Location = new System.Drawing.Point(1054, 401);
            this.Dgv_RobotSalidas.Name = "Dgv_RobotSalidas";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_RobotSalidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.Dgv_RobotSalidas.RowHeadersVisible = false;
            this.Dgv_RobotSalidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_RobotSalidas.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.Dgv_RobotSalidas.Size = new System.Drawing.Size(180, 45);
            this.Dgv_RobotSalidas.TabIndex = 17;
            // 
            // RVA_Salidas
            // 
            this.RVA_Salidas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RVA_Salidas.DefaultCellStyle = dataGridViewCellStyle16;
            this.RVA_Salidas.Frozen = true;
            this.RVA_Salidas.HeaderText = "Alta Velocidad";
            this.RVA_Salidas.Name = "RVA_Salidas";
            this.RVA_Salidas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RVA_Salidas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RVA_Salidas.Width = 60;
            // 
            // RAC_Salidas
            // 
            this.RAC_Salidas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RAC_Salidas.DefaultCellStyle = dataGridViewCellStyle17;
            this.RAC_Salidas.Frozen = true;
            this.RAC_Salidas.HeaderText = "Alta Capacidad";
            this.RAC_Salidas.Name = "RAC_Salidas";
            this.RAC_Salidas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RAC_Salidas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RAC_Salidas.Width = 60;
            // 
            // REE_Salidas
            // 
            this.REE_Salidas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.REE_Salidas.DefaultCellStyle = dataGridViewCellStyle18;
            this.REE_Salidas.Frozen = true;
            this.REE_Salidas.HeaderText = "Normal Estandar";
            this.REE_Salidas.Name = "REE_Salidas";
            this.REE_Salidas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.REE_Salidas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.REE_Salidas.Width = 60;
            // 
            // Lbl_RobotIngresos
            // 
            this.Lbl_RobotIngresos.AutoSize = true;
            this.Lbl_RobotIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RobotIngresos.Location = new System.Drawing.Point(1051, 290);
            this.Lbl_RobotIngresos.Name = "Lbl_RobotIngresos";
            this.Lbl_RobotIngresos.Size = new System.Drawing.Size(122, 16);
            this.Lbl_RobotIngresos.TabIndex = 20;
            this.Lbl_RobotIngresos.Text = "Robot Ingresos.:";
            // 
            // Lbl_RobotSalidas
            // 
            this.Lbl_RobotSalidas.AutoSize = true;
            this.Lbl_RobotSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RobotSalidas.Location = new System.Drawing.Point(1051, 382);
            this.Lbl_RobotSalidas.Name = "Lbl_RobotSalidas";
            this.Lbl_RobotSalidas.Size = new System.Drawing.Size(115, 16);
            this.Lbl_RobotSalidas.TabIndex = 21;
            this.Lbl_RobotSalidas.Text = "Robot Salidas.:";
            // 
            // Lbl_RobotBloques
            // 
            this.Lbl_RobotBloques.AutoSize = true;
            this.Lbl_RobotBloques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RobotBloques.Location = new System.Drawing.Point(1051, 465);
            this.Lbl_RobotBloques.Name = "Lbl_RobotBloques";
            this.Lbl_RobotBloques.Size = new System.Drawing.Size(119, 16);
            this.Lbl_RobotBloques.TabIndex = 22;
            this.Lbl_RobotBloques.Text = "Robot Bloques.:";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.Btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(1272, 670);
            this.Controls.Add(this.Lbl_RobotBloques);
            this.Controls.Add(this.Lbl_RobotSalidas);
            this.Controls.Add(this.Lbl_RobotIngresos);
            this.Controls.Add(this.Dgv_RobotBloques);
            this.Controls.Add(this.Dgv_RobotIngresos);
            this.Controls.Add(this.Dgv_RobotSalidas);
            this.Controls.Add(this.Lbl_Ingresos);
            this.Controls.Add(this.Dgv_Ingresos);
            this.Controls.Add(this.Lbl_Salidas);
            this.Controls.Add(this.Dgv_Salidas);
            this.Controls.Add(this.LbL_Disponibilidad);
            this.Controls.Add(this.Lbl_Existencias);
            this.Controls.Add(this.Lbl_Maximos);
            this.Controls.Add(this.Dgv_Disponibles);
            this.Controls.Add(this.Dgv_Existencias);
            this.Controls.Add(this.Dgv_Maximos);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_SalidaMaterial);
            this.Controls.Add(this.Btn_IngresoMaterial);
            this.Controls.Add(this.Dgv_Tablero);
            this.Controls.Add(this.Lbl_NombreArchivo);
            this.Controls.Add(this.Btn_CargarArchivo);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Bodegas - Skynet WareHouse";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tablero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Maximos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Existencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Salidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RobotBloques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RobotIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RobotSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvTablero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button Btn_CargarArchivo;
        private System.Windows.Forms.Label Lbl_NombreArchivo;
        private System.Windows.Forms.OpenFileDialog Ofd_NombreArchivo;
        private System.Windows.Forms.DataGridView Dgv_Tablero;
        private System.Windows.Forms.ImageList Img_Tablero;
        private System.Windows.Forms.Timer Tmr_Robot;
        private Button Btn_IngresoMaterial;
        private Button Btn_SalidaMaterial;
        private Button Btn_Cerrar;
        private DataGridView Dgv_Maximos;
        private DataGridView Dgv_Existencias;
        private DataGridView Dgv_Disponibles;
        private Label Lbl_Maximos;
        private Label Lbl_Existencias;
        private Label LbL_Disponibilidad;
        private DataGridView Dgv_Salidas;
        private Label Lbl_Salidas;
        private DataGridView Dgv_Ingresos;
        private Label Lbl_Ingresos;
        private DataGridView Dgv_RobotBloques;
        private DataGridViewTextBoxColumn RobotVA;
        private DataGridViewTextBoxColumn RobotAC;
        private DataGridViewTextBoxColumn RobotEE;
        private DataGridView Dgv_RobotIngresos;
        private DataGridView Dgv_RobotSalidas;
        private Label Lbl_RobotIngresos;
        private Label Lbl_RobotSalidas;
        private Label Lbl_RobotBloques;
        private DataGridViewTextBoxColumn RVA_Ingresos;
        private DataGridViewTextBoxColumn RAC_Ingresos;
        private DataGridViewTextBoxColumn REE_Ingresos;
        private DataGridViewTextBoxColumn RVA_Salidas;
        private DataGridViewTextBoxColumn RAC_Salidas;
        private DataGridViewTextBoxColumn REE_Salidas;
    }
}

