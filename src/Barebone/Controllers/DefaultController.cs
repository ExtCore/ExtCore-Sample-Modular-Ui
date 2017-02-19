// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Barebone.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Barebone.Controllers
{
  public class DefaultController : Controller
  {
    public ActionResult Index()
    {
      return this.View(new IndexViewModelFactory().Create());
    }
  }
}