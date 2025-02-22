using System;
using System.Collections.Generic;

class Bag{
  private List<Item> ListofItems;

  public Bag(){
    ListofItems = new List<Item>();
  }

  public void addItemToBag(Item item){
    ListofItems.Add(item);
  }

  public void displayBagItems(){
    Console.WriteLine("********************");
    Console.WriteLine("My Bag Pack");
    Console.WriteLine("********************");
    foreach(Item item in ListofItems){
      Console.WriteLine(item.getItemQty() + " " + item.getItemName());
    }
    Console.WriteLine("********************");
  }
  
}