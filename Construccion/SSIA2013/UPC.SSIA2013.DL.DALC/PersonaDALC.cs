using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;
using UPC.SSIA2013.DL.DataModel;


namespace UPC.SSIA2013.DL.DALC
{
    public class PersonaDALC
    {
        public up_IFCDC_Obtener_PersonaResult obtenerPersona(String personaId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["CSSSIA2013"].ToString());
                up_IFCDC_Obtener_PersonaResult persona = dataContext.up_IFCDC_Obtener_Persona(personaId).SingleOrDefault();

                return persona;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }
    }
}
