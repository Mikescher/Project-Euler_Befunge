/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int main(void)
{
    int64 t0;
    int64 x0=775146;
    int64 x1=600851475143;
    int64 x2=55;
    int64 x3=57;
_1:
    t0=tm(x1,x0-1);
    x0--;
    if((t0)!=0)goto _1;else goto _3;
_3:
    t0=x0-1;
    x3=x0;
    x2=t0;
_4:
    if((tm(x3,x2))!=0)goto _5;else goto _1;
_5:
    t0=x2-2;
    x2--;

    if((t0)!=0)goto _4;else goto _6;
_6:
    printf("%lld ", x3);
    return 0;
}
