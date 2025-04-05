first = int(input())
second = int(input())
arithmetic = input()
if arithmetic == '+':
    print(first + second)
elif arithmetic == '-':
    print(first - second)
elif arithmetic == '*':
    print(first * second)
elif arithmetic == '/':
    if(second == 0):
        print("Error")
    else:
        print(first / second)
else:
    print("unidentified operator")