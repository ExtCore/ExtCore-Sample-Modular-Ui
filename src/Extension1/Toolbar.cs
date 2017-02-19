// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Barebone;

namespace Extension1
{
  public class Toolbar : IToolbar
  {
    public IEnumerable<Button> Buttons
    {
      get
      {
        return new Button[]
        {
          new Button("New", 1),
          new Button("Open", 2),
          new Button("Save", 3)
        };
      }
    }

    public int Position { get { return 100; } }
  }
}