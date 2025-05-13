namespace AbstractFactoryMediaSocial.Products
{
    public class MediaSocialFacebook : MediaSocial
    {
        public override void Like()
        {
            Console.WriteLine("Curtindo a Publicação da Microsft");

        }

        public override void Post(string title, string body)
        {
            Console.WriteLine(title);
            Console.WriteLine(body + " no Facebook");
        }

    }
}
