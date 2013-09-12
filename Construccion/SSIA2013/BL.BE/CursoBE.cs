using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.SSIA2013.BL.BE
{
    public class CursoBE
    {
        public CursoBE()
        { }
        public CursoBE(int cursoid,String nombrecurso,String codigocurso,int creditos,bool escontrol, bool esverificacion)
        {
            this.CursoId = cursoid;
            this.NombreCurso = nombrecurso;
            this.CodigoCurso = codigocurso;
            this.Creditos = creditos;
            this.EsControl = escontrol;
            this.EsVerificacion = esverificacion;
        }
        
        private int _CursoId;

        public int CursoId
        {
            get { return _CursoId; }
            set { _CursoId = value; }
        }
        private String _NombreCurso;

        public String NombreCurso
        {
            get { return _NombreCurso; }
            set { _NombreCurso = value; }
        }
        private String _CodigoCurso;

        public String CodigoCurso
        {
            get { return _CodigoCurso; }
            set { _CodigoCurso = value; }
        }
        private int _Creditos;

        public int Creditos
        {
            get { return _Creditos; }
            set { _Creditos = value; }
        }
        private bool _EsControl;

        public bool EsControl
        {
            get { return _EsControl; }
            set { _EsControl = value; }
        }
        private bool _EsVerificacion;

        public bool EsVerificacion
        {
            get { return _EsVerificacion; }
            set { _EsVerificacion = value; }
        }
    }
}
