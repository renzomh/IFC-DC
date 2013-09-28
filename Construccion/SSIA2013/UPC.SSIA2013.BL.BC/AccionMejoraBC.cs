using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DL.DALC;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.BL.BC
{
    public class AccionMejoraBC
    {
        public List<up_IFCDC_Registrar_AccionMejoraResult> registrarAccionMejora(int hallazgoId, int informeFinCicloId, int cicloEjecucionId, String descripcion)
        {
            AccionMejoraDALC objAccionMejoraDALC;
            
            try
            {
                objAccionMejoraDALC = new AccionMejoraDALC();
                return objAccionMejoraDALC.registrarAccionMejora(hallazgoId, informeFinCicloId, cicloEjecucionId, descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Listar_AccionMejora_x_InformeFinCicloResult> listarAccionesMejoraxInformeFinCiclo(int informeFinCicloId)
        {
            AccionMejoraDALC objAccionesMejoraDALC;

            try
            {
                objAccionesMejoraDALC = new AccionMejoraDALC();
                return objAccionesMejoraDALC.listarAccionesMejoraxInformeFinCiclo(informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Listar_AccionMejora_PreviasResult> listarAccionesMejoraPrevias(int cursoId, int periodoId)
        {
            AccionMejoraDALC objAccionesMejoraDALC;

            try
            {
                objAccionesMejoraDALC = new AccionMejoraDALC();
                return objAccionesMejoraDALC.listarAccionesMejoraPrevias(cursoId, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Editar_AccionMejoraResult> editarAccionMejora(int accionMejoraId, int informeFinCicloId, int cicloEjecucionId, String descripcion)
        {
            AccionMejoraDALC objAccionMejoraDALC;

            try
            {
                objAccionMejoraDALC = new AccionMejoraDALC();
                return objAccionMejoraDALC.editarAccionMejora(accionMejoraId, informeFinCicloId, cicloEjecucionId, descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Editar_AccionMejora_PreviaResult> editarAccionMejoraPrevia(int cursoId, int periodoId, int accionMejoraId, String estado)
        {
            AccionMejoraDALC objAccionMejoraDALC;

            try
            {
                objAccionMejoraDALC = new AccionMejoraDALC();
                return objAccionMejoraDALC.editarAccionMejoraPrevia(cursoId, periodoId, accionMejoraId, estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Eliminar_AccionMejoraResult> eliminarAccionMejora(int accionMejoraId, int informeFinCicloId)
        {
            AccionMejoraDALC objAccionMejoraDALC;

            try
            {
                objAccionMejoraDALC = new AccionMejoraDALC();
                return objAccionMejoraDALC.eliminarAccionMejora(accionMejoraId, informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
