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
    int64 t0;
    int64 x0=1;
    int64 x1=1;
    int64 x2=99;
    int64 x3=99;
    int64 x4=32;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    if(x3<=x2)goto _2;else goto _8;
_2:
    t0=x2-1;
    x2--;
    t0-=9;
    t0=(t0!=0)?0:1;

    if((t0)!=0)goto _3;else goto _7;
_3:
    sp();
    sa(x0);
    sa(x1);

    if((x1)!=0)goto _5;else goto _4;
_4:
    sp();
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}

    printf("%lld ", (int64)(sp()));
    return 0;
_5:
    x4=sr();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),x4));

    sa(sr());
    if(sp()!=0)goto _5;else goto _4;
_7:
    x3=99;
    goto _1;
_8:
    if(td(x2,10)!=0)goto _20;else goto _9;
_9:
    if(td(x2,10)!=0)goto _18;else goto _10;
_10:
    if(tm(x2,10)!=0)goto _16;else goto _11;
_11:
    if(tm(x2,10)!=0)goto _13;else goto _12;
_12:
    t0=x3-1;
    x3--;
    t0-=9;
    t0=(t0!=0)?0:1;

    if((t0)!=0)goto _2;else goto _1;
_13:
    if((tm(x2,10))!=(tm(x3,10)))goto _12;else goto _14;
_14:
    if((x2*(tm(x3,10)))!=(x3*(tm(x2,10))))goto _12;else goto _15;
_15:
    x0*=x2;
    x1*=x3;
    goto _12;
_16:
    if((tm(x2,10))!=(td(x3,10)))goto _11;else goto _17;
_17:
    if((x2*(tm(x3,10)))!=(x3*(td(x2,10))))goto _11;else goto _15;
_18:
    if((td(x2,10))!=(tm(x3,10)))goto _10;else goto _19;
_19:
    if((x2*(td(x3,10)))!=(x3*(tm(x2,10))))goto _10;else goto _15;
_20:
    if((td(x2,10))!=(td(x3,10)))goto _9;else goto _21;
_21:
    if((x2*(td(x3,10)))!=(x3*(td(x2,10))))goto _9;else goto _15;
}
