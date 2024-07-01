from z3 import *

arr = [2, 10, 6, 1, 12, 16, 9, 3, 4, 7, 14, 5, 11, 8, 15, 13]

sol = Solver()
original = [BitVec(f"original_{i}", 8) for i in range(6)]
flag = original[:]

for i in range(6):
    sol.add(original[i] > 32)
    sol.add(original[i] < 127)

tmp = 0
for i in range(6):
    tmp += Sum([If(flag[i]&0xf == j, arr[j], 0) for j in range(16)])

sol.add(tmp == 51)

if sol.check() == sat:
    m = sol.model()
    result = [m[original[i]].as_long() for i in range(6)]
    print(''.join([chr(i) for i in result]))
