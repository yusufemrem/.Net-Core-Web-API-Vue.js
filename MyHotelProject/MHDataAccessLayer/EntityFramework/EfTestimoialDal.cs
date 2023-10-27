﻿using MHDataAccessLayer.Abstract;
using MHDataAccessLayer.Concrete;
using MHDataAccessLayer.Repository;
using MHEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHDataAccessLayer.EntityFramework
{
    public class EfTestimoialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimoialDal(Context context) : base(context)
        {

        }
    }
}
