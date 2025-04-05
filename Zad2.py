CorF = input()
if CorF == "C":
    Celcius = float(input())
    Fahrenheit = Celcius * 1.8 + 32
    print("%f C = %f F" % (Celcius, Fahrenheit))
elif CorF == "F":
    Fahrenheit = float(input())
    Celcius = (Fahrenheit - 32) / 1.8
    print("%f F = %f C" % (Fahrenheit, Celcius))
else:
    print("unidentified")