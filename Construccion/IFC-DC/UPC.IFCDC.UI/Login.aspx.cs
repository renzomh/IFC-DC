using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UPC.IFCDC.BC;
using UPC.IFCDC.BE;
using UPC.IFCDC.Utilitarios;

namespace UPC.IFCDC.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String sUsuario = null;
        PersonaBC objPersonaBC = null;
        PersonaBE objPersonaBE = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresar_Click(object sender, EventArgs e)
        {
            sUsuario = texto_usuario.Text.ToString().Trim();

            objPersonaBC = new PersonaBC();
            objPersonaBE = new PersonaBE();

            objPersonaBE.PersonaId = sUsuario;
            objPersonaBE = objPersonaBC.obtenerPersona(objPersonaBE);

            if (objPersonaBE.PersonaId != null)
            {
                Session["PersonaId"] = objPersonaBE.PersonaId;
                Session["NombreCompletoPersona"] = objPersonaBE.Apellidos + ", " + objPersonaBE.Nombres;

                switch (objPersonaBE.TipoPersona)
                {
                    //ADMINISTRATIVO
                    case 0: break;

                    //COORDINADOR
                    case 1:
                        Response.Redirect("CursosxCoordinador.aspx");
                        break;

                    //NO PERMITIDO
                    default: break;
                }
            }
        }
    }
}