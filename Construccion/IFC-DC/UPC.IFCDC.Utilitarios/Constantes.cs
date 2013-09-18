using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.IFCDC.Utilitarios
{
    public class Constantes
    {
        #region CONSTANTE DEL PROYECTO IFC-DC

        public const String ESTADO_INFORME_NOREALIZADO = "NO REALIZADO";
        public const String ESTADO_INFORME_ENPROCESO = "EN PROCESO";
        public const String ESTADO_INFORME_FINALIZADO = "IMPLEMENTADO";

        #endregion

        #region Formatos

        public const string WM_FORMATO_HORA = "hh:mm am/pm";
        public const char SPL_DOS_PUNTOS = ':';
        public const string PM = "p.m.";
        public const string PM_EDICION = "PM";

        public const string FALTA_FECHA = "Seleccione Fecha";
        public const string FALTA_LUGAR = "Seleccione el Lugar";
        public const string FALTA_HORA = "Ingrese la Hora";

        public const string FALTA_USUARIO = "Ingrese un Usuario";
        public const string FALTA_CODIGO = "Ingrese un Codigo";
        public const string FALTA_APELLIDOS = "Ingrese un Apellido";
        public const string FALTA_EMAIL = "Ingrese un Correo Electronico";
        public const string FALTA_CLAVE_FIRMA = "Ingrese una clave para la firma";
        public const string FALTA_NOMBRE = "Ingrese un Nombre";
        public const string FALTA_DESCRIPCION = "Ingrese una Descripcion";
        public const string FALTA_NIVEL = "Seleccione un Nivel";
        public const string FALTA_PERMISO = "Seleccione al menos un Permiso";
        public const string EXISTE_NOMBRE_PERFIL = "Ya existe un Perfil con ese nombre";
        public const string EXISTE_CODIGO_PROFESOR = "Ya existe un Profesor con ese codigo";
        public const string EXISTE_NOMBRE_MOTIVO = "Ya existe un Motivo con ese nombre";
        public const string EXISTE_NOMBRE_TIPO_ACUERDO = "Ya existe un Tipo de Acuerdo con ese nombre";
        public const string FALTA_CONTRASEÑA = "Ingrese una Contraseña";
        public const string MENSAJE_GRID_VACIO = "EmptyGridView";

        public const string ADMINISTRADOR = "Administrador";

        public const string DIRECCION_IMAGENES_FIRMAS_SERVIDOR = "DireccionImagenesFirmasServidor";
        public const string DIRECCION_RELATIVA_IMAGENES_FIRMAS_SERVIDOR = "DireccionRelativaImagenesFirmasServidor";

        public const string ESTADO_ACTIVO = "Activo";
        public const string ESTADO_INACTIVO = "Inactivo";

        #endregion

        #region Stored Procedures

        public const string UP_PERFILES_X_PROFESOR_ID = "GCD.up_Perfiles_x_Profesor_Id";
        public const string UP_PERFILES_TODOS_GRILLA = "GCD.up_Perfiles_Todos_Grilla";
        public const string UP_PROFESORES_TODOS_GRILLA = "GCD.up_Profesores_Todos_Grilla";
        public const string UP_PROFESORES_PARAMETROS_GRILLA = "GCD.up_Profesor_Parametros_Grilla";

        public const string UP_INSERTAR_REUNION = "GCD.up_Insertar_Reunion";

        public const string UP_PROFESOR_X_PERFIL_INSERTAR = "GCD.up_Insertar_Profesor_X_Perfil";

        public const string UP_PROFESOR_X_PROFESOR_ID = "GCD.up_Profesor_x_Profesor_Id";

        public const string UP_LISTAR_NIVELES = "GCD.up_Listar_Niveles";

        public const string UP_PERFILES_PARAMETROS_GRILLA = "GCD.up_Perfiles_Parametros_Grilla";

        public const string UP_PERFIL_X_NOMBRE = "GCD.up_Perfil_x_Nombre";
        public const string UP_TIPO_ACUERDO_ACTA_X_NOMBRE = "GCD.up_Tipo_Acuerdo_Acta_x_Nombre";
        public const string UP_MOTIVO_X_NOMBRE = "GCD.up_Motivo_x_Nombre";
        public const string UP_PERFIL_INSERTAR = "GCD.up_Insertar_Perfil";
        public const string UP_PROFESOR_INSERTAR = "GCD.up_Insertar_Profesor";
        public const string UP_PROFESOR_ACTUALIZAR = "GCD.up_Actualizar_Profesor";

        public const string UP_ELIMINAR_PERFILES_PROFESOR = "GCD.up_Eliminar_Perfiles_Profesor";

        public const string UP_PERFIL_X_PERFIL_ID = "GCD.up_Perfil_x_Perfil_Id";

        public const string UP_PERFIL_ACTUALIZAR = "GCD.up_Actualizar_Perfil";

        public const string UP_TIPOACUERDO_TODOS = "GCD.up_TipoAcuerdo_Todos_Grilla";
        public const string UP_TIPOACUERDO_PARAMETROS = "GCD.up_TipoAcuerdo_Parametros_Grilla";
        public const string UP_MOTIVO_TODOS = "GCD.up_Motivos_Todos_Grilla";
        public const string UP_MOTIVO_PARAMETROS = "GCD.up_Motivos_Parametros";

        public const string UP_ACTUALIZAR_TIPO_ACUERDO = "GCD.up_Actualizar_Tipo_Acuerdo";
        public const string UP_INSERTAR_TIPO_ACUERDO = "GCD.up_Insertar_Tipo_Acuerdo";
        public const string UP_ACTUALIZAR_MOTIVO = "GCD.up_Actualizar_Motivo";
        public const string UP_INSERTAR_MOTIVO = "GCD.up_Insertar_Motivo";

        public const string UP_PROFESOR_BUSCAR_NOMBRES = "GCD.up_Profesor_Buscar_Nombres";

        public const string UP_TIPO_ACUERDO_X_ID = "GCD.up_Tipo_Acuerdo_X_Tipo_Acuerdo_Id";
        public const string UP_MOTIVO_X_ID = "GCD.up_Motivo_x_Id";

        public const string UP_REUNION_ACTA_GRILLA_TODOS = "GCD.up_Reunion_Acta_Grilla_Todos";
        public const string UP_REUNION_ACTA_GRILLA_PARAMETROS = "GCD.up_Reunion_Acta_Grilla_Parametros";

        public const string UP_INSERTAR_AGENDAS_X_ACTA = "GCD.up_Insertar_Agendas_X_Acta";

        public const string UP_INSERTAR_PARTICIPANTE_X_ACTA = "GCD.up_Insertar_Participante_Acta";

        public const string UP_REUNION_X_FECHA_PROFESOR_ID = "GCD.up_Reunion_X_Fecha_Profesor_Id";

        public const string UP_REUNION_ACTA_X_ACTA_GUID = "GCD.up_Reunion_Acta_X_Acta_Guid";

        public const string UP_AGENDAS_X_ACTA_GUID = "GCD.up_Agendas_X_Acta_Guid";

        public const string UP_PARTICIPANTE_X_ACTA_GUID_X_TIPO = "GCD.up_Participante_X_Acta_Guid_X_Tipo";

        public const string UP_ACTUALIZAR_REUNION = "GCD.up_Actualizar_Reunion";

        public const string UP_ELIMINAR_AGENDAS_X_ACTA_GUID = "GCD.up_Eliminar_Agendas_X_Acta_Guid";

        public const string UP_ELIMINAR_PARTICIPANTES_X_ACTA_GUID = "GCD.up_Eliminar_Participantes_Acta";

        public const string UP_REUNION_FECHA_PROFESOR_ID_ACTUALIZAR = "GCD.up_Reunion_Fecha_Profesor_Id_Actualizar";


        public const string UP_LISTAR_AREA = "GCD.up_Listar_Area";
        public const string UP_BUSCAR_AREA = "GCD.up_Buscar_Area";
        public const string UP_OBTENER_AREA = "GCD.up_Obtener_Area";
        public const string UP_INSERTAR_AREA = "GCD.up_Insertar_Area";
        public const string UP_ACTUALIZAR_AREA = "GCD.up_Actualizar_Area";

        public const string UP_LISTAR_SUBAREA = "GCD.up_Listar_SubArea";
        public const string UP_BUSCAR_SUBAREA = "GCD.up_Buscar_SubArea";
        public const string UP_OBTENER_SUBAREA = "GCD.up_Obtener_SubArea";
        public const string UP_INSERTAR_SUBAREA = "GCD.up_Insertar_SubArea";
        public const string UP_ACTUALIZAR_SUBAREA = "GCD.up_Actualizar_SubArea";

        public const string UP_LISTAR_PERIODO = "GCD.up_Listar_Periodo";
        public const string UP_OBTENER_PERIODO = "GCD.up_Obtener_Periodo";
        public const string UP_OBTENERACTUAL_PERIODO = "GCD.up_ObtenerActual_Periodo";

        #endregion

        #region ViewStates
        public const string VIEWSTATE_LISTA_PERFILES = "ViewStatePerfiles";
        public const string VIEWSTATE_LISTA_PROFESORES = "ViewStateProfesores";
        public const string VIEWSTATE_LISTA_ACTAS = "ViewStateActas";
        public const string VIEWSTATE_LISTA_ACUERDOS = "ViewStateAcuerdos";
        #endregion

        #region Campos de tablas

        //bit

        public const string BIT_ESTADO = "Estado";
        public const string BIT_ES_TC = "EsTC";
        public const string BIT_ESTADO_AREA = "Estado";
        public const string BIT_ESTADO_SUBAREA = "Estado";
        public const string BIT_ESTADO_PERIODO = "Estado";
        public const string BIT_ESACTUAL_PERIODO = "EsActual";

        //image
        public const string IMG_FIRMA = "Firma";

        //Char
        //de 2
        public const string CH_CODIGO = "Codigo";
        public const string CH_TIPO_PARTICIPANTE = "TipoParticipante";
        

        //Date

        public const string DATE_FECHA_NACIMIENTO = "FechaNacimiento";
        public const string DATE_FECHA_REUNION = "FechaReunion";

        //Time
        public const string TME_HORA_INICIO = "HoraInicio";
        public const string TME_HORA_FIN = "HoraFin";
        
        //Int

        public const string INT_ID_PERFIL = "PerfilId";

        public const string INT_ID_NIVELREUNION = "NivelReunionId";

        public const string INT_TIPO_DOCUMENTO = "TipoDocumento";
        public const string INT_ID_TIPO_ACUERDO = "TipoAcuerdoActaId";
        public const string INT_ID_NIVEL_PARAM = "intIdNivel";
        public const string INT_ID_MOTIVO = "MotivoActaId";
        public const string INT_MIN_USUARIOS = "minUsuarios";
        public const string INT_MAX_USUARIOS = "maxUsuarios";
        public const string INT_ID_AREA = "AreaID";
        public const string INT_PERIODOID_AREA = "PeriodoId";
        public const string INT_ID_SUBAREA = "SubAreaId";
        public const string INT_PERIODOID_SUBAREA = "PeriodoId";

        public const string INT_NUM_USUARIOS = "NumUsuarios";

        public const int CERO_ENTERO = 0;

        public const string INT_ID_PERIODO = "PeriodoID";

        //GUID
        public const string GUID_ACTA = "ActaGuid";

        //SMALLINT
        public const string SMALLINT_ORDEN = "Orden";

        //VarChar
        public const string VCH_PROFESOR_ID = "ProfesorId";
        public const string VCH_PROFESOR_CREACION_ID = "ProfesorCreacionId";
        public const string VCH_ESTADO_PROFESOR = "Estado";

        public const string VCH_OTRO_MOTIVO = "OtroMotivo";

        public const string VCH_NOMBRES = "Nombres";
        public const string VCH_NOMBRE = "Nombre";
        public const string VCH_APELLIDOS = "Apellidos";
        public const string VCH_NRO_DOCUMENTO = "NroDocumento";
        public const string VCH_TELEFONO1 = "Telefono1";
        public const string VCH_TELEFONO2 = "Telefono2";
        public const string VCH_CELULAR = "Celular";
        public const string VCH_CORREO_ELECTRONICO = "CorreoElectronico";
        public const string VCH_CLAVE_FIRMA = "ClaveFirma";
        public const string VCH_APELLIDO_PATERNO = "ApellidoPaterno";
        public const string VCH_APELLIDO_MATERNO = "ApellidoMaterno";
        public const string VCH_EMAIL = "Email";
        public const string VCH_CLAVE = "clave";
        public const string VCH_DESCRIPCION = "Descripcion";
        public const string VCH_CODIGO = "Codigo";
        public const string VCH_FIRMA = "Firma";
        public const string VCH_CODIGO_ACTA = "CodigoActa";
        public const string VCH_MOTIVO_ACTA = "Motivo";

        public const string VCH_NOMBRE_NIVELREUNION = "Nombre";
        public const string VCH_DESCRIPCION_NIVELREUNION = "Descripcion";

        public const string VCH_NIVEL = "Nivel";
        public const string VCH_LUGAR = "Lugar";

        public const string VCH_STR_NOMBRE_PERFIL = "strNombrePerfil";
        public const string VCH_ESTADO_PERFIL = "Estado";
        

        public const string VCH_STR_CODIGO_PROFESOR = "strCodigoProfesor";
        public const string VCH_STR_NOMBRES_PROFESOR = "strNombresProfesor";
        public const string VCH_STR_APELLIDOS_PROFESOR = "strApellidosProfesor";
        public const string VCH_STR_ESTADO_PROFESOR = "strEstadoProfesor";

        public const string VCH_NOMBRE_AREA = "Nombre";
        public const string VCH_DESCRIPCION_AREA = "Descripcion";
        public const string VCH_COORDINADORID_AREA = "CoordinadorId";
        public const string VCH_COORDINADORNOMBRE_AREA = "NombreCompleto";
        public const string VCH_PERIODONOMBRE_AREA = "PeriodoNombre";

        public const string VCH_NOMBRE_SUBAREA = "Nombre";
        public const string VCH_NOMBREAREA_SUBAREA = "NombreArea";
        public const string VCH_DESCRIPCION_SUBAREA = "Descripcion";
        public const string VCH_COORDINADORID_SUBAREA = "CoordinadorId";
        public const string VCH_COORDINADORNOMBRE_SUBAREA = "NombreCompleto";
        public const string VCH_PERIODONOMBRE_SUBAREA = "PeriodoNombre";

        public const string VCH_DESCRIPCION_PERIODO = "Descripcion";
        
        


        #endregion

        #region Parametros iniciales
        public const string SESSION_USUARIO = "Usuario";
        public const string ESTADO_PENDIENTE = "EstadoPendiente";
        public const string ESTADO_ATENDIDO = "EstadoAtendido";
        #endregion

        #region Paginacion
        public const string INT_REGISTROSXPAGINA = "RegistrosxPagina";
        public const string INT_PAGINA = "Pagina";
        public const string TOTAL = "Total";
        public const string ULTIMAPAGINA = "UltimaPagina";
        public const string MSG_PAGINA = "Página ";
        public const string MSG_PAGINA_DE = " de ";
        #endregion

        #region Nombre Formularios

        public const string FRM_ELEGIR_PERFIL = "DireccionElegirPerfil";
        public const string FRM_LOGIN = "DireccionLoginUsuario";
        public const string FRM_DASHBOARD = "DireccionDashboard";
        public const string FRM_MANTENIMIENTO_PERFIL = "DireccionMantenimientoPerfil";
        public const string FRM_BUSQUEDA_PERFIL = "DireccionBusquedaPerfil";
        public const string FRM_BUSQUEDA_PROFESOR = "DireccionBusquedaProfesor";
        public const string FRM_MANTENIMIENTO_PROFESOR = "DireccionMantenimientoProfesor";

        public const string FRM_BUSQUEDA_TIPOS_ACUERDO = "DireccionBusquedaTiposAcuerdos";
        public const string FRM_MANTENIMIENTO_TIPOS_ACUERDO = "DireccionMantenimientoTiposAcuerdos";

        public const string FRM_BUSQUEDA_MOTIVOS = "DireccionBusquedaMotivos";
        public const string FRM_MANTENIMIENTO_MOTIVOS = "DireccionMantenimientoMotivos";

        public const string FRM_REGISTRO_EDICION_REUNION = "DireccionRegistroEdicionReunion";
        public const string FRM_BUSQUEDA_REUNION = "DireccionBusquedaReunion";

        
        public const string FRM_BUSQUEDA_AREA = "DireccionBusquedaArea";
        public const string FRM_MANTENIMIENTO_AREA = "DireccionMantenimientoArea";

        public const string FRM_BUSQUEDA_SUBAREA = "DireccionBusquedaSubArea";
        public const string FRM_MANTENIMIENTO_SUBAREA = "DireccionMantenimientoSubArea";

        #endregion  

        #region Campos de Formularios 

        public const string DVF_IDPERFIL = "IdPerfil";
        public const string DVF_PERFILPOSICIONLISTA = "PosicionEnLista";
        public const string DTF_DESCRIPCION = "Descripcion";
        public const string DVF_CODIGO = "Codigo";
        
        #endregion

        #region Otros
        public const string URL_REFERENCIA = "~/";
        #endregion

        #region Textos
        public const string ESPACIO = " ";
        public const string DDL_SELECCIONE = "<< Seleccione >>";
        public const string STR_CERO = "0";
        #endregion

        #region Regular Expressions

        public const string REGEX_EMAIL = @"^(([^<>()[\]\\.,;:\s@\""]+"
                        + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                        + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                        + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                        + @"[a-zA-Z]{2,}))$";

        #endregion

        #region Javascript

        public const string MENSAJE_ALERT = "alert('{0}');";
        public const string MENSAJE_CONFIRM = "confirm('{0}');";
        //gv
        public const string GV_PARTICIPANTES_ID = "gvParticipantes";

        #endregion
    }
}
