CREATE PROCEDURE [dbo].[ProductoObtener]
	@IdProducto int = NULL

AS BEGIN
SET NOCOUNT ON

	SELECT
		IdProducto,
		NombreProducto,
		PrecioProducto
	FROM Producto
	WHERE
	(@IdProducto IS NULL OR IdProducto=@IdProducto)
END

GO