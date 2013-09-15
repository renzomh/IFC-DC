using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.IFCDC.BE
{
    public class CursoxProfesorCollectionBE
    {
        private Collection<CursoxProfesorBE> _lstCursosxProfesor;

        public Collection<CursoxProfesorBE> LstCursosxProfesor
        {
            get { return _lstCursosxProfesor; }
            set { _lstCursosxProfesor = value; }
        }
    }
}
