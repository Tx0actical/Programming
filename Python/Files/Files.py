
def main():
    # open function
    # myfile = open("textfile", "w+")

    # for i in range(1, 10):
    #     myfile.write("This is some text\n")
    # myfile.close()

    # adding contents/ appending
    # myfile = open("textfile", "a+")
    # for i in range(1, 10):
    #     myfile.write("This is some new text\n")
    # myfile.close()

    # no need to open and close while reading
    myfile = open("textfile", "r")
    if myfile == 'r':
        # contents = myfile.read()
        # print(contents)
        f1 = myfile.readlines()
        for x in f1:
            print(x)

if __name__ == "__main__" : main()