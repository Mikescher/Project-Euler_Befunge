/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
    int64 t0,t1;
    int64 x0=1000000;
    int64 x1=0;
    int64 x2=1;
    int64 x3=0;
    int64 x4=35;
    int64 x5=35;
    int64 x6=35;
    s=(int64*)calloc(q,sizeof(int64));
    sa(1);
    sa(2);
    sa(4+(x2*x2));
    sa((tm(4+(x2*x2),64))>57?1:0);
_1:
    if(sp()!=0)goto _3;else goto _2;
_2:
    t0=tm(sr(),16);

    if(t0>9)goto _3;else goto _9;
_3:
    sp();
_4:
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _5;else goto _8;
_5:
    sp();
    t0=x3+x1;
    x1=x3+x1;
    t0=t0>x0?1:0;

    if((t0)!=0)goto _6;else goto _7;
_6:
    printf("%lld ", (int64)(sp()));
    return 0;
_7:
    sa(sp()+1LL);

    sa(sr());
    x2=sr();
    x3=0;
    sa(sp()*2LL);

    sa(sp()+1LL);

    sa(sp()-1LL);

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()+(x2*x2));

    sa((tm(sr(),64))>57?1:0);
    goto _1;
_8:
    sa(sp()-1LL);

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()+(x2*x2));

    sa((tm(sr(),64))>57?1:0);
    goto _1;
_9:
    if(t0!=2)goto _10;else goto _3;
_10:
    if(t0!=3)goto _11;else goto _3;
_11:
    if(t0!=5)goto _12;else goto _3;
_12:
    if(t0!=6)goto _13;else goto _3;
_13:
    if(t0!=7)goto _14;else goto _3;
_14:
    t0-=8;
    t0=(t0!=0)?0:1;

    if((t0)!=0)goto _3;else goto _15;
_15:
    t0=tm(sr(),10);

    if(t0-7==0)goto _3;else goto _16;
_16:
    if(t0-3==0)goto _3;else goto _17;
_17:
    t0-=2;
    t0=(t0!=0)?0:1;

    if((t0)!=0)goto _3;else goto _18;
_18:
    if((tm(sr(),3))!=2)goto _19;else goto _3;
_19:
    x4=0;
    x5=sr();
_20:
    x6=sr();
    sa(sr());
    t0=x5;
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}

    t1=sp();
    sa(sp()+t1);

    sa(td(sp(),2));


    if(sr()!=x6)goto _26;else goto _21;
_21:
    sp();

    if((x6*x6)-x5==0)goto _22;else goto _4;
_22:
    if(sr()>x2)goto _25;else goto _23;
_23:
    sa((td(sr(),2))+x3);
_24:
    x3=sp();
    goto _4;
_25:
    t0=td(sr()+1,2);
    t1=x2;
    sa(t1-t0);
    sa(sp()+1LL);

    sa(sp()+x3);
    goto _24;
_26:
    if(sr()!=x4)goto _27;else goto _21;
_27:
    x4=x6;
    goto _20;
}
