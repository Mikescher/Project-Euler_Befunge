/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
    int64 t0,t1;
    int64 x0=0;
    int64 x1=1000000;
    int64 x2=0;
    int64 x3=1;
    int64 x4=1;
    int64 x5=63;
    int64 x6=63;
    int64 x7=63;
    int64 x8=63;
    s=(int64*)calloc(q,sizeof(int64));
    t0=1;
_1:
    x5=t0;
    t1=td(t0*3,7);
    x6=t1;
    t1*=7;
    t1-=x5*3;

    if(t1>0)goto _2;else goto _7;
_2:
    x7=t1;
    x8=x5*7;

    if((x4*x8)>(x3*x7))goto _3;else goto _4;
_3:
    x4=x7;
    x3=x8;
    x0=x6;
    x2=x5;
_4:
    if(t0!=x1)goto _5;else goto _6;
_5:
    t0++;

    if(tm(t0*3,7)==0)goto _4;else goto _1;
_6:
    printf("%lld ", x0);
    printf(" /");
    printf("\n");
    printf("%lld ", x2);
    return 0;
_7:
    t1*=-1;
    goto _2;
}
