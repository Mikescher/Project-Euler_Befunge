/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
    int64 t0,t1;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(0,2,99);
_1:
    if(gr(0,2)!=1000)goto _2;else goto _47;
_2:
    t0=gr(0,2)+1;
    t1=gr(0,2)+1;
    gw(0,2,gr(0,2)+1);
    t1=tm(t1,2);
    t1=(t1!=0)?0:1;
    if((t1)!=0)goto _1;else goto _3;
_3:
    t0=tm(t0,5);
    t0=(t0!=0)?0:1;
    if((t0)!=0)goto _1;else goto _4;
_4:
    gw(1,2,3);
_5:
    t0=gr(1,2)+1;
    gw(1,2,gr(1,2)+1);
    t0=t0-14;
    t0=(t0!=0)?0:1;
    if((t0)!=0)goto _1;else goto _6;
_6:
    gw(2,2,0);
    if(((gr(0,gr(1,2))-48)+gr(2,2))!=0)goto _8;else goto _7;
_7:
    t0=gr(2,2)+1;
    gw(2,2,gr(2,2)+1);
    t0=t0-3;
    t0=(t0!=0)?0:1;
    if((t0)!=0)goto _5;else goto _8;
_8:
    gw(4,2,gr(0,2));
    sa(5);
    sa(gr(5,gr(1,2))-48);
_9:
    if(sp()!=0)goto _10;else goto _46;
_10:
    sa(sr());
    sa((tm(gr(4,2),10))+48);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+7LL);
    sa(gr(1,2));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(4,2,td(gr(4,2),10));
_11:
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _12;else goto _45;
_12:
    sp();
    sa(gr(12,gr(1,2))-48);
    sa(4);
_13:
    sa(sr()+7);
    sa(gr(1,2));
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
    gw(7,2,sp());
    if(tm(sr(),2)!=0)goto _16;else goto _15;
_15:
    sp();
    goto _7;
_16:
    if(tm(sr(),3)!=0)goto _17;else goto _15;
_17:
    gw(5,2,sp());
    sa(7);
    sa(tm(gr(5,2),7));
_18:
    if(sp()!=0)goto _19;else goto _15;
_19:
    if(sr()>td(gr(5,2),2))goto _22;else goto _20;
_20:
    sa(sr()-2);
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15;else goto _21;
_21:
    sa(sp()+6LL);
    sa(sr());
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    goto _18;
_22:
    gw(8,2,1);
    gw(9,2,gr(2,2));
    gw(9,2,gr(9,2)+1);
    gw(4,2,gr(0,2));
    sp();
_23:
    sa(5);
    sa(gr(5,gr(1,2))-48);
_24:
    if(sp()!=0)goto _25;else goto _43;
_25:
    sa(sr());
    sa((tm(gr(4,2),10))+48);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+7LL);
    sa(gr(9,2)+4);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(4,2,td(gr(4,2),10));
_26:
    sa(sr());
    if(sp()!=0)goto _42;else goto _27;
_27:
    sp();
    sa(gr(12,gr(9,2)+4)-48);
    sa(4);
_28:
    sa(sr()+7);
    sa(gr(9,2)+4);
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
    if(tm(sr(),2)!=0)goto _34;else goto _30;
_30:
    sp();
    if(gr(9,2)!=9)goto _31;else goto _32;
_31:
    gw(9,2,gr(9,2)+1);
    gw(4,2,gr(0,2));
    goto _23;
_32:
    if(gr(8,2)!=8)goto _7;else goto _33;
_33:
    printf("%lld", gr(7,2));
    return 0;
_34:
    if(tm(sr(),3)!=0)goto _35;else goto _30;
_35:
    gw(5,2,sp());
    sa(7);
    sa(tm(gr(5,2),7));
_36:
    if(sp()!=0)goto _37;else goto _30;
_37:
    if(sr()>td(gr(5,2),2))goto _40;else goto _38;
_38:
    sa(sr()-2);
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _30;else goto _39;
_39:
    sa(sp()+6LL);
    sa(sr());
    sa(gr(5,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    goto _36;
_40:
    gw(8,2,gr(8,2)+1);
    goto _30;
_41:
    sa(sp()-1LL);
    goto _28;
_42:
    sa(sp()-1LL);
    sa(sr());
    sa(gr(1,2));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    goto _24;
_43:
    sa(sr());
    sa(gr(9,2)+48);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+7LL);
    sa(gr(9,2)+4);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _26;
_44:
    sa(sp()-1LL);
    goto _13;
_45:
    sa(sp()-1LL);
    sa(sr());
    sa(gr(1,2));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    goto _9;
_46:
    sa(sr());
    sa(gr(2,2)+48);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+7LL);
    sa(gr(1,2));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _11;
_47:
    return 0;
}