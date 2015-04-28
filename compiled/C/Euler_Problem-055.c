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
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    sa(0);
    sa(10000);
    sa(10000);
    sa(0);
    sa(10000);
    sa(0);
_1:
    if(sp()!=0)goto _3; else goto _2;
_2:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*(10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    x1=sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+(x1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _1;
_3:
    sp();
    sa(sp()+sp());
    sa(24);
    sa(0);
_4:
    if(sp()!=0)goto _14; else goto _5;
_5:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_6:
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _7; else goto _13;
_7:
    sp();
    sa(sr());
    x0=sp();
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _8; else goto _9;
_8:
    sa(sr());
    sp();
    sa(sp()+(x0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-(1));
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _4;
_9:
    sp();
    sp();
_10:
    sa(sp()-(1));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _11; else goto _12;
_11:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_12:
    sa(sr());
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _1;
_13:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*(10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    x1=sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+(x1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    goto _6;
_14:
    sp();
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+(1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _10;
}