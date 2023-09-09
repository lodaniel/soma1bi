function soma()
    tot = 0
    for i in 1:1_000_000_000
        tot += i
    end
    return tot
end

ti = time()
res = soma()
tf = time()
println("Soma: ", res)
println("Tempo: ", tf-ti)