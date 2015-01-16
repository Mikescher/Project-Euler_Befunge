/* compiled with BefunCompile v1.0.3 (c) 2015 */
#include <time.h>
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
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    d();
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _12;
_0:
    if(sp()!=0)goto _14; else goto _15;
_1:
    if(sp()!=0)goto _17; else goto _18;
_2:
    if(sp()!=0)goto _19; else goto _20;
_3:
    if(sp()!=0)goto _16; else goto _21;
_4:
    if(sp()!=0)goto _38; else goto _22;
_5:
    if(sp()!=0)goto _24; else goto _37;
_6:
    if(sp()!=0)goto _25; else goto _35;
_7:
    if(sp()!=0)goto _26; else goto _23;
_8:
    if(sp()!=0)goto _34; else goto _27;
_9:
    if(sp()!=0)goto _29; else goto _30;
_10:
    if(sp()!=0)goto _13; else goto _31;
_11:
    if(sp()!=0)goto _32; else goto _33;
_12:
    gw(3,1,9999);
    gw(4,1,2);
    goto _13;
_13:
    sa(-1);
    sa((1)*(gr(3,1)));
    sa(1);
    sa((1)-(gr(4,1)));
    goto _0;
_14:
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
_15:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _16;
_16:
    gw(1,0,sp());
    sa(-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _17;
_17:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _1;
_18:
    sp();
    goto _19;
_19:
    sa((gr(1,0))*(10));
    sa(sp()+sp());
    gw(1,0,sp());
    sa(sr());
    sa(1);
    sa(sp()+sp());
    goto _2;
_20:
    sp();
    sa(gr(1,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(1);
    sa(sp()+sp());
    goto _3;
_21:
    sp();
    sa(sr());
    sa(9);
    sa(9);
    goto _4;
_22:
    sp();
    sa(sr());
    goto _23;
_23:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    goto _5;
_24:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    goto _6;
_25:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _7;
_26:
    sp();
    sa(9);
    sa(9);
    goto _8;
_27:
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
    goto _28;
_28:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sp();
    goto _9;
_29:
    printf("%lld", (int64)(sp()));
    goto __;
_30:
    sp();
    sa((gr(4,1))-(1));
    gw(4,1,(gr(4,1))-(1));
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    goto _10;
_31:
    sa((gr(3,1))-(1));
    gw(3,1,(gr(3,1))-(1));
    goto _11;
_32:
    gw(4,1,5);
    goto _13;
_33:
    sa(69);
    sa(82);
    sa(82);
    sa(79);
    printf("%c", (char)(82));
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    goto __;
_34:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _8;
_35:
    sp();
    goto _36;
_36:
    sp();
    sa(0);
    goto _28;
_37:
    sp();
    goto _36;
_38:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _4;
__:
    return 0;
}