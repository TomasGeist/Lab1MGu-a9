using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3_infracciones
{
    class SistemaInfracciones
    {
        #region nomenclador de infracciones
        int CODIGO_1_INFRACCION = 1;
        string DESC_1_INFRACCION = "Sin luces bajas, ley 25….";
        int UD_1_INFRACCION = 25;
        //
        int CODIGO_2_INFRACCION = 2;
        string DESC_2_INFRACCION = "alta de Matafuego, ley 2…";
        int UD_2_INFRACCION = 30;
        //
        int CODIGO_3_INFRACCION = 3;
        string DESC_3_INFRACCION = "alta de Matafuego, ley 2…";
        int UD_3_INFRACCION = 30;
        #endregion

        #region atributos generales de sistema
        public double BaseMonetaria { get; private set; }

        public double Recaudacion { get; private set; }

        #endregion

        #region atributos por cada acta
        public int Dni { get; private set; }
        string nombre;
        public double totalAPagar;
        #endregion

        #region atributos por cada infraccion
        int codigoInfraccion;
        string descInfraccion;
        double montoInfraccion;
        #endregion

        #region método del sistema
        public void IniciarSistema(double montoBase)
        {
            this.BaseMonetaria = montoBase;
            this.Recaudacion = 0;
        }
        #endregion

        #region métodos por acta
        public void IniciarActa(int dni, string nombre)
        {
            this.Dni = dni;
            this.nombre = nombre;
            totalAPagar = 0;
        }

        public double RegistrarInfraccion(int codigo)
        {
            switch (codigo)
            {
                case 1:
                    {
                        montoInfraccion = UD_1_INFRACCION * BaseMonetaria;
                    }
                    break;
                case 2:
                    {
                        montoInfraccion = UD_2_INFRACCION * BaseMonetaria;
                    }
                    break;
            }
            totalAPagar += montoInfraccion;
            return montoInfraccion;
        }

        public void FinalizarActa(bool pagaEnElLugar)
        {
            Recaudacion += totalAPagar;
        }
        #endregion

    }
}
