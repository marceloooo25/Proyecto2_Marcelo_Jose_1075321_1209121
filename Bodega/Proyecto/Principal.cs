using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Proyecto;

namespace Proyecto
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // Forma Principal no Eliminar
        }

        string[,] nTablero;
        int[,] nMaximos;
        int[,] nExistencias;
        int[,] nIngresos;
        int[,] nSalidas;
        int[,] nDisponibles;
        int[] nRobotIngresos;
        int[] nRobotSalidas;
        int[] nRobotBloques;

        string xTipoMovimiento = "";
        string xTipoRobot = "";
        string xTipoMaterial = "";
        int xCantidadMaterial = 0;
        int xFila = 0;
        int xColumna = 0;
        int xTipoEvento = 1;      

        int CantidadFilas = 0;
        int CantidadColumnas = 0;

        int FilaRobot1 = 0;
        int ColumnaRobot1 = 0;
        int Cantidad = 0;
        string Valor = "";
        string Dato = "";
        bool DatosCorrectos;
        bool Cancelar;
        string[] Archivo;
        bool ArchivoCargado = false;
        string xRobot;
        int Fila;
        int Columna;

        string valorAnteriorDelPasoRobot = "P";

        private void BtnCargarArchivo_Click(object sender, EventArgs e)
        {
            int anterior;
            Cancelar = false;

            do
            {
                DatosCorrectos = true;
                //Lectura de archivo
                Ofd_NombreArchivo.Filter = "Archivos separados por coma |*.txt;*.csv";
                Ofd_NombreArchivo.FileName = "";

                if ((DialogResult.OK == Ofd_NombreArchivo.ShowDialog()) && (Ofd_NombreArchivo.FileName != "") && (ArchivoCargado==false))
                {
                    ArchivoCargado = true;
                    Archivo = File.ReadAllLines(Ofd_NombreArchivo.FileName);

                    if (Archivo.Length != 0)
                    {
                        CantidadFilas = Archivo.Length;
                        CantidadColumnas = Archivo[0].Split(',').Length;

                        //Inicializa Matrices para Control de los Datos
                        nTablero = new string[CantidadFilas, CantidadColumnas];
                        nMaximos = new int[CantidadFilas, CantidadColumnas];
                        nExistencias = new int[CantidadFilas, CantidadColumnas];
                        nIngresos = new int[CantidadFilas, CantidadColumnas];
                        nSalidas = new int[CantidadFilas, CantidadColumnas];
                        nDisponibles = new int[CantidadFilas, CantidadColumnas];                        
                        nRobotIngresos = new int[3];
                        nRobotSalidas = new int[3];
                        nRobotBloques = new int[3];

                        // foreach (var linea in archivo)
                        // for (int fila = 0; fila < archivo.Count(); fila++)
                        // sustituimos el foreach por un do-while

                        anterior = 0;
                        Fila = 0;
                        do
                        {
                            string linea = Archivo[Fila];
                            var valores = linea.Split(',');
                            // TMatriz TempMatriz = new TMatriz();

                            // foreach (var nuevo in valores)
                            //for (int columna = 0; columna < valores.Count(); columna++)
                            // sustituimos el foreach por un do-while

                            Columna = 0;
                            do
                            {
                                Dato = valores[Columna];
                                if (Dato.Length > 0)
                                {
                                    if (char.ToUpper(Dato[0]) == ' ')
                                    {
                                        Dato = Dato.Substring(Dato.IndexOf(" ") + 1);
                                    }

                                    if (Dato.Length > 1)
                                    {
                                        if ((char.ToUpper(Dato[0]) == 'C' || char.ToUpper(Dato[0]) == 'F' || char.ToUpper(Dato[0]) == 'N') && (char.ToUpper(Dato[1]) == '%'))
                                        {
                                            nTablero[Fila, Columna] = Dato[0].ToString();
                                            nMaximos[Fila, Columna] = 10;
                                            nExistencias[Fila, Columna] = 0;
                                            nIngresos[Fila, Columna] = 0;
                                            nSalidas[Fila, Columna] = 0;
                                            nDisponibles[Fila, Columna] = 10;                                                                                        
                                        }
                                        else if (char.ToUpper(Dato[0]) == 'C')
                                        {
                                            Valor = Dato.Substring(Dato.IndexOf("C") + 1);
                                            if (Valor[0] != '0')
                                            {
                                                nTablero[Fila, Columna] = "C";
                                                try
                                                {
                                                    Cantidad = Convert.ToInt32(Valor);
                                                    nMaximos[Fila, Columna] = Convert.ToInt32(Valor);
                                                    nExistencias[Fila, Columna] = 0;
                                                    nIngresos[Fila, Columna] = 0;
                                                    nDisponibles[Fila, Columna] = Convert.ToInt32(Valor);
                                                }
                                                catch
                                                {
                                                    Cantidad = 0;
                                                }

                                                if (Cantidad == 0)
                                                {
                                                    MessageBox.Show("La cantidad para el Material Frío en la Estantería Fila: " + Fila + " Columna: " + Columna + " contine un valor Incorrecto");
                                                    DatosCorrectos = false;
                                                }
                                                else if ((Cantidad % 2) == 0)
                                                {
                                                    MessageBox.Show("La cantidad para el Material Frío en la Estantería Fila: " + Fila + " Columna: " + Columna + " no cumple con un valor Impar");
                                                    DatosCorrectos = false;
                                                }
                                            }
                                            else
                                            {
                                                Cantidad = Convert.ToInt32(Valor);
                                                if (Cantidad == 0)
                                                {
                                                    MessageBox.Show("La cantidad para el Material Frío en la Estantería Fila: " + Fila + " Columna: " + Columna + " contine un valor de 0");
                                                    DatosCorrectos = false;
                                                }
                                            }
                                        }
                                        else if (char.ToUpper(Dato[0]) == 'F')
                                        {
                                            Valor = Dato.Substring(Dato.IndexOf("F") + 1);
                                            if (Valor[0] != '0')
                                            {
                                                nTablero[Fila, Columna] = "F";
                                                try
                                                {
                                                    Cantidad = Convert.ToInt32(Valor);
                                                    nMaximos[Fila, Columna] = Convert.ToInt32(Valor);
                                                    nExistencias[Fila, Columna] = 0;
                                                    nIngresos[Fila, Columna] = 0;
                                                    nSalidas[Fila, Columna] = 0;
                                                    nDisponibles[Fila, Columna] = Convert.ToInt32(Valor);   
                                                }
                                                catch
                                                {
                                                    Cantidad = 0;
                                                }

                                                if (Cantidad == 0)
                                                {
                                                    MessageBox.Show("La cantidad para el Material Frágil en la Estantería Fila: " + Fila + " Columna: " + Columna + " contine un valor Incorrecto");
                                                    DatosCorrectos = false;
                                                }
                                                else if ((Cantidad % 2) == 0)
                                                {
                                                    MessageBox.Show("La cantidad para el Material Frágil en la Estantería Fila: " + Fila + " Columna: " + Columna + " no cumple con un valor Impar");
                                                    DatosCorrectos = false;
                                                }
                                            }
                                            else
                                            {
                                                Cantidad = Convert.ToInt32(Valor);
                                                if (Cantidad == 0)
                                                {
                                                    MessageBox.Show("La cantidad para el Material Frágil en la Estantería Fila: " + Fila + " Columna: " + Columna + " contine un valor 0");
                                                    DatosCorrectos = false;
                                                }
                                            }

                                        }
                                        else if (char.ToUpper(Dato[0]) == 'N')
                                        {
                                            Valor = Dato.Substring(Dato.IndexOf("N") + 1);
                                            if (Valor[0] != '0')
                                            {
                                                nTablero[Fila, Columna] = "N";
                                                try
                                                {
                                                    Cantidad = Convert.ToInt32(Valor);
                                                    nMaximos[Fila, Columna] = Convert.ToInt32(Valor);
                                                    nExistencias[Fila, Columna] = 0;
                                                    nIngresos[Fila, Columna] = 0;
                                                    nSalidas[Fila, Columna] = 0;
                                                    nDisponibles[Fila, Columna] = Convert.ToInt32(Valor);
                                                }
                                                catch
                                                {
                                                    Cantidad = 0;
                                                }

                                                if (Cantidad == 0)
                                                {
                                                    MessageBox.Show("La cantidad para el Material Normal en la Estantería Fila: " + Fila + " Columna: " + Columna + " contine un valor 0");
                                                    DatosCorrectos = false;
                                                }
                                                else if ((Cantidad % 2) == 0)
                                                {
                                                    MessageBox.Show("La cantidad para el Material Normal en la Estantería Fila: " + Fila + " Columna: " + Columna + " no cumple con un valor Impar");
                                                    DatosCorrectos = false;
                                                }
                                            }
                                            else
                                            {
                                                Cantidad = Convert.ToInt32(Valor);
                                                if (Cantidad == 0)
                                                {
                                                    MessageBox.Show("La cantidad para el Material Frágil en la Estantería Fila: " + Fila + " Columna: " + Columna + " contine un valor 0");
                                                    DatosCorrectos = false;
                                                }
                                            }
                                        }
                                        else if (char.ToUpper(Dato[0]) == 'R')
                                        {
                                            xRobot = Dato.Substring(Dato.IndexOf("R") + 1);
                                            if (xRobot == "VA")
                                            {
                                                nTablero[Fila, Columna] = "1";
                                                nMaximos[Fila, Columna] = 0;
                                                nExistencias[Fila, Columna] = 0;
                                                nIngresos[Fila, Columna] = 0;
                                                nSalidas[Fila, Columna] = 0;
                                                nDisponibles[Fila, Columna] = 0;                                                 
                                            }
                                            else if (xRobot == "AC")
                                            {
                                                nTablero[Fila, Columna] = "2";
                                                nMaximos[Fila, Columna] = 0;
                                                nExistencias[Fila, Columna] = 0;
                                                nIngresos[Fila, Columna] = 0;
                                                nSalidas[Fila, Columna] = 0;
                                                nDisponibles[Fila, Columna] = 0;                                                
                                            }
                                            else if (xRobot == "EE")
                                            {
                                                nTablero[Fila, Columna] = "3";
                                                nMaximos[Fila, Columna] = 0;
                                                nExistencias[Fila, Columna] = 0;
                                                nIngresos[Fila, Columna] = 0;
                                                nDisponibles[Fila, Columna] = 0;
                                                
                                            }
                                            else
                                            {
                                                MessageBox.Show("El Robot ingresado R" + xRobot + " en la Fila: " + Fila + " Columna: " + Columna + " es Incorrecto");
                                                DatosCorrectos = false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Existe un dato Incorrecto en la Fila: " + Fila + " Columna: " + Columna);
                                            DatosCorrectos = false;
                                        }

                                    }
                                    else if (Dato[0] == '0')
                                    {
                                        nTablero[Fila, Columna] = "0";
                                        nMaximos[Fila, Columna] = 0;
                                        nExistencias[Fila, Columna] = 0;
                                        nSalidas[Fila, Columna] = 0;
                                        nDisponibles[Fila, Columna] = 0;
                                        
                                    }
                                    else if (Dato[0] == 'P')
                                    {
                                        nTablero[Fila, Columna] = "P";
                                        nMaximos[Fila, Columna] = 0;
                                        nExistencias[Fila, Columna] = 0;
                                        nIngresos[Fila, Columna] = 0;
                                        nSalidas[Fila, Columna] = 0;
                                        nDisponibles[Fila, Columna] = 0;
                                        
                                    }
                                    else if ((Dato[0] != 'P') && (Dato[0] != '0'))
                                    {
                                        if ((char.ToUpper(Dato[0]) == 'C') || (char.ToUpper(Dato[0]) == 'F') || (char.ToUpper(Dato[0]) == 'N'))
                                        {
                                           MessageBox.Show("La CANTIDAD del Material: " + Nombre_Material(Dato[0].ToString()) + " Fila: " + Fila + " Columna: " + Columna + " SIN Valores");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Existe un DATO INCORRECTO Fila: " + Fila + " Columna: " + Columna);
                                        }
                                        DatosCorrectos = false;
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("NO EXISTE un PARAMETRO Válido Fila: " + Fila + " Columna: " + Columna + " INGRESO INCORRECTO");
                                    DatosCorrectos = false;
                                }

                                Columna++;

                            }
                            while ((Columna < valores.Count()) && (DatosCorrectos == true));

                            if (Fila == 0)
                            {
                                anterior = Columna;
                            }
                            else if ((Columna != anterior) && (DatosCorrectos == true))
                            {
                                MessageBox.Show("Existen diferencia en la cantidad de Columnas en las Filas " + (Fila - 1) + " y " + Fila);
                                DatosCorrectos = false;
                            }

                            Fila++;
                        }
                        while ((Fila < Archivo.Count()) && (DatosCorrectos == true));
                        if (DatosCorrectos == false)
                            MessageBox.Show("El Archivo Ingresado tiene errores de Sintaxis");
                    }
                    else
                    {
                        MessageBox.Show("El Archivo no tiene valores");
                        DatosCorrectos = false;
                    }
                }
                else if (Ofd_NombreArchivo.FileName == "")
                {
                    MessageBox.Show("Cancelo el Ingreso del Nombre del Archivo");
                    Cancelar = true;
                    DatosCorrectos = false;
                }
                else if (ArchivoCargado == true)
                {
                    MessageBox.Show("NO se puede volver a Cargar La BODEGA");
                    Cancelar = true;
                    DatosCorrectos = false;
                }

            }
            while ((DatosCorrectos == false) && (Cancelar == false));

            if (DatosCorrectos == true) 
            {
                CantidadFilas = Fila; //Me da la cantidad de filas
                CantidadColumnas = Columna;

                //Mostrar Matriz en DataGrid View
                //Agregar columnas
                for (int i = 0; i < CantidadColumnas; i++)
                {
                    DataGridViewImageColumn C1 = new DataGridViewImageColumn(); //Creo columna de imagenes
                    {
                        C1.Width = 100;
                    }
                    Dgv_Tablero.Columns.Add(C1);

                    DataGridViewTextBoxColumn C2 = new DataGridViewTextBoxColumn();
                    {
                        C2.Width = 35;
                    }
                    Dgv_Maximos.Columns.Add(C2);

                    DataGridViewTextBoxColumn C3 = new DataGridViewTextBoxColumn();
                    {
                        C3.Width = 35;
                    }
                    Dgv_Existencias.Columns.Add(C3);

                    DataGridViewTextBoxColumn C4 = new DataGridViewTextBoxColumn();
                    {
                        C4.Width = 35;
                    }
                    Dgv_Disponibles.Columns.Add(C4);

                    DataGridViewTextBoxColumn C5 = new DataGridViewTextBoxColumn();
                    {
                        C5.Width = 35;
                    }
                    Dgv_Ingresos.Columns.Add(C5);

                    DataGridViewTextBoxColumn C6 = new DataGridViewTextBoxColumn();
                    {
                        C6.Width = 35;
                    }
                    Dgv_Salidas.Columns.Add(C6);
                }

                Dgv_Tablero.Rows.Add(CantidadFilas);

                Dgv_Maximos.RowTemplate.Height = 35;
                Dgv_Maximos.Rows.Add(CantidadFilas);

                Dgv_Existencias.RowTemplate.Height = 35;
                Dgv_Existencias.Rows.Add(CantidadFilas);

                Dgv_Disponibles.RowTemplate.Height = 35;
                Dgv_Disponibles.Rows.Add(CantidadFilas);

                Dgv_Ingresos.RowTemplate.Height = 35;
                Dgv_Ingresos.Rows.Add(CantidadFilas);

                Dgv_Salidas.RowTemplate.Height = 35;
                Dgv_Salidas.Rows.Add(CantidadFilas);

                //poblar el datagrid
                DibujarDataGrid();

                Lbl_NombreArchivo.Text = Ofd_NombreArchivo.FileName;

                Tmr_Robot.Enabled = true;
            }
        }//Fin del click del botón

        void BuscarEntradaSalida(int rFila, int rColumna, ref int Fila, ref int Columna)
        {
            int Posicion = rFila + rColumna;
            bool Primero = true;
            int Peso = 0;
            int i = 0;           
            while (i < CantidadFilas)
            {
                int j = 0;
                while (j < CantidadColumnas)
                {
                    if (nTablero[i, j] == "0")
                    {
                        if (Primero == true)
                        {
                            Primero = false;
                            Fila = i;
                            Columna = j;
                            Peso = Posicion - (i + j);
                        }
                        else if ((i + j - Posicion) < Peso)
                        {                            
                            Fila = i;
                            Columna = j;
                            Peso = Posicion - (i + j);
                        }                                                
                    }
                    j++;
                }
                i++;
            }
        }

        void MoverRobot(int sFila, int sColumna, int rFila, int rColumna, string rTipoRobot, string rPosicion)
        {
            int f;
            int Tiempo = 0;

            if (rTipoRobot == "1")
            {
                Tiempo = 10;
            }
            else if (rTipoRobot == "2")
            {
                Tiempo = 30;
            }
            else if (rTipoRobot == "3")
            {
                Tiempo = 20;
            }

            if (sFila > rFila)
            {
                f = rFila;
                while (f < sFila)
                {
                    //nTipo[rFila, rColumna] = xTipo;
                    MoverPosicion(1, rFila, rColumna, rTipoRobot);
                    DibujarDataGrid();
                    int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                    f++;
                    rFila++;
                }
                if (sColumna > rColumna)
                {
                    f = rColumna;
                    while (f < sColumna)
                    {
                        //nTipo[rFila, rColumna] = xTipo;
                        MoverPosicion(3, rFila, rColumna, rTipoRobot);
                        DibujarDataGrid();                        
                        int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                        f++;
                        rColumna++;
                    }
                }
                else if (sColumna < rColumna)
                {
                    f = rColumna;
                    while (f > sColumna)
                    {
                        //nTipo[rFila, rColumna] = xTipo;
                        MoverPosicion(2, rFila, rColumna, rTipoRobot);
                        DibujarDataGrid();                        
                        int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                        f--;
                        rColumna--;
                    }
                }
            }

            else if (sFila < rFila)
            {
                f = rFila;
                while (f > sFila)
                {
                    //nTipo[rFila, rColumna] = xTipo;
                    MoverPosicion(0, rFila, rColumna, rTipoRobot);
                    DibujarDataGrid();
                    int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                    f--;
                    rFila--;
                }
                if (sColumna > rColumna)
                {
                    f = rColumna;
                    while (f < sColumna)
                    {
                        //nTipo[rFila, rColumna] = xTipo;
                        MoverPosicion(3, rFila, rColumna, rTipoRobot);
                        DibujarDataGrid();
                        int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                        f++;
                        rColumna++;
                    }
                }
                else if (sColumna < rColumna)
                {
                    f = rColumna;
                    while (f > sColumna)
                    {
                        //nTipo[rFila, rColumna] = xTipo;
                        MoverPosicion(2, rFila, rColumna, rTipoRobot);
                        DibujarDataGrid();
                        int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                        f--;
                        rColumna--;
                    }
                }
            }

            else if (sColumna > rColumna)
            {
                f = rColumna;
                while (f < sColumna)
                {
                    //nTipo[rFila, rColumna] = xTipo;
                    MoverPosicion(3, rFila, rColumna, rTipoRobot);
                    DibujarDataGrid();
                    int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                    f++;
                    rColumna++;
                }
                if (sFila > rFila)
                {
                    f = rFila;
                    while (f < sFila)
                    {
                        //nTipo[rFila, rColumna] = xTipo;
                        MoverPosicion(1, rFila, rColumna, rTipoRobot);
                        DibujarDataGrid();
                        int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                        f++;
                        rFila++;
                    }

                }
                else if (sFila < rFila)
                {
                    f = rFila;
                    while (f > sFila)
                    {
                        //nTipo[rFila, rColumna] = xTipo;
                        MoverPosicion(0, rFila, rColumna, rTipoRobot);
                        DibujarDataGrid();
                        int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                        f--;
                        rFila--;
                    }
                }
            }

            else if (sColumna < rColumna)
            {
                f = rColumna;
                while (f > sColumna)
                {
                    //nTipo[rFila, rColumna] = xTipo;
                    MoverPosicion(2, rFila, rColumna, rTipoRobot);
                    DibujarDataGrid();
                    int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                    f--;
                    rColumna--;
                }

                if (sFila > rFila)
                {
                    f = rFila;
                    while (f < sFila)
                    {
                        //nTipo[rFila, rColumna] = xTipo;
                        MoverPosicion(1, rFila, rColumna, rTipoRobot);
                        DibujarDataGrid();
                        int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                        f++;
                        rFila++;
                    }

                }
                else if (sFila < rFila)
                {
                    f = rFila;
                    while (f > sFila)
                    {
                        //nTipo[rFila, rColumna] = xTipo;
                        MoverPosicion(0, rFila, rColumna, rTipoRobot);
                        DibujarDataGrid();
                        int milliseconds = Tiempo; Thread.Sleep(milliseconds);
                        f--;
                        rFila--;
                    }
                }
            }

            if ((sFila == rFila) && (sColumna == rColumna) && (rPosicion == "0"))
            {
                nTablero[rFila, rColumna] = rPosicion;

                DibujarDataGrid();
                int milliseconds = Tiempo; Thread.Sleep(milliseconds);
            }
        }
        
        void SacarRobot(string xPosicion)
        {
            int rFila = 0;

            while ((rFila < CantidadFilas))
            {
                int rColumna = 0;
                while ((rColumna < CantidadColumnas))
                {
                    if ((nTablero[rFila, rColumna] == "1") || (nTablero[rFila, rColumna] == "2") || (nTablero[rFila, rColumna] == "3"))
                    {
                        valorAnteriorDelPasoRobot = xPosicion;
                        int sFila = 0;
                        int sColumna = 0;
                        string rTipo = nTablero[rFila, rColumna];
                        BuscarEntradaSalida(rFila, rColumna, ref sFila, ref sColumna);
                        MoverRobot(sFila, sColumna, rFila, rColumna, rTipo, "0");
                    }
                    rColumna++;
                }
                rFila++;
            }
        }

        void DibujarDataGrid()
        {
            for (int i = 0; i < CantidadFilas; i++)
            {
                for (int j = 0; j < CantidadColumnas; j++)
                {
                    Dgv_Tablero.Rows[i].Cells[j].Value = ObtenerImagendelListado(nTablero[i, j]);
                    Dgv_Maximos.Rows[i].Cells[j].Value = nMaximos[i, j].ToString();
                    Dgv_Existencias.Rows[i].Cells[j].Value = nExistencias[i, j].ToString();
                    Dgv_Ingresos.Rows[i].Cells[j].Value = nIngresos[i, j].ToString();
                    Dgv_Salidas.Rows[i].Cells[j].Value = nSalidas[i, j].ToString();
                    Dgv_Disponibles.Rows[i].Cells[j].Value = nDisponibles[i, j].ToString();                    
                }
            }

            Dgv_RobotIngresos.Rows[0].Cells[0].Value = nRobotIngresos[0].ToString();
            Dgv_RobotIngresos.Rows[0].Cells[1].Value = nRobotIngresos[1].ToString();
            Dgv_RobotIngresos.Rows[0].Cells[2].Value = nRobotIngresos[2].ToString();

            Dgv_RobotSalidas.Rows[0].Cells[0].Value = nRobotSalidas[0].ToString();
            Dgv_RobotSalidas.Rows[0].Cells[1].Value = nRobotSalidas[1].ToString();
            Dgv_RobotSalidas.Rows[0].Cells[2].Value = nRobotSalidas[2].ToString();

            Dgv_RobotBloques.Rows[0].Cells[0].Value = nRobotBloques[0].ToString();
            Dgv_RobotBloques.Rows[0].Cells[1].Value = nRobotBloques[1].ToString();
            Dgv_RobotBloques.Rows[0].Cells[2].Value = nRobotBloques[2].ToString();

            Dgv_Tablero.Refresh();
            Dgv_Maximos.Refresh();
            Dgv_Existencias.Refresh();
            Dgv_Ingresos.Refresh();
            Dgv_Salidas.Refresh();
            Dgv_Disponibles.Refresh();
            Dgv_RobotIngresos.Refresh();
            Dgv_RobotSalidas.Refresh();
            Dgv_RobotBloques.Refresh();
        }

        Image ObtenerImagendelListado(string imagen) {
            switch (imagen)
            {
                case "C":
                    {
                        return Img_Tablero.Images[0];
                    }
                case "F":
                    {
                        return Img_Tablero.Images[1];
                    }
                case "N":
                    {
                        return Img_Tablero.Images[2];
                    }
                case "1":
                    {
                        return Img_Tablero.Images[3];
                    }
                case "2":
                    {
                        return Img_Tablero.Images[4];
                    }
                case "3":
                    {
                        return Img_Tablero.Images[5];
                    }
                case "P":
                    {
                        return Img_Tablero.Images[6];
                    }
                case "0":
                    {
                        return Img_Tablero.Images[7];
                    }
                default:
                    {
                        return Img_Tablero.Images[8];
                    }
            }
        } //Fin de funcion que devuelve la imagen

        private void TRobot_Tick(object sender, EventArgs e)
        {
            SacarRobot(valorAnteriorDelPasoRobot);
            Tmr_Robot.Stop();
        }

        static string Nombre_Material(string xTipoMaterial)
        {
            switch (xTipoMaterial)
            {
                case "C":
                    {
                        return "FRÍO";
                    }
                case "F":
                    {
                        return "FRÁGIL";
                    }
                case "N":
                    {
                        return "NORMAL";
                    }
                default:
                    {
                        return "";
                    }

            }

        }

        void MoverPosicion(int xDireccion, int rFila, int rColumna, string rTipoRobot)
        {
            FilaRobot1 = rFila;
            ColumnaRobot1 = rColumna;

            if (rTipoRobot == "1")
            {
                nRobotBloques[0] += 1;
            }
            else if (rTipoRobot == "2")
            {
                nRobotBloques[1] += 1;
            }
            else if (rTipoRobot == "3")
            {
                nRobotBloques[2] += 1;
            }
               
            switch (xDireccion)
            {   //Se mueve de acuerdo a la direccion que le envia la busqueda del 0 a 3
                case 0:
                    {   //Robot se mueve para arriba
                        if (FilaRobot1 > 0)
                        {
                            //Lo que estaba antes del robot lo volvemos a colocar

                            nTablero[FilaRobot1, ColumnaRobot1] = valorAnteriorDelPasoRobot;

                            FilaRobot1--;
                            valorAnteriorDelPasoRobot = nTablero[FilaRobot1, ColumnaRobot1];
                            //Guardo lo que estaba en esa posición antes de que pasara el robot

                            nTablero[FilaRobot1, ColumnaRobot1] = rTipoRobot;
                            //Lbl_ContarSegundos.Text = "Arriba";
                        }
                    }
                    break;

                case 1:
                    {   //Robot se mueve para abajo
                        if (FilaRobot1 < CantidadFilas - 1)
                        {

                            //Lo que estaba antes del robot lo volvemos a colocar
                            nTablero[FilaRobot1, ColumnaRobot1] = valorAnteriorDelPasoRobot;

                            FilaRobot1++;

                            valorAnteriorDelPasoRobot = nTablero[FilaRobot1, ColumnaRobot1];
                            //Guardo lo que estaba en esa posición antes de que pasara el robot

                            nTablero[FilaRobot1, ColumnaRobot1] = rTipoRobot;
                            //Lbl_ContarSegundos.Text = "Abajo";
                        }
                    }
                    break;

                case 2:
                    { //Robot se mueve para izquierda
                        if (ColumnaRobot1 > 0)
                        {
                            //Lo que estaba antes del robot lo volvemos a colocar
                            nTablero[FilaRobot1, ColumnaRobot1] = valorAnteriorDelPasoRobot;

                            ColumnaRobot1--;
                            valorAnteriorDelPasoRobot = nTablero[FilaRobot1, ColumnaRobot1];
                            //Guardo lo que estaba en esa posición antes de que pasara el robot
                            nTablero[FilaRobot1, ColumnaRobot1] = rTipoRobot;
                            //Lbl_ContarSegundos.Text = "Izquierda";                            
                        }
                    }
                    break;

                case 3:
                    { //Robot se mueve para derecha
                        if (ColumnaRobot1 < CantidadColumnas - 1)
                        {
                            //Lo que estaba antes del robot lo volvemos a colocar

                            nTablero[FilaRobot1, ColumnaRobot1] = valorAnteriorDelPasoRobot;

                            ColumnaRobot1++;
                            valorAnteriorDelPasoRobot = nTablero[FilaRobot1, ColumnaRobot1];
                            nTablero[FilaRobot1, ColumnaRobot1] = rTipoRobot;
                            //Lbl_ContarSegundos.Text = "Derecha";

                            //Guardo lo que estaba en esa posición antes de que pasara el robot
                        }
                    }
                    break;
            }
        }

        void BuscarDisponibilidad(string TipoMaterial, int TipoIO, ref int Disponibilidad)
        {
            Disponibilidad = 0;
            for (int i = 0; i < CantidadFilas; i++)
                {
                    for (int j = 0; j < CantidadColumnas; j++)
                    {
                        if (nTablero[i,j] == TipoMaterial)
                        {
                            if (TipoIO == 0)
                            {
                                Disponibilidad += nDisponibles[i, j];
                            }
                            else if (TipoIO == 1)
                            {
                                Disponibilidad += nExistencias[i, j];
                            }
                        }
                    }
                }            
        }

        private void Btn_IngresoMaterial_Click(object sender, EventArgs e)
        {
            if (Ofd_NombreArchivo.FileName != "")
            {
                Frm_IngresoMaterial Ingreso_Material = new Frm_IngresoMaterial();
                Ingreso_Material.Pasado += new Frm_IngresoMaterial.pasar(Ejecutar);
                Ingreso_Material.ShowDialog();

                if (xTipoEvento == 0)
                {
                    if (xTipoMovimiento == "M")
                    {
                        if (xTipoMaterial == nTablero[xFila, xColumna])
                        {
                            int sFila = 0;
                            int sColumna = 0;
                            if (nExistencias[xFila, xColumna] == nMaximos[xFila, xColumna])
                            {
                                SacarRobot(valorAnteriorDelPasoRobot);
                                MessageBox.Show("Material: " + Nombre_Material(xTipoMaterial) + " Fila: " + xFila + " Columna: " + xColumna + " EXCEDE su CAPACIDAD");
                            }
                            else if (nExistencias[xFila, xColumna] + xCantidadMaterial <= nMaximos[xFila, xColumna])
                            {
                                nExistencias[xFila, xColumna] += xCantidadMaterial;
                                nIngresos[xFila, xColumna] += xCantidadMaterial;
                                nDisponibles[xFila, xColumna] = nMaximos[xFila, xColumna] - nExistencias[xFila, xColumna];
                                if (xTipoRobot == "1")
                                {
                                    nRobotIngresos[0] += 1;
                                }
                                else if (xTipoRobot == "2")
                                {
                                    nRobotIngresos[1] += 1;
                                }
                                else if (xTipoRobot == "2")
                                {
                                    nRobotIngresos[2] += 1;
                                }
                                BuscarEntradaSalida(xFila, xColumna, ref sFila, ref sColumna);
                                MoverRobot(xFila, xColumna, sFila, sColumna, xTipoRobot, xTipoMaterial);
                                MessageBox.Show("Material: " + Nombre_Material(xTipoMaterial) + " Fila: " + xFila + " Columna: " + xColumna + " INGRESO CORRECTO");
                                SacarRobot(valorAnteriorDelPasoRobot);
                            }
                            else
                            {
                                if (xTipoRobot == "1")
                                {
                                    nRobotIngresos[0] += 1;
                                }
                                else if (xTipoRobot == "2")
                                {
                                    nRobotIngresos[1] += 1;
                                }
                                else if (xTipoRobot == "2")
                                {
                                    nRobotIngresos[2] += 1;
                                }
                                BuscarEntradaSalida(xFila, xColumna, ref sFila, ref sColumna);
                                MoverRobot(xFila, xColumna, sFila, sColumna, xTipoRobot, xTipoMaterial);
                                MessageBox.Show("Material: " + Nombre_Material(xTipoMaterial) + "  Fila: " + xFila + " Columna: " + xColumna + " SOBREPASA Capacidad en ESTANTERIA");
                                SacarRobot(valorAnteriorDelPasoRobot);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Material: " + Nombre_Material(xTipoMaterial) + " Fila: " + xFila + " Columna: " + xColumna + " NO es IGUAL en ESTANTERIA");
                        }

                    }
                    else if (xTipoMovimiento == "A")
                    {                        
                        int xDisponibilidad = 0;
                        BuscarDisponibilidad(xTipoMaterial, 0, ref xDisponibilidad);                        
                        if (xCantidadMaterial <= xDisponibilidad)
                        {
                            int i = 0;                            
                            while ((xDisponibilidad > 0) && (i < CantidadFilas))
                            {
                                int j = 0;
                                while ((xDisponibilidad > 0) && (j < CantidadColumnas))
                                {
                                    if (nTablero[i, j] == xTipoMaterial)
                                    {
                                        int Pendiente = 0;
                                        if (xCantidadMaterial <= nDisponibles[i, j])
                                        {
                                            Pendiente = xCantidadMaterial;                                        
                                        }
                                        else
                                        {
                                            Pendiente = nDisponibles[i, j];
                                        }
                                        
                                        int Repetir = 0;
                                        while (Pendiente > 0)
                                        {
                                            if (Pendiente >= 7)
                                            {
                                                Repetir = Pendiente / 7;
                                                for (int n = 0; n < Repetir; n++)
                                                {
                                                    int sFila = 0;
                                                    int sColumna = 0;
                                                    nRobotIngresos[1] += 1;
                                                    BuscarEntradaSalida(i, j, ref sFila, ref sColumna);
                                                    MoverRobot(i, j, sFila, sColumna, "2", xTipoMaterial);
                                                    SacarRobot(valorAnteriorDelPasoRobot);                                                    
                                                }
                                                nExistencias[i, j] += Repetir * 7;
                                                nIngresos[i, j] += Repetir * 7;
                                                nDisponibles[i, j] -= Repetir *  7;
                                                xCantidadMaterial -= Repetir * 7;
                                                Pendiente %= 7;
                                            }
                                            else if (Pendiente >= 5)
                                            {
                                                Repetir = Pendiente / 5;
                                                for (int n = 0; n < Repetir; n++)
                                                {
                                                    int sFila = 0;
                                                    int sColumna = 0;
                                                    nRobotIngresos[2] += 1;
                                                    BuscarEntradaSalida(i, j, ref sFila, ref sColumna);
                                                    MoverRobot(i, j, sFila, sColumna, "3", xTipoMaterial);
                                                    SacarRobot(valorAnteriorDelPasoRobot);                                                    
                                                }
                                                nExistencias[i, j] += Repetir * 5;
                                                nIngresos[i, j] += Repetir * 5;
                                                nDisponibles[i, j] -= Repetir * 5;
                                                xCantidadMaterial -= Repetir * 5;
                                                Pendiente %= 5;
                                            }
                                            else if (Pendiente >= 3)
                                            {
                                                Repetir = Pendiente / 3;
                                                for (int n = 0; n < Repetir; n++)
                                                {
                                                    int sFila = 0;
                                                    int sColumna = 0;
                                                    nRobotIngresos[0] += 1;
                                                    BuscarEntradaSalida(i, j, ref sFila, ref sColumna);
                                                    MoverRobot(i, j, sFila, sColumna, "1", xTipoMaterial);
                                                    SacarRobot(valorAnteriorDelPasoRobot);
                                                }
                                                nExistencias[i, j] += Repetir * 3;
                                                nIngresos[i, j] += Repetir * 3;
                                                nDisponibles[i, j] -= Repetir * 3;
                                                xCantidadMaterial -= Repetir * 3;
                                                Pendiente %= 3;
                                            }
                                            else if (Pendiente < 3)
                                            {
                                                int sFila = 0;
                                                int sColumna = 0;
                                                nRobotIngresos[0] += 1;
                                                BuscarEntradaSalida(i, j, ref sFila, ref sColumna);
                                                MoverRobot(i, j, sFila, sColumna, "1", xTipoMaterial);
                                                SacarRobot(valorAnteriorDelPasoRobot);
                                                nExistencias[i, j] += Pendiente;
                                                nIngresos[i, j] += Pendiente;
                                                nDisponibles[i, j] -= Pendiente;
                                                xCantidadMaterial -= Pendiente;
                                                Pendiente = 0;
                                            }
                                        }                                        
                                    }
                                    j++;

                                }
                                i++;

                                DibujarDataGrid();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("No Existe CAPACIDAD para Almacenar El Material: " + Nombre_Material(xTipoMaterial) + " en las Estanterias");
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede PROCESAR Materiales, NO esta CARGADA La Bodega - SKYNET" + Environment.NewLine +
                                "Por favor Cargue el ARCHVIO de La Bodega - SKYNET");
            }
        }

        private void Btn_SalidaMaterial_Click(object sender, EventArgs e)
        {
            if (Ofd_NombreArchivo.FileName != "")
            {
                
                Frm_SalidaMaterial Salida_Material = new Frm_SalidaMaterial();
                Salida_Material.Pasado += new Frm_SalidaMaterial.pasar(Ejecutar);
                Salida_Material.ShowDialog();

                if (xTipoEvento == 0)
                {
                    if (xTipoMovimiento == "M")
                    {
                        if (xTipoMaterial == nTablero[xFila, xColumna])
                        {
                            int sFila = 0;
                            int sColumna = 0;
                            if (xCantidadMaterial <= nExistencias[xFila, xColumna])
                            {
                                nExistencias[xFila, xColumna] -= xCantidadMaterial;
                                nSalidas[xFila, xColumna] += xCantidadMaterial;
                                nDisponibles[xFila, xColumna] = nMaximos[xFila, xColumna] - nExistencias[xFila, xColumna];
                                if (xTipoRobot == "1")
                                {
                                    nRobotSalidas[0] += 1;
                                }
                                else if (xTipoRobot == "2")
                                {
                                    nRobotSalidas[1] += 1;
                                }
                                else if (xTipoRobot == "2")
                                {
                                    nRobotSalidas[2] += 1;
                                }
                                BuscarEntradaSalida(xFila, xColumna, ref sFila, ref sColumna);
                                MoverRobot(xFila, xColumna, sFila, sColumna, xTipoRobot, xTipoMaterial);
                                MessageBox.Show("Material: " + Nombre_Material(xTipoMaterial) + " Fila: " + xFila + " Columna: " + xColumna + " SALIDA CORRECTA");
                                SacarRobot(valorAnteriorDelPasoRobot);
                            }
                            else
                            {
                                if (xTipoRobot == "1")
                                {
                                    nRobotSalidas[0] += 1;
                                }
                                else if (xTipoRobot == "2")
                                {
                                    nRobotSalidas[1] += 1;
                                }
                                else if (xTipoRobot == "2")
                                {
                                    nRobotSalidas[2] += 1;
                                }
                                BuscarEntradaSalida(xFila, xColumna, ref sFila, ref sColumna);
                                MoverRobot(xFila, xColumna, sFila, sColumna, xTipoRobot, xTipoMaterial);
                                MessageBox.Show("Material: " + Nombre_Material(xTipoMaterial) + " Fila: " + xFila + " Columna: " + xColumna + " EXCEDE Capacidad de SALIDA en ESTANTERIA");
                                SacarRobot(valorAnteriorDelPasoRobot);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Material: " + Nombre_Material(xTipoMaterial) + " Fila: " + xFila + " Columna: " + xColumna + " NO es IGUAL en ESTANTERIA");
                        }
                    }
                    else if (xTipoMovimiento == "A")
                    {
                        int xDisponibilidad = 0;
                        BuscarDisponibilidad(xTipoMaterial, 1, ref xDisponibilidad);
                        if (xCantidadMaterial <= xDisponibilidad)
                        {
                            int i = 0;
                            while (i < CantidadFilas)
                            {
                                int j = 0;
                                while (j < CantidadColumnas)
                                {
                                    if (nTablero[i, j] == xTipoMaterial)
                                    {
                                        int Pendiente = 0;
                                        if (xCantidadMaterial <= nExistencias[i, j])
                                        {
                                            Pendiente = xCantidadMaterial;
                                        }
                                        else
                                        {
                                            Pendiente = nExistencias[i, j];
                                        }

                                        int Repetir = 0;
                                        while (Pendiente > 0)
                                        {
                                            if (Pendiente >= 7)
                                            {
                                                Repetir = Pendiente / 7;
                                                for (int n = 0; n < Repetir; n++)
                                                {
                                                    int sFila = 0;
                                                    int sColumna = 0;
                                                    nRobotSalidas[1] += 1;
                                                    BuscarEntradaSalida(i, j, ref sFila, ref sColumna);
                                                    MoverRobot(i, j, sFila, sColumna, "2", xTipoMaterial);
                                                    SacarRobot(valorAnteriorDelPasoRobot);
                                                }
                                                nExistencias[i, j] -= Repetir * 7;
                                                nSalidas[i, j] += Repetir * 7;                                                
                                                nDisponibles[i, j] += Repetir * 7;
                                                xCantidadMaterial -= Repetir * 7;
                                                Pendiente %= 7;
                                            }
                                            else if (Pendiente >= 5)
                                            {
                                                Repetir = Pendiente / 5;
                                                for (int n = 0; n < Repetir; n++)
                                                {
                                                    int sFila = 0;
                                                    int sColumna = 0;
                                                    nRobotSalidas[2] += 1;
                                                    BuscarEntradaSalida(i, j, ref sFila, ref sColumna);
                                                    MoverRobot(i, j, sFila, sColumna, "3", xTipoMaterial);
                                                    SacarRobot(valorAnteriorDelPasoRobot);
                                                }
                                                nExistencias[i, j] -= Repetir * 5;
                                                nSalidas[i, j] += Repetir * 5;
                                                nDisponibles[i, j] += Repetir * 5;
                                                xCantidadMaterial -= Repetir * 5;
                                                Pendiente %= 5;
                                            }
                                            else if (Pendiente >= 3)
                                            {
                                                Repetir = Pendiente / 3;
                                                for (int n = 0; n < Repetir; n++)
                                                {
                                                    int sFila = 0;
                                                    int sColumna = 0;
                                                    nRobotSalidas[0] += 1;
                                                    BuscarEntradaSalida(i, j, ref sFila, ref sColumna);
                                                    MoverRobot(i, j, sFila, sColumna, "1", xTipoMaterial);
                                                    SacarRobot(valorAnteriorDelPasoRobot);
                                                }
                                                nExistencias[i, j] -= Repetir * 3;
                                                nSalidas[i, j] += Repetir * 3;
                                                nDisponibles[i, j] += Repetir * 3;                                                
                                                xCantidadMaterial -= Repetir * 3;
                                                Pendiente %= 3;
                                            }
                                            else if (Pendiente < 3)
                                            {
                                                int sFila = 0;
                                                int sColumna = 0;
                                                nRobotSalidas[0] += 1;
                                                BuscarEntradaSalida(i, j, ref sFila, ref sColumna);
                                                MoverRobot(i, j, sFila, sColumna, "1", xTipoMaterial);
                                                SacarRobot(valorAnteriorDelPasoRobot);
                                                nExistencias[i, j] -= Pendiente;
                                                nSalidas[i, j] += Pendiente;
                                                nDisponibles[i, j] += Pendiente;                                                
                                                xCantidadMaterial -= Pendiente;
                                                Pendiente = 0;
                                            }
                                        }
                                    }
                                    j++;

                                }
                                i++;

                                DibujarDataGrid();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Existe Material: " + Nombre_Material(xTipoMaterial) + " para RETIRAR en Estanterias");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede PROCESAR Materiales, NO esta CARGADA La Bodega - SKYNET" + Environment.NewLine +
                                "Por favor Cargue el ARCHIVO de La Bodega - SKYNET");
            }
        }

        public void Ejecutar(string TipoMovimiento, string TipoRobot, string TipoMaterial, int UnidadMaterial, int Fila, int Columna, int TipoEvento)
        {
            xTipoMovimiento = TipoMovimiento;
            xTipoRobot = TipoRobot;
            xTipoMaterial = TipoMaterial;
            xCantidadMaterial = UnidadMaterial;
            xFila = Fila;
            xColumna = Columna;
            xTipoEvento = TipoEvento;
        }
        
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
