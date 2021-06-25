using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Application.Interfaces;
using RestaurantManagement.Application.Services;
using RestaurantManagement.Domain.Models;
using RestaurantManagement.WebUI.DTOs;
using RestaurantManagement.WebUI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.WebUI.Controllers
{
    [AuthorizeByRole(Roles.Admin)]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IMapper _mapper;
        public RestaurantController(IRestaurantService restaurantService, IMapper mapper)
        {
            _mapper = mapper;
            _restaurantService = restaurantService;
        }
        public async Task<IActionResult> Index()
        {
            var restaurants = await _restaurantService.GetAllAsync();
            return View(_mapper.Map<List<RestaurantDto>>(restaurants));

        }
       
    }
}
