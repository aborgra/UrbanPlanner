using System;
using System.Collections.Generic;

namespace Planner {

  public class Building {

    public Building (string address) {
      Address = address;
    }

    public void Construct () {
      dateConstructed = DateTime.Now;
    }

    public void Purchase (string name) {
      Owner = name;
    }

    private string Designer { get; set; }
    private DateTime dateConstructed { get; set; }
    private string Address { get; set; }
    private string Owner { get; set; }

    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Volume {
      get {
        return Width * Depth * (3 * Stories);
      }
    }

    public override string ToString () {
      return ($"Address: {Address}, Constructed On: {dateConstructed},Owned By: {Owner}, Volume: {Volume} cubic meters of space");
    }
  }
}