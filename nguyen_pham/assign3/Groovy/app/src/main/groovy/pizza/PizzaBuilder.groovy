package pizza

static create(clazz, closure = {}){ 
  def instance = clazz.newInstance()
  closure.delegate = instance
  closure.call()
  return instance.toString()
}



