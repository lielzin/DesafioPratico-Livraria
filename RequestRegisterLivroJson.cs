namespace MyFirstApi.Communication.Request
{
    public class RequestRegisterLivroJson
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public decimal Preco { get; set; } = 0.0m;
        public int QuantidadeEstoque { get; set; } = 0;


    }
}
