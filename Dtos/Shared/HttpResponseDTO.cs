namespace AuthenticationAPIJWT.Dtos.Shared
{
    public class HttpResponseDTO<T> 
    {
        public int statusCode { get; set; }
        public string message { get; set; }
        public List<T> data { get; set; }

        public HttpResponseDTO(int statusCode, string message, List<T> data = null) { 
            this.statusCode = statusCode;
            this.message = message;
            this.data = data;
        }
    }
}
