using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using UPC.SSIA2013.BL.BE;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.DL.DALC
{
    public class CarreraDALC
    {
        public List<CarreraBE> CarreraListar()
        {
            SSIA2013DataContext objModel = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            List<CarreraBE> lstCarrera = new List<CarreraBE>();
            lstCarrera = (List<CarreraBE>)(from carrera in objModel.Carreras 
                          where (carrera.CarreraId == 1 || carrera.CarreraId == 2 || carrera.CarreraId == 3) 
                          select new CarreraBE(carrera.CarreraId,carrera.Nombre)).ToList();
            return lstCarrera;
        }
    }
}
