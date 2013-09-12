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
-- Description:	Este sp nos permite obtener los datos de un profesor segun su codigo
-- =============================================
CREATE PROCEDURE [IFC-DC].[spObtenerProfesor]
(
	@ProfesorId varchar(50)
)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		pr.ProfesorId, pr.Codigo, pe.Nombres, pe.Apellidos, pr.EsTC 
	
	FROM 
		Profesor pr,
		Persona pe
	
	WHERE
		pr.ProfesorId = @ProfesorId AND 
		pe.PersonaId = ProfesorId  

END
GO
