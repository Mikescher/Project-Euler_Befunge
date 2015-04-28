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
    sa(0);
    sa(1);
    sa(1);
    sa(0);
    sa(59049);
    sa(59049);
_1:
    if(sp()!=0)goto _12; else goto _2;
_2:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _11; else goto _3;
_3:
    sa(sp()*(59049));
_4:
    sa(sr());
    sa(sr());
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _5; else goto _10;
_5:
    sa(sp()-(1));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _6; else goto _4;
_6:
    sp();
    sp();
_7:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _8; else goto _9;
_8:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _7;
_9:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_10:
    sa(sr());
    goto _5;
_11:
    sa(sp()+(1));
    sa(sr());
    sa(sr());
    sa(sp()*(59049));
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _1;
_12:
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+(1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _1;
}