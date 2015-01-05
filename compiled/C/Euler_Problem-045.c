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
    goto _6;
_0:
    if(sp()!=0)goto _17; else goto _8;
_1:
    if(sp()!=0)goto _9; else goto _11;
_2:
    if(sp()!=0)goto _16; else goto _10;
_3:
    if(sp()!=0)goto _9; else goto _11;
_4:
    if(sp()!=0)goto _13; else goto _12;
_5:
    if(sp()!=0)goto _15; else goto _14;
_6:
    x0=1152921504606846976;
    x2=0;
    x1=991873;
    sa(144);
    sa(991873);
    goto _7;
_7:
    sa(x0);
    sa((((x0)>(x1))?1:0));
    goto _0;
_8:
    sa(sr());
    goto _1;
_9:
    sa(sr());
    sa(x2);
    sa(sp()+sp());
    sa(x1);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    goto _2;
_10:
    x2=td(x2,2);
    sa(4);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _3;
_11:
    sp();
    sa(((x2)*(x2)));
    {int64 v0=sp();sa(sp()-v0);}
    sa(((((tm(x2,6))-(5)))!=0)?0:1);
    goto _4;
_12:
    x2=0;
    sp();
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(sr());
    sa(2);
    sa(sp()*sp());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sp()*sp());
    sa(24);
    sa(sp()*sp());
    sa(1);
    sa(sp()+sp());
    sa(sr());
    x1=sp();
    goto _7;
_13:
    sa((sp()!=0)?0:1);
    goto _5;
_14:
    x2=0;
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(sr());
    sa(2);
    sa(sp()*sp());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sp()*sp());
    sa(24);
    sa(sp()*sp());
    sa(1);
    sa(sp()+sp());
    sa(sr());
    x1=sp();
    goto _7;
_15:
    sa(sr());
    sa(2);
    sa(sp()*sp());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sp()*sp());
    printf("%lld", (int64)(sp()));
    goto __;
_16:
    sa(sr());
    sa(x2);
    sa(sp()+sp());
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    x1=sp();
    sa(sr());
    sa(2);
    sa(sp()*sp());
    sa(x2);
    sa(sp()+sp());
    x2=sp();
    x2=td(x2,2);
    sa(4);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    goto _8;
_17:
    sa(4);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(x1);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _0;
__:
    return 0;
}