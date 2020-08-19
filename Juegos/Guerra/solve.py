def solve(arr, N, A, B):
    temp = []
    for num in arr:
        q = 0
        for x in range(N):
            for y in range(N):
                p = A**x + B**y
                if (p < num):
                    q = q + 1 
        temp.append(q)            
    
    print('termino')    
    return temp

# N = int (input())
# A = int (input())
# B = int (input())
# arr = map(int, input().split())
N = 3
A = 10
B = 3
arr = map(int, '2 4 11'.split())
print(arr)
a = solve (arr, N, A, B)
print ('\n'.join(map(str, a)))
i=1
if (i=i+1 and (i==1)):
    printf('tes')