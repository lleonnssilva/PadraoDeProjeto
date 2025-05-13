using BuilderMediaSocial.Build;

namespace BuilderMediaSocial
{
    public class Director
    {
        public Director(MediaSocialBuilder builder)
        {
            builder.Post();
            builder.Like();
        }
    }
}
