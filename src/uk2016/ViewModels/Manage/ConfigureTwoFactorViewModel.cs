﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;

namespace uk2016.ViewModels.Manage
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }
    }
}
