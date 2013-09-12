using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using UPC.SSIA2013.BL.BE;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.DL.DALC
{
    public class PeriodoDALC
    {
        public List<PeriodoBE> PeriodoListar()
        {
            SSIA2013DataContext objModel = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            List<PeriodoBE> lstPeriodo = new List<PeriodoBE>();
            lstPeriodo= (List<PeriodoBE>)(from periodo in objModel.Periodos 
                         select new PeriodoBE(periodo.PeriodoId,periodo.Descripcion)).ToList();
            return lstPeriodo;
        }
    }
}
