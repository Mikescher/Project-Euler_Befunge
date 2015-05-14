/* compiled with BefunCompile v1.0.5 (c) 2015 */
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
    int64 x0=10;
    int64 x1=1;
    int64 x2=88;
    int64 x3=1;
    int64 x4=88;
    s=(int64*)calloc(q,sizeof(int64));
    sa(10);
    sa(1);
    sa(1);
    sa(1);
    sa(1);
_1:
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(2));
    sa(sp()*(x1));
    x1=sp();
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _1;
_3:
    x2=2;
    sp();
    sa(sr());
    sa(x2);
_4:
    x4=1;
    sa(sp()*sp());
    sa(sp()*(10));
_5:
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _6;else goto _13;
_6:
    sp();
    if((x4-x1)!=0)goto _10;else goto _7;
_7:
    sa(x2+1);
    x2=x2+1;
    sa(sp()-(7));
    if(sp()!=0)goto _8;else goto _9;
_8:
    sa(sr());
    sa(x2);
    goto _4;
_9:
    printf("%lld", (int64)(sp()));
    sp();
    sp();
    return 0;
_10:
    sp();
    sa(sp()+(1));
    sa(sr());
    sa(x3);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _11;else goto _12;
_11:
    sp();
    sa(sp()*(10));
    sa(sr());
    x0=sp();
    sa(sr());
    {int64 v0=6;sa((v0==0)?0:(sp()/v0));}
    x3=sp();
    x1=1;
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(sr());
    sa(sp()*(10));
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _1;
_12:
    x1=1;
    sa(sr());
    sa(sr());
    sa(sp()*(10));
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _1;
_13:
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(2));
    sa(sp()*(x4));
    x4=sp();
    goto _5;
}