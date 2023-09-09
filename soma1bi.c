#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    long long tot = 0;
    long long n = 1000000000;
    clock_t ti = clock();
    for (long long i = 1; i <= n; i++) {
        tot += i;
    }
    clock_t tf = clock();
    double dt = (double)(tf-ti)/CLOCKS_PER_SEC;
    printf("Soma: %lld\n", tot);
    printf("Tempo: %.15lf\n", dt);
    return 0;
}