namespace MyFirstApi.Communication.Responses
{
    public class ResponseRegisterLivroJson
    {
        public string Titulo { get; set; } 
        public string Autor { get; set; } 
        public string Genero { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

    }
}
