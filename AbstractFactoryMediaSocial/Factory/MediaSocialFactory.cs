using AbstractFactoryMediaSocial.Abstract;
using AbstractFactoryMediaSocial.Products;

namespace AbstractFactoryMediaSocial.Factory
{
    public class MediaSocialFactory : AbstractFactory
    {
        public override MediaSocial CreateMediaSocial()
        {
            return new MediaSocialTwitter();
        }
    }
}
