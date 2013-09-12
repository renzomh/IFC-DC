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
-- Description:	Este sp nos permite registrar un nuevo Informe de Fin de Ciclo
-- =============================================
CREATE PROCEDURE [IFC-DC].[spRegistrarInformeFinCiclo]
(
	@ProfesorId varchar(50),
	@CursoId int,
	@PeriodoId int,
	@ComentarioInfraestructura varchar(250),
	@ComentarioAlumnos varchar(250),
	@CalificacionDelegado int,
	@ComentarioDelegado varchar(250)
)
AS
BEGIN
	INSERT INTO [IFC-DC].InformeFinCiclo
           ([ProfesorId]
           ,[CursoId]
           ,[PeriodoId]
           ,[ComentarioInfraestructura]
           ,[ComentarioAlumnos]
           ,[CalificacionDelegado]
           ,[ComentarioDelegado]
           ,[FechaIngreso])
     VALUES
           (@ProfesorId
           ,@CursoId
           ,@PeriodoId
           ,@ComentarioInfraestructura
           ,@ComentarioAlumnos
           ,@CalificacionDelegado
           ,@ComentarioDelegado
           ,GETDATE())
     
     return @@identity
END
GO
