﻿using Microsoft.AspNetCore.Mvc;
using ReviewsSites.ReviewsRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Controllers
{
    public class ReviewsController : Controller
    {
        ReviewsRepository reviewRepo;
        public ReviewsController()
        {
            reviewRepo = new ReviewsRepository();
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }

    }
}
