// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Barebone;

namespace Extension1
{
  public class Menu : IMenu
  {
    public IEnumerable<MenuItem> MenuItems
    {
      get
      {
        return new MenuItem[]
        {
          new MenuItem("File", 100),
          new MenuItem("Tools", 500),
          new MenuItem("Help", 600)
        };
      }
    }
  }
}