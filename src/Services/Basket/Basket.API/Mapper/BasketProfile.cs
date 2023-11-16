using AutoMapper;
using Basket.API.Entities;
using EventBus.Messages.Events;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Basket.API.Mapper
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}