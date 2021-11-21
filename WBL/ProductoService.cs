using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;


namespace WBL
{
    public interface IProductoService
    {
        Task<DBEntity> Create(ProductoEntity entity);
        Task<DBEntity> Delete(ProductoEntity entity);
        Task<IEnumerable<ProductoEntity>> Get();
        Task<IEnumerable<ProductoEntity>> Lista();
        Task<ProductoEntity> GetById(ProductoEntity entity);
        Task<DBEntity> Update(ProductoEntity entity);
    }

    public class ProductoService : IProductoService
    {
        private readonly IDataAccess sql;

        public ProductoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Get
        public async Task<IEnumerable<ProductoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ProductoEntity>("ProductoObtener");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Lista
        public async Task<IEnumerable<ProductoEntity>> Lista()
        {
            try
            {
                var result = sql.QueryAsync<ProductoEntity>("ProductoLista");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //GetById
        public async Task<ProductoEntity> GetById(ProductoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ProductoEntity>("ProductoObtener", new { entity.IdProducto });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Create
        public async Task<DBEntity> Create(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ProductoInsertar", new
                {
                    entity.NombreProducto,
                    entity.PrecioProducto
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Update
        public async Task<DBEntity> Update(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ProductoActualizar", new
                {
                    entity.IdProducto,
                    entity.NombreProducto,
                    entity.PrecioProducto
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Delete
        public async Task<DBEntity> Delete(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ProductoEliminar", new
                {
                    entity.IdProducto
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
