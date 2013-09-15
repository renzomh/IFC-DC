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
    public class LogroBC
    {
        public LogroBE obtenerLogroxCurso(LogroBE logro)
        {
            LogroBE objLogroBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSObtenerLogroxCurso";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(logro);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objLogroBE = JsonConvert.DeserializeObject<LogroBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objLogroBE;
        }
    }
}
