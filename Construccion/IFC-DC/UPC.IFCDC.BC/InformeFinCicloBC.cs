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
    public class InformeFinCicloBC
    {
        public InformeFinCicloBE obtenerInformeFinCicloxId(InformeFinCicloBE informe)
        {
            InformeFinCicloBE objInformeFinCicloBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSObtenerInformeFinCicloxId";
            ServiceHelper objServiceHelper = null;

            try
            {
                objServiceHelper = new ServiceHelper();
                json = objServiceHelper.serializeObjectToJson(informe);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);

                objInformeFinCicloBE = JsonConvert.DeserializeObject<InformeFinCicloBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objInformeFinCicloBE;
        }

        public InformeFinCicloBE obtenerInformeFinCiclo(InformeFinCicloBE informe)
        {
            InformeFinCicloBE objInformeFinCicloBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSObtenerInformeFinCiclo";
            ServiceHelper objServiceHelper = null;

            try
            {
                objServiceHelper = new ServiceHelper();
                json = objServiceHelper.serializeObjectToJson(informe);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);

                objInformeFinCicloBE = JsonConvert.DeserializeObject<InformeFinCicloBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objInformeFinCicloBE;
        }

        public InformeFinCicloBE editarInformeFinCiclo(InformeFinCicloBE informe)
        {
            InformeFinCicloBE objInformeFinCicloBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSEditarInformeFinCiclo";
            ServiceHelper objServiceHelper = null;

            try
            {
                objServiceHelper = new ServiceHelper();
                json = objServiceHelper.serializeObjectToJson(informe);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);

                objInformeFinCicloBE = JsonConvert.DeserializeObject<InformeFinCicloBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objInformeFinCicloBE;
        }
    }
}
