import spock.lang.Specification
import static pizza.PizzaBuilder.*

class PizzaBuilderTest extends Specification {
  
  def "canary"() { 
    expect:
      true
  }
    
  def "create pizza"() {      
    def result = create Pizza
    
    expect:
      result == "Pizza:" 
  }

  def "create pizza and sauce"() {      
    def result = create Pizza, {
      spread sauce
    } 
    
    expect:
      result == "Pizza: sauce" 
  }

  def "create pizza and sauce and cheese"() {      
    def result = create Pizza, {
      spread sauce
      spread cheese
    }
    expect:
      result == "Pizza: sauce cheese" 
  }
  
  def "create pizza and sauce and cheese and pepperoni"() {      
    def result = create Pizza, {
      spread sauce
      spread cheese
      toppings pepperoni, sausage
    }
    expect:
      result == "Pizza: sauce cheese pepperoni sausage" 
  }

  def "create pizza and sauce and cheese and pepperoni bake"() {      
    def result = create Pizza, {
      spread sauce
      spread cheese
      toppings pepperoni, sausage
      bake
    }
    expect:
      result == "Pizza: (sauce cheese pepperoni sausage)"
  }
}
