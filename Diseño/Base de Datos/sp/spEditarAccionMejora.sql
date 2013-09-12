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
-- Description:	Este sp nos permite editar una accion de mejora
-- =============================================
CREATE PROCEDURE [IFC-DC].[spEditarAccionMejora]
(
	@AcccionMejoraId int,
	@Descripcion varchar(250)
)
AS
BEGIN
	 UPDATE 
		[IFC-DC].AccionMejora

	 SET	
		[Descripcion] = @Descripcion

     WHERE
		AccionMejoraId = @AcccionMejoraId
END
GO