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
    goto _1;
_0:
    if(sp()!=0)goto _2; else goto _9;
_1:
    sa(0);
    sa(1);
    sa(1);
    sa(0);
    sa(59049);
    sa(59049);
    goto _0;
_2:
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+(1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _0;
_3:
    sa(sp()+(1));
    sa(sr());
    sa(sr());
    sa(sp()*(59049));
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _0;
_4:
    sa(sp()*(59049));
    goto _10;
_5:
    sp();
    sp();
    goto _12;
_6:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_7:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _12;
_8:
    sa(sr());
    goto _11;
_9:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _3; else goto _4;
_10:
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
    if(sp()!=0)goto _11; else goto _8;
_11:
    sa(sp()-(1));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _5; else goto _10;
_12:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _7; else goto _6;
}