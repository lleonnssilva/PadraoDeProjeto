using BuilderMediaSocial.Products;

namespace BuilderMediaSocial.Build
{
    public class MediaSocialFacebookBuilder : MediaSocialBuilder
    {
        public MediaSocialFacebookBuilder()
        {
            _mediaSocial = new MediaSocial("Facebook",ConsoleColor.Blue);
        }
        public override void Like()
        {
            _mediaSocial.Like("Publicação da Microsft");
        }

        public override void Post()
        {
            _mediaSocial.Post("Publicação do Facebook", "Minha primeira publicação do Facebook");

        }
    }
}
