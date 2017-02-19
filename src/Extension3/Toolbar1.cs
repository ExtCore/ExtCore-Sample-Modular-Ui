// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Barebone;

namespace Extension3
{
  public class Toolbar1 : IToolbar
  {
    public IEnumerable<Button> Buttons
    {
      get
      {
        return new Button[]
        {
          new Button("Build", 1),
          new Button("Rebuild", 2),
          new Button("Clear", 3)
        };
      }
    }

    public int Position { get { return 300; } }
  }
}