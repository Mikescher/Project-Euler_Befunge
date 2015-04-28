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
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    sa(1);
    sa(2);
    sa(2);
    sa(0);
_1:
    if(sp()!=0)goto _9; else goto _2;
_2:
    sa(sr());
    sa(sr());
    {int64 v0=5;sa((v0==0)?0:(sp()/v0));}
    sa(sp()*(5));
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _9; else goto _3;
_3:
    sa(sr());
    sa(sp()-(1000));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _4; else goto _8;
_4:
    sp();
    sp();
    sp();
_5:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sp()-(1));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _6; else goto _7;
_6:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_7:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _5;
_8:
    sp();
    sa(sp()+(1));
    sa(sr());
    sa(sr());
    sa(sr());
    {int64 v0=3;sa((v0==0)?0:(sp()/v0));}
    sa(sp()*(3));
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _1;
_9:
    sa(sr());
    goto _3;
}