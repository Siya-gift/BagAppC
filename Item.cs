class Item : Bag{
  private string name;
  private int qty;

  public Item(string name,int qty){
    this.name = name;
    this.qty = qty;
  }

  public string getItemName(){
    return this.name;
  }
  
  public int getItemQty(){
    return this.qty;
  }
}