class Program {
  public static void Main (string[] args) {
    // instantiate
    Bag bag = new Bag();
    Item item1 = new Item("Book",5);
    Item item2 = new Item("Pen",1);
    Item item3 = new Item("Bottle Juice",1);
    Item item4 = new Item("Pencil",2);

    // add items
    bag.addItemToBag(item1);
    bag.addItemToBag(item2);
    bag.addItemToBag(item3);
    bag.addItemToBag(item4);

    // display bag
    bag.displayBagItems();
  }
}