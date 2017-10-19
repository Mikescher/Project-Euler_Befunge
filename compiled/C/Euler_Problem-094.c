/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int main(void)
{
    int64 t0;
    int64 x0=0;
    int64 x1=1000000000;
    int64 x2=2;
    int64 x3=1;
_1:
    if(x1>(x2*2))goto _3;else goto _2;
_2:
    printf("%lld ", x0);
    return 0;
_3:
    x0=((x2>2?1:0)*((((2*x2)%3)-1!=0)?0:1)*((((x2-2)*x3)%3!=0)?0LL:1LL)*((x2*2)-2))+x0;
    x0=(((((x2*2)%3)-2!=0)?0:1)*((((x2+2)*x3)%3!=0)?0LL:1LL)*(2+(2*x2)))+x0;
    t0=x2+(x3*2);
    x2=(x2*2)+(x3*3);
    x3=t0;
    goto _1;
}
