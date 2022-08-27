# Declaring variables of different datatypes

myint = 5
myfloat = 17.17
mybool = True
mystring = "This is a string"
mylist = [0, 1, "two", 3, "four", 5]
mytuple = (0, 1, 2)
mydict = {"one" : 1, "two" : 2}

# Printing them

# print(myint)
# print(myfloat)
# print(mybool)
# print(mystring)
# print(mylist)
# print(mytuple)
# print(mydict)

# # re-declaring a variable
# myint = 10
# print(myint)

# # access a sequence type, use []
# print(mylist[2])
# print(mytuple[1])

# # access subset of a sequence
# print(mylist[1:5])
# print(mytuple[::2])

# # reversing using slices
# print(mylist[::-1])

# # accessing dictionary
# print(mydict["one"])

# # ERROR: combining datatypes
# print("string" + str(123))

# global and local variables
def somefunction():
    global mystring
    mystring = "def"
    print(mystring)
somefunction()
print(mystring)

# del mystring
# print(mystring)