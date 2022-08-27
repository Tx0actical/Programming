def main():
    x = 0

    # while loop
    while(x < 5):
        print(x)
        x = x + 1
    
    # for loop over a collection, using break and continue
    days = ["Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun"]
    for i in days:

        if (i == "Mon"):
            continue
        if (i == "Fri"):
            break
        print(i)
    
    # using enumerate() function
    days = ["Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun"]
    for i,t in enumerate(days):
        print(i,t)


if __name__  == "__main__": main()