using System;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace MultApps.Models.Repositories
{
    public class CategoriaRepository
    {
        // String de conexão com o banco de dados MySQL
        public string ConnectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root";

        // Método para cadastrar uma categoria
        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO categoria (nome, status)
                                   VALUES(@Nome, @Status)";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        // Método para atualizar uma categoria
        public bool AtualizarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE categoria
                                   SET nome = @Nome, status = @Status
                                   WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", categoria.Id);
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status);

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }

        // Método para deletar uma categoria
        public bool DeletarCategoria(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM categoria WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        // Método para listar todas as categorias
        public List<Categoria> ListarTodasCategorias()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_criacao AS DataCadastro, data_alteracao AS DataAlteracao, status
                                   FROM categoria";
                var resultado = db.Qy<Categouerria>(comandoSql).ToList();
                return resultado;
            }
        }

        // Método para obter uma categoria por ID
        public Categoria ObterCategoriaPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_criacao, data_alteracao, status
                                   FROM categoria WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Categoria>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }
        }
    }

    // Classe Categoria com as propriedades necessárias
    public class Categoria
    {
        public int Id { get; set; } 
        public string Nome { get; set; } 
        public string Status { get; set; } 
        public DateTime DataCriacao { get; set; } 
        public DateTime DataAlteracao { get; set; } 
    }
}
