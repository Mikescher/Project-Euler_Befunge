/* compiled with BefunCompile v1.0.8 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v   XX{ }  i{=}  H    v      <     v<{ }  2{?}  H v<<   v<<<|-\"!\":<|-+98:<{ }  *>040p\";};}@\"**58*v{ }  -v   _v# -1<  v<10   v 10"
           "> v    <    <|<{ }  ,v{ }  +<{ }  20    |:+<2?^#*4<2?^#$<{ }  )^<{ }  ->1-:2+0\\1pv{ }  <{^3<    }  \"{ }  +-{ }  ,|:{ }  (<     >"
           ">>v >>>v v<{ }  ){>>>v   }  \" >>>v{ }  (2{ }  )v $<{ }  /12 v 12 v #^p04<+55$<{01 v   }  \" 01 v >v     :{ }  )>40g::2+1g1+\\2+1p>"
           "#^?3>#^?3>++58*%:40p>#^?2>{4*#^?2>+}  \"|>:56*-{|{ }  )}  \"{ }  *>4^v<>4^ #v<{ }  'v<{>3^    }  \" >3^{ }  2>$58vv{ }  -<v $<|-*94"
           ":<|-+*294:<|-7:  <    v p04+55${<      }  \"   #v *<{  >>>v }  \"^{    <  }  \"      <{ }  D:    ${ 01 v  }  \"#>v{   >v }  \"{  >v }"
           "  # #{>v   }  #> v{ }  '-    >#^?2>4*#^?2>+ :|>1-:|>1 {-:|>1}  '-:| #{ }  '1>1-::2v>3^    >3^   >55+v>56 +v>64*v>\"'\"v>5v  >0v  v"
           "    <    v    >40g3-   v |:p2+ <>::1+2g2+1g\\ 2+2g 2+1 g \\`{ }  9v>v{ }  '#  >62*v >$v    ^_v#:<-1p2\\g 05+2 :-1 p 2+2\\ g2+1 :: p "
           "05 g    2+2:_^#>40g492*+-|{ }  '>0>:58* \\`|  >$22 g.32 g.4 2 g.@{ }  1>40g6%1+2/2*5*5+v$  >74*v     ^+1  <  >#<^#{ }  '># {   >#"
           "}  # >#   >#{ }  )#<      >{ }  'v^<{ }  2{<{ }  (}  \"{ }  -<{ }  1<  $p04<";
int t=0;int z=0;
int64 g[1540];
int d(){int s,w,i,j,h;h=z;for(;t<1099;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<77&&y<20){return g[y*77+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<77&&y<20){g[y*77+x]=v;}}
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0,t1,t2;
    d();
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    gw(4,0,0);
    gw(41,1,0);
    sa(1000000);
    sa(38);
_1:
    sa(sr()+2);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    if(sp()!=0)goto _97;else goto _2;
_2:
    sp();
_3:
    sa(gr(4,0));
    gw(gr(4,0)+2,1,gr(gr(4,0)+2,1)+1);
    if(rd()){if(rd()){goto _96;}else{goto _95;}}else{if(rd()){goto _94;}else{goto _5;}}
_5:
    sa(2);
_6:
    if(rd()){if(rd()){goto _93;}else{goto _92;}}else{if(rd()){goto _91;}else{goto _7;}}
_7:
    sa(sp()+3LL);
_8:
    sa(sp()+sp());
    sa(tm(sp(),40));
    sa(sr());
    gw(4,0,sp());
    if(rd()){if(rd()){goto _90;}else{goto _89;}}else{if(rd()){goto _88;}else{goto _10;}}
_10:
    sa(8);
_11:
    if(rd()){if(rd()){goto _87;}else{goto _86;}}else{if(rd()){goto _85;}else{goto _12;}}
_12:
    sa(sp()+2LL);
_13:
    sa(sp()*4LL);
    if(rd()){if(rd()){goto _84;}else{goto _83;}}else{if(rd()){goto _82;}else{goto _15;}}
_15:
    sa(sp()+2LL);
_16:
    if(sp()!=0)goto _28;else goto _17;
_17:
    gw(4,0,10);
    sp();
_18:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _3;else goto _19;
_19:
    gw(41,2,39);
    sp();
    sa(38);
_20:
    sa(sr());
    sa(sr()+2);
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    if(sp()!=0)goto _27;else goto _21;
_21:
    sp();
    sa(0);
_22:
    sa(sr());
    if(sp()!=0)goto _25;else goto _23;
_23:
    sa(sp()+1LL);
    if(sr()<40)goto _22;else goto _24;
_24:
    printf("%lld", gr(2,2));
    printf("%lld", gr(3,2));
    printf("%lld", gr(4,2));
    sp();
    return 0;
_25:
    sa(sr());
    sa(sr()+1);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()+2LL);
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}
    sa(sp()+2LL);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()+2LL);
    sa(1);
    {int64 v0=sp();t1=gr(sp(),v0);}
    t2=t0<t1?1:0;
    if((t2)!=0)goto _26;else goto _23;
_26:
    sa(sr()+2);
    sa(2);
    {int64 v0=sp();t0=gr(sp(),v0);}
    gw(5,0,t0);
    sa(sr());
    sa(sr()+1);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+2LL);
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr()+2);
    sa(gr(5,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    goto _22;
_27:
    sa(sp()-1LL);
    goto _20;
_28:
    if(sr()!=30)goto _29;else goto _17;
_29:
    if(sr()!=2)goto _44;else goto _30;
_30:
    sp();
    if(rd()){if(rd()){goto _43;}else{goto _42;}}else{if(rd()){goto _41;}else{goto _32;}}
_32:
    sa(8);
_33:
    if(rd()){if(rd()){goto _40;}else{goto _39;}}else{if(rd()){goto _38;}else{goto _34;}}
_34:
    sa(sp()+2LL);
_35:
    sa(sr());
    if(sp()!=0)goto _36;else goto _17;
_36:
    sa(sp()-1LL);
    if(sp()!=0)goto _18;else goto _37;
_37:
    gw(4,0,0);
    goto _18;
_38:
    sa(sp()+1LL);
    goto _35;
_39:
    sa(sp()+0LL);
    goto _35;
_40:
    sa(sp()+3LL);
    goto _35;
_41:
    sa(4);
    goto _33;
_42:
    sa(0);
    goto _33;
_43:
    sa(12);
    goto _33;
_44:
    if(sr()!=17)goto _45;else goto _30;
_45:
    if(sr()!=33)goto _46;else goto _30;
_46:
    if(sr()!=7)goto _80;else goto _47;
_47:
    sp();
    if(rd()){if(rd()){goto _79;}else{goto _78;}}else{if(rd()){goto _77;}else{goto _49;}}
_49:
    sa(8);
_50:
    if(rd()){if(rd()){goto _76;}else{goto _75;}}else{if(rd()){goto _74;}else{goto _51;}}
_51:
    sa(sp()+2LL);
_52:
    sa(sr());
    if(sp()!=0)goto _53;else goto _73;
_53:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _54;else goto _72;
_54:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _55;else goto _71;
_55:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _56;else goto _70;
_56:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _57;else goto _69;
_57:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _58;else goto _68;
_58:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _59;else goto _67;
_59:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _60;else goto _67;
_60:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _61;else goto _64;
_61:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _62;else goto _63;
_62:
    sp();
    goto _18;
_63:
    gw(4,0,gr(4,0)-3);
    goto _62;
_64:
    if(gr(4,0)!=22)goto _65;else goto _66;
_65:
    gw(4,0,12);
    goto _62;
_66:
    gw(4,0,28);
    goto _62;
_67:
    gw(4,0,(10*(td((tm(gr(4,0),6))+1,2)))+5);
    goto _62;
_68:
    gw(4,0,0);
    goto _62;
_69:
    gw(4,0,5);
    goto _62;
_70:
    gw(4,0,39);
    goto _62;
_71:
    gw(4,0,24);
    goto _62;
_72:
    gw(4,0,11);
    goto _62;
_73:
    gw(4,0,10);
    goto _62;
_74:
    sa(sp()+1LL);
    goto _52;
_75:
    sa(sp()+3LL);
    goto _52;
_76:
    sa(sp()+0LL);
    goto _52;
_77:
    sa(4);
    goto _50;
_78:
    sa(12);
    goto _50;
_79:
    sa(0);
    goto _50;
_80:
    if(sr()!=22)goto _81;else goto _47;
_81:
    if(sr()!=36)goto _62;else goto _47;
_82:
    sa(sp()+1LL);
    goto _16;
_83:
    sa(sp()+3LL);
    goto _16;
_84:
    sa(sp()+0LL);
    goto _16;
_85:
    sa(sp()+1LL);
    goto _13;
_86:
    sa(sp()+3LL);
    goto _13;
_87:
    sa(sp()+0LL);
    goto _13;
_88:
    sa(4);
    goto _11;
_89:
    sa(12);
    goto _11;
_90:
    sa(0);
    goto _11;
_91:
    sa(sp()+2LL);
    goto _8;
_92:
    sa(sp()+1LL);
    goto _8;
_93:
    sa(sp()+4LL);
    goto _8;
_94:
    sa(1);
    goto _6;
_95:
    sa(4);
    goto _6;
_96:
    sa(3);
    goto _6;
_97:
    sa(sp()-1LL);
    goto _1;
}