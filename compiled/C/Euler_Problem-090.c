/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
_1:
    sa(sp()-1LL);

    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    if(sp()!=0)goto _1;else goto _3;
_3:
    gw(2,1,0);
    gw(2,2,0);
    gw(13,1,0);
    gw(13,2,0);
    sp();
    sa(8);
_4:
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

    if(sp()!=0)goto _92;else goto _5;
_5:
    sp();
    sa(9);
_6:
    sa(sr());
    sa(sr()+8);
    sa(0);
    {int64 v0=sp();t0=gr(sp(),v0);}

    if((t0)!=0)goto _89;else goto _7;
_7:
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(td(sp(),10));

    sa(sr()+4);
    sa(2);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;
    t0+=gr(2,2);
    gw(2,2,t0);
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),10));


    if(sr()!=9)goto _88;else goto _8;
_8:
    gw(2,1,(((gr(10,1))!=0)?0:1)+gr(2,1));
    gw(10,1,1);
    sp();
_9:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _6;else goto _10;
_10:
    sp();

    if((gr(2,1)>6?1:0)+(gr(2,2)>6?1LL:0LL)==0)goto _17;else goto _11;
_11:
    gw(17,0,((gr(17,0))!=0)?0:1);
    sa(8);
    sa(8);
    sa(gr(17,0));
_12:
    if(sp()!=0)goto _16;else goto _13;
_13:
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _14;else goto _15;
_14:
    printf("%lld", gr(2,0));
    sp();
    return 0;
_15:
    sa(sp()-1LL);

    sa(sr());
    sa(sr());
    sa(sr());
    sa(sr()+9);
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+9LL);

    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    goto _12;
_16:
    sp();
    sp();
    sa(0);
    goto _3;
_17:
    if(6!=gr(2,1))goto _87;else goto _18;
_18:
    sa(2);
_19:
    if(gr(2,2)!=6)goto _20;else goto _86;
_20:
    sa(9);
    sa(gr(13,2));
_21:
    if(sp()!=0)goto _22;else goto _45;
_22:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _23;else goto _24;
_23:
    sa(sr()+4);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    goto _21;
_24:
    sp();
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _44;else goto _26;
_26:
    sa(sp()-1LL);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _31;else goto _27;
_27:
    sa(sp()-1LL);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _28;else goto _30;
_28:
    gw(17,0,((gr(17,0))!=0)?0:1);
    sp();
    sa(8);
    sa(8);
    sa(gr(17,0));
    goto _12;
_30:
    return 0;
_31:
    sp();
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_33:
    if(sp()!=0)goto _34;else goto _28;
_34:
    sa(sr()+4);
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
_35:
    if(sp()!=0)goto _43;else goto _36;
_36:
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}

    if(5!=gr(2,1))goto _38;else goto _37;
_37:
    sa(1);
    goto _19;
_38:
    sa(9);
    sa(gr(13,1));
_39:
    if(sp()!=0)goto _40;else goto _42;
_40:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _41;else goto _31;
_41:
    sa(sr()+4);
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    goto _39;
_42:
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(0);
    goto _19;
_43:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _33;
_44:
    sp();
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _40;
_45:
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}

    if(5!=gr(2,2))goto _46;else goto _85;
_46:
    sa(9);
    sa(gr(13,2));
_47:
    if(sp()!=0)goto _48;else goto _52;
_48:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _51;else goto _49;
_49:
    sp();
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _23;else goto _24;
_51:
    sa(sr()+4);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    goto _47;
_52:
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(4,0,(((gr(10,1))!=0)?0:1)+gr(13,1));
    gw(5,0,(((gr(10,2))!=0)?0:1)+gr(13,2));
    gw(6,0,0);
    gw(7,0,0);
    gw(6,0,gr(13,1)+(gr(6,0)*2));
    sa(0);
_53:
    sa(0);
_54:
    sa(8);
_55:
    sa(sr()+4);
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0+=gr(6,0)*2;
    gw(6,0,t0);
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _55;else goto _57;
_57:
    gw(7,0,gr(13,2)+(gr(7,0)*2));
    sp();
    sa(8);
