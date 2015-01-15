/* compiled with BefunCompile v1.0.2 (c) 2015 */
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
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _5;
_0:
    if(sp()!=0)goto _6; else goto _7;
_1:
    if(sp()!=0)goto _16; else goto _8;
_2:
    if(sp()!=0)goto _11; else goto _10;
_3:
    if(sp()!=0)goto _12; else goto _9;
_4:
    if(sp()!=0)goto _15; else goto _14;
_5:
    sa(0);
    sa(1);
    sa(1);
    sa(0);
    sa(59049);
    sa(59049);
    goto _0;
_6:
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _0;
_7:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    goto _1;
_8:
    sa(59049);
    sa(sp()*sp());
    goto _9;
_9:
    sa(sr());
    sa(sr());
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
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
    goto _2;
_10:
    sa(sr());
    goto _11;
_11:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _3;
_12:
    sp();
    sp();
    goto _13;
_13:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _4;
_14:
    sp();
    printf("%lld", (int64)(sp()));
    goto __;
_15:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _13;
_16:
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(sr());
    sa(59049);
    sa(sp()*sp());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _0;
__:
    return 0;
}