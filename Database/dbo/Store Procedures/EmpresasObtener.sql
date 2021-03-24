CREATE PROCEDURE dbo.EmpresasObtener

AS BEGIN
	SET NOCOUNT ON 

	SELECT 
		IdEmpresa
	,	NombreEmpresa
	,	Estado
	FROM dbo.Empresa

END
