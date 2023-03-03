class Player(val name: String, val number: Int){
  override def toString: String = s"$name is number $number"
}


object example2{
  

  def main(args: Array[String]): Unit = {
    val TeamNumbers = List.fill(5)(scala.util.Random.nextInt(100))
    val names = List("John", "Jane", "Joe", "Jill", "Jack")
    val Team = names.zip(TeamNumbers).map{case (name, number) => new Player(name, number)}
    Team.foreach(println)
  }
}