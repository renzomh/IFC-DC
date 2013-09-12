using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DL.DALC;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.BL.BC
{
    public class CursoBC
    {
        public List<up_IFCDC_Listar_Cursos_x_ProfesorResult> listarCursosxProfesor(string profesorId)
        {
            CursoDALC objCursoDALC;

            try
            {
                objCursoDALC = new CursoDALC();
                return objCursoDALC.listarCursosxProfesor(profesorId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
