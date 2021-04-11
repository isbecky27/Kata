def average_string(s):

    if s == '':
        return "n/a"

    num = {"zero":0, "one":1, "two":2, "three":3, "four":4, "five":5, "six":6, "seven":7, "eight":8, "nine":9}
    arr = s.split(' ')
    result = 0
    for i in arr:
        if i not in num :
            return "n/a"
        result += num[i]
    result = result/len(arr)

    for key, value in num.items():
        if value == int(result):
            return key

print(average_string("zero nine five two"))