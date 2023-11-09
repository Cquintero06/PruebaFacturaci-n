using FacturaciónTienda.Models;
using System.Data.SqlClient;
using System.Data;

namespace FacturaciónTienda.Data
{
    public class FacturasRepository
    {
        private readonly IConfiguration _configuration;

        public FacturasRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<string> ObtenerRazonesSociales()
        {
            List<string> razonesSociales = new List<string>();

            using (var connection = new SqlConnection(_configuration.GetConnectionString("cadenaSQL")))
            {
                connection.Open();

                using (var command = new SqlCommand("sp_ObtenerRazonSocialClientes", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string razonSocial = reader["RazonSocial"].ToString();
                            razonesSociales.Add(razonSocial);
                        }
                    }
                }
            }

            return razonesSociales;
        }

        public List<CatProductosModel> ObtenerProductos()
        {
            List<CatProductosModel> productos = new List<CatProductosModel>();

            using (var connection = new SqlConnection(_configuration.GetConnectionString("cadenaSQL")))
            {
                connection.Open();

                using (var command = new SqlCommand("sp_ObtenerDatosCatProductos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CatProductosModel producto = new CatProductosModel
                            {
                                NombreProducto = reader["NombreProducto"].ToString(),
                                ImagenProducto = (byte[])reader["ImagenProducto"],
                                PrecioUnitario = (decimal)reader["PrecioUnitario"]
                            };
                            productos.Add(producto);
                        }
                    }
                }
            }

            return productos;
        }

        public List<TblFacturasModel> Busqueda(string tipoBusqueda, string criterio)
        {
            List<TblFacturasModel> facturasList = new List<TblFacturasModel>();

            using (var connection = new SqlConnection(_configuration.GetConnectionString("cadenaSQL")))
            {
                connection.Open();

                using (var command = new SqlCommand("sp_BusquedaFacturas", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TblFacturasModel facturasLista = new TblFacturasModel
                            {
                                NumeroFactura = Convert.ToInt32(reader["NumeroFactura"]),
                                FechaEmisionFactura = Convert.ToDateTime(reader["FechaEmisionFactura"]),
                                TotalFactura = Convert.ToDecimal(reader["TotalFactura"]),

                            };
                            facturasList.Add(facturasLista);
                        }
                    }
                }
            }

            return facturasList;
        }

        //public bool GuardarFactura(FacturasViewModel viewModel)
        //{
        //    try
        //    {
        //        using (var connection = new SqlConnection(_configuration.GetConnectionString("cadenaSQL")))
        //        {
        //            connection.Open();
        //            using (var command = new SqlCommand("sp_GuardarProductos", connection))
        //            {
        //                command.CommandType = CommandType.StoredProcedure;

        //                // Usar el primer elemento de la lista (índice 0)
        //                command.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.NVarChar) { Value = viewModel.GuardarRequests[0].RazonSocial });
        //                command.Parameters.Add(new SqlParameter("@NumeroFactura", SqlDbType.Int) { Value = viewModel.GuardarRequests[0].NumeroFactura });
        //                command.Parameters.Add(new SqlParameter("@NombreProducto", SqlDbType.NVarChar) { Value = viewModel.GuardarRequests[0].NombreProducto });
        //                command.Parameters.Add(new SqlParameter("@PrecioUnitario", SqlDbType.Decimal) { Value = viewModel.GuardarRequests[0].PrecioUnitario });
        //                command.Parameters.Add(new SqlParameter("@CantidadDeProducto", SqlDbType.Int) { Value = viewModel.GuardarRequests[0].CantidadDeProducto });
        //                command.Parameters.Add(new SqlParameter("@ImagenProducto", SqlDbType.VarBinary) { Value = viewModel.GuardarRequests[0].ImagenProducto });
        //                command.Parameters.Add(new SqlParameter("@SubtotalProducto", SqlDbType.Decimal) { Value = viewModel.GuardarRequests[0].SubtotalProducto });
        //                command.Parameters.Add(new SqlParameter("@SubTotalFactura", SqlDbType.Decimal) { Value = viewModel.GuardarRequests[0].SubTotalFactura });
        //                command.Parameters.Add(new SqlParameter("@TotalImpuesto", SqlDbType.Decimal) { Value = viewModel.GuardarRequests[0].TotalImpuesto });
        //                command.Parameters.Add(new SqlParameter("@TotalFactura", SqlDbType.Decimal) { Value = viewModel.GuardarRequests[0].TotalFactura });


        //                command.ExecuteNonQuery();
        //            }
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
    }
}
