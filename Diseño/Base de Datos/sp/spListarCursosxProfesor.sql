-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Renzo Martinez
-- Create date: 25/06/2013
-- Description:	Este sp nos permite listar los cursos de un profesor
-- =============================================
CREATE PROCEDURE [IFC-DC].[spListarCursosxProfesor]
(
	@ProfesorId varchar(50)
)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT 
		DISTINCT c.CursoId, 
		c.Codigo, 
		c.Nombre,
		psc.ProfesorId
	FROM
		ProfesorxSeccionxCurso psc,
		SeccionxCurso sc,
		Curso c
	WHERE
		psc.ProfesorId = @ProfesorId AND 
		psc.SeccionxCursoId = sc.SeccionxCursoId AND 
		sc.CursoId = c.CursoId	

END
GO