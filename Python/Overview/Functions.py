# defining a basic function
from unittest import result

def func1():
    print("I am a function")

# function taking argument
def func2(arg1, arg2):
    print(arg1, arg2)

# function that returns a value
def cube(x):
    return x * x * x

# function with default value for an argument
def power(num, x = 1):
    result = 1
    for i in range(x):
        result = result * num
    return result

# function with variable number of arguments
def multi_add(*args):
    result = 0
    for x in args:
        result = result + x
    return result

# *****function call section*****
func1() # executes contents of the function

print(func1())  # func1 gets executed first, and since it
                # returns no value print 'prints' None as output

print(func1)    # function is not executed since parenthesis 
                # are not included, value of function definition is printed

func2(10, 20)
print(func2(10, 20))
cube(2)

print(power(2, 3))
print(power(2)) # uninitialized parameter will default to 1
print(power(x = 2, num = 9)) # parameter is order is immaterial
                                # if they are passed with argument name

print(multi_add(4, 5, 10, 4, 12341))