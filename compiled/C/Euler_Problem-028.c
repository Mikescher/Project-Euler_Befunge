/* compiled with BefunCompile v1.0.3 (c) 2015 */
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
    int64 x0=88;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _2;
_0:
    if(sp()!=0)goto _3; else goto _4;
_1:
    if(sp()!=0)goto _5; else goto _6;
_2:
    x0=1000;
    sa(1002001);
    sa((1002001)-(x0));
    sa(((1002001)-(x0))-(x0));
    sa((((1002001)-(x0))-(x0))-(x0));
    sa(((((1002001)-(x0))-(x0))-(x0))-(x0));
    sa((((((1002001)-(x0))-(x0))-(x0))-(x0))-(1));
    goto _0;
_3:
    x0=(x0)-(2);
    sa(sr());
    sa(x0);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(x0);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(x0);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(x0);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    goto _0;
_4:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _1;
_5:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _4;
_6:
    sp();
    printf("%lld", (int64)(sp()));
    goto __;
__:
    return 0;
}