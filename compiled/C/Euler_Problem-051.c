/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    gw(0LL,2LL,99LL);
_1:
    if(gr(0LL,2LL)!=1000LL)goto _2;else goto _48;
_2:
    sa(gr(0LL,2LL)+1LL);
    sa(gr(0LL,2LL)+1LL);
    gw(0LL,2LL,gr(0LL,2LL)+1LL);
    sa(tm(sp(),2L));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _47;else goto _3;
_3:
    sa(tm(sp(),5L));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _1;else goto _4;
_4:
    gw(1LL,2LL,3LL);
_5:
    sa(gr(1LL,2LL)+1LL);
    gw(1LL,2LL,gr(1LL,2LL)+1LL);
    sa(sp()-14LL);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _1;else goto _6;
_6:
    gw(2LL,2LL,0LL);
    if(((gr(0LL,gr(1LL,2LL))-48LL)+gr(2LL,2LL))!=0)goto _8;else goto _7;
_7:
    sa(gr(2LL,2LL)+1LL);
    gw(2LL,2LL,gr(2LL,2LL)+1LL);
    sa(sp()-3LL);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _5;else goto _8;
_8:
    gw(4LL,2LL,gr(0LL,2LL));
    sa(5LL);
    sa(gr(5LL,gr(1LL,2LL))-48LL);
_9:
    if(sp()!=0)goto _10;else goto _46;
_10:
    sa(sr());
    sa((tm(gr(4LL,2LL),10LL))+48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+7LL);
    sa(gr(1LL,2LL));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(4LL,2LL,td(gr(4LL,2LL),10LL));
_11:
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _12;else goto _45;
_12:
    sp();
    sa(gr(12LL,gr(1LL,2LL))-48LL);
    sa(4LL);
_13:
    sa(sr()+7LL);
    sa(gr(1LL,2LL));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _44;else goto _14;
_14:
    sp();
    sa(sp()*10LL);
    sa(sp()+sp());
    sa(sp()*10LL);
    sa(sp()+sp());
    sa(sp()*10LL);
    sa(sp()+sp());
    sa(sp()*10LL);
    sa(sp()+sp());
    sa(sp()*10LL);
    sa(sp()+sp());
    sa(sr());
    gw(7LL,2LL,sp());
    if(tm(sr(),2LL)!=0)goto _16;else goto _15;
_15:
    sp();
    goto _7;
_16:
    if(tm(sr(),3LL)!=0)goto _17;else goto _15;
_17:
    gw(5LL,2LL,sp());
    sa(7LL);
    sa(tm(gr(5LL,2LL),7LL));
_18:
    if(sp()!=0)goto _19;else goto _15;
_19:
    if(sr()>td(gr(5L,2L),2L))goto _22;else goto _20;
_20:
    sa(sr()-2LL);
    sa(gr(5LL,2LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15;else goto _21;
_21:
    sa(sp()+6LL);
    sa(sr());
    sa(gr(5LL,2LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    goto _18;
_22:
    gw(8LL,2LL,1LL);
    gw(9LL,2LL,gr(2LL,2LL));
    gw(9LL,2LL,gr(9LL,2LL)+1LL);
    gw(4LL,2LL,gr(0LL,2LL));
    sp();
_23:
    sa(5LL);
    sa(gr(5LL,gr(1LL,2LL))-48LL);
_24:
    if(sp()!=0)goto _25;else goto _43;
_25:
    sa(sr());
    sa((tm(gr(4LL,2LL),10LL))+48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+7LL);
    sa(gr(9LL,2LL)+4LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(4LL,2LL,td(gr(4LL,2LL),10LL));
_26:
    sa(sr());
    if(sp()!=0)goto _42;else goto _27;
_27:
    sp();
    sa(gr(12LL,gr(9LL,2LL)+4LL)-48LL);
    sa(4LL);
_28:
    sa(sr()+7LL);
    sa(gr(9LL,2LL)+4LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _41;else goto _29;
_29:
    sp();
    sa(sp()*10LL);
    sa(sp()+sp());
    sa(sp()*10LL);
    sa(sp()+sp());
    sa(sp()*10LL);
    sa(sp()+sp());
    sa(sp()*10LL);
    sa(sp()+sp());
    sa(sp()*10LL);
    sa(sp()+sp());
    if(tm(sr(),2LL)!=0)goto _34;else goto _30;
_30:
    sp();
    if(gr(9LL,2LL)!=9LL)goto _31;else goto _32;
_31:
    gw(9LL,2LL,gr(9LL,2LL)+1LL);
    gw(4LL,2LL,gr(0LL,2LL));
    goto _23;
_32:
    if(gr(8LL,2LL)!=8LL)goto _7;else goto _33;
_33:
    printf("%lld", (int64)(gr(7LL,2LL)));
    return 0;
_34:
    if(tm(sr(),3LL)!=0)goto _35;else goto _30;
_35:
    gw(5LL,2LL,sp());
    sa(7LL);
    sa(tm(gr(5LL,2LL),7LL));
_36:
    if(sp()!=0)goto _37;else goto _30;
_37:
    if(sr()>td(gr(5L,2L),2L))goto _40;else goto _38;
_38:
    sa(sr()-2LL);
    sa(gr(5LL,2LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _30;else goto _39;
_39:
    sa(sp()+6LL);
    sa(sr());
    sa(gr(5LL,2LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    goto _36;
_40:
    gw(8LL,2LL,gr(8LL,2LL)+1LL);
    goto _30;
_41:
    sa(sp()-1LL);
    goto _28;
_42:
    sa(sp()-1LL);
    sa(sr());
    sa(gr(1LL,2LL));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    goto _24;
_43:
    sa(sr());
    sa(gr(9LL,2LL)+48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+7LL);
    sa(gr(9LL,2LL)+4LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _26;
_44:
    sa(sp()-1LL);
    goto _13;
_45:
    sa(sp()-1LL);
    sa(sr());
    sa(gr(1LL,2LL));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    goto _9;
_46:
    sa(sr());
    sa(gr(2LL,2LL)+48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+7LL);
    sa(gr(1LL,2LL));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _11;
_47:
    sp();
    goto _1;
_48:
    return 0;
}