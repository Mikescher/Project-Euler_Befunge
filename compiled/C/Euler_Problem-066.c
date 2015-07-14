/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(2LL,1LL,67108864LL);
    gw(3LL,1LL,3LL);
    gw(1LL,3LL,0LL);
    gw(24LL,8LL,0LL);
    sa(15LL);
_1:
    sa(sr()+8LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(8LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _3;else goto _1;
_3:
    sp();
_4:
    sa(gr(3LL,1LL));
    gw(1LL,0LL,0LL);
    sa(sr());
    gw(2LL,0LL,sp());
_5:
    sa(sr());
    gw(3LL,0LL,sp());
    sa(sr());
    sa(gr(2LL,0LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}
    sa(sp()+sp());
    sa(td(sp(),2L));
    if(sr()!=gr(3LL,0LL))goto _54;else goto _6;
_6:
    sp();
    sa(gr(3LL,0LL));
    gw(4LL,1LL,gr(3LL,0LL));
    sa(sr());
    sa(sp()*sp());
    sa(sp()-gr(3LL,1LL));
    if(sp()!=0)goto _7;else goto _53;
_7:
    gw(24LL,5LL,0LL);
    gw(24LL,4LL,0LL);
    gw(24LL,1LL,0LL);
    gw(24LL,0LL,0LL);
    sa(15LL);
_8:
    sa(sr()+8LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(5LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()+8LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(4LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()+8LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()+8LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _10;else goto _8;
_10:
    gw(24LL,1LL,1LL);
    gw(24LL,4LL,1LL);
    gw(1LL,2LL,0LL);
    gw(2LL,2LL,1LL);
    gw(3LL,2LL,td(gr(4LL,1LL)+gr(1LL,2LL),gr(2LL,2LL)));
    sp();
_11:
    sa(15LL);
    sa(15LL);
    sa(gr(24LL,0LL)+(gr(24LL,1LL)*gr(3LL,2LL))+gr(1LL,3LL));
    gw(1LL,3LL,td(gr(24LL,0LL)+(gr(24LL,1LL)*gr(3LL,2LL))+gr(1LL,3LL),gr(2LL,1LL)));
_12:
    sa(tm(sp(),gr(2L,1L)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _52;else goto _13;
_13:
    sp();
    sa(15LL);
    sa(15LL);
    sa(gr(24LL,4LL)+(gr(24LL,5LL)*gr(3LL,2LL))+gr(1LL,3LL));
    gw(1LL,3LL,td(gr(24LL,4LL)+(gr(24LL,5LL)*gr(3LL,2LL))+gr(1LL,3LL),gr(2LL,1LL)));
_14:
    sa(tm(sp(),gr(2L,1L)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(6LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _15;else goto _16;
_15:
    sa(sr());
    sa(sr());
    sa(sr()+9LL);
    sa(4LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(5LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(3LL,2LL));
    sa(sp()+sp());
    sa(sp()+gr(1LL,3LL));
    sa(td(sr(),gr(2LL,1LL)));
    gw(1LL,3LL,sp());
    goto _14;
_16:
    gw(1LL,4LL,1LL);
    gw(24LL,9LL,0LL);
    sp();
    sa(14LL);
_17:
    sa(sr()+9LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(9LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _17;else goto _19;
_19:
    gw(2LL,4LL,15LL);
    gw(3LL,4LL,gr(2LL,4LL)+9LL);
    sp();
_20:
    sa(15LL);
    sa((gr(24LL,6LL)*gr(gr(2LL,4LL)+9LL,6LL)*gr(3LL,1LL))+gr(1LL,4LL)+gr(gr(3LL,4LL),9LL));
    gw(1LL,4LL,td((gr(24LL,6LL)*gr(gr(2LL,4LL)+9LL,6LL)*gr(3LL,1LL))+gr(1LL,4LL)+gr(gr(3LL,4LL),9LL),gr(2LL,1LL)));
_21:
    sa(tm(sp(),gr(2L,1L)));
    gw(gr(3LL,4LL),9LL,sp());
    sa(sp()-1LL);
    if(gr(3L,4L)-9L==0)goto _22;else goto _51;
_22:
    sp();
    sa(gr(2LL,4LL)-1LL);
    if((gr(2L,4L))==0)goto _24;else goto _23;
_23:
    gw(2LL,4LL,sp());
    gw(3LL,4LL,gr(2LL,4LL)+9LL);
    goto _20;
_24:
    gw(1LL,4LL,0LL);
    gw(24LL,7LL,0LL);
    sp();
    sa(14LL);
_25:
    sa(sr()+9LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _25;else goto _27;
_27:
    gw(2LL,4LL,15LL);
    gw(3LL,4LL,gr(2LL,4LL)+9LL);
    sp();
_28:
    sa(15LL);
    sa((gr(24LL,2LL)*gr(gr(2LL,4LL)+9LL,2LL))+gr(1LL,4LL)+gr(gr(3LL,4LL),7LL));
    gw(1LL,4LL,td((gr(24LL,2LL)*gr(gr(2LL,4LL)+9LL,2LL))+gr(1LL,4LL)+gr(gr(3LL,4LL),7LL),gr(2LL,1LL)));
_29:
    sa(tm(sp(),gr(2L,1L)));
    gw(gr(3LL,4LL),7LL,sp());
    sa(sp()-1LL);
    if(gr(3L,4L)-9L==0)goto _30;else goto _50;
_30:
    sp();
    sa(gr(2LL,4LL)-1LL);
    if((gr(2L,4L))==0)goto _31;else goto _49;
_31:
    sp();
    sa(15LL);
    sa(gr(24LL,7LL)-gr(24LL,9LL));
_32:
    if(sp()!=0)goto _45;else goto _33;
_33:
    sa(sr()-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _44;else goto _34;
_34:
    sp();
    sa(0LL);
    sa(gr(9LL,2LL)-gr(9LL,8LL));
    sa(gr(9LL,2LL)-gr(9LL,8LL));
_35:
    if(sp()!=0)goto _40;else goto _36;
_36:
    sp();
    sa(sp()+1LL);
    if(sr()-17L==0)goto _37;else goto _39;
_37:
    sp();
    sa(gr(3LL,1LL)+1LL);
    gw(3LL,1LL,gr(3LL,1LL)+1LL);
    sa(sp()-1000LL);
    if(sp()!=0)goto _4;else goto _38;
_38:
    printf("%lld", (int64)(gr(1LL,1LL)));
    return 0;
_39:
    sa(sr());
    sa(sr()+9LL);
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(8LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _35;
_40:
    sa((sp()>0L)?1:0);
    if(sp()!=0)goto _41;else goto _37;
_41:
    gw(1LL,1LL,gr(3LL,1LL));
    gw(24LL,8LL,gr(24LL,2LL));
    sp();
    sa(14LL);
_42:
    sa(sr());
    sa(sr()+9LL);
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(8LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _37;else goto _42;
_44:
    sa(sr());
    sa(sr()+9LL);
    sa(7LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(9LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();sa(sp()-v0);}
    goto _32;
_45:
    gw(1LL,2LL,(gr(3LL,2LL)*gr(2LL,2LL))-gr(1LL,2LL));
    gw(2LL,2LL,td(gr(3LL,1LL)-(gr(1LL,2LL)*gr(1LL,2LL)),gr(2LL,2LL)));
    sp();
    sa(15LL);
_46:
    sa(sr());
    sa(sr()+9LL);
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+9LL);
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+9LL);
    sa(5LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(4LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+9LL);
    sa(6LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(5LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _48;else goto _46;
_48:
    gw(3LL,2LL,td(gr(4LL,1LL)+gr(1LL,2LL),gr(2LL,2LL)));
    sp();
    goto _11;
_49:
    gw(2LL,4LL,sp());
    gw(3LL,4LL,gr(2LL,4LL)+9LL);
    goto _28;
_50:
    sa(sr());
    sa((sr()+gr(2LL,4LL))-6LL);
    gw(3LL,4LL,sp());
    sa(sp()+9LL);
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(gr(2LL,4LL)+9LL,2LL));
    sa(sp()+gr(1LL,4LL));
    sa(sp()+gr(gr(3LL,4LL),7LL));
    sa(td(sr(),gr(2LL,1LL)));
    gw(1LL,4LL,sp());
    goto _29;
_51:
    sa(sr());
    sa((sr()+gr(2LL,4LL))-6LL);
    gw(3LL,4LL,sp());
    sa(sp()+9LL);
    sa(6LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(gr(2LL,4LL)+9LL,6LL)*gr(3LL,1LL));
    sa(sp()+gr(1LL,4LL));
    sa(sp()+gr(gr(3LL,4LL),9LL));
    sa(td(sr(),gr(2LL,1LL)));
    gw(1LL,4LL,sp());
    goto _21;
_52:
    sa(sr());
    sa(sr());
    sa(sr()+9LL);
    sa(0LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(3LL,2LL));
    sa(sp()+sp());
    sa(sp()+gr(1LL,3LL));
    sa(td(sr(),gr(2LL,1LL)));
    gw(1LL,3LL,sp());
    goto _12;
_53:
    gw(3LL,1LL,gr(3LL,1LL)+1LL);
    sa(gr(3LL,1LL));
    gw(1LL,0LL,0LL);
    sa(sr());
    gw(2LL,0LL,sp());
    goto _5;
_54:
    if(sr()!=gr(1LL,0LL))goto _55;else goto _6;
_55:
    gw(1LL,0LL,gr(3LL,0LL));
    goto _5;
}