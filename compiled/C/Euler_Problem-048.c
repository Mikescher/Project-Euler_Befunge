/* compiled with BefunCompile v1.0 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int random(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 x0=32;
    int64 x1=32;
    int64 x2=32;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _2;
_0:
    if(sp()!=0)goto _4; else goto _3;
_1:
    if(sp()!=0)goto _6; else goto _7;
_2:
    x0=10000000000;
    sa(0);
    sa(1000);
    sa(1000);
    goto _0;
_3:
    sp();
    printf("%lld", (int64)(sp()));
    goto __;
_4:
    sa(sr());
    x2=sp();
    sa(sr());
    sa(sr());
    goto _5;
_5:
    x1=sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _1;
_6:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(x1);
    sa(sp()*sp());
    sa(x0);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _5;
_7:
    sp();
    sp();
    sa(x1);
    sa(sp()+sp());
    sa(x0);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(((x2)-(1)));
    sa(((x2)-(1)));
    goto _0;
__:
    return 0;
}