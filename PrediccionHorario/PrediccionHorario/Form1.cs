using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cg_Cls_LeerConexionW;
using LbrUtilerias;


namespace PrediccionHorario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cg_Cls_LeerConexion conexion = new Cg_Cls_LeerConexion();

 //prueba
            ClsTransacciones Obj_Transacciones = new ClsTransacciones("Provider=Ifxoledbc;Persist Security Info=False;User ID=sirh;Data Source=sacdmnom@hacprdinf;Extended Properties=;Password=s4CdmN0M", "Infiernix");

            string CadenaSQL = " select first 1 * from empleado";

            DataTable tablon = Obj_Transacciones.OdbRegresa_Datos_Tabla(CadenaSQL, "tablonon");
            int a = 1;

        }
    }
}
