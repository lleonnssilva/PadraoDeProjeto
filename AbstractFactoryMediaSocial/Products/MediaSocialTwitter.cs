namespace AbstractFactoryMediaSocial.Products
{
    public class MediaSocialTwitter : MediaSocial
    {
        public override void Like()
        {
            Console.WriteLine("Curtindo a Publicação da Tesla");

        }

        public override void Post(string title, string body)
        {
            Console.WriteLine(title);
            Console.WriteLine(body + " no Twitter");
        }

    }
}
