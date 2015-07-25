/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
    int64 t0,t1;
    int64 x0=32;
    int64 x1=32;
    s=(int64*)calloc(q,sizeof(int64));
    sa(0);
    sa(10000);
    sa(10000);
    sa(0);
    sa(10000);
_1:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*10LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    t0=tm(sr(),10);
    x1=t0;
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));
    sa(sr());
    sa((sp()!=0)?0:1);
_2:
    if(sp()!=0)goto _3;else goto _1;
_3:
    sp();
    sa(sp()+sp());
    sa(24);
_4:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sr());
    t0=0;
_5:
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _6;else goto _13;
_6:
    sp();
    x0=t0;
    sa(sp()-t0);
    t1=sp();
    if((t1)!=0)goto _7;else goto _12;
_7:
    sa(sr());
    sp();
    sa(sp()+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _8;else goto _4;
_8:
    sp();
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_9:
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _10;else goto _11;
_10:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_11:
    sa(sr());
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _2;
_12:
    sp();
    sp();
    goto _9;
_13:
    t0=t0*10;
    t1=tm(sr(),10);
    x1=t1;
    t0=t0+x1;
    sa(td(sp(),10));
    goto _5;
}