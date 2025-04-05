Count = int(input())
sum = 0
for i in range(Count):
    Grade = float(input())
    sum += Grade
if Count > 0:
    avg = sum / Count
print("Średnia %0.2f" % avg)
if(avg >= 3.0):
    print("Uczeń zdał.")
else:
    print("Uczeń nie zdał.")