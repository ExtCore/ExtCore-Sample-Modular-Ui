// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Barebone;

namespace Extension3
{
  public class Toolbar : IToolbar
  {
    public IEnumerable<Button> Buttons
    {
      get
      {
        return new Button[]
        {
          new Button("Undo", 1),
          new Button("Redo", 2)
        };
      }
    }

    public int Position { get { return 200; } }
  }
}