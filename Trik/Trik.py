i = input()
l = list(i)

ball = 1
for c in l:
    if ball is 1 and c is 'A':
        ball = 2
    elif ball is 2 and c is 'A':
        ball = 1
    elif ball is 2 and c is 'B':
        ball = 3
    elif ball is 3 and c is 'B':
        ball = 2
    elif ball is 3 and c is 'C':
        ball = 1
    elif ball is 1 and c is 'C':
        ball = 3

print(ball)