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
-- Description:	Este sp nos permite obtener un informe de fin de ciclo
-- =============================================
CREATE PROCEDURE [IFC-DC].[spObtenerInformeFinCiclo]
(
	@InformFinCicloId int
)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		* 
	
	FROM 
		[IFC-DC].InformeFinCiclo i
	
	WHERE
		i.InformeFinCicloId = @InformFinCicloId

END
GO
