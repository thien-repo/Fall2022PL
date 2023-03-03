class Pizza{
  List<String> ingredients = []

  def spread(String ingredient){
    ingredients.add(ingredient)
  }
  
  def propertyMissing(String name){
    return name
  } 

  def getbake(){
    ingredients = ["(${ingredients.join(' ')})"]
  }

  def toppings(String... toppings){
    ingredients.addAll(toppings)
  }

  String toString() {
    if(ingredients.size() == 0){
      return "Pizza:"
    }
    
    "Pizza: " + ingredients.join(" ")
  }
}
