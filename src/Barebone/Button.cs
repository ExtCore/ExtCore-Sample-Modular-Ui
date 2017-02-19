// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Barebone
{
  public class Button
  {
    public string Name { get; }
    public int Position { get; }

    public Button(string name, int position)
    {
      this.Name = name;
      this.Position = position;
    }
  }
}