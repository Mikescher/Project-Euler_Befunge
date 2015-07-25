/* compiled with BefunCompile v1.0.7 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "vYYY     {#}  0{ }  XXBXX    {#}  0{ }  XZZZ     {#}  0{ }  XN{ }  oOOO     {{#}  0{ }  `}  #{#}  0{ }  ;v 9::p4+9\\g5+9::p1+9\\g2"
           "+9: <{ }  ){#}  0{ }  ;>+6g\\9+5p:1-\\!v0  <{ }  2{#}  0{ }  ?v{ }  ($_::9+1g\\9+0p:^{ }  Av  _v#-*\";}\"8p13:+1g13$<{ }  .#     <   "
           ">\"@ \":*:**21p331p013p88 +>:8+0\\8v    >11g.@   >+8p:1-\\!|  >-22g/22p35*^{ }  )v{ }  )p02:p010g13<$<_^#!:-1p<{ }  -^9\\g2+9::<# ^*:"
           "g21g13p21-g21*g 22<vp01g03_v#-g01:_v#- <^{ }  +<v_v#!:-1p0\\0+8:p1\\0 <^*53p11g13$_{ }  )^  g>:30p:20 g\\/+2/: 30g^{ }  *>88 +>:8+0"
           "\\5p:8+0\\4p:8+^    >     `^      >$$ $v2{ }  (>{ }  '>$30g:41p:*31g-|  >$164*1p164*4p012p122pv  0 >$1+:9-8-     !| 03^p02:p010g13"
           "p13+1g13{ }  +<v{ }  '># 3# 5# *#    #<v ^_^#:-g8+9\\g2+9::< <$v*53p23/g22+g21g14{ }  .<{ }  '${ }  C>  ^>:::9+0g\\9+1g32g*+13g+:v"
           " v 53<{ }  *|!\\-1:g42$<      >::9+7g\\9+9g-      |   |\\-1:p2+9\\%g12 p31/g12 < # >$     014p35 *>:9+0\\ v|!-9g43-1p7g43%g12p41/g12 "
           ":+g<>$35*:::9+4g\\9+5g32g*+13g+v  ${ }  (>*>2 4p35*  >::24g+# 6-34p9+2g24g9+2gv>1v7>:::9+4g\\9+5g32g*+13g+v   <|!\\-1:g42$<    |\\-1"
           ":p7<{ }  '^{ }  /#  < -g|\\-1:p6+9\\%g12p31/g12:<>     # :9+0\\v| !-9 g43-1p9g43%g12p41/g12:+g9g43<v1*<|\\<4>$114p35*{ }  .^ >*>2 4p"
           "35*#9> ::2 4g+6-34p9+6g24g9+6g31g**14g+^> 4g +3^{ }  7^    _^#\\-1:p< ^53$<{ }  >^ $<   ";
int t=0;int z=0;
int64 g[2000];
int d(){int s,w,i,j,h;h=z;for(;t<1239;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<80&&y<25){return g[y*80+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<80&&y<25){g[y*80+x]=v;}}
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
    gw(2,1,67108864);
    gw(3,1,3);
    gw(1,3,0);
    gw(24,8,0);
    sa(15);
_1:
    sa(sr()+8);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(8);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _3;else goto _1;
_3:
    sp();
_4:
    sa(gr(3,1));
    gw(1,0,0);
    sa(sr());
    gw(2,0,sp());
_5:
    sa(sr());
    gw(3,0,sp());
    sa(sr());
    t0=gr(2,0);
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}
    t1=sp();
    sa(sp()+t1);
    sa(td(sp(),2));
    if(sr()!=gr(3,0))goto _54;else goto _6;
_6:
    sp();
    sa(gr(3,0));
    gw(4,1,gr(3,0));
    sa(sr());
    sa(sp()*sp());
    t0=sp();
    t0=t0-gr(3,1);
    if((t0)!=0)goto _7;else goto _53;
_7:
    gw(24,5,0);
    gw(24,4,0);
    gw(24,1,0);
    gw(24,0,0);
    sa(15);
_8:
    sa(sr()+8);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(5);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()+8);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(4);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()+8);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()+8);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _10;else goto _8;
_10:
    gw(24,1,1);
    gw(24,4,1);
    gw(1,2,0);
    gw(2,2,1);
    gw(3,2,td(gr(4,1)+gr(1,2),gr(2,2)));
    sp();
_11:
    sa(15);
    sa(15);
    sa(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3));
    gw(1,3,td(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3),gr(2,1)));
_12:
    sa(tm(sp(),gr(2,1)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _52;else goto _13;
_13:
    sp();
    sa(15);
    sa(15);
    sa(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3));
    gw(1,3,td(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3),gr(2,1)));
_14:
    sa(tm(sp(),gr(2,1)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(6);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _15;else goto _16;
_15:
    sa(sr());
    sa(sr());
    sa(sr()+9);
    sa(4);
    {int64 v0=sp();t0=gr(sp(),v0);}
    sa(sp()+9LL);
    sa(5);
    {int64 v0=sp();t1=gr(sp(),v0);}
    t1=t1*gr(3,2);
    sa(t0+t1);
    sa(sp()+gr(1,3));
    t0=td(sr(),gr(2,1));
    gw(1,3,t0);
    goto _14;
_16:
    gw(1,4,1);
    gw(24,9,0);
    sp();
    sa(14);
_17:
    sa(sr()+9);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(9);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _17;else goto _19;
_19:
    gw(2,4,15);
    gw(3,4,gr(2,4)+9);
    sp();
_20:
    sa(15);
    sa((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9));
    gw(1,4,td((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9),gr(2,1)));
_21:
    sa(tm(sp(),gr(2,1)));
    gw(gr(3,4),9,sp());
    sa(sp()-1LL);
    if(gr(3,4)-9==0)goto _22;else goto _51;
_22:
    sp();
    t0=gr(2,4)-1;
    if((gr(2,4))==0)goto _23;else goto _50;
_23:
    gw(1,4,0);
    gw(24,7,0);
    sa(14);
_24:
    sa(sr()+9);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _24;else goto _26;
_26:
    gw(2,4,15);
    gw(3,4,gr(2,4)+9);
    sp();
_27:
    sa(15);
    sa((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7));
    gw(1,4,td((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7),gr(2,1)));
_28:
    sa(tm(sp(),gr(2,1)));
    gw(gr(3,4),7,sp());
    sa(sp()-1LL);
    if(gr(3,4)-9==0)goto _29;else goto _49;
_29:
    sp();
    t0=gr(2,4)-1;
    if((gr(2,4))==0)goto _30;else goto _48;
_30:
    sa(15);
    sa(gr(24,7)-gr(24,9));
_31:
    if(sp()!=0)goto _44;else goto _32;
_32:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _43;else goto _33;
_33:
    sp();
    sa(0);
    sa(gr(9,2)-gr(9,8));
    sa(gr(9,2)-gr(9,8));
_34:
    if(sp()!=0)goto _39;else goto _35;
_35:
    sp();
    sa(sp()+1LL);
    if(sr()-17==0)goto _36;else goto _38;
_36:
    sp();
    t0=gr(3,1)+1;
    gw(3,1,gr(3,1)+1);
    t0=t0-1000;
    if((t0)!=0)goto _4;else goto _37;
_37:
    printf("%lld", gr(1,1));
    return 0;
_38:
    sa(sr());
    sa(sr()+9);
    sa(2);
    {int64 v0=sp();t0=gr(sp(),v0);}
    sa(sp()+9LL);
    sa(8);
    {int64 v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    sa(sr());
    goto _34;
_39:
    sa((sp()>0)?1:0);
    if(sp()!=0)goto _40;else goto _36;
_40:
    gw(1,1,gr(3,1));
    gw(24,8,gr(24,2));
    sp();
    sa(14);
_41:
    sa(sr());
    sa(sr()+9);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(8);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _36;else goto _41;
_43:
    sa(sr());
    sa(sr()+9);
    sa(7);
    {int64 v0=sp();t0=gr(sp(),v0);}
    sa(sp()+9LL);
    sa(9);
    {int64 v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    goto _31;
_44:
    gw(1,2,(gr(3,2)*gr(2,2))-gr(1,2));
    gw(2,2,td(gr(3,1)-(gr(1,2)*gr(1,2)),gr(2,2)));
    sp();
    sa(15);
_45:
    sa(sr());
    sa(sr()+9);
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+9);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+9);
    sa(5);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(4);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+9);
    sa(6);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(5);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _47;else goto _45;
_47:
    gw(3,2,td(gr(4,1)+gr(1,2),gr(2,2)));
    sp();
    goto _11;
_48:
    gw(2,4,t0);
    gw(3,4,gr(2,4)+9);
    goto _27;
_49:
    sa(sr());
    t0=(sr()+gr(2,4))-6;
    gw(3,4,t0);
    sa(sp()+9LL);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(gr(2,4)+9,2));
    sa(sp()+gr(1,4));
    sa(sp()+gr(gr(3,4),7));
    t0=td(sr(),gr(2,1));
    gw(1,4,t0);
    goto _28;
_50:
    gw(2,4,t0);
    gw(3,4,gr(2,4)+9);
    goto _20;
_51:
    sa(sr());
    t0=(sr()+gr(2,4))-6;
    gw(3,4,t0);
    sa(sp()+9LL);
    sa(6);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(gr(2,4)+9,6)*gr(3,1));
    sa(sp()+gr(1,4));
    sa(sp()+gr(gr(3,4),9));
    t0=td(sr(),gr(2,1));
    gw(1,4,t0);
    goto _21;
_52:
    sa(sr());
    sa(sr());
    sa(sr()+9);
    sa(0);
    {int64 v0=sp();t0=gr(sp(),v0);}
    sa(sp()+9LL);
    sa(1);
    {int64 v0=sp();t1=gr(sp(),v0);}
    t1=t1*gr(3,2);
    sa(t0+t1);
    sa(sp()+gr(1,3));
    t0=td(sr(),gr(2,1));
    gw(1,3,t0);
    goto _12;
_53:
    gw(3,1,gr(3,1)+1);
    sa(gr(3,1));
    gw(1,0,0);
    sa(sr());
    gw(2,0,sp());
    goto _5;
_54:
    if(sr()!=gr(1,0))goto _55;else goto _6;
_55:
    gw(1,0,gr(3,0));
    goto _5;
}