﻿using BikesApi.Entities;

namespace Bikes.ViewModels.Orders
{
    public class IndexVM
    {
        public List<Order> Orders { get; set; }
        public Dictionary<int, List<string>> OrderToRecipes { get; set; }   
    }
}
