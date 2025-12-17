import random

def is_valid_guess(user_input):
    return user_input.isdigit() and 1 <= int(user_input) <= 100

def get_guess(number):
    user_input = input(number)
    while not is_valid_guess(user_input):
        user_input = input("Invalid input. Enter a number between 1 and 100: ")
    return int(user_input)


def display_feedback(guess, target):
    if guess < target:
        return "Too low. Guess again: "
    elif guess > target:
        return "Too high. Guess again: "
    else:
        return "correct"


def number_guessing_game():
    correct_number = random.randint(1, 100)
    attempts = 0
    number = "Guess a number between 1 and 100: "

    while True:
        guess = get_guess(number)
        attempts += 1
        feedback = display_feedback(guess, correct_number)

        if feedback == "correct":
            print(f"You guessed the number in {attempts} attempts")
            break
        else:
            number = feedback

number_guessing_game()
