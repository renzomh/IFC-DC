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
-- Description:	Este sp nos permite obtener el logro terminal de un curso
-- =============================================
CREATE PROCEDURE [IFC-DC].[spObtenerLogroxCurso]
(
	@CursoId int
)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT TOP 1
		l.LogroId,
		c.CursoId,
		l.Descripcion,
		l.Estado
	
	FROM
		Curso c,
		SeccionxCurso sc,
		Logro l
	
	WHERE
		c.CursoId = @CursoId AND
		c.CursoId = sc.CursoId AND 
		sc.SeccionxCursoId = l.SeccionxCursoId	 

END
GO