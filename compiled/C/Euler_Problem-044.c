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
    int64 x0=1073741824;
    int64 x1=2;
    int64 x2=37;
    int64 x3=37;
    int64 x4=37;
    int64 x5=5;
    int64 x6=37;
    s=(int64*)calloc(q,sizeof(int64));
    sa(2LL);
    sa(5LL);
_1:
    sa(x1-1LL);
    sa(x1-1LL);
_2:
    if(sp()!=0)goto _4;else goto _3;
_3:
    sp();
    sp();
    sa(sp()+1LL);
    sa(sr());
    x1=sr();
    sa((sr()*3LL)-1LL);
    sa(sp()*sp());
    sa(td(sp(),2L));
    x5=sr();
    goto _1;
_4:
    x2=sr();
    sa((sr()*3LL)-1LL);
    sa(sp()*sp());
    sa(td(sp(),2L));
    x3=sr();
    x6=0LL;
    {int64 v0=sp();sa(sp()-v0);}
    sa(sp()*24LL);
    sa(sp()+1LL);
    x4=sr();
    sa(x0);
    sa(x0>x4?1:0);
_5:
    if(sp()!=0)goto _25;else goto _6;
_6:
    sa(sr());
    if(sp()!=0)goto _22;else goto _7;
_7:
    sp();
    sa(sp()-(x6*x6));
    sa(x6);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _21;else goto _8;
_8:
    sa(tm(sp(),6L));
    sa(sp()-5LL);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _9;else goto _15;
_9:
    sa(((x3+x5)*24LL)+1LL);
    sa(((x3+x5)*24LL)+1LL);
    x6=0LL;
    x4=sp();
    sa(x0);
    sa(x0>x4?1:0);
_10:
    if(sp()!=0)goto _20;else goto _11;
_11:
    sa(sr());
    if(sp()!=0)goto _17;else goto _12;
_12:
    sp();
    sa(sp()-(x6*x6));
    sa(x6);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _16;else goto _13;
_13:
    sa(tm(sp(),6L));
    sa(sp()-5LL);
    if(sp()!=0)goto _15;else goto _14;
_14:
    sp();
    printf("%lld", (int64)(x5-x3));
    return 0;
_15:
    sa(x5);
    sa(x2-1LL);
    sa(x2-1LL);
    goto _2;
_16:
    sp();
    goto _15;
_17:
    if((sr()+x6)<=x4)goto _19;else goto _18;
_18:
    x6=td(x6,2LL);
    sa(td(sp(),4L));
    sa(sr());
    if(sp()!=0)goto _17;else goto _12;
_19:
    sa(sr()+x6);
    sa(x4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    x4=sp();
    sa((sr()*2LL)+x6);
    x6=sp();
    x6=td(x6,2LL);
    sa(td(sp(),4L));
    goto _11;
_20:
    sa(td(sp(),4L));
    sa(sr()>x4?1:0);
    goto _10;
_21:
    sp();
    goto _15;
_22:
    if((sr()+x6)<=x4)goto _24;else goto _23;
_23:
    x6=td(x6,2LL);
    sa(td(sp(),4L));
    sa(sr());
    if(sp()!=0)goto _22;else goto _7;
_24:
    sa(sr()+x6);
    sa(x4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    x4=sp();
    sa((sr()*2LL)+x6);
    x6=sp();
    x6=td(x6,2LL);
    sa(td(sp(),4L));
    goto _6;
_25:
    sa(td(sp(),4L));
    sa(sr()>x4?1:0);
    goto _5;
}