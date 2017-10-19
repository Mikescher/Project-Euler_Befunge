/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    gw(3,1,9999);
    gw(4,1,2);
_1:
    sa(-1);
    sa(gr(3,1));
    sa(1);
    sa(1-gr(4,1));
_2:
    if(sp()!=0)goto _29;else goto _3;
_3:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_4:
    gw(1,0,sp());
    sa(-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_5:
    sa(sr()%10);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/10LL);

    sa(sr());
    if(sp()!=0)goto _5;else goto _7;
_7:
    sp();
_8:
    sa(sp()+(gr(1,0)*10));

    gw(1,0,sp());
    if(sr()!=-1)goto _8;else goto _10;
_10:
    sp();
    sa(gr(1,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sr()!=-1)goto _4;else goto _11;
_11:
    sp();
    sa(sr());
    sa(9);
    sa(9);
_12:
    if(sp()!=0)goto _13;else goto _14;
_13:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr());
    goto _12;
_14:
    sp();
    sa(sr());
_15:
    sa(sr()%10);
    sa(sr());

    if(sp()!=0)goto _16;else goto _28;
_16:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}

    if(sp()!=0)goto _28;else goto _17;
_17:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()/10LL);

    sa(sr());

    if(sp()!=0)goto _15;else goto _18;
_18:
    sp();
    sa(9);
    sa(9);
_19:
    if(sp()!=0)goto _20;else goto _21;
_20:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);

    sa(sr());
    goto _19;
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
    sa(gr(4,1)-2);
    gw(4,1,gr(4,1)-1);

    if(sp()!=0)goto _1;else goto _24;
_24:
    sa(gr(3,1)-1);
    gw(3,1,gr(3,1)-1);

    if(sp()!=0)goto _26;else goto _25;
_25:
    printf("RORRE");
    return 0;
_26:
    gw(4,1,5);
    goto _1;
_27:
    printf("%lld ", (int64)(sp()));
    return 0;
_28:
    sp();
    sp();
    sa(0);
    goto _22;
_29:
    sa(sp()+1LL);

    sa(sr()*gr(3,1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr()-gr(4,1));
    goto _2;
}
