namespace Parcels.Models
{
  public class Parcel
  {
    public int Height {get; set;}
    public int Width {get; set;}
    public int Length {get; set;}
    public int Weight {get; set;}

    public Parcel(int height, int width, int length,int weight)
    {
      Height = height;
      Width = width;
      Length = length;
      Weight = weight;
    }
    public int Volume()
    {
      int volume = this.Height * this.Width * this.Length;
      return volume;
    }
  }
}