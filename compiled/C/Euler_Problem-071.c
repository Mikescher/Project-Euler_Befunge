/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    int64 t0;
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
    sa(1);
    sa(0);
_1:
    if(sp()!=0)goto _5;else goto _2;
_2:
    x5=sr();
    t0=(sr()*3)/7;
    x6=t0;
    t0*=7;
    t0-=x5*3;

    if(t0>0)goto _3;else goto _8;
_3:
    x7=t0;
    x8=x5*7;

    if((x4*x8)>(x3*x7))goto _4;else goto _5;
_4:
    x4=x7;
    x3=x8;
    x0=x6;
    x2=x5;
_5:
    if((sr()-x1)!=0)goto _7;else goto _6;
_6:
    printf("%lld ", x0);
    printf(" /");
    printf("\n");
    printf("%lld ", x2);
    sp();
    return 0;
_7:
    sa(sp()+1LL);

    sa(((sr()*3)%7!=0)?0:1);
    goto _1;
_8:
    t0*=-1;
    goto _3;
}
