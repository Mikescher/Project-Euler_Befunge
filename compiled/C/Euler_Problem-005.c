/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int main(void)
{
    int64 t0;
    int64 x0=20;
    int64 x1=1;
    int64 x2=1;
    int64 x3=48;
    int64 x4=112;
    int64 x5=48;
_1:
    x1*=x2;
    t0=x0>(x2+1)?1:0;
    x2++;

    if((t0)!=0)goto _3;else goto _2;
_2:
    printf("%lld ", x1);
    return 0;
_3:
    x3=1;
_4:
    t0=x3;
    x3++;
    t0=t0>x0?1:0;

    if((t0)!=0)goto _1;else goto _5;
_5:
    if((tm(x1,x3))!=0)goto _4;else goto _6;
_6:
    x5=td(x1,x3);
    x4=1;
_7:
    t0=x2>(x4+1)?1:0;
    x4++;

    if((t0)!=0)goto _9;else goto _8;
_8:
    x1/=x3;
    goto _5;
_9:
    if((tm(x5,x4))!=0)goto _4;else goto _7;
}
