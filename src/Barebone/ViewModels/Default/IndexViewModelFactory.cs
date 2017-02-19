// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using ExtCore.Infrastructure;

namespace Barebone.ViewModels
{
  public class IndexViewModelFactory
  {
    public IndexViewModel Create()
    {
      // We have to merge menu items from different extensions into a single list in order to be able to sort them
      List<MenuItem> menuItems = new List<MenuItem>();

      foreach (IMenu menu in ExtensionManager.GetInstances<IMenu>())
        menuItems.AddRange(menu.MenuItems);

      return new IndexViewModel()
      {
        MenuItems = menuItems.OrderBy(mi => mi.Position),
        Toolbars = ExtensionManager.GetInstances<IToolbar>()
      };
    }
  }
}