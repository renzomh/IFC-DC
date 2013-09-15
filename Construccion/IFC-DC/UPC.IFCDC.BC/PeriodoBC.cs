using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.IFCDC.BE;
using UPC.IFCDC.Utilitarios;

using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace UPC.IFCDC.BC
{
    public class PeriodoBC
    {
        public PeriodoBE obtenerPeriodoActual()
        {
            PeriodoBE objPeriodoBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSObtenerPeriodoActual";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(null);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objPeriodoBE = JsonConvert.DeserializeObject<PeriodoBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objPeriodoBE;
        }
    }
}
