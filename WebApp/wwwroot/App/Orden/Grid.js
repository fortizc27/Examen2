"use strict";
var OrdenGrid;
(function (OrdenGrid) {
    function OnClickEli(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "d33").then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Eliminando...");
                App.AxiosProvider.OrdenEliminar(id).then(function (data) {
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "Registro eliminado con éxito.", icon: "success" }).then(function () { return window.location.reload(); });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    OrdenGrid.OnClickEli = OnClickEli;
    $("#GridView").DataTable();
})(OrdenGrid || (OrdenGrid = {}));
//# sourceMappingURL=Grid.js.map