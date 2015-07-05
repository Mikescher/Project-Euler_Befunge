/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } \"Z{0} \"+{{ }  O{#} \"+}  R{ } #)> \"]M~A~~~~~h!\"++++++*+**10p\":~+\"+*55+0p\"d\"2*1+20pv{ } \"'v{ }  Q<{ } !4v{ }  O<     \"4\"<{ } "
           " /@.g0+55$<{ }  'v{ }  3<   \"4\"<{ }  1>{ }  '${v{ }  4}  \"p05/+55p06<{ }  /v{ }  <<{ }  7>-!#v_{ }  -v{ }  N>20g\"4\">80p:0\\80gp80"
           "g1-:1-#^_$1-:#^_$\"dd\">80p:80g\\20 g>:0\\1pv>120g1p40p>050p20g60p>60g1g40g*50g+:55+%60g1p60g1-:#^_$$1-:#v_$0170p>9*70g1g+10g%70g1+:"
           "70p20g-1-#^_20g\"4\">90p30p:30g90gg:|   >55+0g1-55+0p$v>30g90g1-:1-#^_$1-:1-#^_@>80g1-:1-#v_$1-:1-#v_^{ }  T^_^#!:-1<{ }  *^{ }  Q"
           "<{ }  \\>$30g90gp${ }  (>{ }  9{^{ }  ^}  \"{ } !E<\"d\"     <  ";
int t=0;int z=0;
int64 g[14632];
int d(){int s,w,i,j,h;h=z;for(;t<572;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
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
    gw(1LL,0LL,357913941LL);
    gw(10LL,0LL,9802LL);
    gw(2LL,0LL,201LL);
    sa(gr(2LL,0LL));
    gw(8LL,0LL,52LL);
_1:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(8LL,0LL));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(gr(8LL,0LL)-1LL);
    if(gr(8LL,0LL)!=2LL)goto _31;else goto _2;
_2:
    sp();
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _3;else goto _4;
_3:
    gw(8LL,0LL,52LL);
    goto _1;
_4:
    gw(8LL,0LL,100LL);
    sp();
    sa(100LL);
    sa(gr(8LL,0LL));
    sa(100LL);
_5:
    sa(gr(2LL,0LL));
    gw(gr(2LL,0LL),1LL,0LL);
_6:
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _8;else goto _7;
_7:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _6;
_8:
    gw(gr(2LL,0LL),1LL,1LL);
    sp();
    gw(4LL,0LL,sp());
_9:
    gw(5LL,0LL,0LL);
    gw(6LL,0LL,gr(2LL,0LL));
_10:
    sa((gr(gr(6LL,0LL),1LL)*gr(4LL,0LL))+gr(5LL,0LL));
    gw(gr(6LL,0LL),1LL,tm((gr(gr(6LL,0LL),1LL)*gr(4LL,0LL))+gr(5LL,0LL),10LL));
    sa(gr(6LL,0LL)-1LL);
    if(gr(6LL,0LL)!=1LL)goto _30;else goto _11;
_11:
    sp();
    sp();
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _9;else goto _12;
_12:
    gw(7LL,0LL,1LL);
    sp();
    sa(tm(gr(gr(7LL,0LL),1LL),gr(1LL,0LL)));
_13:
    sa(gr(7LL,0LL)+1LL);
    gw(7LL,0LL,gr(7LL,0LL)+1LL);
    sa(sp()-gr(2LL,0LL));
    sa(sp()-1LL);
    if(sp()!=0)goto _29;else goto _14;
_14:
    sa(gr(2LL,0LL));
    gw(9LL,0LL,52LL);
_15:
    gw(3LL,0LL,sp());
    sa(sr());
    sa(gr(gr(3LL,0LL),gr(9LL,0LL)));
    if((gr(gr(3LL,0LL),gr(9LL,0LL)))!=0)goto _16;else goto _28;
_16:
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _22;else goto _17;
_17:
    sa(gr(3LL,0LL));
    sa(gr(9LL,0LL)-1LL);
    if(gr(9LL,0LL)!=2LL)goto _21;else goto _18;
_18:
    sp();
    sa(sp()-1LL);
    if(sr()!=1LL)goto _20;else goto _19;
_19:
    return 0;
_20:
    gw(9LL,0LL,52LL);
    goto _15;
_21:
    gw(9LL,0LL,sp());
    goto _15;
_22:
    gw(10LL,0LL,gr(10LL,0LL)-1LL);
    sp();
_23:
    sa(gr(8LL,0LL)-1LL);
    if(gr(8LL,0LL)!=2LL)goto _27;else goto _24;
_24:
    sp();
    sa(sp()-1LL);
    if(sr()!=1LL)goto _26;else goto _25;
_25:
    sp();
    printf("%lld", (int64)(gr(10LL,0LL)));
    return 0;
_26:
    gw(8LL,0LL,100LL);
    sa(sr());
    sa(gr(8LL,0LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _5;
_27:
    gw(8LL,0LL,sp());
    sa(sr());
    sa(gr(8LL,0LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _5;
_28:
    sp();
    gw(gr(3LL,0LL),gr(9LL,0LL),sp());
    sp();
    goto _23;
_29:
    sa(sp()*9LL);
    sa(sp()+gr(gr(7LL,0LL),1LL));
    sa(tm(sp(),gr(1L,0L)));
    goto _13;
_30:
    gw(6LL,0LL,sp());
    sa(td(sp(),10L));
    gw(5LL,0LL,sp());
    goto _10;
_31:
    gw(8LL,0LL,sp());
    goto _1;
}