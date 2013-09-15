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
    public class PersonaBC
    {
        public PersonaBE obtenerPersona(PersonaBE persona)
        {
            PersonaBE objPersonaBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSObtenerPersona";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(persona);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objPersonaBE = JsonConvert.DeserializeObject<PersonaBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objPersonaBE;
        }
    }
}
