﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarbook.Application.Interfaces.CarInterfaces;
using UdemyCarbook.Persistance.Context;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarbook.Persistance.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
    }
}
