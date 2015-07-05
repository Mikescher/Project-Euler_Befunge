/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{#}  ){ } !`v{#}  )    v{ } !O<#     p145< {#}  ){ }  )v{ }  *+1<{ }  +v{ }  ,<  v{ }  /<{ }  1vp2\\0:<{ }  ){>v    }  \"      >$"
           "v   v\\g2:<{ }  =>\"ec\"*31p>241p>01-1>:31g*\\:41g-#^_$>\\10p01-\\>:55+%\\55+/:#^_$>10g55+*+10p:1+#^_$10g\\:1+#v_$:55+>  1-:|  >:55+%:|>"
           ":2g!|>1\\2p55+/:!| >55+> 1-:|>#v_$41g1-:41p1-#^_31g1-:31p|{ }  C^{ }  R\\<{ }  +$>$:^  {    $#}  \"{ }  *<v{+}  ($<{ } !J$${>     }"
           "  \"     $0>9-!\\$     ^ >.     @     ,,,,, \"RORRE\"<";
int t=0;int z=0;
int64 g[1014];
int d(){int s,w,i,j,h;h=z;for(;t<434;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<169&&y<6){return g[y*169+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<169&&y<6){g[y*169+x]=v;}}
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
    gw(3LL,1LL,9999LL);
    gw(4LL,1LL,2LL);
_1:
    sa(-1LL);
    sa(gr(3LL,1LL));
    sa(1LL);
    sa(1LL-gr(4LL,1LL));
_2:
    if(sp()!=0)goto _31;else goto _3;
_3:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_4:
    gw(1LL,0LL,sp());
    sa(-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_5:
    sa(tm(sr(),10LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(sr());
    if(sp()!=0)goto _5;else goto _7;
_7:
    sp();
_8:
    sa(sp()+(gr(1LL,0LL)*10LL));
    gw(1LL,0LL,sp());
    if((sr()+1LL)!=0)goto _8;else goto _10;
_10:
    sp();
    sa(gr(1LL,0LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if((sr()+1LL)!=0)goto _4;else goto _11;
_11:
    sp();
    sa(sr());
    sa(9LL);
_12:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _12;else goto _14;
_14:
    sp();
    sa(sr());
_15:
    sa(tm(sr(),10LL));
    sa(sr());
    if(sp()!=0)goto _16;else goto _30;
_16:
    sa(sr());
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _17;else goto _28;
_17:
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10L));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _18;else goto _15;
_18:
    sp();
    sa(9LL);
_19:
    sa(sr());
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _19;else goto _21;
_21:
    sp();
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()-9LL);
    sa((sp()!=0)?0:1);
_22:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sp();
    if(sp()!=0)goto _27;else goto _23;
_23:
    sp();
    sa(gr(4LL,1LL)-1LL);
    gw(4LL,1LL,gr(4LL,1LL)-1LL);
    sa(sp()-1LL);
    if(sp()!=0)goto _1;else goto _24;
_24:
    sa(gr(3LL,1LL)-1LL);
    gw(3LL,1LL,gr(3LL,1LL)-1LL);
    if(sp()!=0)goto _26;else goto _25;
_25:
    sa(69LL);
    sa(82LL);
    sa(82LL);
    sa(79LL);
    printf("R");
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    return 0;
_26:
    gw(4LL,1LL,5LL);
    goto _1;
_27:
    printf("%lld", (int64)(sp()));
    return 0;
_28:
    sp();
_29:
    sp();
    sa(0LL);
    goto _22;
_30:
    sp();
    goto _29;
_31:
    sa(sp()+1LL);
    sa(sr()*gr(3LL,1LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr()-gr(4LL,1LL));
    goto _2;
}