﻿using FoodDelivery.DAL.Infrastructure.QueryObjects.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.DAL.Infrastructure.QueryObjects.Interfaces;

public interface IGetAllRestaurantMealsQueryObject<TEntity> : IQueryObject<TEntity> where TEntity : class, new()
{
    IQueryObject<TEntity> UseFilter(int restaurantId);

}
