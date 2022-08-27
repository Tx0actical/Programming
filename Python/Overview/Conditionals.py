from nis import match


def main():
    x, y = 10, 100

    # conditionals 
    if x < y:
        result = "x is less than y"
    elif x == y:
        result = "x is equal to y"
    else:
        result = "x is greater than y"
    
    print(result)
    # single conditional statement
    result = "x is less than y" if x < y else "x is greater than or equal to y"
    
    # match-case statement
    value = "42"
    match value:
        case "one":
            result = 1
        case "two":
            result = 2
        case "three" | "four":
            result = (3,4)
        case _:
            result = -1
    print(result) 

if __name__ == "__main__": main()