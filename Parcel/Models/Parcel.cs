using System.Collections.Generic;

namespace FubexParcel.Models
{
  public class Parcel
  {
    private static List<Parcel> _instances = new List<Parcel> { };
    public string Name { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    public int Cost { get; set; }


    public Parcel(string name, string street, string city, string state, int length, int width, int height, int weight)
    {
      Name = name;
      Street = street;
      City = city;
      State = state;
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
      int cost = Volume + 2;
      return cost;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }
  }
}