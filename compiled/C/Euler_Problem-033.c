/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
    int64 x0=32;
    int64 x1=32;
    int64 x2=32;
    int64 x3=32;
    int64 x4=32;
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    x0=1;
    x1=1;
    x2=99;
    x3=99;
_1:
    if(((((x3)>(x2)?1:0)!=0)?0:1)!=0)goto _2;else goto _8;
_2:
    sa((x2)-(1));
    x2=(x2)-(1);
    sa(sp()-(9));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _3; else goto _7;
_3:
    sp();
    sa(x0);
    sa(x1);
    if((x1)!=0)goto _5;else goto _4;
_4:
    sp();
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    printf("%lld", (int64)(sp()));
    return 0;
_5:
    sa(sr());
    x4=sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=x4;sa((v0==0)?0:(sp()%v0));}
    sa(sr());
_6:
    if(sp()!=0)goto _5; else goto _4;
_7:
    x3=99;
    goto _1;
_8:
    sa(td(x2,10));
    if(sp()!=0)goto _9; else goto _11;
_9:
    sa((td(x2,10))-(td(x3,10)));
    if(sp()!=0)goto _11; else goto _10;
_10:
    sa(((x2)*(td(x3,10)))-((x3)*(td(x2,10))));
    if(sp()!=0)goto _11; else goto _21;
_11:
    sa(td(x2,10));
    if(sp()!=0)goto _12; else goto _14;
_12:
    sa((td(x2,10))-(tm(x3,10)));
    if(sp()!=0)goto _14; else goto _13;
_13:
    sa(((x2)*(td(x3,10)))-((x3)*(tm(x2,10))));
    if(sp()!=0)goto _14; else goto _21;
_14:
    sa(tm(x2,10));
    if(sp()!=0)goto _15; else goto _17;
_15:
    sa((tm(x2,10))-(td(x3,10)));
    if(sp()!=0)goto _17; else goto _16;
_16:
    sa(((x2)*(tm(x3,10)))-((x3)*(td(x2,10))));
    if(sp()!=0)goto _17; else goto _21;
_17:
    sa(tm(x2,10));
    if(sp()!=0)goto _19; else goto _18;
_18:
    sa((x3)-(1));
    x3=(x3)-(1);
    sa(sp()-(9));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _2; else goto _1;
_19:
    sa((tm(x2,10))-(tm(x3,10)));
    if(sp()!=0)goto _18; else goto _20;
_20:
    sa(((x2)*(tm(x3,10)))-((x3)*(tm(x2,10))));
    if(sp()!=0)goto _18; else goto _21;
_21:
    x0=(x0)*(x2);
    x1=(x1)*(x3);
    goto _18;
}