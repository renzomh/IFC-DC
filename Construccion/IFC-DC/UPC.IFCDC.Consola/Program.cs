using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.IFCDC.BC;
using UPC.IFCDC.BE;

namespace UPC.IFCDC.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            obtenerPeriodoActual();
            //obtenerPersona();
            //obtenerLogroCurso();
            //obtenerInformeFinCiclo();
            //listarCursosxProfesor();
            //listarResultadoProgramaxCurso();
        }

        static void obtenerPeriodoActual()
        {
            PeriodoBC objPeriodoBC = null;
            PeriodoBE objPeriodoBE = null;

            try
            {
                Console.WriteLine("SERVICIO: Obtener Periodo Actual");

                objPeriodoBC = new PeriodoBC();
                objPeriodoBE = objPeriodoBC.obtenerPeriodoActual();

                Console.WriteLine("\nSALIDA:");
                Console.WriteLine("- PeriodoId: " + objPeriodoBE.PeriodoId);
                Console.WriteLine("- Descripcion: " + objPeriodoBE.Descripcion);
                Console.WriteLine("- FechaInicio: " + objPeriodoBE.FechaInicio);
                Console.WriteLine("- FechaFin: " + objPeriodoBE.FechaFin);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void obtenerPersona()
        {
            PersonaBC objPersonaBC = null;
            PersonaBE objPersonaBE = null;

            try
            {
                Console.WriteLine("SERVICIO: Obtener Persona");

                objPersonaBC = new PersonaBC();
                objPersonaBE = new PersonaBE();

                Console.WriteLine("\nENTRADA:");
                Console.WriteLine("PersonaId:");
                objPersonaBE.PersonaId = Console.ReadLine();

                objPersonaBE = objPersonaBC.obtenerPersona(objPersonaBE);

                Console.WriteLine("\nSALIDA:");
                Console.WriteLine("- PersonaId: " + objPersonaBE.PersonaId);
                Console.WriteLine("- Nombres: " + objPersonaBE.Nombres);
                Console.WriteLine("- Apellidos: " + objPersonaBE.Apellidos);
                Console.WriteLine("- TipoPersona: " + objPersonaBE.TipoPersona);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void obtenerLogroCurso()
        {
            LogroBC objLogroBC = null;
            LogroBE objLogroBE = null;

            try
            {
                Console.WriteLine("SERVICIO: Obtener Logro Terminal de Curso");

                objLogroBC = new LogroBC();
                objLogroBE = new LogroBE();

                Console.WriteLine("\nENTRADA:");
                Console.WriteLine("CursoId:");
                objLogroBE.CursoId = Convert.ToInt32(Console.ReadLine());

                objLogroBE = objLogroBC.obtenerLogroxCurso(objLogroBE);

                Console.WriteLine("\nSALIDA:");
                Console.WriteLine("- LogroId: " + objLogroBE.LogroId);
                Console.WriteLine("- CursoId: " + objLogroBE.CursoId);
                Console.WriteLine("- Descripcion: " + objLogroBE.Descripcion);
                Console.WriteLine("- Estado: " + objLogroBE.Estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void obtenerInformeFinCiclo()
        {
            InformeFinCicloBC objInformeFinCicloBC = null;
            InformeFinCicloBE objInformeFinCicloBE = null;

            try
            {
                Console.WriteLine("SERVICIO: Obtener Informe");

                objInformeFinCicloBC = new InformeFinCicloBC();
                objInformeFinCicloBE = new InformeFinCicloBE();

                Console.WriteLine("\nENTRADA:");
                Console.WriteLine("CoordinadorId:"); objInformeFinCicloBE.CoordinadorId = Console.ReadLine();
                Console.WriteLine("CursoId:"); objInformeFinCicloBE.CursoId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PeriodoId:"); objInformeFinCicloBE.PeriodoId = Convert.ToInt32(Console.ReadLine());

                objInformeFinCicloBE = objInformeFinCicloBC.obtenerInformeFinCiclo(objInformeFinCicloBE);

                Console.WriteLine("\nSALIDA:");
                Console.WriteLine("- InformeFinCicloId: " + objInformeFinCicloBE.InformeFinCicloId);
                Console.WriteLine("- CoordinadorId: " + objInformeFinCicloBE.CoordinadorId);
                Console.WriteLine("- CursoId: " + objInformeFinCicloBE.CursoId);
                Console.WriteLine("- PeriodoId: " + objInformeFinCicloBE.PeriodoId);
                Console.WriteLine("- DesarrolloUnidades: " + objInformeFinCicloBE.DesarrolloUnidades);
                Console.WriteLine("- ComentarioInfraestructura: " + objInformeFinCicloBE.ComentarioInfraestructura);
                Console.WriteLine("- ComentarioAlumnos: " + objInformeFinCicloBE.ComentarioAlumnos);
                Console.WriteLine("- ComentarioDelegados: " + objInformeFinCicloBE.ComentarioDelegados);
                Console.WriteLine("- ComentarioEncuesta: " + objInformeFinCicloBE.ComentarioEncuesta);
                Console.WriteLine("- Estado: " + objInformeFinCicloBE.Estado);
                Console.WriteLine("- UltimaActualizacion: " + objInformeFinCicloBE.UltimaActualizacion);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void listarCursosxProfesor()
        {
            CursoxProfesorBC objCursoxProfesorBC = null;
            CursoxProfesorCollectionBE objCursoxProfesorCollectionBE = null;
            CursoxProfesorBE objCursoxProfesorBE = null;

            try
            {
                Console.WriteLine("SERVICIO: Listar Cursos por Profesor");

                objCursoxProfesorBC = new CursoxProfesorBC();
                objCursoxProfesorBE = new CursoxProfesorBE();

                Console.WriteLine("\nENTRADA:");
                Console.WriteLine("ProfesorId:"); objCursoxProfesorBE.ProfesorId = Console.ReadLine();

                objCursoxProfesorCollectionBE = objCursoxProfesorBC.listarCursosxProfesor(objCursoxProfesorBE);

                if (objCursoxProfesorCollectionBE != null)
                {
                    Console.WriteLine("\nSALIDA:");

                    for (int i = 0; i < objCursoxProfesorCollectionBE.LstCursosxProfesor.Count; i++)
                    {
                        Console.WriteLine("\n- CursoId: " + objCursoxProfesorCollectionBE.LstCursosxProfesor[i].CursoId);
                        Console.WriteLine("- Codigo: " + objCursoxProfesorCollectionBE.LstCursosxProfesor[i].Codigo);
                        Console.WriteLine("- Nombre: " + objCursoxProfesorCollectionBE.LstCursosxProfesor[i].Nombre);
                        Console.WriteLine("- ProfesorId: " + objCursoxProfesorCollectionBE.LstCursosxProfesor[i].ProfesorId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void listarResultadoProgramaxCurso()
        {
            ResultadoProgramaxCursoBC objResultadoProgramaxCursoBC = null;
            ResultadoProgramaxCursoCollectionBE objResultadoProgramaxCursoCollectionBE = null;
            ResultadoProgramaxCursoBE objResultadoProgramaxCursoBE = null;

            try
            {
                Console.WriteLine("SERVICIO: Listar Resultado Programa por Curso");

                objResultadoProgramaxCursoBC = new ResultadoProgramaxCursoBC();
                objResultadoProgramaxCursoBE = new ResultadoProgramaxCursoBE();

                Console.WriteLine("\nENTRADA:");
                Console.WriteLine("CursoId:"); objResultadoProgramaxCursoBE.CursoId = Convert.ToInt32(Console.ReadLine());

                objResultadoProgramaxCursoCollectionBE = objResultadoProgramaxCursoBC.listarResultadoProgramaxCurso(objResultadoProgramaxCursoBE);

                if (objResultadoProgramaxCursoCollectionBE != null)
                {
                    Console.WriteLine("\nSALIDA:");

                    for (int i = 0; i < objResultadoProgramaxCursoCollectionBE.LstResultadoProgramaxCurso.Count; i++)
                    {
                        Console.WriteLine("\n- ResultadoProgramaId: " + objResultadoProgramaxCursoCollectionBE.LstResultadoProgramaxCurso[i].ResultadoProgramaId);
                        Console.WriteLine("- CarreraId: " + objResultadoProgramaxCursoCollectionBE.LstResultadoProgramaxCurso[i].CarreraId);
                        Console.WriteLine("- Outcome: " + objResultadoProgramaxCursoCollectionBE.LstResultadoProgramaxCurso[i].Outcome);
                        Console.WriteLine("- Descripcion: " + objResultadoProgramaxCursoCollectionBE.LstResultadoProgramaxCurso[i].Descricpion);
                        Console.WriteLine("- CursoId: " + objResultadoProgramaxCursoCollectionBE.LstResultadoProgramaxCurso[i].CursoId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
