/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
_1:
    if(sr()-2==0)goto _2;else goto _11;
_2:
    sp();
    x2++;
_4:
    t0=x1+1;
    x1++;
    t0=t0<(x2*10)?1:0;

    if((t0)!=0)goto _5;else goto _10;
_5:
    sa(sp()+x0);


    if(tm(x1,4)!=0)goto _6;else goto _9;
_6:
    sa(sr());
    sa(sr()<2?1:0);
_7:
    if(sp()!=0)goto _8;else goto _1;
_8:
    sp();
    goto _4;
_9:
    x0+=2;
    sa(sr());
    sa(sr()<2?1:0);
    goto _7;
_10:
    printf("%lld", ((td(x1-2,4))*2)+3);
    sp();
    return 0;
_11:
    if(tm(sr(),2)==0)goto _8;else goto _12;
_12:
    if(sr()<9)goto _2;else goto _13;
_13:
    if(tm(sr(),3)==0)goto _8;else goto _14;
_14:
    if(tm(sr(),5)==0)goto _8;else goto _15;
_15:
    x4=1;
_16:
    sa(sr());
    t0=x4+1;
    x4++;
    x3=sr();
    sa(sp()-1LL);

    t1=0;
_17:
    if(tm(sr(),2)==0)goto _18;else goto _19;
_18:
    sa(td(sp(),2));

    t1++;
    goto _17;
_19:
    x5=t1;
    x7=x3;
    x6=sp();
    x8=t0;
    x9=1;
    sa(0);
    sa(x6);
    sa((x6!=0)?0:1);
_20:
    if(sp()!=0)goto _21;else goto _34;
_21:
    sp();
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_22:
    sa(sr());

    if(sp()!=0)goto _23;else goto _26;
_23:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),x7));

    t0=td(x9,2);
    x9/=2;
    t1=x6;
    t2=td(t1,t0);
    t2%=2;
    t2=(t2!=0)?0:1;

    if((t2)!=0)goto _24;else goto _25;
_24:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    goto _22;
_25:
    sa(sp()*x8);

    sa(tm(sp(),x7));
    goto _24;
_26:
    sp();
    sa(x5);
    sa(x5);
_27:
    if(sp()!=0)goto _28;else goto _32;
_28:
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

    if((t1)!=0)goto _31;else goto _29;
_29:
    sp();
    sp();
    sa(x4);
_30:
    sp();
    sp();
    goto _4;
_31:
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),x3));

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);

    sa(sr());
    goto _27;
_32:
    sp();
    sa(sp()-1LL);

    sa((sp()!=0)?0:1);
    sa((sp()!=0)?0:1);
    sa(x4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _33;else goto _30;
_33:
    sa(sp()-3LL);


    if(sp()!=0)goto _16;else goto _2;
_34:
    x9*=2;
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),2));

    sa(sr());
    sa((sp()!=0)?0:1);
    goto _20;
}
