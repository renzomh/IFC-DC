using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

using UPC.IFCDC.BE;
using UPC.IFCDC.Utilitarios;

using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace UPC.IFCDC.BC
{
    public class AccionMejoraBC
    {
        public AccionMejoraCollectionBE listarAccionesMejora(AccionMejoraBE objAccionMejoraBE)
        {
            AccionMejoraCollectionBE objAccionMejoraCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSListarAccionesMejoraxInformeFinCiclo";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objAccionMejoraBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objAccionMejoraCollectionBE = JsonConvert.DeserializeObject<AccionMejoraCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objAccionMejoraCollectionBE;
        }

        public AccionMejoraCollectionBE listarAccionesPrevias(InformeFinCicloBE objInformeFinCicloBE)
        {
            AccionMejoraCollectionBE objAccionMejoraCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSListarAccionesMejoraPrevia";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objInformeFinCicloBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objAccionMejoraCollectionBE = JsonConvert.DeserializeObject<AccionMejoraCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objAccionMejoraCollectionBE;
        }

        public AccionMejoraCollectionBE eliminarAccionMejora(AccionMejoraBE objAccionMejoraBE)
        {
            AccionMejoraCollectionBE objAccionMejoraCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSEliminarAccionMejora";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objAccionMejoraBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objAccionMejoraCollectionBE = JsonConvert.DeserializeObject<AccionMejoraCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objAccionMejoraCollectionBE;
        }
    }
}
