namespace ProjetoP.WebApi.Model
{

    public class Jogo
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Desenvolvedora { get; set; }

        public string Publicadora { get; set; }

        public string Genero { get; set; }

        public string Plataforma { get; set; }

        public string SuporteMultijogador { get; set; }
    }
}