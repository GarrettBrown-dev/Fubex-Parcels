using System.Collections.Generic;

namespace Parcel.Models
{
  public class Parcel
  {
    private static List<Parcel> _instances = new List<Parcel> { };
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }

    public int Volume { get; set; }

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      Volume = Volume();
      _instances.Add(this);
    }

    public static int Volume()
    {
      return this.Length * this.Width * this.Height;
    }

    public static int CostToShip()
    {
      return 0;
    }

    public static GetAll()
    {

    }
  }
}