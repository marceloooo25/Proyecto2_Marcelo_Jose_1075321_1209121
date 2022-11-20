
namespace Proyecto
{
    partial class Frm_SalidaMaterial
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
            this.Rdb_TipoManual = new System.Windows.Forms.RadioButton();
            this.Rdb_TipoAutomatico = new System.Windows.Forms.RadioButton();
            this.Pnl_EnvioDatos = new System.Windows.Forms.Panel();
            this.Txt_ColumnaEstanteria = new System.Windows.Forms.TextBox();
            this.Lbl_ColumnaEstanteria = new System.Windows.Forms.Label();
            this.Txt_FilaEstanteria = new System.Windows.Forms.TextBox();
            this.Lbl_FilaEstanteria = new System.Windows.Forms.Label();
            this.Txt_UnidadMaterial = new System.Windows.Forms.TextBox();
            this.Lbl_UnidadMaterial = new System.Windows.Forms.Label();
            this.Cmb_TipoMaterial = new System.Windows.Forms.ComboBox();
            this.Lbl_TipoMaterial = new System.Windows.Forms.Label();
            this.Cmb_TipoRobot = new System.Windows.Forms.ComboBox();
            this.Lbl_TipoRobot = new System.Windows.Forms.Label();
            this.Gpb_TipoEnvio = new System.Windows.Forms.GroupBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Pnl_EnvioDatos.SuspendLayout();
            this.Gpb_TipoEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rdb_TipoManual
            // 
            this.Rdb_TipoManual.AutoSize = true;
            this.Rdb_TipoManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_TipoManual.Location = new System.Drawing.Point(33, 27);
            this.Rdb_TipoManual.Name = "Rdb_TipoManual";
            this.Rdb_TipoManual.Size = new System.Drawing.Size(76, 20);
            this.Rdb_TipoManual.TabIndex = 0;
            this.Rdb_TipoManual.Text = "Manual";
            this.Rdb_TipoManual.UseVisualStyleBackColor = true;
            this.Rdb_TipoManual.CheckedChanged += new System.EventHandler(this.Rdb_TipoManual_CheckedChanged_1);
            // 
            // Rdb_TipoAutomatico
            // 
            this.Rdb_TipoAutomatico.AutoSize = true;
            this.Rdb_TipoAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_TipoAutomatico.Location = new System.Drawing.Point(171, 27);
            this.Rdb_TipoAutomatico.Name = "Rdb_TipoAutomatico";
            this.Rdb_TipoAutomatico.Size = new System.Drawing.Size(103, 20);
            this.Rdb_TipoAutomatico.TabIndex = 1;
            this.Rdb_TipoAutomatico.Text = "Automático";
            this.Rdb_TipoAutomatico.UseVisualStyleBackColor = true;
            this.Rdb_TipoAutomatico.CheckedChanged += new System.EventHandler(this.Rdb_TipoAutomatico_CheckedChanged_1);
            // 
            // Pnl_EnvioDatos
            // 
            this.Pnl_EnvioDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_EnvioDatos.Controls.Add(this.Txt_ColumnaEstanteria);
            this.Pnl_EnvioDatos.Controls.Add(this.Lbl_ColumnaEstanteria);
            this.Pnl_EnvioDatos.Controls.Add(this.Txt_FilaEstanteria);
            this.Pnl_EnvioDatos.Controls.Add(this.Lbl_FilaEstanteria);
            this.Pnl_EnvioDatos.Controls.Add(this.Txt_UnidadMaterial);
            this.Pnl_EnvioDatos.Controls.Add(this.Lbl_UnidadMaterial);
            this.Pnl_EnvioDatos.Controls.Add(this.Cmb_TipoMaterial);
            this.Pnl_EnvioDatos.Controls.Add(this.Lbl_TipoMaterial);
            this.Pnl_EnvioDatos.Controls.Add(this.Cmb_TipoRobot);
            this.Pnl_EnvioDatos.Controls.Add(this.Lbl_TipoRobot);
            this.Pnl_EnvioDatos.Location = new System.Drawing.Point(44, 85);
            this.Pnl_EnvioDatos.Name = "Pnl_EnvioDatos";
            this.Pnl_EnvioDatos.Size = new System.Drawing.Size(302, 192);
            this.Pnl_EnvioDatos.TabIndex = 4;
            // 
            // Txt_ColumnaEstanteria
            // 
            this.Txt_ColumnaEstanteria.Location = new System.Drawing.Point(153, 150);
            this.Txt_ColumnaEstanteria.Name = "Txt_ColumnaEstanteria";
            this.Txt_ColumnaEstanteria.Size = new System.Drawing.Size(109, 20);
            this.Txt_ColumnaEstanteria.TabIndex = 9;
            this.Txt_ColumnaEstanteria.Text = "0";
            this.Txt_ColumnaEstanteria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_ColumnaEstanteria.Visible = false;
            this.Txt_ColumnaEstanteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ColumnaEstanteria_KeyPress_1);
            // 
            // Lbl_ColumnaEstanteria
            // 
            this.Lbl_ColumnaEstanteria.AutoSize = true;
            this.Lbl_ColumnaEstanteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ColumnaEstanteria.Location = new System.Drawing.Point(20, 151);
            this.Lbl_ColumnaEstanteria.Name = "Lbl_ColumnaEstanteria";
            this.Lbl_ColumnaEstanteria.Size = new System.Drawing.Size(130, 16);
            this.Lbl_ColumnaEstanteria.TabIndex = 8;
            this.Lbl_ColumnaEstanteria.Text = "Columna Estantería.:";
            this.Lbl_ColumnaEstanteria.Visible = false;
            // 
            // Txt_FilaEstanteria
            // 
            this.Txt_FilaEstanteria.Location = new System.Drawing.Point(153, 120);
            this.Txt_FilaEstanteria.Name = "Txt_FilaEstanteria";
            this.Txt_FilaEstanteria.Size = new System.Drawing.Size(109, 20);
            this.Txt_FilaEstanteria.TabIndex = 7;
            this.Txt_FilaEstanteria.Text = "0";
            this.Txt_FilaEstanteria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_FilaEstanteria.Visible = false;
            this.Txt_FilaEstanteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FilaEstanteria_KeyPress_1);
            // 
            // Lbl_FilaEstanteria
            // 
            this.Lbl_FilaEstanteria.AutoSize = true;
            this.Lbl_FilaEstanteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FilaEstanteria.Location = new System.Drawing.Point(20, 120);
            this.Lbl_FilaEstanteria.Name = "Lbl_FilaEstanteria";
            this.Lbl_FilaEstanteria.Size = new System.Drawing.Size(99, 16);
            this.Lbl_FilaEstanteria.TabIndex = 6;
            this.Lbl_FilaEstanteria.Text = "Fila Estantería.:";
            this.Lbl_FilaEstanteria.Visible = false;
            // 
            // Txt_UnidadMaterial
            // 
            this.Txt_UnidadMaterial.Location = new System.Drawing.Point(153, 87);
            this.Txt_UnidadMaterial.Name = "Txt_UnidadMaterial";
            this.Txt_UnidadMaterial.Size = new System.Drawing.Size(109, 20);
            this.Txt_UnidadMaterial.TabIndex = 5;
            this.Txt_UnidadMaterial.Text = "0";
            this.Txt_UnidadMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_UnidadMaterial.Visible = false;
            this.Txt_UnidadMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UnidadMaterial_KeyPress_1);
            // 
            // Lbl_UnidadMaterial
            // 
            this.Lbl_UnidadMaterial.AutoSize = true;
            this.Lbl_UnidadMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UnidadMaterial.Location = new System.Drawing.Point(20, 86);
            this.Lbl_UnidadMaterial.Name = "Lbl_UnidadMaterial";
            this.Lbl_UnidadMaterial.Size = new System.Drawing.Size(124, 16);
            this.Lbl_UnidadMaterial.TabIndex = 4;
            this.Lbl_UnidadMaterial.Text = "Unidades Material.:";
            this.Lbl_UnidadMaterial.Visible = false;
            // 
            // Cmb_TipoMaterial
            // 
            this.Cmb_TipoMaterial.AutoCompleteCustomSource.AddRange(new string[] {
            "RVA",
            "RAC",
            "REE"});
            this.Cmb_TipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoMaterial.FormattingEnabled = true;
            this.Cmb_TipoMaterial.Items.AddRange(new object[] {
            "(C) - FRÍO",
            "(F) -FRÁGIL ",
            "(N) - NORMAL"});
            this.Cmb_TipoMaterial.Location = new System.Drawing.Point(153, 53);
            this.Cmb_TipoMaterial.Name = "Cmb_TipoMaterial";
            this.Cmb_TipoMaterial.Size = new System.Drawing.Size(109, 21);
            this.Cmb_TipoMaterial.TabIndex = 3;
            this.Cmb_TipoMaterial.Visible = false;
            this.Cmb_TipoMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_TipoMaterial_KeyPress_1);
            // 
            // Lbl_TipoMaterial
            // 
            this.Lbl_TipoMaterial.AutoSize = true;
            this.Lbl_TipoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoMaterial.Location = new System.Drawing.Point(20, 53);
            this.Lbl_TipoMaterial.Name = "Lbl_TipoMaterial";
            this.Lbl_TipoMaterial.Size = new System.Drawing.Size(112, 16);
            this.Lbl_TipoMaterial.TabIndex = 2;
            this.Lbl_TipoMaterial.Text = "Tipo de Material.:";
            this.Lbl_TipoMaterial.Visible = false;
            // 
            // Cmb_TipoRobot
            // 
            this.Cmb_TipoRobot.AutoCompleteCustomSource.AddRange(new string[] {
            "RVA",
            "RAC",
            "REE"});
            this.Cmb_TipoRobot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoRobot.FormattingEnabled = true;
            this.Cmb_TipoRobot.Items.AddRange(new object[] {
            "(RVA) - ALTA VELOCIDAD",
            "(RAC) - ALTA CAPACIDAD ",
            "(REE) - NORMAL VELOCIDAD "});
            this.Cmb_TipoRobot.Location = new System.Drawing.Point(153, 18);
            this.Cmb_TipoRobot.Name = "Cmb_TipoRobot";
            this.Cmb_TipoRobot.Size = new System.Drawing.Size(109, 21);
            this.Cmb_TipoRobot.TabIndex = 1;
            this.Cmb_TipoRobot.Visible = false;
            this.Cmb_TipoRobot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_TipoRobot_KeyPress_1);
            // 
            // Lbl_TipoRobot
            // 
            this.Lbl_TipoRobot.AutoSize = true;
            this.Lbl_TipoRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoRobot.Location = new System.Drawing.Point(20, 18);
            this.Lbl_TipoRobot.Name = "Lbl_TipoRobot";
            this.Lbl_TipoRobot.Size = new System.Drawing.Size(101, 16);
            this.Lbl_TipoRobot.TabIndex = 0;
            this.Lbl_TipoRobot.Text = "Tipo de Robot.:";
            this.Lbl_TipoRobot.Visible = false;
            // 
            // Gpb_TipoEnvio
            // 
            this.Gpb_TipoEnvio.BackColor = System.Drawing.Color.Khaki;
            this.Gpb_TipoEnvio.Controls.Add(this.Rdb_TipoAutomatico);
            this.Gpb_TipoEnvio.Controls.Add(this.Rdb_TipoManual);
            this.Gpb_TipoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_TipoEnvio.Location = new System.Drawing.Point(44, 19);
            this.Gpb_TipoEnvio.Name = "Gpb_TipoEnvio";
            this.Gpb_TipoEnvio.Size = new System.Drawing.Size(302, 60);
            this.Gpb_TipoEnvio.TabIndex = 0;
            this.Gpb_TipoEnvio.TabStop = false;
            this.Gpb_TipoEnvio.Text = "Tipo de Salida.:";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(77, 294);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 27);
            this.Btn_Aceptar.TabIndex = 5;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click_1);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(232, 294);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(75, 27);
            this.Btn_Cerrar.TabIndex = 6;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click_1);
            // 
            // Frm_SalidaMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(389, 336);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Gpb_TipoEnvio);
            this.Controls.Add(this.Pnl_EnvioDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SalidaMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida de Materiales";
            this.Load += new System.EventHandler(this.Frm_SalidaMaterial_Load);
            this.Pnl_EnvioDatos.ResumeLayout(false);
            this.Pnl_EnvioDatos.PerformLayout();
            this.Gpb_TipoEnvio.ResumeLayout(false);
            this.Gpb_TipoEnvio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Rdb_TipoManual;
        private System.Windows.Forms.RadioButton Rdb_TipoAutomatico;
        private System.Windows.Forms.Panel Pnl_EnvioDatos;
        private System.Windows.Forms.ComboBox Cmb_TipoRobot;
        private System.Windows.Forms.Label Lbl_TipoRobot;
        private System.Windows.Forms.GroupBox Gpb_TipoEnvio;
        private System.Windows.Forms.Label Lbl_TipoMaterial;
        private System.Windows.Forms.ComboBox Cmb_TipoMaterial;
        private System.Windows.Forms.TextBox Txt_UnidadMaterial;
        private System.Windows.Forms.Label Lbl_UnidadMaterial;
        private System.Windows.Forms.TextBox Txt_ColumnaEstanteria;
        private System.Windows.Forms.Label Lbl_ColumnaEstanteria;
        private System.Windows.Forms.TextBox Txt_FilaEstanteria;
        private System.Windows.Forms.Label Lbl_FilaEstanteria;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cerrar;
    }
}