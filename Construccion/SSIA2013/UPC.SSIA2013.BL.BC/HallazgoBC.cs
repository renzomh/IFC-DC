using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DL.DALC;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.BL.BC
{
    public class HallazgoBC
    {
        public List<up_IFCDC_Registrar_HallazgoResult> registrarHallazgo(int informeFinCicloId, String descripcion, int periodoId)
        {
            HallazgoDALC objHallazgoDALC;
            
            try
            {
                objHallazgoDALC = new HallazgoDALC();

                return objHallazgoDALC.registrarHallazgo(informeFinCicloId, descripcion, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Listar_Hallazgos_x_InformeFinCicloResult> listarHallazgosxInformeFinCiclo(int informeFinCicloId)
        {
            HallazgoDALC objHallazgoDALC;

            try
            {
                objHallazgoDALC = new HallazgoDALC();
                return objHallazgoDALC.listarHallazgosxInformeFinCiclo(informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Editar_HallazgoResult> editarHallazgo(int hallazgoId, int informeFinCicloId, String descripcion)
        {
            HallazgoDALC objHallazgoDALC;

            try
            {
                objHallazgoDALC = new HallazgoDALC();
                return objHallazgoDALC.editarHallazgo(hallazgoId, informeFinCicloId, descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Eliminar_HallazgoResult> eliminarHallazgo(int hallazgoId, int informeFinCicloId)
        {
            HallazgoDALC objHallazgoDALC;

            try
            {
                objHallazgoDALC = new HallazgoDALC();
                return objHallazgoDALC.eliminarHallazgo(hallazgoId, informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Listar_Reporte_HallazgoResult> listarReporteHallazgo(int cursoId, int periodoId)
        {
            HallazgoDALC objHallazgoDALC;

            try
            {
                objHallazgoDALC = new HallazgoDALC();
                return objHallazgoDALC.listarReporteHallazgo(cursoId, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
