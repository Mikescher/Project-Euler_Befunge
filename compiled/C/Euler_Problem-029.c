/* compiled with BefunCompile v1.0.8 (c) 2015 */
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
    int64 t0,t1;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1,0,357913941);
    gw(10,0,9802);
    gw(2,0,201);
    sa(gr(2,0));
    gw(8,0,52);
_1:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(8,0));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    t0=gr(8,0)-1;
    if(gr(8,0)!=2)goto _31;else goto _2;
_2:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _3;else goto _4;
_3:
    gw(8,0,52);
    goto _1;
_4:
    gw(8,0,100);
    sp();
    sa(100);
    sa(gr(8,0));
    sa(100);
_5:
    sa(gr(2,0));
    gw(gr(2,0),1,0);
_6:
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _8;else goto _7;
_7:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _6;
_8:
    gw(gr(2,0),1,1);
    sp();
    gw(4,0,sp());
_9:
    gw(5,0,0);
    gw(6,0,gr(2,0));
_10:
    t0=(gr(gr(6,0),1)*gr(4,0))+gr(5,0);
    gw(gr(6,0),1,tm((gr(gr(6,0),1)*gr(4,0))+gr(5,0),10));
    t1=gr(6,0)-1;
    if(gr(6,0)!=1)goto _30;else goto _11;
_11:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _9;else goto _12;
_12:
    gw(7,0,1);
    sp();
    sa(tm(gr(gr(7,0),1),gr(1,0)));
_13:
    t0=gr(7,0)+1;
    gw(7,0,gr(7,0)+1);
    t0-=gr(2,0);
    t0--;
    if((t0)!=0)goto _29;else goto _14;
_14:
    sa(gr(2,0));
    gw(9,0,52);
_15:
    gw(3,0,sp());
    sa(sr());
    t0=gr(gr(3,0),gr(9,0));
    if((gr(gr(3,0),gr(9,0)))!=0)goto _16;else goto _28;
_16:
    sa(sp()-t0);
    t1=sp();
    t1=(t1!=0)?0:1;
    if((t1)!=0)goto _22;else goto _17;
_17:
    sa(gr(3,0));
    t0=gr(9,0)-1;
    if(gr(9,0)!=2)goto _21;else goto _18;
_18:
    sa(sp()-1LL);
    if(sr()!=1)goto _20;else goto _19;
_19:
    return 0;
_20:
    gw(9,0,52);
    goto _15;
_21:
    gw(9,0,t0);
    goto _15;
_22:
    gw(10,0,gr(10,0)-1);
    sp();
_23:
    t0=gr(8,0)-1;
    if(gr(8,0)!=2)goto _27;else goto _24;
_24:
    sa(sp()-1LL);
    if(sr()!=1)goto _25;else goto _26;
_25:
    gw(8,0,100);
    sa(sr());
    sa(gr(8,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _5;
_26:
    printf("%lld", gr(10,0));
    sp();
    return 0;
_27:
    gw(8,0,t0);
    sa(sr());
    sa(gr(8,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _5;
_28:
    gw(gr(3,0),gr(9,0),sp());
    sp();
    goto _23;
_29:
    sa(sp()*9LL);
    sa(sp()+gr(gr(7,0),1));
    sa(tm(sp(),gr(1,0)));
    goto _13;
_30:
    gw(6,0,t1);
    t0/=10;
    gw(5,0,t0);
    goto _10;
_31:
    gw(8,0,t0);
    goto _1;
}