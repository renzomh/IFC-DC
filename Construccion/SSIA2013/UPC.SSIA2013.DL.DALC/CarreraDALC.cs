using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.DL.DALC
{
    public class CarreraDALC
    {
        //public Carrera getCarrera(Carrera objCarrera)
        //{
        //    SSIA2013DataContext objModel = null;
        //    Carrera objCarreraNuevo = null;

        //    try
        //    {
        //        objModel = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
        //        objCarreraNuevo = (from objCarreraFrom in objModel.Carreras
        //                           where objCarreraFrom.CarreraId.Equals(objCarrera.CarreraId) && objCarreraFrom.EscuelaId.Equals(objCarrera.EscuelaId)
        //                           select objCarreraFrom).SingleOrDefault();
        //    }
        //    catch
        //    {
        //        objCarreraNuevo = null;
        //    }
        //    finally
        //    {
        //        if (objModel != null)
        //            objModel.Dispose();
        //    }

        //    return objCarreraNuevo;
        //}
        /*
        #region metodosGPPP
        public List<GPPP_CARRERA_LISTARXESCUELAResult> carreraListarXEscuela(int? escuelaId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                List<GPPP_CARRERA_LISTARXESCUELAResult> lst = dc.GPPP_CARRERA_LISTARXESCUELA(escuelaId).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }

        #endregion*/
    }
}
