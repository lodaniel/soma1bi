function soma()
    local tot = 0
    local n = 1000000000
    for i = 1, n do
        tot = tot + i
    end
    return tot
end
local ti = os.clock()
local res = soma()
local tf = os.clock()
local dt = tf-ti
print("Soma:", res)
print("Tempo:", string.format("%.15f", dt))