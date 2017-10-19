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
    int64 t0,t1;
    int64 x0=32;
    int64 x1=32;
    int64 x2=1;
    s=(int64*)calloc(q,sizeof(int64));
    t0=1;
    sa(0);
    sa(1);
    sa(10);
    sa(100);
    sa(1000);
    sa(10000);
    sa(100000);
    sa(1000000);
    sa(1000000);
_1:
    if(sp()!=0)goto _3;else goto _2;
_2:
    printf("%lld ", x2);
    sp();
    return 0;
_3:
    x0=1;
    x1=1;
_4:
    if(sr()>(x0*9*x1))goto _10;else goto _5;
_5:
    sa(sp()-1LL);

    t0=(td(sr(),x0))+x1;
    sa(tm(sp(),x0));

    t1=x0;
    sa(t1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}

    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _9;else goto _6;
_6:
    sa(sr());
_7:
    if(sp()!=0)goto _9;else goto _8;
_8:
    t0%=10;
    t0*=x2;
    x2=t0;
    sp();
    sa(sr());
    goto _1;
_9:
    t0/=10;
    sa(sp()-1LL);

    sa(sr());
    goto _7;
_10:
    sa(sp()-(x0*9*x1));

    x0++;
    x1*=10;
    goto _4;
}
