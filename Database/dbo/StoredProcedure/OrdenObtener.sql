CREATE PROCEDURE [dbo].[OrdenObtener]
	@IdOrden int = NULL

AS BEGIN
SET NOCOUNT ON

	SELECT
		O.IdOrden,
		O.CantidadProducto,
		O.Estado,
		O.IdProducto,
		
		P.NombreProducto
	FROM Orden O
	LEFT JOIN Producto P
	ON O.IdProducto = P.IdProducto
	WHERE 
	(@IdOrden IS NULL OR IdOrden = @IdOrden)

END


GO