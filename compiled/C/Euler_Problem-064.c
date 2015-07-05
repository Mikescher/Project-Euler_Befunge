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
    int64 x0=10000;
    int64 x1=35;
    int64 x2=35;
    int64 x3=9;
    int64 x4=35;
    int64 x5=35;
    int64 x6=0;
    int64 x7=1;
    s=(int64*)calloc(q,sizeof(int64));
    sa(0LL);
    sa(10000LL);
    sa(0LL);
_1:
    sa(x0);
    x4=0LL;
    x1=sr();
_2:
    x2=sr();
    sa(sr());
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}
    sa(sp()+sp());
    sa(td(sp(),2L));
    if(sr()!=x2)goto _15;else goto _3;
_3:
    sp();
    sa(x2);
    if((x2*x2)!=x0)goto _12;else goto _4;
_4:
    sa(0LL);
_5:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _11;else goto _6;
_6:
    sp();
    sa(tm(sp(),2L));
    if(sp()!=0)goto _8;else goto _7;
_7:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_8:
    if(sr()!=2LL)goto _10;else goto _9;
_9:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_10:
    x3=9LL;
    sa(sp()-1LL);
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    x0=sp();
    x6=0LL;
    x7=1LL;
    goto _1;
_11:
    sp();
    sa(sp()+1LL);
    goto _5;
_12:
    x5=sr();
    sa(sp()+x6);
    sa(td(sp(),x7));
    sa((sr()*x7)-x6);
    x6=sp();
_13:
    if(((x7-1LL)+x3)!=0)goto _14;else goto _4;
_14:
    x7=td(x0-(x6*x6),x7);
    x3=0LL;
    sa(td(x5+x6,x7));
    x6=((td(x5+x6,x7))*x7)-x6;
    goto _13;
_15:
    if(sr()!=x4)goto _16;else goto _3;
_16:
    x4=x2;
    goto _2;
}