/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [IFCDCadmin]    Script Date: 09/28/2013 00:17:07 ******/
CREATE LOGIN [IFCDCadmin] WITH PASSWORD=N'2t§iJUnò%8Ê®Ý¾vÂqbê½·Ç', DEFAULT_DATABASE=[IFCDC-SSIA2013], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

ALTER LOGIN [IFCDCadmin] DISABLE
GO


