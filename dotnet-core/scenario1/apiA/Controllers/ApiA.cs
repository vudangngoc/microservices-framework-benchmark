﻿using Microsoft.AspNetCore.Mvc;

namespace ApiA.Controllers
{
  public class ApiA : Controller
  {
    [HttpGet]
    public string Get()
    {
      return "Hello World!";
    }

  }
}
