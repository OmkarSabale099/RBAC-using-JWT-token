namespace CRUD_with_JWT_Auht.Model
{
    public class Response<T>
    {
        public T Data { get; set; }
        public string message { get; set; }
        public int code { get; set; }
    }
}
