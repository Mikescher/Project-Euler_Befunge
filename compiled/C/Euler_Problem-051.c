/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
    goto _7;
_0:
    if(sp()!=0)goto _30; else goto _11;
_1:
    if(sp()!=0)goto _14; else goto _38;
_2:
    if(sp()!=0)goto _40; else goto _15;
_3:
    if(sp()!=0)goto _28; else goto _19;
_4:
    if(sp()!=0)goto _22; else goto _43;
_5:
    if(sp()!=0)goto _45; else goto _47;
_6:
    if(((gr(0,2))-(1000))!=0)goto _32;else goto _31;
_7:
    gw(0,2,99);
    goto _6;
_8:
    sp();
    goto _6;
_9:
    gw(1,2,3);
    goto _35;
_10:
    gw(4,2,gr(0,2));
    sa(5);
    sa((gr(5,gr(1,2)))-(48));
    goto _0;
_11:
    sa(sr());
    sa((gr(2,2))+(48));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    sa(sp()+sp());
    sa(gr(1,2));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _37;
_12:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(gr(1,2));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    goto _0;
_13:
    sp();
    sa((gr(12,gr(1,2)))-(48));
    sa(5);
    sa(5);
    goto _1;
_14:
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
    goto _1;
_15:
    sp();
    goto _36;
_16:
    gw(5,2,sp());
    sa(7);
    sa(tm(gr(5,2),7));
    goto _2;
_17:
    gw(8,2,1);
    gw(9,2,gr(2,2));
    gw(9,2,(gr(9,2))+(1));
    gw(4,2,gr(0,2));
    sp();
    goto _18;
_18:
    sa(5);
    sa((gr(5,gr(1,2)))-(48));
    goto _3;
_19:
    sa(sr());
    sa((gr(9,2))+(48));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    sa(sp()+sp());
    sa((gr(9,2))+(4));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _42;
_20:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(gr(1,2));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    goto _3;
_21:
    sp();
    sa((gr(12,(gr(9,2))+(4)))-(48));
    sa(5);
    sa(5);
    goto _4;
_22:
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
    goto _4;
_23:
    printf("%lld", (int64)(gr(7,2)));
    return 0;
_24:
    gw(9,2,(gr(9,2))+(1));
    gw(4,2,gr(0,2));
    goto _18;
_25:
    gw(5,2,sp());
    sa(7);
    sa(tm(gr(5,2),7));
    goto _5;
_26:
    gw(8,2,(gr(8,2))+(1));
    goto _47;
_27:
    sa(6);
    sa(sp()+sp());
    sa(sr());
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _5;
_28:
    sa(sr());
    sa((tm(gr(4,2),10))+(48));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    sa(sp()+sp());
    sa((gr(9,2))+(4));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(4,2,td(gr(4,2),10));
    goto _42;
_29:
    sa(6);
    sa(sp()+sp());
    sa(sr());
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _2;
_30:
    sa(sr());
    sa((tm(gr(4,2),10))+(48));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    sa(sp()+sp());
    sa(gr(1,2));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(4,2,td(gr(4,2),10));
    goto _37;
_31:
    return 0;
_32:
    sa((gr(0,2))+(1));
    sa((gr(0,2))+(1));
    gw(0,2,(gr(0,2))+(1));
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _8; else goto _34;
_33:
    gw(2,2,0);
    if((((gr(0,gr(1,2)))-(48))+(gr(2,2)))!=0)goto _10;else goto _36;
_34:
    sa(5);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _6; else goto _9;
_35:
    sa((gr(1,2))+(1));
    gw(1,2,(gr(1,2))+(1));
    sa(14);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _6; else goto _33;
_36:
    sa((gr(2,2))+(1));
    gw(2,2,(gr(2,2))+(1));
    sa(3);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _35; else goto _10;
_37:
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _13; else goto _12;
_38:
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
    if(sp()!=0)goto _39; else goto _15;
_39:
    sa(sr());
    sa(3);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    if(sp()!=0)goto _16; else goto _15;
_40:
    sa(sr());
    sa(td(gr(5,2),2));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _17; else goto _41;
_41:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(sp()-v0);}
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15; else goto _29;
_42:
    sa(sr());
    if(sp()!=0)goto _20; else goto _21;
_43:
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
    if(sp()!=0)goto _44; else goto _47;
_44:
    sa(sr());
    sa(3);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    if(sp()!=0)goto _25; else goto _47;
_45:
    sa(sr());
    sa(td(gr(5,2),2));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _26; else goto _46;
_46:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(sp()-v0);}
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _47; else goto _27;
_47:
    sp();
    sa((gr(9,2))-(9));
    if(sp()!=0)goto _24; else goto _48;
_48:
    sa((gr(8,2))-(8));
    if(sp()!=0)goto _36; else goto _23;
}