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
    goto _3;
_0:
    if(sp()!=0)goto _6; else goto _5;
_1:
    if(sp()!=0)goto _7; else goto _16;
_2:
    if(sp()!=0)goto _10; else goto _19;
_3:
    x0=1073741824;
    x1=2;
    x5=5;
    sa(2);
    sa(5);
    goto _4;
_4:
    sa((x1)-(1));
    sa((x1)-(1));
    goto _0;
_5:
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
    goto _4;
_6:
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
    goto _1;
_7:
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=x4;sa((sp()>v0)?1:0);}
    goto _1;
_8:
    sa(x5);
    sa((x2)-(1));
    sa((x2)-(1));
    goto _0;
_9:
    sa((((x3)+(x5))*(24))+(1));
    sa((((x3)+(x5))*(24))+(1));
    x6=0;
    x4=sp();
    sa(x0);
    sa((x0)>(x4)?1:0);
    goto _2;
_10:
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=x4;sa((sp()>v0)?1:0);}
    goto _2;
_11:
    sp();
    printf("%lld", (int64)((x5)-(x3)));
    return 0;
_12:
    sp();
    goto _8;
_13:
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
    goto _19;
_14:
    sp();
    goto _8;
_15:
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
    goto _16;
_16:
    sa(sr());
    if(sp()!=0)goto _24; else goto _17;
_17:
    sp();
    sa(sp()-((x6)*(x6)));
    sa(x6);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _14; else goto _18;
_18:
    {int64 v0=6;sa((v0==0)?0:(sp()%v0));}
    sa(sp()-(5));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _9; else goto _8;
_19:
    sa(sr());
    if(sp()!=0)goto _22; else goto _20;
_20:
    sp();
    sa(sp()-((x6)*(x6)));
    sa(x6);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _12; else goto _21;
_21:
    {int64 v0=6;sa((v0==0)?0:(sp()%v0));}
    sa(sp()-(5));
    if(sp()!=0)goto _8; else goto _11;
_22:
    sa(sr());
    sa(sp()+(x6));
    {int64 v0=x4;sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _13; else goto _23;
_23:
    x6=td(x6,2);
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _22; else goto _20;
_24:
    sa(sr());
    sa(sp()+(x6));
    {int64 v0=x4;sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15; else goto _25;
_25:
    x6=td(x6,2);
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _24; else goto _17;
}