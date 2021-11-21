CREATE PROCEDURE [dbo].[ProductoLista]
	
AS

BEGIN

	SET NOCOUNT ON

	SELECT
		IdProducto,
		NombreProducto
	FROM
		Producto
END
