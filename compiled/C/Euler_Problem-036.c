/* compiled with BefunCompile v1.0.1 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 x0=32;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _9;
_0:
    if(sp()!=0)goto _32; else goto _10;
_1:
    if(sp()!=0)goto _12; else goto _13;
_2:
    if(sp()!=0)goto _14; else goto _31;
_3:
    if(sp()!=0)goto _30; else goto _16;
_4:
    if(sp()!=0)goto _29; else goto _17;
_5:
    if(sp()!=0)goto _19; else goto _20;
_6:
    if(sp()!=0)goto _21; else goto _28;
_7:
    if(sp()!=0)goto _23; else goto _24;
_8:
    if(sp()!=0)goto _26; else goto _27;
_9:
    x0=9990;
    sa(0);
    sa(0);
    sa(999);
    sa((9)+(x0));
    sa(99);
    sa(99);
    goto _0;
_10:
    x0=0;
    sp();
    sa(sr());
    sa(sr());
    goto _11;
_11:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(x0);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _1;
_12:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    sa(sp()*sp());
    x0=sp();
    goto _11;
_13:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _2;
_14:
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _15;
_15:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _3;
_16:
    x0=990;
    sa(999);
    sa((9)+(x0));
    sa(99);
    sa(99);
    goto _4;
_17:
    x0=0;
    sp();
    sa(sr());
    sa(sr());
    goto _18;
_18:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(x0);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _5;
_19:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    sa(sp()*sp());
    x0=sp();
    goto _18;
_20:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _6;
_21:
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _22;
_22:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _7;
_23:
    sa(sr());
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(10);
    sa(sp()*sp());
    x0=sp();
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(x0);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _4;
_24:
    sa(61);
    printf("%c", (char)(32));
    printf("%c", (char)(sp()));
    goto _25;
_25:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _8;
_26:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _25;
_27:
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    goto __;
_28:
    sp();
    goto _22;
_29:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    sa(sp()*sp());
    x0=sp();
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(x0);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _4;
_30:
    sa(sr());
    sa(sr());
    sa(10);
    sa(sp()*sp());
    x0=sp();
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(x0);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _0;
_31:
    sp();
    goto _15;
_32:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    sa(sp()*sp());
    x0=sp();
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(x0);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _0;
__:
    return 0;
}