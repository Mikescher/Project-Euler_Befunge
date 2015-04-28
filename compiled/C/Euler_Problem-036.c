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
    goto _0;
_0:
    x0=9990;
    sa(0);
    sa(0);
    sa(999);
    sa((9)+(x0));
    sa(99);
    sa(99);
_1:
    if(sp()!=0)goto _2; else goto _3;
_2:
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
_3:
    x0=0;
    sp();
    sa(sr());
    sa(sr());
_4:
    sa(sr());
    {int64 v0=2;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=2;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _25; else goto _5;
_5:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _24; else goto _6;
_6:
    sp();
_7:
    sa(sp()-(1));
    sa(sr());
    if(sp()!=0)goto _8; else goto _9;
_8:
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
    goto _1;
_9:
    x0=990;
    sa(999);
    sa((9)+(x0));
    sa(99);
    sa(99);
_10:
    if(sp()!=0)goto _11; else goto _12;
_11:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*(10));
    x0=sp();
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _10;
_12:
    x0=0;
    sp();
    sa(sr());
    sa(sr());
_13:
    sa(sr());
    {int64 v0=2;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=2;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _23; else goto _14;
_14:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _22; else goto _15;
_15:
    sp();
_16:
    sa(sp()-(1));
    sa(sr());
    if(sp()!=0)goto _21; else goto _17;
_17:
    sa(61);
    printf("%c", (char)(32));
    printf("%c", (char)(sp()));
_18:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _20; else goto _19;
_19:
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    return 0;
_20:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _18;
_21:
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
    goto _10;
_22:
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _16;
_23:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*(2));
    x0=sp();
    goto _13;
_24:
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _7;
_25:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*(2));
    x0=sp();
    goto _4;
}