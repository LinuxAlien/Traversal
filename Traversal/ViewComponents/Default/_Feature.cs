﻿using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new
            EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            //var values = featureManager.TGetList();
            //ViewBag.image1=featureManager.
            return View();
        }
    }
}
