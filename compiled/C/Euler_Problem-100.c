/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int main(void)
{
    int64 t0;
    int64 x0=1;
    int64 x1=1;
    int64 x2=0;
    int64 x3=0;
_1:
    t0=(x2*3)+(x0*2);
    x0=(x0*3)+(x2*4);
    x2=t0;
    t0=(x3*3)-(x1*2);
    x1=(x1*3)-(x3*4);
    x3=t0;
    if((((2+(x2*2))-x0-(2*x3)-x1)/4)>1000000000000LL)goto _3;else goto _1;
_3:
    printf("%lld ", ((4+(x1*2)+(x3*2)+(x0*2))-(x2*2))/8);
    return 0;
}
