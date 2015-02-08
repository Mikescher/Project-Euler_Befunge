/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
    goto _5;
_0:
    if(sp()!=0)goto _7; else goto _8;
_1:
    if(sp()!=0)goto _10; else goto _11;
_2:
    if(sp()!=0)goto _12; else goto _25;
_3:
    if(sp()!=0)goto _24; else goto _14;
_4:
    if(sp()!=0)goto _20; else goto _16;
_5:
    gw(3,1,9999);
    gw(4,1,2);
    goto _6;
_6:
    sa(-1);
    sa((1)*(gr(3,1)));
    sa(1);
    sa((1)-(gr(4,1)));
    goto _0;
_7:
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(gr(3,1));
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(gr(4,1));
    {int64 v0=sp();sa(sp()-v0);}
    goto _0;
_8:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _9;
_9:
    gw(1,0,sp());
    sa(-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _10;
_10:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _1;
_11:
    sp();
    goto _12;
_12:
    sa((gr(1,0))*(10));
    sa(sp()+sp());
    gw(1,0,sp());
    sa(sr());
    sa(1);
    sa(sp()+sp());
    goto _2;
_13:
    sp();
    sa(sr());
    sa(9);
    sa(9);
    goto _3;
_14:
    sp();
    sa(sr());
    goto _26;
_15:
    sp();
    sa(9);
    sa(9);
    goto _4;
_16:
    sp();
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(9);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _27;
_17:
    printf("%lld", (int64)(sp()));
    return 0;
_18:
    gw(4,1,5);
    goto _6;
_19:
    sa(69);
    sa(82);
    sa(82);
    sa(79);
    printf("%c", (char)(82));
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    return 0;
_20:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _4;
_21:
    sp();
    goto _22;
_22:
    sp();
    sa(0);
    goto _27;
_23:
    sp();
    goto _22;
_24:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _3;
_25:
    sp();
    sa(gr(1,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(1);
    sa(sp()+sp());
    if(sp()!=0)goto _9; else goto _13;
_26:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    if(sp()!=0)goto _30; else goto _23;
_27:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sp();
    if(sp()!=0)goto _17; else goto _28;
_28:
    sp();
    sa((gr(4,1))-(1));
    gw(4,1,(gr(4,1))-(1));
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _6; else goto _29;
_29:
    sa((gr(3,1))-(1));
    gw(3,1,(gr(3,1))-(1));
    if(sp()!=0)goto _18; else goto _19;
_30:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _31; else goto _21;
_31:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15; else goto _26;
}