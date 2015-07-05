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
    sa(3LL);
    sa(3LL);
_1:
    if(sr()-2L==0)goto _2;else goto _11;
_2:
    sp();
_3:
    x2=x2+1LL;
_4:
    sa(x1+1LL);
    x1=x1+1LL;
    sa((sp()<(x2*10L))?1:0);
    if(sp()!=0)goto _5;else goto _10;
_5:
    sa(sp()+x0);
    if(tm(x1,4LL)!=0)goto _6;else goto _9;
_6:
    sa(sr());
    sa(sr()<2L?1:0);
_7:
    if(sp()!=0)goto _8;else goto _1;
_8:
    sp();
    goto _4;
_9:
    x0=x0+2LL;
    sa(sr());
    sa(sr()<2L?1:0);
    goto _7;
_10:
    sp();
    printf("%lld", (int64)(((td(x1-2LL,4LL))*2LL)+3LL));
    return 0;
_11:
    if(tm(sr(),2L)==0)goto _8;else goto _12;
_12:
    if(sr()<9L)goto _2;else goto _13;
_13:
    if(tm(sr(),3L)==0)goto _8;else goto _14;
_14:
    if(tm(sr(),5L)==0)goto _8;else goto _15;
_15:
    x4=1LL;
_16:
    sa(sr());
    sa(x4+1LL);
    x4=x4+1LL;
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    x3=sr();
    sa(sp()-1LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_17:
    if(tm(sr(),2L)==0)goto _35;else goto _18;
_18:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    x5=sp();
    x7=x3;
    x6=sp();
    x8=sp();
    x9=1LL;
    sa(0LL);
    sa(x6);
    sa((x6!=0)?0:1);
_19:
    if(sp()!=0)goto _20;else goto _34;
_20:
    sp();
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_21:
    sa(sr());
    if(sp()!=0)goto _22;else goto _25;
_22:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sp()*sp());
    sa(tm(sp(),x7));
    sa(td(x9,2LL));
    x9=td(x9,2LL);
    sa(x6);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}
    sa(tm(sp(),2L));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _23;else goto _24;
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
    if(sp()!=0)goto _27;else goto _31;
_27:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(tm(sp(),x3));
    sa(sp()-1LL);
    sa((sp()!=0)?0:1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sr()-1L!=0)?1:0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-x3);
    sa(sp()+1LL);
    sa((sp()!=0)?0:1);
    sa((sp()!=0)?0:1);
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()-3LL);
    if(sp()!=0)goto _30;else goto _28;
_28:
    sp();
    sp();
    sa(x4);
_29:
    sp();
    sp();
    goto _4;
_30:
    sa(sr());
    sa(sp()*sp());
    sa(tm(sp(),x3));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    sa(sr());
    goto _26;
_31:
    sp();
    sa(sp()-1LL);
    sa((sp()!=0)?0:1);
    sa((sp()!=0)?0:1);
    sa(x4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _32;else goto _29;
_32:
    sa(sp()-3LL);
    if(sp()!=0)goto _16;else goto _33;
_33:
    sp();
    goto _3;
_34:
    x9=x9*2LL;
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),2L));
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _19;
_35:
    sa(td(sp(),2L));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _17;
}