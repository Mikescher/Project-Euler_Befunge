/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v X_XXOO {#}  ){ }  0v6$<{ }  1> #g #0 #+ #8 #: #:v#<>v 2 X {#}  *v 2+4\\1p22+g22!g2+4:< _^#-9:%+55*:p1+4\\1p12+g12!g1+4:/+55*::_v"
           " 1g 9 X {#}  *v1+4\\1p12+g12!g1+4:<   _v#-9:%+55*:p2+4\\1p22+g22!g2+4:/+55*::< 26 3  C{ }  *>p{ }  0#^6$ #<     #v      >#      #<"
           "{ }  +1-:|$` *>020p8>:0\\9+0p:#v_$021p022p9>:0\\4+1p:0\\4+2p:#v_$55+^vg0+9p0+9\\!g0+9::::<   >^2 +p     ^-1{ }  '<^00{ }  '<^-1{ }  "
           ".<   v$$_!#v_1- #  #v #! #+^#`6g2< 33{ }  :^{ }  5<     >$   ^  v_8     ^{ }  '>^{ }  F@.g02< >:1-\\#v_${ }  )>     8^{ }  5>:0\\4"
           "+1p  >:1-\\#v_$     v{ }  (|g1+4:<9_v#-g12 6<{ }  >vp1+4\\1:<|g1+4:<9_v#-g125p1+4\\1:<{ }  (2>{ }  '^{ }  <^0{ }  '^<      >#1>:0\\4"
           "+1p     >:1-\\#^_${ }  )^{ }  <$#{ }  /^  $$  <{ }  1#${ }  B>#^_1-{ }  -:!#^_1-{ }  0:!#^_@{ }  @!{  >{ }  /}  \"{ }  '>22g6- #v "
           "_v{ }  .>v{ }  (^:{ }  3^#{ }  2< >:1-\\#v_$  #2v{ }  -p{ }  3>:0\\4+2p  >:1-\\#v_$     v{ }  (|g2+4:<9<< > v{ }  -2{ }  4vp2+4\\1:<"
           "|g2+4:<9_v#-g225p2+4\\1:< v{ }  *<   >g1+20pv  +{ }  3^0{ }  '^<      >#1>:0\\4+2p   # >:1-\\#^_$  ^     ^02p+g<   9{ }  3$#{ }  /^"
           " #$$  <      ^  $<{ }  ($# >%\\\"P\"/33^ >#4>{ }  /{:!#^_1-{ }  -}  \"    :!#^_@^\"P\":\\g03<   0 v+64p04+g1+94!g1+64<   >#{ }  +#<{ } "
           " +#v#{ }  *#<     v     #  p >2g!49+2g+50pv>40g50g+#^_046+1p149+1p046+2p149+2pv>146+1p049+1p146+2p 049vv<^<^2+641< v0p2+9$0 41p2"
           "+640_v#!g05<p1+940p1+641< v p 2#1+941p1+640_v#!g04<p2+<# v{ }  '$#{ }  ($#      <   >v{ }  *v{    $# }  \"{ }  *#     <  > ^ >  1"
           "+{:!#^_1-   }  \"#^{ }  .#< :!#^_1-:!#^_@>33g+g:30g-#v_$$^     < ^{ }  (-#{ }  0< 9   ^{ }  @< >57*- !|  #{ }  *>      >060p070p9"
           "v<{ }  +9p070p060<   <   ^/\"P\"\\%\"P\"::<  v   <{ }  3v*2g06g1+4:<  $v{ }  3<{ }  .>\\v^-1<*\" (\"<#{ }  0>+60p:1-\\  #^_^>:4+2g70g2*+7"
           "0p:1-\\#^_$70g60g:70g`#^_>48*:**+30p^{#} -M";
int t=0;int z=0;
int64 g[3600];
int d(){int s,w,i,j,h;h=z;for(;t<1706;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<80&&y<45){return g[y*80+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<80&&y<45){g[y*80+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(3,3,29);
    gw(2,0,0);
    gw(17,0,0);
    sa(8);
    sa(8);
_1:
    if(sp()!=0)goto _94;else goto _2;
_2:
    gw(2,1,0);
    gw(2,2,0);
    gw(13,1,0);
    gw(13,2,0);
    sp();
    sa(9);
    sa(9);
_3:
    if(sp()!=0)goto _93;else goto _4;
_4:
    sp();
    sa(9);
    sa(9);
_5:
    if(sp()!=0)goto _85;else goto _6;
_6:
    sp();

    if(((gr(2,1)>6?1:0)+(gr(2,2)>6?1LL:0LL))!=0)goto _7;else goto _13;
_7:
    gw(17,0,((gr(17,0))!=0)?0:1);
    sa(8);
    sa(8);
    sa(gr(17,0));
_8:
    if(sp()!=0)goto _9;else goto _10;
_9:
    sp();
    sp();
    sa(0);
    goto _2;
_10:
    if(sp()!=0)goto _12;else goto _11;
_11:
    printf("%lld ", gr(2,0));
    sp();
    return 0;
_12:
    sa(sp()-1LL);

    sa(sr());
    sa(sr());
    sa(sr());
    sa(((gr(sr()+9,0))!=0)?0:1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+9LL);

    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    goto _8;
_13:
    if(gr(2,1)!=6)goto _84;else goto _14;
_14:
    sa(2);
_15:
    if(gr(2,2)!=6)goto _83;else goto _16;
_16:
    sa(2);
_17:
    gw(4,0,(((gr(10,1))!=0)?0:1)+gr(13,1));
    gw(5,0,(((gr(10,2))!=0)?0:1)+gr(13,2));
    sa(0);
_18:
    gw(6,0,0);
    gw(7,0,0);
    gw(6,0,gr(13,1)+(gr(6,0)*2));
    sa(8);
    sa(9);
_19:
    if(sp()!=0)goto _82;else goto _20;
_20:
    gw(7,0,gr(13,2)+(gr(7,0)*2));
    sp();
    sa(8);
    sa(9);
_21:
    if(sp()!=0)goto _81;else goto _22;
_22:
    sp();
    sa(gr(7,0));
    sa(gr(6,0));

    if(gr(6,0)>gr(7,0))goto _23;else goto _24;
_23:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_24:
    sa(sp()*1024LL);

    sa(sp()+sp());

    t0=sp();
    gw(3,0,t0);
    sa(1279);
    sa(gr(79,15+gr(3,3)));
    sa(gr(79,15+gr(3,3))-gr(3,0));
_25:
    if(sp()!=0)goto _26;else goto _80;
_26:
    sa(sp()-35LL);


    if(sp()!=0)goto _79;else goto _27;
_27:
    sa(gr(3,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr()%80);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/80LL);

    sa(sp()+gr(3,3));

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(2,0,gr(2,0)+1);
_28:
    sa(sp()+1LL);

    sa(sr());

    if(sp()!=0)goto _29;else goto _78;
_29:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _30;else goto _76;
_30:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _31;else goto _75;
_31:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _32;else goto _33;
_32:
    return 0;
_33:
    gw(10,1,1);
    gw(13,1,0);
    gw(10,2,1);
    gw(13,2,0);
    sp();
_34:
    if((gr(4,0))!=0)goto _36;else goto _35;
_35:
    gw(10,1,0);
    gw(13,1,1);
    sa(1);
    goto _18;
_36:
    if((gr(5,0))!=0)goto _37;else goto _74;
_37:
    sa(sr());

    if(sp()!=0)goto _38;else goto _73;
_38:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _39;else goto _60;
_39:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _32;else goto _40;
_40:
    sp();
    t0=1;
    sa(sr());

    if(sp()!=0)goto _42;else goto _59;
_42:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _43;else goto _45;
_43:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _32;else goto _44;
_44:
    sp();
    gw(17,0,((gr(17,0))!=0)?0:1);
    sa(8);
    sa(8);
    sa(gr(17,0));
    goto _8;
_45:
    sp();
_46:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_47:
    if(sp()!=0)goto _48;else goto _44;
_48:
    sa(gr(sr()+4,1));
_49:
    if(sp()!=0)goto _58;else goto _50;
_50:
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}

    if(gr(2,1)!=5)goto _52;else goto _51;
_51:
    sa(1);
    goto _15;
_52:
    sa(9);
    sa(gr(13,1));
_53:
    if(sp()!=0)goto _54;else goto _57;
_54:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _55;else goto _56;
_55:
    sa(gr(sr()+4,1));
    goto _53;
_56:
    t0=2;
    sp();
    goto _46;
_57:
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(0);
    goto _15;
_58:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _47;
_59:
    sp();
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _54;
_60:
    sp();
_61:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _62;else goto _40;
_62:
    sa(gr(sr()+4,2));
_63:
    if(sp()!=0)goto _72;else goto _64;
_64:
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}

    if(gr(2,2)!=5)goto _66;else goto _65;
_65:
    sa(1);
    goto _17;
_66:
    sa(9);
    sa(gr(13,2));
_67:
    if(sp()!=0)goto _68;else goto _71;
_68:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _69;else goto _70;
_69:
    sa(gr(sr()+4,2));
    goto _67;
_70:
    t0=2;
    sp();
    goto _61;
_71:
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(0);
    goto _17;
_72:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _62;else goto _40;
_73:
    sp();
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _68;
_74:
    gw(10,2,0);
    t0=0;
    gw(13,2,1);
    sa(-1);
    goto _18;
_75:
    gw(10,1,1);
    gw(13,1,0);
    sp();
    goto _36;
_76:
    sp();

    if((gr(4,0)+gr(5,0))!=0)goto _34;else goto _77;
_77:
    gw(10,1,0);
    gw(13,1,1);
    gw(10,2,0);
    gw(13,2,1);
    sa(2);
    goto _18;
_78:
    gw(10,2,1);
    gw(13,2,0);
    sp();
    goto _37;
_79:
    sa(sp()-1LL);

    sa(sr());
    sa(sr()%80);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/80LL);

    sa(sp()+gr(3,3));

    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr()-gr(3,0));
    goto _25;
_80:
    sp();
    sp();
    goto _28;
_81:
    gw(7,0,gr(sr()+4,2)+(gr(7,0)*2));
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _21;
_82:
    gw(6,0,gr(sr()+4,1)+(gr(6,0)*2));
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _19;
_83:
    sa(9);
    sa(gr(13,2));
    goto _63;
_84:
    sa(9);
    sa(gr(13,1));
    goto _49;
_85:
    sa(sr());

    if((gr(sr()+8,0))!=0)goto _90;else goto _86;
_86:
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()/10LL);

    gw(2,2,(((gr(sr()+4,2))!=0)?0:1)+gr(2,2));
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sp()*sp());

    sa(sp()%10LL);


    if(sr()!=9)goto _89;else goto _87;
_87:
    gw(2,1,(((gr(10,1))!=0)?0:1)+gr(2,1));
    gw(10,1,1);
    sp();
_88:
    t0=6;
    sa(sp()-1LL);

    sa(sr());
    goto _5;
_89:
    gw(2,1,(((gr(sr()+4,1))!=0)?0:1)+gr(2,1));
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _88;
_90:
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()/10LL);

    gw(2,1,(((gr(sr()+4,1))!=0)?0:1)+gr(2,1));
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sp()*sp());

    sa(sp()%10LL);


    if(sr()!=9)goto _92;else goto _91;
_91:
    gw(2,2,(((gr(10,2))!=0)?0:1)+gr(2,2));
    gw(10,2,1);
    sp();
    goto _88;
_92:
    gw(2,2,(((gr(sr()+4,2))!=0)?0:1)+gr(2,2));
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _88;
_93:
    sa(sp()-1LL);

    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    goto _3;
_94:
    sa(sp()-1LL);

    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    goto _1;
}
