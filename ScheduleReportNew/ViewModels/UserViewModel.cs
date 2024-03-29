﻿using ScheduleReport.Controllers;
using ScheduleReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduleReport.ViewModels
{
   public class UserViewModel
   {
      public string UserName { get; set; }
      public string Password { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public int Type { get; set; }
   }
}