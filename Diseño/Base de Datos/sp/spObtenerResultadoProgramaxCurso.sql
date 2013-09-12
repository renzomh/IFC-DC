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
-- Description:	Este sp nos permite obtener los Student Outcomes de un curso
-- =============================================
CREATE PROCEDURE [IFC-DC].[spObtenerResultadoProgramaxCurso]
(
	@CursoId int
)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT 
		rp.ResultadoProgramaId,
		rp.CarreraId,
		rp.Outcome,
		rp.Descripcion
	
	FROM
		Curso c,
		ResultadoPrograma rp,
		CursoxResultadoPrograma crp
	
	WHERE
		c.CursoId = @CursoId AND
		crp.CursoId = c.CursoId AND
		crp.ResultadoProgramaId = rp.ResultadoProgramaId	 

END
GO
