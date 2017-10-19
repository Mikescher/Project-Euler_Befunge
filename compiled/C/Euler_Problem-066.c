/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    sa(15);
_1:
    if(sp()!=0)goto _55;else goto _2;
_2:
    sp();
_3:
    t0=gr(3,1);
    sa(gr(3,1));
    sa(gr(3,1));
    gw(1,0,0);
    gw(2,0,t0);
_4:
    gw(3,0,sp());
    t0=gr(2,0);
    sa(sr());
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}

    t1=sp();
    sa(sp()+t1);

    sa(sp()/2LL);


    if((sr()-gr(3,0))!=0)goto _53;else goto _5;
_5:
    t0=gr(3,0)*gr(3,0);
    gw(4,1,gr(3,0));
    t0-=gr(3,1);
    sp();

    if((t0)!=0)goto _6;else goto _52;
_6:
    gw(24,5,0);
    gw(24,4,0);
    gw(24,1,0);
    gw(24,0,0);
    sa(15);
    sa(15);
_7:
    if(sp()!=0)goto _51;else goto _8;
_8:
    gw(24,1,1);
    gw(24,4,1);
    gw(1,2,0);
    gw(2,2,1);
    sp();
_9:
    gw(3,2,td(gr(4,1)+gr(1,2),gr(2,2)));
    sa(15);
    sa(15);
    sa(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3));
    gw(1,3,td(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3),gr(2,1)));
_10:
    sa(tm(sp(),gr(2,1)));

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _50;else goto _11;
_11:
    sp();
    sa(15);
    sa(15);
    sa(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3));
    gw(1,3,td(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3),gr(2,1)));
_12:
    sa(tm(sp(),gr(2,1)));

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(6);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _13;else goto _14;
_13:
    sa(sr());
    sa(sr());
    t0=gr(sr()+9,4);
    sa(sp()+9LL);

    sa(5);
    {int64 v0=sp();t1=gr(sp(),v0);}
    t1*=gr(3,2);
    sa(t0+t1+gr(1,3));
    gw(1,3,td(sr(),gr(2,1)));
    goto _12;
_14:
    gw(1,4,1);
    gw(24,9,0);
    sp();
    sa(14);
    sa(15);
_15:
    if(sp()!=0)goto _49;else goto _16;
_16:
    gw(2,4,15);
    sp();
_17:
    gw(3,4,gr(2,4)+9);
    sa(15);
    sa((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9));
    gw(1,4,td((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9),gr(2,1)));
_18:
    sa(tm(sp(),gr(2,1)));

    gw(gr(3,4),9,sp());
    sa(sp()-1LL);


    if(gr(3,4)!=9)goto _48;else goto _19;
_19:
    t0=gr(2,4)-1;
    sp();

    if((gr(2,4))!=0)goto _47;else goto _20;
_20:
    gw(1,4,0);
    gw(24,7,0);
    sa(14);
    sa(15);
_21:
    if(sp()!=0)goto _46;else goto _22;
_22:
    gw(2,4,15);
    sp();
_23:
    gw(3,4,gr(2,4)+9);
    sa(15);
    sa((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7));
    gw(1,4,td((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7),gr(2,1)));
_24:
    sa(tm(sp(),gr(2,1)));

    gw(gr(3,4),7,sp());
    sa(sp()-1LL);


    if(gr(3,4)!=9)goto _45;else goto _25;
_25:
    t0=gr(2,4)-1;
    sp();

    if((gr(2,4))!=0)goto _44;else goto _26;
_26:
    sa(15);
    sa(gr(24,7)-gr(24,9));
_27:
    if(sp()!=0)goto _40;else goto _28;
_28:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _29;else goto _30;
_29:
    sa(sr());
    t0=gr(sr()+9,7);
    sa(sp()+9LL);

    sa(9);
    {int64 v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    goto _27;
_30:
    t0=1;
    t1=1;
    sp();
    sa(0);
    sa(gr(9,2)-gr(9,8));
    sa(gr(9,2)-gr(9,8));
_31:
    if(sp()!=0)goto _36;else goto _32;
_32:
    sp();
    sa(sp()+1LL);


    if(sr()!=17)goto _35;else goto _33;
_33:
    t0=gr(3,1)-999;
    gw(3,1,gr(3,1)+1);
    sp();

    if((t0)!=0)goto _3;else goto _34;
_34:
    printf("%lld ", gr(1,1));
    return 0;
_35:
    sa(sr());
    t0=gr(sr()+9,2);
    sa(sp()+9LL);

    sa(8);
    {int64 v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    sa(t0-t1);
    goto _31;
_36:
    sa((sp()>0)?1:0);


    if(sp()!=0)goto _37;else goto _33;
_37:
    gw(1,1,gr(3,1));
    gw(24,8,gr(24,2));
    sp();
    sa(14);
    sa(15);
_38:
    if(sp()!=0)goto _39;else goto _33;
_39:
    sa(sr());
    sa(gr(sr()+9,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(8);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _38;
_40:
    gw(1,2,(gr(3,2)*gr(2,2))-gr(1,2));
    gw(2,2,td(gr(3,1)-(gr(1,2)*gr(1,2)),gr(2,2)));
    sp();
    sa(15);
    sa(0);
_41:
    if(sp()!=0)goto _42;else goto _43;
_42:
    sp();
    goto _9;
_43:
    sa(sr());
    sa(gr(sr()+9,1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(gr(sr()+9,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(gr(sr()+9,5));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(4);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(gr(sr()+9,6));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(5);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);
    goto _41;
_44:
    gw(2,4,t0);
    goto _23;
_45:
    sa(sr());
    gw(3,4,(sr()+gr(2,4))-6);
    sa(sp()+9LL);

    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(gr(2,4)+9,2));

    sa(sp()+gr(1,4));

    sa(sp()+gr(gr(3,4),7));

    gw(1,4,td(sr(),gr(2,1)));
    goto _24;
_46:
    sa(sr()+9);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _21;
_47:
    gw(2,4,t0);
    goto _17;
_48:
    sa(sr());
    gw(3,4,(sr()+gr(2,4))-6);
    sa(sp()+9LL);

    sa(6);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(gr(2,4)+9,6)*gr(3,1));

    sa(sp()+gr(1,4));

    sa(sp()+gr(gr(3,4),9));

    gw(1,4,td(sr(),gr(2,1)));
    goto _18;
_49:
    sa(sr()+9);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(9);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _15;
_50:
    sa(sr());
    sa(sr());
    t0=gr(sr()+9,0);
    sa(sp()+9LL);

    sa(1);
    {int64 v0=sp();t1=gr(sp(),v0);}
    t1*=gr(3,2);
    sa(t0+t1+gr(1,3));
    gw(1,3,td(sr(),gr(2,1)));
    goto _10;
_51:
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
    goto _7;
_52:
    gw(3,1,gr(3,1)+1);
    t0=gr(3,1);
    sa(gr(3,1));
    sa(gr(3,1));
    gw(1,0,0);
    gw(2,0,t0);
    goto _4;
_53:
    if((sr()-gr(1,0))!=0)goto _54;else goto _5;
_54:
    gw(1,0,gr(3,0));
    sa(sr());
    goto _4;
_55:
    sa(sr()+8);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(8);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr());
    goto _1;
}
