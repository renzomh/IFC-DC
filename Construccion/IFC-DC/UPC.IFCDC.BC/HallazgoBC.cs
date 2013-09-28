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
    public class HallazgoBC
    {
        public HallazgoCollectionBE resgistrarHallazgo(HallazgoBE objHallazgoBE)
        {
            HallazgoCollectionBE objHallazgoCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSRegistrarHallazgo";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objHallazgoBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objHallazgoCollectionBE = JsonConvert.DeserializeObject<HallazgoCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objHallazgoCollectionBE;
        }

        public HallazgoCollectionBE listarHallazgos(HallazgoBE objHallazgoBE)
        {
            HallazgoCollectionBE objHallazgoCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSListarHallazgosxInformeFinCiclo";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objHallazgoBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objHallazgoCollectionBE = JsonConvert.DeserializeObject<HallazgoCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objHallazgoCollectionBE;
        }

        public HallazgoCollectionBE editarHallazgo(HallazgoBE objHallazgoBE)
        {
            HallazgoCollectionBE objHallazgoCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSEditarHallazgo";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objHallazgoBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objHallazgoCollectionBE = JsonConvert.DeserializeObject<HallazgoCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objHallazgoCollectionBE;
        }

        public HallazgoCollectionBE eliminarHallazgo(HallazgoBE objHallazgoBE)
        {
            HallazgoCollectionBE objHallazgoCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSEliminarHallazgo";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objHallazgoBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objHallazgoCollectionBE = JsonConvert.DeserializeObject<HallazgoCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objHallazgoCollectionBE;
        }
    }
}
