def is_armstrong(number):
    # Initializing Sum and Number of Digits
    digit_sum = 0
    digit_count = 0

    # Calculating Number of individual digits
    temp = number
    while temp > 0:
        digit_count += 1
        temp = temp // 10

    # Finding Armstrong Number
    temp = number
    for n in range(1, temp + 1):
        digit = temp % 10
        digit_sum = digit_sum + (digit ** digit_count)
        temp //= 10
    return digit_sum


# End of Function

# User Input
number = int(input("\nPlease Enter the Number to Check for Armstrong: "))

if (number == is_armstrong(number)):
    print("\n %d is Armstrong Number.\n" % number)
else:
    print("\n %d is Not a Armstrong Number.\n" % number)