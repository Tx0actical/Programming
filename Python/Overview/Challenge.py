import re

def main():
    run = True
    while (run):
        print("Enter string for palindrome or 'exit'")
        user_input = input()
        if user_input != "exit":
            
            # converting string to the one without spaces, punctuation and no upper case characters
            user_input = re.sub(r'[^\w\s]', '', user_input)
            user_input = user_input.replace(" ", "")
            user_input = user_input.lower()

            # calculating reverse string
            reversed_user_input = user_input[::-1]

            # palindrome logic
            if user_input == reversed_user_input:
                print("Palindrome test: True")
            else:
                print("Palindrome test: False")
        else:
            run = False
            exit(0)

if __name__ == "__main__": main()
