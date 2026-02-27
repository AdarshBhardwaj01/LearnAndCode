import random;
def valid_guess(user_input):
    if user_input.isdigit() and 1<= int(user_input) <=100:
        return True
    else:
        return False

def main():
    correct_number=random.randint(1,100)
    guessed_correctly=False
    guessed_number=input("Guess a number between 1 and 100:")
    guess_count=0
    while not guessed_correctly:
        if not valid_guess(guessed_number):
            guessed_number=input("I wont count this one Please enter a number between 1 to 100")
            continue
        else:
            guess_count+=1
            guessed_number=int(guessed_number)

        if guessed_number<correct_number:
            guessed_number=input("Too low. Guess again")
        elif guessed_number>correct_number:
            guessed_number=input("Too High. Guess again")
        else:
            print("You guessed it in",guess_count,"guesses!")
            guessed_correctly=True

main()