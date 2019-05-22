using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;//*****-
namespace capaNegocio
{
    public class Consultas
    {
        bdConex test= new bdConex();
        private String codVendor, nombrePlantilla;
        public DataTable dt = new DataTable();//**
        public String NombreVendor
        {
            get { return nombrePlantilla; }
            set { nombrePlantilla = value; }
        }

        public String CodPlantilla
        {
            get { return codPlantilla; }
            set { codPlantilla = value; }
        }
        //

        public void insertPlantilla()
        {
            try {
            String insert="INSERT INTO PLANTILLA(Plantilla,NOMBRE)VALUES('"+codPlantilla+"','"+nombrePlantilla+"')";
                    test.Conectar();
                    test.consultaSQL(insert);
                    test.Desconectar();         
            }
            catch {
            
            }
        }


        public void updatePlantilla()
        {
            try
            {
                String update = "update Plantilla set NOMBRE='"
                                 + nombrePlantilla + "' where Plantilla='"
                                 +codPlantilla + "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void deletePlantilla()
        {
            try
            {
                String delete = "delete from Plantilla where plantilla='"
                                 + codPlantilla + "'";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {

            }
        }


        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }

        public void mostrarPlantilla()
        {
            try
            {
                String consulta = "select Plantilla as CODPlantilla,NOMBRE as NomPlatilla from [dbo].[Plantilla]";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }
        }




        public object nombrêPlantilla { get; set; }

        public string codPlantilla { get; set; }

        public string nombrePlantilla { get; set; }
    }
}
