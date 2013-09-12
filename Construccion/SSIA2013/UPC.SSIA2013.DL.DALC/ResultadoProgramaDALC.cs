using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.DL.DALC
{
    public class ResultadoProgramaDALC
    {
        public List<up_IFCDC_Listar_ResultadoPrograma_x_CursoResult> listarResultadoProgramaxCurso(int cursoId)
        {
            SSIA2013DataContext dataContext = null;
            
            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<up_IFCDC_Listar_ResultadoPrograma_x_CursoResult> lstResultadoProgramas = dataContext.up_IFCDC_Listar_ResultadoPrograma_x_Curso(cursoId).ToList();
                
                return lstResultadoProgramas;
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
            
            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }
    }
}
