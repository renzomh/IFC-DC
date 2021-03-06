USE [SSIA2012-1]
GO
/****** Object:  StoredProcedure [dbo].[up.IFCDC_Listar_Cursos_x_Profesor]    Script Date: 09/15/2013 01:33:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Renzo Martinez
-- Create date: 25/06/2013
-- Description:	Este sp nos permite listar los cursos de un profesor
-- =============================================
CREATE PROCEDURE [dbo].[up.IFCDC_Listar_Cursos_x_Profesor]
(
	@ProfesorId varchar(50)
)
AS
BEGIN

	SET NOCOUNT ON;
		
	SELECT c.CursoId, c.Codigo, c.Nombre
	
	FROM
		CoordinadorxCurso cc
		JOIN Persona p ON cc.ProfesorId = p.PersonaId
		JOIN Periodo pe ON pe.PeriodoId = cc.PeriodoId
		JOIN Curso c ON cc.CursoId = c.CursoId
	WHERE
		p.PersonaId = @ProfesorId AND
		pe.EsActual = 1	
END
