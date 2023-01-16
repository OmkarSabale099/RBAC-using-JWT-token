using CRUD_with_JWT_Auht.Model;
using Dapper;

namespace CRUD_with_JWT_Auht.Repository
{
    public interface IJWTAuthManager
    {
        Response<string> GenerateJWT(User user);
        Response<T> Execute_Command<T>(string query, DynamicParameters sp_params);
        Response<List<T>> getUserList<T>();
    }
}
