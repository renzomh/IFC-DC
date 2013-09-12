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
-- Description:	Este sp nos permite editar un Hallazgo
-- =============================================
CREATE PROCEDURE [IFC-DC].[spEditarHallazgo]
(
	@HallazgoId int,
	@Descripcion varchar(250)
)
AS
BEGIN
	 UPDATE 
		[IFC-DC].Hallazgo

	 SET	
		[Descripcion] = @Descripcion

     WHERE
		HallazgoId = @HallazgoId
END
GO