﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }

        public string Name { get; set; }

        public string  Tittle { get; set; }
        public string Comment { get; set; }
        public string  ImageUrl { get; set; }


    }
}
