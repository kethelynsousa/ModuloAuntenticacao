using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    public class Conexao
    {
        public static SqlConnection _conn;

        //Melhorando a classe Conexao

        public static SqlConnection MinhaInstancia
        { //a chave da propriedade
            get
            { // chave do método get
              //se não existe conexão.
                if (_conn == null)
                { // chave do if
                    _conn = new SqlConnection(@"Server = Lab206_21; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");
                } // fecha chave do if
                  //retorna a conexão
                return _conn;
            }
        }
    }
}








