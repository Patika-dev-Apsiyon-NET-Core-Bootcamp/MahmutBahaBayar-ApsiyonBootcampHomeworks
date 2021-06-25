using AutoMapper;
using RestaurantManagement.Domain.Models;
using RestaurantManagement.WebUI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.WebUI.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Food, FoodDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
            CreateMap<Menu, MenuWithFoodDto>().ReverseMap();
            CreateMap<Menu, MenuWithRestaurant>().ReverseMap();
        }
    }
}
