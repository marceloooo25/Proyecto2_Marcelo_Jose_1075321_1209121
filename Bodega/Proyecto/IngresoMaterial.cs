using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto;

namespace Proyecto
{
    public partial class Frm_IngresoMaterial : Form
    {
        public string xTipoMovimiento = "";
        public string xTipoRobot = "";
        public string xTipoMaterial = "";
        public int xUnidadMaterial = 0;
        public int xFila = 0;
        public int xColumna = 0;
        public int xEvento = 0;

        public delegate void pasar(string TipoMovimiento, string TipoRobot, string TipoMaterial, int UnidadMaterial, int Fila, int Columna, int TípoEvento);
        public event pasar Pasado;
      
        public Frm_IngresoMaterial()
        {
            InitializeComponent();
            
        }

        private void FrIMaterial_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            //ControlBox = false;
        }

        private void Rdb_TipoManual_CheckedChanged(object sender, EventArgs e)
        {
            PnEnvio.Visible = true;
            Lbl_TipoRobot.Visible = true;
            Cmb_TipoRobot.Visible = true;
            Lbl_TipoMaterial.Visible = true;
            Cmb_TipoMaterial.Visible = true;
            Lbl_UnidadMaterial.Visible = true;
            Txt_UnidadMaterial.Visible = true;
            Lbl_FilaEstanteria.Visible = true;
            Txt_FilaEstanteria.Visible = true;
            Llb_ColumnaEstanteria.Visible = true;
            Txt_ColumnaEstanteria.Visible = true;
            Cmb_TipoRobot.Focus();
        }

        private void Rbt_Automatico_CheckedChanged(object sender, EventArgs e)
        {
            PnEnvio.Visible = true;
            Lbl_TipoRobot.Visible = false;
            Cmb_TipoRobot.Visible = false;
            Lbl_TipoMaterial.Visible = true;
            Cmb_TipoMaterial.Visible = true;
            Lbl_UnidadMaterial.Visible = true;
            Txt_UnidadMaterial.Visible = true;            
            Lbl_FilaEstanteria.Visible = false;
            Txt_FilaEstanteria.Visible = false;
            Llb_ColumnaEstanteria.Visible = false;
            Txt_ColumnaEstanteria.Visible = false;
            Cmb_TipoMaterial.Focus();
        }

