/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } \"Z{0} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{"
           "#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }"
           "  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \""
           "+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{"
           "#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ }  O{#} \"+{ } #)> \"]M~A~~~~~h!\"++++++"
           "*+**10p\":~+\"+*55+0p\"d\"2*1+20pv{ } \"'v{ }  Q<{ } !4v{ }  O<     \"4\"<{ }  /@.g0+55$<{ }  'v{ }  3<   \"4\"<{ }  1>{ }  '${v{ }  4}  "
           "\"p05/+55p06<{ }  /v{ }  <<{ }  7>-!#v_{ }  -v{ }  N>20g\"4\">80p:0\\80gp80g1-:1-#^_$1-:#^_$\"dd\">80p:80g\\20 g>:0\\1pv>120g1p40p>050p2"
           "0g60p>60g1g40g*50g+:55+%60g1p60g1-:#^_$$1-:#v_$0170p>9*70g1g+10g%70g1+:70p20g-1-#^_20g\"4\">90p30p:30g90gg:|   >55+0g1-55+0p$v>30g"
           "90g1-:1-#^_$1-:1-#^_@>80g1-:1-#v_$1-:1-#v_^{ }  T^_^#!:-1<{ }  *^{ }  Q<{ }  \\>$30g90gp${ }  (>{ }  9{^{ }  ^}  \"{ } !E<\"d\"     "
           "<  ";
int t=0;int z=0;
int64 g[14632];
int d(){int s,w,i,j,h;h=z;for(;t<1155;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<248&&y<59){return g[y*248+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<248&&y<59){g[y*248+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    d();
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    gw(1,0,357913941);
    gw(10,0,9802);
    gw(2,0,201);
    sa(gr(2,0));
    gw(8,0,52);
    goto _21;
_1:
    gw(8,0,100);
    sp();
    sa(100);
    sa(gr(8,0));
    sa(100);
    goto _2;
_2:
    sa(gr(2,0));
    gw(gr(2,0),1,0);
    goto _22;
_3:
    gw(gr(2,0),1,1);
    sp();
    gw(4,0,sp());
    goto _4;
_4:
    gw(5,0,0);
    gw(6,0,gr(2,0));
    goto _23;
_5:
    gw(7,0,1);
    sp();
    sa(tm((0)+(gr(gr(7,0),1)),gr(1,0)));
    goto _26;
_6:
    sa(gr(2,0));
    gw(9,0,52);
    goto _25;
_7:
    sp();
    gw(gr(3,0),gr(9,0),sp());
    sp();
    goto _29;
_8:
    gw(8,0,100);
    sa(sr());
    sa(gr(8,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _2;
_9:
    sp();
    printf("%lld", (int64)(gr(10,0)));
    return 0;
_10:
    gw(8,0,sp());
    sa(sr());
    sa(gr(8,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _2;
_11:
    gw(10,0,(gr(10,0))-(1));
    sp();
    goto _29;
_12:
    gw(9,0,52);
    goto _25;
_13:
    return 0;
_14:
    gw(9,0,sp());
    goto _25;
_15:
    sa(9);
    sa(sp()*sp());
    sa(gr(gr(7,0),1));
    sa(sp()+sp());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _26;
_16:
    gw(6,0,sp());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    gw(5,0,sp());
    goto _23;
_17:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _22;
_18:
    gw(8,0,52);
    goto _21;
_19:
    gw(8,0,sp());
    goto _21;
_20:
    sp();
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    if(sp()!=0)goto _18; else goto _1;
_21:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(8,0));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa((gr(8,0))-(1));
    if((((gr(8,0))-(1))-(1))!=0)goto _19;else goto _20;
_22:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _3; else goto _17;
_23:
    sa(((gr(gr(6,0),1))*(gr(4,0)))+(gr(5,0)));
    gw(gr(6,0),1,tm(((gr(gr(6,0),1))*(gr(4,0)))+(gr(5,0)),10));
    sa((gr(6,0))-(1));
    if(((gr(6,0))-(1))!=0)goto _16;else goto _24;
_24:
    sp();
    sp();
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    if(sp()!=0)goto _4; else goto _5;
_25:
    gw(3,0,sp());
    sa(sr());
    sa(gr(gr(3,0),gr(9,0)));
    if((gr(gr(3,0),gr(9,0)))!=0)goto _28;else goto _7;
_26:
    sa((gr(7,0))+(1));
    gw(7,0,(gr(7,0))+(1));
    sa(gr(2,0));
    {int64 v0=sp();sa(sp()-v0);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _15; else goto _6;
_27:
    sa(gr(3,0));
    sa((gr(9,0))-(1));
    if((((gr(9,0))-(1))-(1))!=0)goto _14;else goto _30;
_28:
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _11; else goto _27;
_29:
    sa((gr(8,0))-(1));
    if((((gr(8,0))-(1))-(1))!=0)goto _10;else goto _31;
_30:
    sp();
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _12; else goto _13;
_31:
    sp();
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _8; else goto _9;
}