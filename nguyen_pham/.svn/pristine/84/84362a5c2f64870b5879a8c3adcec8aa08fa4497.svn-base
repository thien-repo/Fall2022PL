package PizzaBuilder

val sauce = "sauce"
val cheese = "cheese"

class Pizza {
  var ingredients = List[String]()
  
  def spread(ingredient: String) : Pizza = {
    ingredients = ingredients :+ ingredient
    this
  }

  def toppings(ingredient: String) : Pizza = {
    ingredients = ingredients :+ ingredient
    this
  }

  def and(ingredient: String) : Pizza = {
    toppings(ingredient)
  }

  def bake = {
    ingredients = ingredients.map(ingredient => s"$ingredient,").init :+ ingredients.last
    
    ingredients = ingredients.splitAt(ingredients.length - 1) match {
      case (a, b) => a ++ List("and") ++ b
    }

    ingredients = List("(") ++ ingredients ++ List(")")
  }
  
  override def toString() = s"Pizza: ${ingredients.mkString(" ")}"
}

object create {
  def Pizza = "Pizza:"

  def Pizza(block: Pizza => Unit) = {
    val pizza = new Pizza
    block(pizza)
    pizza.toString()
  }
}
