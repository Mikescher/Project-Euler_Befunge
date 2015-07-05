/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    int64 x0=1;
    int64 x1=32;
    int64 x2=32;
    s=(int64*)calloc(q,sizeof(int64));
    sa(0LL);
    sa(1LL);
    sa(10LL);
    sa(100LL);
    sa(1000LL);
    sa(10000LL);
    sa(100000LL);
    sa(1000000LL);
_1:
    x1=1LL;
    x2=1LL;
_2:
    if(sr()<=x1*9L*x2)goto _3;else goto _9;
_3:
    sa(sp()-1LL);
    sa((td(sr(),x1))+x2);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),x1));
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _7;else goto _4;
_4:
    sa(sr());
    if(sp()!=0)goto _7;else goto _5;
_5:
    sp();
    sa(tm(sp(),10L));
    sa(sp()*x0);
    x0=sp();
    sa(sr());
    if(sp()!=0)goto _1;else goto _6;
_6:
    sp();
    printf("%lld", (int64)(x0));
    return 0;
_7:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _7;else goto _5;
_9:
    sa(x1*9LL*x2);
    x1=x1+1LL;
    x2=x2*10LL;
    {int64 v0=sp();sa(sp()-v0);}
    goto _2;
}