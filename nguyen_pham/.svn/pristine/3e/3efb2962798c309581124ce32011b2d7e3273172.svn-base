import scala.language.postfixOps
import PizzaBuilder._

class PizzaBuilderTest extends munit.FunSuite {

  test("canary") {
    assert(true)
  }

  test("create pizza") {
    val result = create Pizza

    assertEquals(result, "Pizza:")
  }

  test("create pizza and spread sauce") {
      val result = create Pizza {
        _ spread sauce
      }
      assertEquals(result, "Pizza: sauce") 
  } 

  test ("create pizza and spread cheese") {
    val result = create Pizza {
      _ spread cheese
    }
    assertEquals(result, "Pizza: cheese")
  } 
  
  test("create pizza and spread sauce and cheese") {
    val result = create Pizza {
      _ spread sauce spread cheese
    }

    assertEquals(result, "Pizza: sauce cheese")
  }

  test("create pizza and spread sauce and cheese and toppings") {
    val result = create Pizza {
      _ spread sauce spread cheese toppings "pepperoni" and "sausage"
    }

    assertEquals(result, "Pizza: sauce cheese pepperoni sausage")
  }

  test("create pizza and spread sauce and cheese and toppings and bake") {
    val result = create Pizza {
      _ spread sauce spread cheese toppings "pepperoni" and "sausage" bake
    }

    assertEquals(result, "Pizza: ( sauce, cheese, pepperoni, and sausage )")
  }
}
