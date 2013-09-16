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
    public class CursoxProfesorBC
    {
        public CursoxProfesorCollectionBE listarCursosxProfesor(CursoxProfesorBE cursosxProfesor)
        {
            CursoxProfesorCollectionBE objColeccionCursosxProfesorBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSListarCursosxProfesor";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(cursosxProfesor);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objColeccionCursosxProfesorBE = JsonConvert.DeserializeObject<CursoxProfesorCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objColeccionCursosxProfesorBE;
        }
    }
}
