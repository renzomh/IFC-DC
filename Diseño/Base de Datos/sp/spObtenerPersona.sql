USE [SSIA2012-1]
GO
/****** Object:  StoredProcedure [IFC-DC].[spObtenerPersona]    Script Date: 09/10/2013 06:47:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Renzo Martinez
-- Create date: 25/06/2013
-- Description:	Este sp nos permite obtener los datos de una persona segun su codigo
-- =============================================
CREATE PROCEDURE [IFC-DC].[spObtenerPersona]
(
	@PersonaId varchar(50)
)
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @numAdministrativos int
	DECLARE @numCoordinadores int

	SET @numAdministrativos = 0
	SET @numCoordinadores = 0

	SELECT @numAdministrativos = COUNT(*) FROM Administrativo a WHERE a.AdministrativoId = @PersonaId
	SELECT @numCoordinadores = COUNT(*) FROM Profesor p JOIN CoordinadorxCurso cc ON p.ProfesorId = cc.ProfesorId WHERE p.ProfesorId = @PersonaId

	IF(@numAdministrativos > 0)
		BEGIN
			SELECT	p.PersonaId, p.Nombres, p.Apellidos, 0 'TipoPersona'
			FROM	Persona p
			WHERE	p.PersonaId = @PersonaId
		END

	ELSE IF(@numCoordinadores > 0)
		BEGIN
			SELECT	p.PersonaId, p.Nombres, p.Apellidos, 1 'TipoPersona'
			FROM	Persona p
			WHERE	p.PersonaId = @PersonaId
		END
	ELSE
		BEGIN
			SELECT	p.PersonaId, p.Nombres, p.Apellidos, -1 'TipoPersona'
			FROM	Persona p
			WHERE	p.PersonaId = @PersonaId
		END	

END