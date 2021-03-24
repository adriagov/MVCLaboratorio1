CREATE PROCEDURE [dbo].[EmpresaInsertar]
	@NombreEmpresa VARCHAR(50)
,	@Estado BIT
AS BEGIN
SET NOCOUNT ON
	--Modificar
	BEGIN TRANSACTION TRANSA

	BEGIN TRY

	INSERT INTO dbo.Empresa
	(
		NombreEmpresa
	,	Estado
	)
	VALUES
	(
		@NombreEmpresa
	,	@Estado
	)
	COMMIT TRANSACTION TRANSA

	SELECT 0 AS CodeError, '' AS MsgError 

	END TRY

	BEGIN CATCH
				SELECT
						ERROR_NUMBER() AS CodeError
					,	ERROR_MESSAGE() AS MsgError
		ROLLBACK TRANSACTION TRANSA 

END CATCH

END