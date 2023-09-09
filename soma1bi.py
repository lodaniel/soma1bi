import time

def soma():
    tot = 0
    for i in range(1, 1_000_000_001):
        tot += i
    return tot

ti = time.time()
res = soma()
tf = time.time()
print("Soma:", res)
print("Tempo:", tf-ti)