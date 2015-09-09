/* compiled with BefunCompile v1.0.8 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v $$$    {#}  g{ }  y{#}  g{ }  tv{ }  1-1<{ }  W>\"F\">:9+\"0\"\\0p:9+\"0\"\\2p:|{ }  Wv\"c\"p040p2\"O1\"p0\"O0\"   $<{ }  a>$1{ }  )v@.<v02-"
           "\"0\"p0g03:g2g03-\"0\"g0:p03:<-1<{ }  7>:1-3%:!|   >:1+3/2*v  +>g*+40g+:55+%\"0\"+30g2p55+/40p:9-|{ }  5>:|{ }  '>2-#^_1     >20 p{ } "
           " 6\"O\"v  #  ${ }  5| ># #+ #1 #: #- #12# ^#{ }  <># ^# <{ }  5${ }  />\\v  >\\:!|{ }  V>0\"F\">:9+2g\"0\"-:| >:!|1 +<{ }  [^{ }  (-1_ ^"
           "#1<{ }  Z";
int t=0;int z=0;
int64 g[1120];
int d(){int s,w,i,j,h;h=z;for(;t<393;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<80&&y<14){return g[y*80+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<80&&y<14){g[y*80+x]=v;}}
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
    gw(79,0,48);
    gw(79,2,48);
    sa(69);
_1:
    sa(sr()+9);
    sa(48);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()+9);
    sa(48);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    if(sp()!=0)goto _23;else goto _2;
_2:
    gw(79,0,48);
    gw(79,2,49);
    gw(4,0,0);
    sp();
    sa(99);
_3:
    sa(tm(sr()-1,3));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _22;else goto _4;
_4:
    sa(sp()-2LL);
    if(sp()!=0)goto _21;else goto _5;
_5:
    gw(2,0,1);
    gw(3,0,79);
_6:
    sa(79);
    sa(gr(79,0)-48);
_7:
    t0=gr(gr(3,0),2);
    gw(gr(3,0),0,gr(gr(3,0),2));
    t0-=48;
    t0*=gr(2,0);
    sa(sp()+t0);
    t1=sp();
    t1+=gr(4,0);
    t0=(tm(t1,10))+48;
    gw(gr(3,0),2,t0);
    t1/=10;
    gw(4,0,t1);
    if(sr()!=9)goto _20;else goto _8;
_8:
    sp();
    sa(sp()-1LL);
    if((sr()+1)!=0)goto _9;else goto _11;
_9:
    sa(sr());
    if(sp()!=0)goto _3;else goto _10;
_10:
    gw(2,0,2);
    gw(3,0,79);
    goto _6;
_11:
    sp();
    sa(0);
    sa(70);
    sa(gr(79,2)-48);
    sa(gr(79,2)-48);
_12:
    if(sp()!=0)goto _13;else goto _19;
_13:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_14:
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15;else goto _18;
_15:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _17;else goto _16;
_16:
    sa(sp()+sp());
    goto _15;
_17:
    sa(sp()+sp());
    t0=sp();
    printf("%lld", t0);
    return 0;
_18:
    sa(sp()-1LL);
    sa(sr()+9);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    sa(sr());
    goto _12;
_19:
    if(sp()!=0)goto _18;else goto _14;
_20:
    sa(sp()-1LL);
    sa(sr());
    gw(3,0,sp());
    sa(sr());
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    goto _7;
_21:
    t0=(td(sr()+1,3))*2;
    gw(2,0,t0);
    gw(3,0,79);
    goto _6;
_22:
    gw(2,0,1);
    gw(3,0,79);
    sp();
    goto _6;
_23:
    sa(sp()-1LL);
    goto _1;
}