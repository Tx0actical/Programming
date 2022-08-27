try:
    x = 10 / 0
except:
    print("Well that didn't work")

try:
    answer = input("What should I divide by 10?")
    num = int(answer)
    print(10 / num)
except ZeroDivisionError as e:
    print("Cannot divide by 0")
except ValueError as e:
    print("Give a valid number")
    print(e)
finally:
    print("This code always run")