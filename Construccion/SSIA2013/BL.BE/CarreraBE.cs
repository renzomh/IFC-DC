using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.SSIA2013.BL.BE
{
    public class CarreraBE
    {
        public CarreraBE(int carreraid,String nombre)
        {
            this.CarreraId = carreraid;
            this.Nombre = nombre;
        }
        
        private int _CarreraId;

        public int CarreraId
        {
            get { return _CarreraId; }
            set { _CarreraId = value; }
        }
        private String _Nombre;

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    }
}
