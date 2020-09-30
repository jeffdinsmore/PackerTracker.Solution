using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Packer
  {
    public string Name { get; set; }
    public string Cost { get; set; }
    public bool SleepingBag { get; set; }
    public bool Packed { get; set; }
    private static List<Packer> ListItems = new List<Packer> {};
    
    public Packer(string inputName, string inputCost)
    {
      Name = inputName;
      Cost = inputCost;
      SleepingBag = false;
      Packed = false;
      ListItems.Add(this);
      Id = ListItems.Count;
    }

    public static List<Packer> GetAll()
    {
      return ListItems;
    }

    public static Packer Find(int searchId)
    {
      return ListItems[searchId-1];
    }
    
  }
}