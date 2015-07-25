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
    int64 t0;
    int64 x0=10000000000;
    int64 x1=32;
    int64 x2=32;
    s=(int64*)calloc(q,sizeof(int64));
    sa(0);
    sa(1000);
_1:
    x2=sr();
    sa(sr());
    x1=sr();
_2:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _5;else goto _3;
_3:
    sp();
    sp();
    sa(sp()+x1);
    sa(tm(sp(),x0));
    sa(x2-1);
    if(x2!=1)goto _1;else goto _4;
_4:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_5:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    t0=tm(sr()*x1,x0);
    x1=t0;
    goto _2;
}