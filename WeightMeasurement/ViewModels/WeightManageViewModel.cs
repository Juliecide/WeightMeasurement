﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightMeasurement.ViewModels
{
    public class WeightManageViewModel
    {
        public int Id { get; set; }

        public int SubUserId { get; set; }

        public decimal Weight { get; set; }

        public string SubUserName { get; set; }

        public DateTime AddedOn { get; set; }

    }
}