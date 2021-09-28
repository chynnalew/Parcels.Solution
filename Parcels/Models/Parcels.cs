using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Height {get; set;}
    public int Width {get; set;}
    public int Length {get; set;}

    public Parcel(int height, int width, int length)
    {
      Height = height;
      Width = width;
      Length = length;
    }
    public int Volume()
    {
      int volume = this.Height * this.Width * this.Length;
      return volume;
    }
    public double CostToShip()
    {
      double dubVol = (double)this.Volume();
      double cost = dubVol*0.25;
      return cost;
    }
  }
}