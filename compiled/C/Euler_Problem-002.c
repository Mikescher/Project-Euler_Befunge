/* compiled with BefunCompile v1.0.1 (c) 2015 */
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
    int64 x0=62;
    int64 x1=118;
    int64 x2=118;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _2;
_0:
    if(sp()!=0)goto _4; else goto _5;
_1:
    if(sp()!=0)goto _7; else goto _6;
_2:
    x1=2;
    x0=1;
    x2=2;
    goto _3;
_3:
    sa(x0);
    sa(x1);
    x0=x1;
    sa(sp()+sp());
    sa(sr());
    x1=sp();
    sa(sr());
    sa(10240000);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _0;
_4:
    printf("%lld", (int64)(x2));
    sp();
    goto __;
_5:
    sa(sr());
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(2);
    sa(sp()*sp());
    {int64 v0=sp();sa(sp()-v0);}
    goto _1;
_6:
    sa(x2);
    sa(sp()+sp());
    x2=sp();
    goto _3;
_7:
    sp();
    goto _3;
__:
    return 0;
}