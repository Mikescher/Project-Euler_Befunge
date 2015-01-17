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
    int64 x1=88;
    int64 x2=88;
    int64 x3=88;
    int64 x4=88;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _5;
_0:
    if(sp()!=0)goto _17; else goto _6;
_1:
    if(sp()!=0)goto _10; else goto _9;
_2:
    if(sp()!=0)goto _16; else goto _15;
_3:
    if(sp()!=0)goto _13; else goto _12;
_4:
    if(((x4)-(x1))!=0)goto _14;else goto _11;
_5:
    x0=10;
    x3=1;
    x1=1;
    sa(10);
    sa(1);
    sa(1);
    sa(1);
    sa(1);
    goto _0;
_6:
    x2=2;
    sp();
    sa(sr());
    sa(x2);
    goto _7;
_7:
    x4=1;
    sa(sp()*sp());
    sa(10);
    sa(sp()*sp());
    goto _8;
_8:
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _1;
_9:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(2);
    sa(sp()+sp());
    sa(x4);
    sa(sp()*sp());
    x4=sp();
    goto _8;
_10:
    sp();
    goto _4;
_11:
    sa((x2)+(1));
    x2=(x2)+(1);
    sa(7);
    {int64 v0=sp();sa(sp()-v0);}
    goto _3;
_12:
    printf("%lld", (int64)(sp()));
    sp();
    sp();
    goto __;
_13:
    sa(sr());
    sa(x2);
    goto _7;
_14:
    sp();
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(x3);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    goto _2;
_15:
    x1=1;
    sa(sr());
    sa(sr());
    sa(10);
    sa(sp()*sp());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _0;
_16:
    sp();
    sa(10);
    sa(sp()*sp());
    sa(sr());
    x0=sp();
    sa(sr());
    sa(6);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    x3=sp();
    x1=1;
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(sr());
    sa(10);
    sa(sp()*sp());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _0;
_17:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(2);
    sa(sp()+sp());
    sa(x1);
    sa(sp()*sp());
    x1=sp();
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _0;
__:
    return 0;
}