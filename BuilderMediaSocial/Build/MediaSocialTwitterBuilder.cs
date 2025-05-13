using BuilderMediaSocial.Products;

namespace BuilderMediaSocial.Build
{
    public class MediaSocialTwitterBuilder : MediaSocialBuilder
    {
        public MediaSocialTwitterBuilder()
        {
            _mediaSocial = new MediaSocial("Twitter", ConsoleColor.Cyan);
        }
        public override void Like()
        {
            _mediaSocial.Like("Publicação da Tesla");
        }

        public override void Post()
        {
            _mediaSocial.Post("Publicação do Twiter", "Minha primeira publicação do Twitter");

        }
    }

}
