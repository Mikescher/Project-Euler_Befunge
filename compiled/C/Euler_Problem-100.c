/* transpiled with BefunCompile v1.1.0 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0,t1,t2;
    int64 x0=1;
    int64 x1=1;
    int64 x2=0;
    int64 x3=0;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    t0=x0;
    t1=x2;
    x0=(x0*3)+(x2*4);
    t1*=3;
    t0*=2;
    t2=t1+t0;
    x2=t2;
    t0=x1;
    t1=x3;
    x1=(x1*3)-(x3*4);
    t1*=3;
    t0*=2;
    t2=t1-t0;
    x3=t2;
    if((td((2+(x2*2))-x0-(2*x3)-x1,4))<=1000000000000LL)goto _1;else goto _3;
_3:
    printf("%lld", td((4+(x1*2)+(x3*2)+(x0*2))-(x2*2),8));
    return 0;
}
