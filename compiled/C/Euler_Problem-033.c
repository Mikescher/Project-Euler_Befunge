/* compiled with BefunCompile v1.0 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int random(){return rand()%2==0;}
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
    int64 x3=32;
    int64 x4=32;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _17;
_0:
    if(sp()!=0)goto _20; else goto _19;
_1:
    if(sp()!=0)goto _21; else goto _22;
_2:
    if(sp()!=0)goto _24; else goto _28;
_3:
    if(sp()!=0)goto _28; else goto _25;
_4:
    if(sp()!=0)goto _29; else goto _31;
_5:
    if(sp()!=0)goto _31; else goto _30;
_6:
    if(sp()!=0)goto _32; else goto _34;
_7:
    if(sp()!=0)goto _34; else goto _33;
_8:
    if(sp()!=0)goto _35; else goto _27;
_9:
    if(sp()!=0)goto _27; else goto _36;
_10:
    if(sp()!=0)goto _18; else goto _15;
_11:
    if(sp()!=0)goto _27; else goto _26;
_12:
    if(sp()!=0)goto _34; else goto _26;
_13:
    if(sp()!=0)goto _31; else goto _26;
_14:
    if(sp()!=0)goto _28; else goto _26;
_15:
    if(((((((x3)>(x2))?1:0))!=0)?0:1)!=0)goto _18;else goto _23;
_16:
    if((x1)!=0)goto _21;else goto _22;
_17:
    x0=1;
    x1=1;
    x2=99;
    x3=99;
    goto _15;
_18:
    sa(((x2)-(1)));
    x2=((x2)-(1));
    sa(9);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _0;
_19:
    x3=99;
    goto _15;
_20:
    sp();
    sa(x0);
    sa(x1);
    goto _16;
_21:
    sa(sr());
    x4=sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(x4);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    goto _1;
_22:
    sp();
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    printf("%lld", (int64)(sp()));
    goto __;
_23:
    sa(td(x2,10));
    goto _2;
_24:
    sa(((td(x2,10))-(td(x3,10))));
    goto _3;
_25:
    sa(((((x2)*(td(x3,10))))-(((x3)*(td(x2,10))))));
    goto _14;
_26:
    x0=((x0)*(x2));
    x1=((x1)*(x3));
    goto _27;
_27:
    sa(((x3)-(1)));
    x3=((x3)-(1));
    sa(9);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _10;
_28:
    sa(td(x2,10));
    goto _4;
_29:
    sa(((td(x2,10))-(tm(x3,10))));
    goto _5;
_30:
    sa(((((x2)*(td(x3,10))))-(((x3)*(tm(x2,10))))));
    goto _13;
_31:
    sa(tm(x2,10));
    goto _6;
_32:
    sa(((tm(x2,10))-(td(x3,10))));
    goto _7;
_33:
    sa(((((x2)*(tm(x3,10))))-(((x3)*(td(x2,10))))));
    goto _12;
_34:
    sa(tm(x2,10));
    goto _8;
_35:
    sa(((tm(x2,10))-(tm(x3,10))));
    goto _9;
_36:
    sa(((((x2)*(tm(x3,10))))-(((x3)*(tm(x2,10))))));
    goto _11;
__:
    return 0;
}