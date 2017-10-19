/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    int64 t0,t1,t2;
    int64 x0=2;
    int64 x1=1;
    int64 x2=0;
    int64 x3=35;
    int64 x4=35;
    int64 x5=35;
    int64 x6=35;
    int64 x7=35;
    int64 x8=35;
    int64 x9=35;
    s=(int64*)calloc(q,sizeof(int64));
    sa(3);
    sa(3);
    sa(0);
_1:
    if(sp()!=0)goto _2;else goto _8;
_2:
    sp();
_3:
    t0=x1+1;
    x1++;
    t0=t0<(x2*10)?1:0;

    if((t0)!=0)goto _4;else goto _7;
_4:
    sa(sp()+x0);


    if((x1%4)!=0)goto _5;else goto _6;
_5:
    sa(sr());
    sa(sr()<2?1:0);
    goto _1;
_6:
    x0+=2;
    sa(sr());
    sa(sr()<2?1:0);
    goto _1;
_7:
    printf("%lld ", (((x1-2)/4)*2)+3);
    sp();
    return 0;
_8:
    if(sr()!=2)goto _10;else goto _9;
_9:
    sp();
    x2++;
    goto _3;
_10:
    if((sr()%2)!=0)goto _11;else goto _2;
_11:
    if(sr()<9)goto _9;else goto _12;
_12:
    if((sr()%3)!=0)goto _13;else goto _2;
_13:
    if((sr()%5)!=0)goto _14;else goto _2;
_14:
    x4=1;
    sa(-2);
_15:
    if(sp()!=0)goto _16;else goto _9;
_16:
    t0=x4+1;
    x4++;
    sa(sr());
    x3=sr();
    t1=0;
    sa(sp()-1LL);
_17:
    if((sr()%2)!=0)goto _18;else goto _35;
_18:
    x5=t1;
    x7=x3;
    x6=sp();
    x8=t0;
    x9=1;
    sa(0);
    sa(x6);
    sa(x6);
_19:
    if(sp()!=0)goto _34;else goto _20;
_20:
    sp();
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_21:
    sa(sr());

    if(sp()!=0)goto _22;else goto _25;
_22:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),x7));

    t0=x9/2;
    x9/=2;
    t1=x6;
    t2=td(t1,t0);
    t2%=2;

    if((t2)!=0)goto _24;else goto _23;
_23:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    goto _21;
_24:
    sa(sp()*x8);

    sa(tm(sp(),x7));
    goto _23;
_25:
    sp();
    sa(x5);
    sa(x5);
_26:
    if(sp()!=0)goto _27;else goto _33;
_27:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    t0=sp();
    t0%=x3;
    t0--;
    t0=(t0!=0)?0:1;
    t1=(sr()-1!=0)?1:0;
    sa(sp()-x3);

    sa(sp()+1LL);

    sa((sp()!=0)?0:1);
    sa((sp()!=0)?0:1);
    sa(t1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());

    t2=sp();
    t1=t0+t2;
    t1-=3;

    if((t1)!=0)goto _32;else goto _28;
_28:
    sp();
    sp();
    sa(x4);
    sa(1);
_29:
    if(sp()!=0)goto _30;else goto _31;
_30:
    sp();
    sp();
    goto _3;
_31:
    sa(sp()-3LL);
    goto _15;
_32:
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),x3));

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);

    sa(sr());
    goto _26;
_33:
    sp();
    sa(sp()-1LL);

    sa((sp()!=0)?0:1);
    sa((sp()!=0)?0:1);
    sa(x4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _29;
_34:
    x9*=2;
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/2LL);

    sa(sr());
    goto _19;
_35:
    t1++;
    sa(sp()/2LL);
    goto _17;
}
