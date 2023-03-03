

def add(first , second):
    return first + second

tests = ( (1, 1, 2),
          (2, 2, 4),
          (1, 2, 3)
        )

for first , second , result in tests:
    if add(first , second) != result:
        print("Test failed: add(%d, %d) != %d" % (first , second , result))
    else:
        print("Test passed: add(%d, %d) == %d" % (first , second , result))
        

