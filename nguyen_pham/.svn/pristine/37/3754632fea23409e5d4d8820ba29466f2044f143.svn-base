def factorials(n):
    def tail_factorials(n, result):
        if n == 1:
            return result
        return tail_factorials(n-1, result + [n * result[-1]])
    return tail_factorials(n, [1])
  
  
def main():
  print(factorials(1))
  print(factorials(4))
  print(factorials(7))
  print(factorials(10))
  
  
if __name__ == '__main__':
  main()