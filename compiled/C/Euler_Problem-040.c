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
    int64 x0=32;
    int64 x1=32;
    int64 x2=32;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _5;
_0:
    if(sp()!=0)goto _6; else goto _13;
_1:
    if(sp()!=0)goto _9; else goto _8;
_2:
    if(sp()!=0)goto _12; else goto _10;
_3:
    if(sp()!=0)goto _12; else goto _11;
_4:
    if(sp()!=0)goto _12; else goto _11;
_5:
    x0=1;
    sa(0);
    sa(1);
    sa(10);
    sa(100);
    sa(1000);
    sa(10000);
    sa(100000);
    sa(1000000);
    sa(1000000);
    goto _0;
_6:
    x1=1;
    x2=1;
    goto _7;
_7:
    sa(sr());
    sa((x1)*((9)*(x2)));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    goto _1;
_8:
    sa((x1)*((9)*(x2)));
    x1=(x1)+(1);
    x2=(x2)*(10);
    {int64 v0=sp();sa(sp()-v0);}
    goto _7;
_9:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(x1);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(x2);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(x1);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _2;
_10:
    sa(sr());
    goto _4;
_11:
    sp();
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(x0);
    sa(sp()*sp());
    x0=sp();
    sa(sr());
    goto _0;
_12:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _3;
_13:
    sp();
    printf("%lld", (int64)(x0));
    goto __;
__:
    return 0;
}