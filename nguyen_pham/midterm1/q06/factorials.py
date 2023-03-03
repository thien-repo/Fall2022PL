def factorials(n):
    if n == 1:
        return [1]
    
    result = factorials(n-1)
    return result + [n * result[-1]]
  
  
def main():
  print(factorials(1))
  print(factorials(4))
  print(factorials(7))
  print(factorials(10))
  
  
if __name__ == '__main__':
  main()