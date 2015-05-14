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
    int64 x0=1152921504606846976;
    int64 x1=991873;
    int64 x2=0;
    s=(int64*)calloc(q,sizeof(int64));
    sa(144);
    sa(991873);
_1:
    sa(x0);
    sa((x0)>(x1)?1:0);
_2:
    if(sp()!=0)goto _12;else goto _3;
_3:
    sa(sr());
    if(sp()!=0)goto _4;else goto _6;
_4:
    sa(sr());
    sa(sp()+(x2));
    {int64 v0=x1;sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _11;else goto _5;
_5:
    x2=td(x2,2);
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _4;else goto _6;
_6:
    sp();
    sa(sp()-(x2*x2));
    sa(((tm(x2,6))-5!=0)?0:1);
    if(sp()!=0)goto _7;else goto _10;
_7:
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _8;else goto _9;
_8:
    sa(sr());
    sa(sp()*(2));
    sa(sp()-(1));
    sa(sp()*sp());
    printf("%lld", (int64)(sp()));
    return 0;
_9:
    x2=0;
    sa(sp()+(1));
    sa(sr());
    sa(sr());
    sa(sp()*(2));
    sa(sp()-(1));
    sa(sp()*sp());
    sa(sp()*(24));
    sa(sp()+(1));
    sa(sr());
    x1=sp();
    goto _1;
_10:
    x2=0;
    sp();
    sa(sp()+(1));
    sa(sr());
    sa(sr());
    sa(sp()*(2));
    sa(sp()-(1));
    sa(sp()*sp());
    sa(sp()*(24));
    sa(sp()+(1));
    sa(sr());
    x1=sp();
    goto _1;
_11:
    sa(sr());
    sa(sp()+(x2));
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    x1=sp();
    sa(sr());
    sa(sp()*(2));
    sa(sp()+(x2));
    x2=sp();
    x2=td(x2,2);
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    goto _3;
_12:
    {int64 v0=4;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=x1;sa((sp()>v0)?1:0);}
    goto _2;
}