_58:
    sa(sr()+4);
    sa(2);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0+=gr(7,0)*2;
    gw(7,0,t0);
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _58;else goto _60;
_60:
    sp();
    sa(gr(7,0));
    sa(gr(6,0));

    if(gr(6,0)>gr(7,0))goto _61;else goto _62;
_61:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_62:
    sa(sp()*1024LL);

    sa(sp()+sp());

    t0=sp();
    gw(3,0,t0);
    sa(1279);
    sa(gr(79,15+gr(3,3)));
    sa(gr(79,15+gr(3,3))-gr(3,0));
_63:
    if(sp()!=0)goto _64;else goto _84;
_64:
    sa(sp()-35LL);

    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _65;else goto _83;
_65:
    sa(gr(3,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),80));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),80));

    sa(sp()+gr(3,3));

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(2,0,gr(2,0)+1);
_66:
    sa(sp()+1LL);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _82;else goto _67;
_67:
    sa(sp()-1LL);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _80;else goto _68;
_68:
    sa(sp()-1LL);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _79;else goto _69;
_69:
    sa(sp()-1LL);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _70;else goto _30;
_70:
    gw(10,1,1);
    gw(13,1,0);
    gw(10,2,1);
    gw(13,2,0);
    sp();
_71:
    if((gr(4,0))==0)goto _72;else goto _73;
_72:
    gw(10,1,0);
    gw(13,1,1);
    gw(6,0,0);
    gw(7,0,0);
    gw(6,0,gr(13,1)+(gr(6,0)*2));
    sa(1);
    goto _54;
_73:
    if((gr(5,0))==0)goto _78;else goto _74;
_74:
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _77;else goto _75;
_75:
    sa(sp()-1LL);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _49;else goto _76;
_76:
    sa(sp()-1LL);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _24;else goto _30;
_77:
    sp();
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _48;
_78:
    gw(10,2,0);
    gw(13,2,1);
    gw(6,0,0);
    gw(7,0,0);
    gw(6,0,gr(13,1)+(gr(6,0)*2));
    sa(-1);
    goto _54;
_79:
    gw(10,1,1);
    gw(13,1,0);
    sp();
    goto _73;
_80:
    sp();

    if((gr(4,0)+gr(5,0))!=0)goto _71;else goto _81;
_81:
    gw(10,1,0);
    gw(13,1,1);
    gw(10,2,0);
    gw(13,2,1);
    gw(6,0,0);
    gw(7,0,0);
    gw(6,0,gr(13,1)+(gr(6,0)*2));
    sa(2);
    goto _54;
_82:
    gw(10,2,1);
    gw(13,2,0);
    sp();
    goto _74;
_83:
    sa(sp()-1LL);

    sa(sr());
    sa(tm(sr(),80));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),80));

    sa(sp()+gr(3,3));

    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr()-gr(3,0));
    goto _63;
_84:
    sp();
    sp();
    goto _66;
_85:
    gw(4,0,(((gr(10,1))!=0)?0:1)+gr(13,1));
    gw(5,0,(((gr(10,2))!=0)?0:1)+gr(13,2));
    gw(6,0,0);
    gw(7,0,0);
    gw(6,0,gr(13,1)+(gr(6,0)*2));
    sa(1);
    goto _53;
_86:
    gw(4,0,(((gr(10,1))!=0)?0:1)+gr(13,1));
    gw(5,0,(((gr(10,2))!=0)?0:1)+gr(13,2));
    gw(6,0,0);
    gw(7,0,0);
    gw(6,0,gr(13,1)+(gr(6,0)*2));
    sa(2);
    goto _53;
_87:
    sa(9);
    sa(gr(13,1));
    goto _35;
_88:
    sa(sr()+4);
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;
    t0+=gr(2,1);
    gw(2,1,t0);
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _9;
_89:
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(td(sp(),10));

    sa(sr()+4);
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;
    t0+=gr(2,1);
    gw(2,1,t0);
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),10));


    if(sr()!=9)goto _91;else goto _90;
_90:
    gw(2,2,(((gr(10,2))!=0)?0:1)+gr(2,2));
    gw(10,2,1);
    sp();
    goto _9;
_91:
    sa(sr()+4);
    sa(2);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;
    t0+=gr(2,2);
    gw(2,2,t0);
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+4LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _9;
_92:
    sa(sp()-1LL);
    goto _4;
}
