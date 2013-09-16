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
    public class ResultadoProgramaxCursoBC
    {
        public ResultadoProgramaxCursoCollectionBE listarResultadoProgramaxCurso(ResultadoProgramaxCursoBE resultadoProgramaxCurso)
        {
            ResultadoProgramaxCursoCollectionBE objCollectionResultadoProgramaxCursoBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSListarResultadoProgramaxCurso";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(resultadoProgramaxCurso);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objCollectionResultadoProgramaxCursoBE = JsonConvert.DeserializeObject<ResultadoProgramaxCursoCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objCollectionResultadoProgramaxCursoBE;
        }
    }
}
