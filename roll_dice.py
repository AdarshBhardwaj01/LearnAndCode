import random
def roll_dice(faces):
    result=random.randint(1, faces)
    return result

def main():
    faces=6
    roll_again=True
    while roll_again:
        response=input("Ready to roll? Enter Q to Quit")
        if response.lower() !="q":
            result=roll_dice(faces)
            print("You have rolled a",result)
        else:
            roll_again=False
main();