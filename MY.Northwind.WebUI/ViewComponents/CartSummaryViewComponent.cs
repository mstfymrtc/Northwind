﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MY.Northwind.Entity.Concrete;
using MY.Northwind.WebUI.Models;
using MY.Northwind.WebUI.Services;

namespace MY.Northwind.WebUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {

        private ICartSessionService _cartSessionService;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }



        public ViewViewComponentResult Invoke()
        {

            var model = new CartSummaryViewModel()
            {

                Cart = _cartSessionService.GetCart()

            };
            return View(model);

        }


    }
}
