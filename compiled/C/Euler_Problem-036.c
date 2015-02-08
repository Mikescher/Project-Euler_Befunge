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
    s=(int64*)calloc(q,sizeof(int64));
    goto _2;
_0:
    if(sp()!=0)goto _18; else goto _3;
_1:
    if(sp()!=0)goto _15; else goto _7;
_2:
    x0=9990;
    sa(0);
    sa(0);
    sa(999);
    sa((9)+(x0));
    sa(99);
    sa(99);
    goto _0;
_3:
    x0=0;
    sp();
    sa(sr());
    sa(sr());
    goto _19;
_4:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*(2));
    x0=sp();
    goto _19;
_5:
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _21;
_6:
    x0=990;
    sa(999);
    sa((9)+(x0));
    sa(99);
    sa(99);
    goto _1;
_7:
    x0=0;
    sp();
    sa(sr());
    sa(sr());
    goto _22;
_8:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*(2));
    x0=sp();
    goto _22;
_9:
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _24;
_10:
    sa(sr());
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sp()*(10));
    x0=sp();
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _1;
_11:
    sa(61);
    printf("%c", (char)(32));
    printf("%c", (char)(sp()));
    goto _25;
_12:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _25;
_13:
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    return 0;
_14:
    sp();
    goto _24;
_15:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*(10));
    x0=sp();
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _1;
_16:
    sa(sr());
    sa(sr());
    sa(sp()*(10));
    x0=sp();
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _0;
_17:
    sp();
    goto _21;
_18:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*(10));
    x0=sp();
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _0;
_19:
    sa(sr());
    {int64 v0=2;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=2;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _4; else goto _20;
_20:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _5; else goto _17;
_21:
    sa(sp()-(1));
    sa(sr());
    if(sp()!=0)goto _16; else goto _6;
_22:
    sa(sr());
    {int64 v0=2;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=2;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _8; else goto _23;
_23:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _9; else goto _14;
_24:
    sa(sp()-(1));
    sa(sr());
    if(sp()!=0)goto _10; else goto _11;
_25:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _12; else goto _13;
}