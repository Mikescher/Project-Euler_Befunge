/* compiled with BefunCompile v1.0.3 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "\"c\"02p{ }  0v >02g1+::02p 2%!#v_5%!#v_312p>12g1+:12p27*-!#v_022pv> v{#}  .{ }  (>#|v#-*8\";}\"g20<   ${ }  +^{ }  0< >1#0|  OOO OO"
           " OOO   #{ }  (^ @# >#{ }  '^#{  <   }  \"{ }  2<^_^#<1>v {#}  .{ }  N>22g1+:22p3-!^2#  110001#??????#{ }  )>{ }  D^{ }  /< 101001"
           "#??????#{ }  +> ^v24 pg21+7\\+\"0\"%+55g24:>#<:      !#v_ v{ }  'g+  100101#??????#{ }  .>g55+/42p>{ }  -^ |-\"0\"gg21: -1<p24g206   "
           "<100011#??????#{ }  7^pg21+7\\+\"0\"g22:<      #>#$>1-:7+12gvgg  011001#??????#   >82g8-|    @{ }  @^6<|:\\-\"0\"g <\"2  010101#??????#"
           "   $     >72g.^{ }  ,>${ }  1^>$#<55+*+55+v02  010011#??????# vp29g22p281  $_v# `/2g25:_^#%\\g25< v_v# %2:  <v*+55+*+55+*<\"-  001"
           "101#??????#   ${ }  ,:{ }  )>^   ># ^#>#<:3%v    >+55+*+v     >^  001011#??????#   ${ }  ,>2-52g\\%!#^_6+:^:7p25_^#  <   ^   p27:"
           "<{ }  )000111#??????# >92g1+92pv{ }  'v_v#{ }  (:>#<:42g55+%\"0\"+\\7+92g4+p42 v     {#}  . |-9g29<  >602g42p>1 -:12gg\"0\"-| ^{ }  /"
           "<p24/+55g<{ }  4> ^   ^    $<   v6$<{ }  *>:92g\"0\"+\\7+92g4+p^{ }  .v_v# `/2g25:_v# %\\g25< v_v# %2<>>1-:7+92g4v>v{ }  A8{ }  ,v  "
           "  ># ^#>#<:3%v: |:\\-\"0\"g+ <+5{ }  A2 >:2-52g\\%!#v_6+:^:7p25_^#  <+ >$55+*+55+*^5{ }  A>g1+82p      >${ }  ,^  ^ *+55+*+55+*+<{ }"
           "  A";
int t=0;int z=0;
int64 g[1560];
int d(){int s,w,i,j,h;h=z;for(;t<1155;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<78&&y<20){return g[y*78+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<78&&y<20){g[y*78+x]=v;}}
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
    goto _24;
_0:
    if(sp()!=0)goto _26; else goto _27;
_1:
    if(sp()!=0)goto _22; else goto _28;
_2:
    if(sp()!=0)goto _22; else goto _30;
_3:
    if(sp()!=0)goto _64; else goto _32;
_4:
    if(sp()!=0)goto _35; else goto _34;
_5:
    if(sp()!=0)goto _36; else goto _37;
_6:
    if(sp()!=0)goto _40; else goto _38;
_7:
    if(sp()!=0)goto _41; else goto _38;
_8:
    if(sp()!=0)goto _42; else goto _38;
_9:
    if(sp()!=0)goto _43; else goto _62;
_10:
    if(sp()!=0)goto _61; else goto _45;
_11:
    if(sp()!=0)goto _47; else goto _48;
_12:
    if(sp()!=0)goto _49; else goto _50;
_13:
    if(sp()!=0)goto _55; else goto _51;
_14:
    if(sp()!=0)goto _56; else goto _51;
_15:
    if(sp()!=0)goto _57; else goto _51;
_16:
    if(sp()!=0)goto _58; else goto _59;
_17:
    if(sp()!=0)goto _54; else goto _52;
_18:
    if(sp()!=0)goto _39; else goto _53;
_19:
    if(sp()!=0)goto _29; else goto _31;
_20:
    if(sp()!=0)goto _51; else goto _60;
_21:
    if(sp()!=0)goto _38; else goto _63;
_22:
    if(((gr(0,2))-(1000))!=0)goto _25;else goto _65;
_23:
    if((((gr(0,gr(1,2)))-(48))+(gr(2,2)))!=0)goto _31;else goto _39;
_24:
    gw(0,2,99);
    goto _22;
_25:
    sa((gr(0,2))+(1));
    sa((gr(0,2))+(1));
    gw(0,2,(gr(0,2))+(1));
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    goto _0;
_26:
    sp();
    goto _22;
_27:
    sa(5);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    goto _1;
_28:
    gw(1,2,3);
    goto _29;
_29:
    sa((gr(1,2))+(1));
    gw(1,2,(gr(1,2))+(1));
    sa(14);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _2;
_30:
    gw(2,2,0);
    goto _23;
_31:
    gw(4,2,gr(0,2));
    sa(5);
    sa((gr(5,gr(1,2)))-(48));
    goto _3;
_32:
    sa(sr());
    sa((gr(2,2))+(48));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    sa(sp()+sp());
    sa(gr(1,2));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _33;
_33:
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _4;
_34:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(gr(1,2));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    goto _3;
_35:
    sp();
    sa((gr(12,gr(1,2)))-(48));
    sa(5);
    sa(5);
    goto _5;
_36:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(7);
    sa(sp()+sp());
    sa(gr(1,2));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _5;
_37:
    sp();
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(sr());
    gw(7,2,sp());
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _6;
_38:
    sp();
    goto _39;
_39:
    sa((gr(2,2))+(1));
    gw(2,2,(gr(2,2))+(1));
    sa(3);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _19;
_40:
    sa(sr());
    sa(3);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _7;
_41:
    gw(5,2,sp());
    sa(7);
    sa(tm(gr(5,2),7));
    goto _8;
_42:
    sa(sr());
    sa(td(gr(5,2),2));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _9;
_43:
    gw(8,2,1);
    gw(9,2,gr(2,2));
    gw(9,2,(gr(9,2))+(1));
    gw(4,2,gr(0,2));
    sp();
    goto _44;
_44:
    sa(5);
    sa((gr(5,gr(1,2)))-(48));
    goto _10;
_45:
    sa(sr());
    sa((gr(9,2))+(48));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    sa(sp()+sp());
    sa((gr(9,2))+(4));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _46;
_46:
    sa(sr());
    goto _11;
_47:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(gr(1,2));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    goto _10;
_48:
    sp();
    sa((gr(12,(gr(9,2))+(4)))-(48));
    sa(5);
    sa(5);
    goto _12;
_49:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(7);
    sa(sp()+sp());
    sa((gr(9,2))+(4));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _12;
_50:
    sp();
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(10);
    sa(sp()*sp());
    sa(sp()+sp());
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _13;
_51:
    sp();
    sa((gr(9,2))-(9));
    goto _17;
_52:
    sa((gr(8,2))-(8));
    goto _18;
_53:
    printf("%lld", (int64)(gr(7,2)));
    goto __;
_54:
    gw(9,2,(gr(9,2))+(1));
    gw(4,2,gr(0,2));
    goto _44;
_55:
    sa(sr());
    sa(3);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _14;
_56:
    gw(5,2,sp());
    sa(7);
    sa(tm(gr(5,2),7));
    goto _15;
_57:
    sa(sr());
    sa(td(gr(5,2),2));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _16;
_58:
    gw(8,2,(gr(8,2))+(1));
    goto _51;
_59:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(sp()-v0);}
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    goto _20;
_60:
    sa(6);
    sa(sp()+sp());
    sa(sr());
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _15;
_61:
    sa(sr());
    sa((tm(gr(4,2),10))+(48));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    sa(sp()+sp());
    sa((gr(9,2))+(4));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(4,2,td(gr(4,2),10));
    goto _46;
_62:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(sp()-v0);}
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    goto _21;
_63:
    sa(6);
    sa(sp()+sp());
    sa(sr());
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _8;
_64:
    sa(sr());
    sa((tm(gr(4,2),10))+(48));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    sa(sp()+sp());
    sa(gr(1,2));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(4,2,td(gr(4,2),10));
    goto _33;
_65:
    goto __;
__:
    return 0;
}