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
-- Description:	Este sp nos permite obtener las aciones de mejora por Informe de Fin de Ciclo
-- =============================================
CREATE PROCEDURE [IFC-DC].[spListarAccionesMejoraxHallazgo]
(
	@InformeFinCicloId int
)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		*
	
	FROM 
		[IFC-DC].AccionMejora a
	
	WHERE
		a.InformeFinCicloId = @InformeFinCicloId

END
GO