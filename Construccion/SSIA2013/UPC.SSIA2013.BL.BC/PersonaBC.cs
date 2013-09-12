using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DL.DALC;
using UPC.SSIA2013.DL.DataModel;


namespace UPC.SSIA2013.BL.BC
{
    public class PersonaBC
    {
        public up_IFCDC_Obtener_PersonaResult obtenerPersona(String personaId)
        {
            PersonaDALC objPersonaDALC;

            try
            {
                objPersonaDALC = new PersonaDALC();
                return objPersonaDALC.obtenerPersona(personaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
