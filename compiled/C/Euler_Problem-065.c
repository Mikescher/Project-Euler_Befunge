/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(79LL,0LL,48LL);
    gw(79LL,2LL,48LL);
    sa(69LL);
_1:
    sa(sr()+9LL);
    sa(48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()+9LL);
    sa(48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    if(sp()!=0)goto _23;else goto _2;
_2:
    gw(79LL,0LL,48LL);
    gw(79LL,2LL,49LL);
    gw(4LL,0LL,0LL);
    sp();
    sa(99LL);
_3:
    sa(tm(sr()-1LL,3LL));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _22;else goto _4;
_4:
    sa(sp()-2LL);
    if(sp()!=0)goto _21;else goto _5;
_5:
    gw(2LL,0LL,1LL);
    gw(3LL,0LL,79LL);
_6:
    sa(79LL);
    sa(gr(79LL,0LL)-48LL);
_7:
    sa(gr(gr(3LL,0LL),2LL));
    gw(gr(3LL,0LL),0LL,gr(gr(3LL,0LL),2LL));
    sa(sp()-48LL);
    sa(sp()*gr(2LL,0LL));
    sa(sp()+sp());
    sa(sp()+gr(4LL,0LL));
    sa((tm(sr(),10LL))+48LL);
    gw(gr(3LL,0LL),2LL,sp());
    sa(td(sp(),10L));
    gw(4LL,0LL,sp());
    if(sr()!=9LL)goto _20;else goto _8;
_8:
    sp();
    sa(sp()-1LL);
    if((sr()+1LL)!=0)goto _9;else goto _11;
_9:
    sa(sr());
    if(sp()!=0)goto _3;else goto _10;
_10:
    gw(2LL,0LL,2LL);
    gw(3LL,0LL,79LL);
    goto _6;
_11:
    sp();
    sa(0LL);
    sa(70LL);
    sa(gr(79LL,2LL)-48LL);
    sa(gr(79LL,2LL)-48LL);
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
    if(sp()!=0)goto _16;else goto _17;
_16:
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    return 0;
_17:
    sa(sp()+sp());
    goto _15;
_18:
    sa(sp()-1LL);
    sa(sr()+9LL);
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    sa(sr());
    goto _12;
_19:
    if(sp()!=0)goto _18;else goto _14;
_20:
    sa(sp()-1LL);
    sa(sr());
    gw(3LL,0LL,sp());
    sa(sr());
    sa(0LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    goto _7;
_21:
    sa((td(sr()+1LL,3LL))*2LL);
    gw(2LL,0LL,sp());
    gw(3LL,0LL,79LL);
    goto _6;
_22:
    gw(2LL,0LL,1LL);
    gw(3LL,0LL,79LL);
    sp();
    goto _6;
_23:
    sa(sp()-1LL);
    goto _1;
}