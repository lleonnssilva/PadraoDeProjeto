using BuilderMediaSocial.Products;

namespace BuilderMediaSocial.Build
{
    public abstract class MediaSocialBuilder
    {
        protected MediaSocial _mediaSocial;
        public MediaSocial MediaSocial => _mediaSocial;

        public abstract void Post();
        public abstract void Like();

    }
}
