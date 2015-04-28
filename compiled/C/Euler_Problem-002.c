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
    int64 x0=62;
    int64 x1=118;
    int64 x2=118;
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    x1=2;
    x0=1;
    x2=2;
_1:
    sa(x0);
    sa(x1);
    x0=x1;
    sa(sp()+sp());
    sa(sr());
    x1=sp();
    sa(sr());
    {int64 v0=10240000;sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _5; else goto _2;
_2:
    sa(sr());
    sa(sr());
    {int64 v0=2;sa((v0==0)?0:(sp()/v0));}
    sa(sp()*(2));
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _3; else goto _4;
_3:
    sp();
    goto _1;
_4:
    sa(sp()+(x2));
    x2=sp();
    goto _1;
_5:
    printf("%lld", (int64)(x2));
    sp();
    return 0;
}