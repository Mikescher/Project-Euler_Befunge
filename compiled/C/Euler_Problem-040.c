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
    s=(int64*)calloc(q,sizeof(int64));
    goto _2;
_0:
    if(sp()!=0)goto _3; else goto _7;
_1:
    if(sp()!=0)goto _5; else goto _4;
_2:
    x0=1;
    sa(0);
    sa(1);
    sa(10);
    sa(100);
    sa(1000);
    sa(10000);
    sa(100000);
    sa(1000000);
    sa(1000000);
    goto _0;
_3:
    x1=1;
    x2=1;
    goto _8;
_4:
    sp();
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()*(x0));
    x0=sp();
    sa(sr());
    goto _0;
_5:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-(1));
    sa(sr());
    goto _1;
_6:
    sa((x1)*((9)*(x2)));
    x1=(x1)+(1);
    x2=(x2)*(10);
    {int64 v0=sp();sa(sp()-v0);}
    goto _8;
_7:
    sp();
    printf("%lld", (int64)(x0));
    return 0;
_8:
    sa(sr());
    {int64 v0=(x1)*((9)*(x2));sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _9; else goto _6;
_9:
    sa(sp()-(1));
    sa(sr());
    {int64 v0=x1;sa((v0==0)?0:(sp()/v0));}
    sa(sp()+(x2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=x1;sa((v0==0)?0:(sp()%v0));}
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    sa(sp()-(1));
    sa(sr());
    if(sp()!=0)goto _5; else goto _10;
_10:
    sa(sr());
    if(sp()!=0)goto _5; else goto _4;
}