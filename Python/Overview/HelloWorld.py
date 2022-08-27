# import platform

# print('Hello, World!')
# print('This is python version {}'.format(platform.python_version()))

from email import message
import platform

def main():
    message()

def message():
    print('Hello, World!')
    print('The is python version {}'.format(platform.python_version()))
    name = input("What is your name? ")
    print('Nice to meet you', name)

if __name__ == '__main__' : main()  # Executed as main, kind of gives it an entry point justlike other languages
# This will execute as a program