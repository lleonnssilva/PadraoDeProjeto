using AbstractFactoryMediaSocial.Abstract;
using AbstractFactoryMediaSocial.Factory;

AbstractFactory factory = new MediaSocialFactory();
var mediaSocial = factory.CreateMediaSocial();
mediaSocial.Post("Minha Publicação", "Minha primeira publicação no");
mediaSocial.Like();