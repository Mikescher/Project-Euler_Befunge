/* compiled with BefunCompile v1.0 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<109&&y<5164){return g[y][x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<109&&y<5164){g[y][x]=v;}}
int random(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _9;
_0:
    if(sp()!=0)goto _29; else goto _11;
_1:
    if(sp()!=0)goto _28; else goto _13;
_2:
    if(sp()!=0)goto _14; else goto _10;
_3:
    if(sp()!=0)goto _17; else goto _21;
_4:
    if(sp()!=0)goto _19; else goto _20;
_5:
    if(sp()!=0)goto _16; else goto _22;
_6:
    if(sp()!=0)goto _15; else goto _23;
_7:
    if(sp()!=0)goto _27; else goto _25;
_8:
    if(sp()!=0)goto _24; else goto _26;
_9:
    gw(2,0,5163);
    gw(0,0,5163);
    goto _10;
_10:
    gw(1,0,0);
    sa(0);
    sa(((gr(0,gr(0,0)))-(64)));
    sa((((((gr(0,gr(0,0)))-(64)))>(0))?1:0));
    goto _0;
_11:
    gw(1,0,((0)+(((gr(1,0))*(28)))));
    sp();
    goto _12;
_12:
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(12);
    {int64 v0=sp();sa(sp()-v0);}
    goto _1;
_13:
    gw(0,gr(0,0),gr(1,0));
    sp();
    sa(((gr(0,0))-(1)));
    gw(0,0,((gr(0,0))-(1)));
    sa((sp()!=0)?0:1);
    goto _2;
_14:
    gw(3,0,gr(2,0));
    goto _15;
_15:
    gw(4,0,0);
    goto _16;
_16:
    sa((((gr(0,((gr(4,0))+(1))))>(gr(0,((gr(4,0))+(2)))))?1:0));
    goto _3;
_17:
    sa(gr(4,0));
    gw(6,0,((gr(4,0))+(1)));
    gw(7,0,sp());
    gw(8,0,12);
    sa(gr(12,((gr(6,0))+(1))));
    gw(gr(8,0),((gr(6,0))+(1)),gr(12,((gr(7,0))+(1))));
    goto _18;
_18:
    gw(gr(8,0),((gr(7,0))+(1)),sp());
    sa(gr(8,0));
    sa(((gr(8,0))-(1)));
    gw(8,0,((gr(8,0))-(1)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _4;
_19:
    sa(sr());
    sa(((gr(6,0))+(1)));
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(((gr(7,0))+(1)));
    {int64 v0=sp();sa(gr(sp(),v0));}
    gw(gr(8,0),((gr(6,0))+(1)),sp());
    goto _18;
_20:
    sp();
    goto _21;
_21:
    sa(((gr(4,0))+(1)));
    gw(4,0,((gr(4,0))+(1)));
    sa(((gr(3,0))-(1)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _5;
_22:
    sa(gr(3,0));
    gw(3,0,((gr(3,0))-(1)));
    sa(2);
    {int64 v0=sp();sa(sp()-v0);}
    goto _6;
_23:
    gw(9,0,0);
    gw(5,0,gr(2,0));
    goto _24;
_24:
    sa(1);
    sa(gr(1,gr(5,0)));
    sa(((gr(1,gr(5,0)))-(32)));
    goto _7;
_25:
    sp();
    sp();
    sp();
    sa(((gr(5,0))-(1)));
    gw(5,0,((gr(5,0))-(1)));
    goto _8;
_26:
    printf("%lld", (int64)(gr(9,0)));
    goto __;
_27:
    sa(64);
    {int64 v0=sp();sa(sp()-v0);}
    sa(gr(5,0));
    sa(sp()*sp());
    sa(gr(9,0));
    sa(sp()+sp());
    gw(9,0,sp());
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(gr(5,0));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa(32);
    {int64 v0=sp();sa(sp()-v0);}
    goto _7;
_28:
    sa(sr());
    sa(gr(0,0));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(64);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(0);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _0;
_29:
    sa(((gr(1,0))*(28)));
    sa(sp()+sp());
    gw(1,0,sp());
    goto _12;
__:
    return 0;
}