        private void Cmb_TipoRobot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)) && (Cmb_TipoRobot.Text != ""))
            {
                Cmb_TipoMaterial.Focus();
                e.Handled = true;
            }                        
        }

        private void Cmb_TipoMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Txt_UnidadMaterial.Focus();
                e.Handled = true;
            }
        }

        private void Txt_UnidadMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (Rdb_TipoManual.Checked == true)
                    {
                        Txt_FilaEstanteria.Focus();
                    }
                    if (Rdb_TipoAutomatico.Checked == true)
                    {
                        Btn_Aceptar.Focus();
                    }
                    
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }

            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void Txt_FilaEstanteria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    Txt_ColumnaEstanteria.Focus();
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }

            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void Txt_ColumnaEstanteria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    Btn_Aceptar.Focus();
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }

            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }    

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            bool DatosCorrectos = true;
            
            if (Rdb_TipoManual.Checked == true)
            {
                xTipoMovimiento = "M";
                int xIndiceRobot = Cmb_TipoRobot.SelectedIndex;
                if (xIndiceRobot == 0)
                {
                    xTipoRobot = "1";
                }
                else if (xIndiceRobot == 1)
                {
                    xTipoRobot = "2";
                }
                else if (xIndiceRobot == 2)
                {
                    xTipoRobot = "3";
                }
                else
                {
                    MessageBox.Show("Debe de elegir un Tipo de Robot");
                    DatosCorrectos = false;
                    Cmb_TipoRobot.Focus();
                }

                if (DatosCorrectos == true)
                {
                    int xIndiceMaterial = Cmb_TipoMaterial.SelectedIndex;
                    if (xIndiceMaterial == 0)
                    {
                        xTipoMaterial = "C";
                    }
                    else if (xIndiceMaterial == 1)
                    {
                        xTipoMaterial = "F";
                    }
                    else if (xIndiceMaterial == 2)
                    {
                        xTipoMaterial = "N";
                    }
                    else
                    {
                        MessageBox.Show("Debe de elegir el Tipo de Material");
                        DatosCorrectos = false;
                        Cmb_TipoMaterial.Focus();
                    }

                    if (DatosCorrectos == true)
                    {
                        try
                        {
                            xUnidadMaterial = Convert.ToInt32(Txt_UnidadMaterial.Text);
                            if (xUnidadMaterial == 0)
                            {
                                MessageBox.Show("La cantidad de Material debe ser mayor a 0");
                                DatosCorrectos = false;
                                Txt_UnidadMaterial.Focus();
                            }
                            else if ((xUnidadMaterial % 2) == 0)
                            {
                                MessageBox.Show("Las Unidades para el Material no pueden ser Pares");
                                DatosCorrectos = false;
                                Txt_UnidadMaterial.Focus();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("El Valor para las Unidades de Material no puede estar vacio");
                            DatosCorrectos = false;
                            Txt_UnidadMaterial.Focus();
                        }
                    }

                    if (DatosCorrectos == true)
                    {
                        try
                        {
                            xFila = Convert.ToInt32(Txt_FilaEstanteria.Text);
                        }
                        catch
                        {
                            MessageBox.Show("El Valor para la Fila no puede estar vacio");
                            DatosCorrectos = false;
                            Txt_FilaEstanteria.Focus();
                        }
                    }

                    if (DatosCorrectos == true)
                    {
                        try
                        {
                            xColumna = Convert.ToInt32(Txt_ColumnaEstanteria.Text);
                        }
                        catch
                        {
                            MessageBox.Show("El Valor para la Fila no puede estar vacio");
                            DatosCorrectos = false;
                            Txt_ColumnaEstanteria.Focus();
                        }
                    }
                }           
            }
            else if (Rdb_TipoAutomatico.Checked == true)
            {
                xTipoMovimiento = "A";
                int xIndiceMaterial = Cmb_TipoMaterial.SelectedIndex;
                if (xIndiceMaterial == 0)
                {
                    xTipoMaterial = "C";
                }
                else if (xIndiceMaterial == 1)
                {
                    xTipoMaterial = "F";
                }
                else if (xIndiceMaterial == 2)
                {
                    xTipoMaterial = "N";
                }
                else
                {
                    MessageBox.Show("Debe de elegir el Tipo de Material");
                    DatosCorrectos = false;
                    Cmb_TipoMaterial.Focus();
                }

                if (DatosCorrectos == true)
                {
                    try
                    {
                        xUnidadMaterial = Convert.ToInt32(Txt_UnidadMaterial.Text);
                        if (xUnidadMaterial == 0)
                        {
                            MessageBox.Show("La cantidad de Material debe ser mayor a 0");
                            DatosCorrectos = false;
                            Txt_UnidadMaterial.Focus();
                        }
                        else if ((xUnidadMaterial % 2) == 0)
                        {
                            MessageBox.Show("La cantidad para el Material no puede ser un valor Impar");
                            DatosCorrectos = false;
                            Txt_UnidadMaterial.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("El Valor para las Unidades de Material no puede estar vacio");
                        DatosCorrectos = false;
                        Txt_UnidadMaterial.Focus();
                    }
                }
            }

            if (DatosCorrectos == true)
            {
                Pasado(xTipoMovimiento, xTipoRobot, xTipoMaterial, xUnidadMaterial, xFila, xColumna, 0);
                this.Close();
            }
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Pasado("", "", "", 0, 0, 0, 1);
            this.Close();
        }
    }
}
