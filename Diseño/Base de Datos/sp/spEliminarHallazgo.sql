USE [SSIA2012-1]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Martinez Hernandez, Renzo
-- Create date: 
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [IFC-DC].[spEliminarHallazgo]
(
	@HallazgoId int
) 

AS
BEGIN

	SET NOCOUNT ON;
	
	DELETE FROM 
		Hallazgo
		
	WHERE
		HallazgoId = @HallazgoId	
END