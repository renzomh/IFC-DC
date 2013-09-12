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
-- Description:	Este sp nos permite registrar un nueva  Accion de Mejora
-- =============================================
CREATE PROCEDURE [IFC-DC].[spRegistrarAccionMejora]
(
	@HallazgoId int,
	@InformeFinCicloId int,
	@Codigo varchar(20),
	@Descripcion varchar(250)
)
AS
BEGIN
	INSERT INTO [IFC-DC].AccionMejora
           ([HallazgoId]
           ,[InformeFinCicloId]
           ,[Codigo]
           ,[Descripcion])

     VALUES
           (@HallazgoId
		   ,@InformeFinCicloId
           ,@Codigo
           ,@Descripcion)
     
     return @@identity
END
GO