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
    int64 x0=88;
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    x0=1000;
    sa(1002001);
    sa((1002001)-(x0));
    sa(((1002001)-(x0))-(x0));
    sa((((1002001)-(x0))-(x0))-(x0));
    sa(((((1002001)-(x0))-(x0))-(x0))-(x0));
    sa((((((1002001)-(x0))-(x0))-(x0))-(x0))-(1));
_1:
    if(sp()!=0)goto _5; else goto _2;
_2:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _4; else goto _3;
_3:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_4:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _2;
_5:
    x0=(x0)-(2);
    sa(sr());
    sa(sp()-(x0));
    sa(sr());
    sa(sp()-(x0));
    sa(sr());
    sa(sp()-(x0));
    sa(sr());
    sa(sp()-(x0));
    sa(sr());
    sa(sp()-(1));
    goto _1;
}