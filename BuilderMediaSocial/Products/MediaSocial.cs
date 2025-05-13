namespace BuilderMediaSocial.Products
{
    public class MediaSocial
    {
        private readonly string _nomeRedeSocial;
        private readonly ConsoleColor _color;
        public MediaSocial(string nomeRedeSocial, ConsoleColor color)
        {
            _nomeRedeSocial = nomeRedeSocial;
            _color = color;
        }

        public void Post(string title, string body)
        {
            Console.ForegroundColor = _color;
            Console.WriteLine(this._nomeRedeSocial);
            Console.WriteLine(title);
            Console.WriteLine(body);
           
        }
        public void Like(string publicacao)
        {
            Console.WriteLine($"A publicação {this._nomeRedeSocial} foi curtida na {this._nomeRedeSocial}");
            Console.ResetColor();
        }
    }
}
