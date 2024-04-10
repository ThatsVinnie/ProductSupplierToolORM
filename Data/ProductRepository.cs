using Domain;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace Data
{
    public class ProductRepository
    {
        // Método para recuperar a connection string com o banco MYSQL
        private static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.AppSettings["MySqlConnection"];
            return connectionString;
        }

        // métodos CRUD
        public static bool Create(Product product)
        {
            using(var connect = new MySqlConnection(GetConnectionString()))
            {
                string query = "INSERT INTO product (_name, descr, price, quantity, id_supplier) VALUES (@name, @descr, @price, @qtde, @idSup)";

                var command = new MySqlCommand(query, connect);

                // Adiciona os parâmetros do produto à consulta para prevenir injeção de SQL
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@descr", product.Description);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@qtde", product.Quantity);
                command.Parameters.AddWithValue("@idSup", product.IdSupplier);

                try
                {
                    connect.Open(); // Abrindo a conexão com o banco de dados

                    command.ExecuteNonQuery();

                    return true;

                }catch (Exception ex)
                {
                    return false;
                }
                finally
                { 
                    connect.Close(); // Fechando a conexão com o banco de dados
                }
            }
        }

        public static DataTable Read() 
        {
            using(var connect = new MySqlConnection(GetConnectionString()))
            {
                // Consulta utilizando de JOIN para poder recuperar não o ID de associação, mas sim o nome do fornecedor associado
                string query = @"
                        SELECT p.*, s._name as supplier_name 
                        FROM product p 
                        JOIN supplier s ON p.id_supplier = s.id";

                var command = new MySqlCommand(query, connect);
                var adapter = new MySqlDataAdapter(command); // Definição de um novo MYSQLAdapter para poder preencher os dados em uma tabela
                var datatable = new DataTable(); // Declaração da datatable que servirá de base para os registros

                try
                {
                    connect.Open();

                    adapter.Fill(datatable); // Recuperando valores para preencher a datatable

                    return datatable;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally 
                { 
                    connect.Close(); 
                }
            }
        }

        public static bool Update(Product product, int _idProduct)
        {
            using(var connect = new MySqlConnection(GetConnectionString()))
            {
                string query = "UPDATE product SET _name=@name, descr=@descr, price=@price, quantity=@qtde, id_supplier=@newSupId WHERE id=@idProduct";
                var command = new MySqlCommand(query, connect);

                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@descr", product.Description);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@qtde", product.Quantity);
                command.Parameters.AddWithValue("@newSupId", product.IdSupplier);
                command.Parameters.AddWithValue("@idProduct", _idProduct);

                try
                {
                    connect.Open();

                    command.ExecuteNonQuery ();

                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public static bool Delete(int _idProduct)
        {
            using(var connect = new MySqlConnection(GetConnectionString()))
            {
                string query = "DELETE FROM product WHERE id=@idProduct";

                var command = new MySqlCommand(query, connect);

                command.Parameters.AddWithValue("@idProduct", _idProduct);

                try
                {
                    connect.Open();
                    command.ExecuteNonQuery ();
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                { 
                    connect.Close();
                }
            }
        }
    }
}
