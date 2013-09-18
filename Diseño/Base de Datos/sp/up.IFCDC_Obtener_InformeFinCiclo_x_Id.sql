USE [SSIA2012-1]
GO
/****** Object:  StoredProcedure [dbo].[up.IFCDC_Obtener_InformeFinCiclo]    Script Date: 09/18/2013 02:56:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Renzo Martinez
-- Create date: 25/06/2013
-- Description:	Este sp nos permite registrar u obtener un nuevo Informe de Fin de Ciclo x ID
-- =============================================
CREATE PROCEDURE [dbo].[up.IFCDC_Obtener_InformeFinCiclo_x_Id]
(
	@InformeFinCicloId int
)
AS
BEGIN
	SELECT	i.InformeFinCicloId, i.CoordinadorId, i.CursoId, i.PeriodoId, i.DesarrolloUnidades, i.ComentarioAlumnos, i.ComentarioInfraestructura,
			i.ComentarioDelegados, i.ComentarioEscuesta, i.Estado, CONVERT(varchar,i.UltimaActualizacion,103) AS UltimaActualizacion
	FROM	[IFCDC].InformeFinCiclo i
	WHERE	i.InformeFinCicloId = @InformeFinCicloId
END
