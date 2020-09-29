using System.Collections.Generic;

namespace FubexParcel.Models
{
  public class Parcel
  {
    private static List<Parcel> _instances = new List<Parcel> { };
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    public int Cost { get; set; }


    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      Volume = GetVolume();
      Cost = CostToShip();

      _instances.Add(this);
    }

    public int GetVolume()
    {
      return this.Length * this.Width * this.Height;
    }

    public int CostToShip()
    {
      return 666;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }
  }
}