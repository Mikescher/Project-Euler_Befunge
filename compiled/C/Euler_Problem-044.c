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
    int64 x0=37;
    int64 x1=37;
    int64 x2=37;
    int64 x3=37;
    int64 x4=37;
    int64 x5=37;
    int64 x6=37;
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    x0=1073741824;
    x1=2;
    x5=5;
    sa(2);
    sa(5);
_1:
    sa((x1)-(1));
    sa((x1)-(1));
_2:
    if(sp()!=0)goto _3; else goto _25;
_3:
    sa(sr());
    x2=sp();
    sa(sr());
    sa(sp()*(3));
    sa(sp()-(1));
    sa(sp()*sp());
    {int64 v0=2;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    x3=sp();
    x6=0;
    {int64 v0=sp();sa(sp()-v0);}
    sa(sp()*(24));
    sa(sp()+(1));
    sa(sr());
    x4=sp();
    sa(x0);
    sa((x0)>(x4)?1:0);
_4:
    if(sp()!=0)goto _24; else goto _5;
_5:
    sa(sr());
    if(sp()!=0)goto _6; else goto _8;
_6:
    sa(sr());
    sa(sp()+(x6));
    {int64 v0=x4;sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _23; else goto _7;
_7:
    x6=td(x6,2);
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _6; else goto _8;
_8:
    sp();
    sa(sp()-((x6)*(x6)));
    sa(x6);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _22; else goto _9;
_9:
    {int64 v0=6;sa((v0==0)?0:(sp()%v0));}
    sa(sp()-(5));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _10; else goto _18;
_10:
    sa((((x3)+(x5))*(24))+(1));
    sa((((x3)+(x5))*(24))+(1));
    x6=0;
    x4=sp();
    sa(x0);
    sa((x0)>(x4)?1:0);
_11:
    if(sp()!=0)goto _21; else goto _12;
_12:
    sa(sr());
    if(sp()!=0)goto _13; else goto _15;
_13:
    sa(sr());
    sa(sp()+(x6));
    {int64 v0=x4;sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _20; else goto _14;
_14:
    x6=td(x6,2);
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _13; else goto _15;
_15:
    sp();
    sa(sp()-((x6)*(x6)));
    sa(x6);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _19; else goto _16;
_16:
    {int64 v0=6;sa((v0==0)?0:(sp()%v0));}
    sa(sp()-(5));
    if(sp()!=0)goto _18; else goto _17;
_17:
    sp();
    printf("%lld", (int64)((x5)-(x3)));
    return 0;
_18:
    sa(x5);
    sa((x2)-(1));
    sa((x2)-(1));
    goto _2;
_19:
    sp();
    goto _18;
_20:
    sa(sr());
    sa(sp()+(x6));
    sa(x4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    x4=sp();
    sa(sr());
    sa(sp()*(2));
    sa(sp()+(x6));
    x6=sp();
    x6=td(x6,2);
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    goto _12;
_21:
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=x4;sa((sp()>v0)?1:0);}
    goto _11;
_22:
    sp();
    goto _18;
_23:
    sa(sr());
    sa(sp()+(x6));
    sa(x4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    x4=sp();
    sa(sr());
    sa(sp()*(2));
    sa(sp()+(x6));
    x6=sp();
    x6=td(x6,2);
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    goto _5;
_24:
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=x4;sa((sp()>v0)?1:0);}
    goto _4;
_25:
    sp();
    sp();
    sa(sp()+(1));
    sa(sr());
    sa(sr());
    x1=sp();
    sa(sr());
    sa(sp()*(3));
    sa(sp()-(1));
    sa(sp()*sp());
    {int64 v0=2;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    x5=sp();
    goto _1;
}