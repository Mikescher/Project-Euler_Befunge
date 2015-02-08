/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } !g{$}  ){ } !^{#}  ?{ } #3vp2\\0:<{ } !\\>\" \">  1-:|{ } !cv{ } !R<  *\"ce\"<    v   p01 1$<{ }  'vp1\\0:<{ }  ){>v    }  \"{     "
           " >$v{ }  ){>v    }  \"}  \"      >$v   v\\g1:< >10g:1+10p2pv{ }  <>9\"ec\"*>80p:80g55+>  1-:|  >:55+%:|>:1g!|>1\\1p55+/:!| >\\:>:55+%:|"
           ">:1g!|>1\\1p55+/:!| >*:>:55+%:|>:1g!|>1\\1p55+/:!| >55+> 1-:|>|{ }  +>80g1-:5558***-#^_$1-:1-|{ }  <>$:{^  {    $#}  \"{ }  *<    }"
           "  \"^  {    $#}  \"{ }  *<v{+}  ($< >${ }  *^v{ }  5$<    v{ }  ,<{ }  4{>     }  \"{ }  2{>     }  \"{ }  1$>     >${ }  ($00>9-!{ "
           "}  '^{ }  -1{ }  H|{ } !=<0{ }  /<*9*3+1*94<{ }  8vp1\\0:<{ }  ){>v    }  \"{      >$v{ }  ){>v    }  \"}  \"      >$v   v\\g1:< >10g"
           ":1+10p2pv{ }  6>\"c\"49*1+3*9*>80p:80g55+>  1-:|  >:55+%:|>:1g!|>1\\1p55+/:!| >\\:>:55+%:|>:1g!|>1\\1p55+/:!| >*:>:55+%:|>:1g!|>1\\1p5"
           "5+/:!| >55+> 1-:|>|{ }  +>80g1-:\"d\"-#^_$1-:55+-|{ }  >>$:{^  {    $#}  \"{ }  *<    }  \"^  {    $#}  \"{ }  *<v{+}  ($< >${ }  *^{"
           " }  5${ }  H>     >#v{ }  5>#    >#   #<{ }  0$>     >${ }  ($00>9-!{ }  '^{ }  Cv{ }  O<{ }  3v\\<{ }  +^{ }  r<    v{ }  T-1<{ "
           "}  'v< |:g2:<{ } !(v{ }  *># $#    >#     v#     -1<{ }  2^$<{ } ! >\" \">80p80g1->70p80g2g:!|>70g2g -|      > 70g:1-#^_$80g:2-#^_"
           "$0>\" \">    1-:| >+#<\\:#<_+.@{ } !&>^{ }  '>070g2p^{ }  B>$^{ }  x";
int t=0;int z=0;
int64 g[3486];
int d(){int s,w,i,j,h;h=z;for(;t<1217;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<166&&y<21){return g[y*166+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<166&&y<21){g[y*166+x]=v;}}
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
    goto _9;
_0:
    if(sp()!=0)goto _65; else goto _10;
_1:
    if(sp()!=0)goto _64; else goto _12;
_2:
    if(sp()!=0)goto _55; else goto _16;
_3:
    if(sp()!=0)goto _17; else goto _54;
_4:
    if(sp()!=0)goto _21; else goto _53;
_5:
    if(sp()!=0)goto _52; else goto _23;
_6:
    if(sp()!=0)goto _43; else goto _27;
_7:
    if(sp()!=0)goto _28; else goto _42;
_8:
    if(sp()!=0)goto _75; else goto _35;
_9:
    sa(31);
    sa(31);
    goto _0;
_10:
    gw(1,0,1);
    gw(8,0,9999);
    sp();
    sa(9);
    sa(9);
    goto _11;
_11:
    sa(gr(8,0));
    sa(9);
    sa(9);
    goto _1;
_12:
    sp();
    sa(sr());
    goto _66;
_13:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _88;
_14:
    sp();
    sa(sp()*sp());
    sa(sr());
    goto _91;
_15:
    sp();
    sa(9);
    sa(9);
    goto _2;
_16:
    sp();
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(9);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _3;
_17:
    sa(gr(1,0));
    gw(1,0,(gr(1,0))+(1));
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _67;
_18:
    gw(8,0,sp());
    sa(sr());
    goto _11;
_19:
    gw(8,0,9999);
    sa(sr());
    goto _11;
_20:
    sp();
    sa(1);
    goto _4;
_21:
    gw(8,0,999);
    sa(99);
    sa(99);
    goto _22;
_22:
    sa(gr(8,0));
    sa(9);
    sa(9);
    goto _5;
_23:
    sp();
    sa(sr());
    goto _69;
_24:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _80;
_25:
    sp();
    sa(sp()*sp());
    sa(sr());
    goto _83;
_26:
    sp();
    sa(9);
    sa(9);
    goto _6;
_27:
    sp();
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(9);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _7;
_28:
    sa(gr(1,0));
    gw(1,0,(gr(1,0))+(1));
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _70;
_29:
    sa(0);
    goto _4;
_30:
    gw(8,0,32);
    gw(7,0,(gr(8,0))-(1));
    sp();
    goto _72;
_31:
    gw(gr(7,0),2,0);
    goto _73;
_32:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    gw(7,0,sp());
    goto _72;
_33:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    gw(8,0,sp());
    gw(7,0,(gr(8,0))-(1));
    goto _72;
_34:
    sp();
    sa(0);
    sa(31);
    sa(31);
    goto _8;
_35:
    sp();
    goto _76;
_36:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _76;
_37:
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    return 0;
_38:
    sp();
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _8;
_39:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _8;
_40:
    sp();
    goto _73;
_41:
    sa(999);
    goto _29;
_42:
    sp();
    goto _70;
_43:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _6;
_44:
    sp();
    goto _45;
_45:
    sp();
    sp();
    sa(0);
    sa(0);
    goto _7;
_46:
    sp();
    goto _45;
_47:
    sp();
    goto _48;
_48:
    sp();
    goto _45;
_49:
    sp();
    goto _48;
_50:
    sp();
    goto _48;
_51:
    sp();
    goto _48;
_52:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _5;
_53:
    gw(8,0,sp());
    sa(sr());
    goto _22;
_54:
    sp();
    goto _67;
_55:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _2;
_56:
    sp();
    goto _57;
_57:
    sp();
    sp();
    sa(0);
    sa(0);
    goto _3;
_58:
    sp();
    goto _57;
_59:
    sp();
    goto _60;
_60:
    sp();
    goto _57;
_61:
    sp();
    goto _60;
_62:
    sp();
    goto _60;
_63:
    sp();
    goto _60;
_64:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _1;
_65:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _0;
_66:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    if(sp()!=0)goto _86; else goto _63;
_67:
    sa((gr(8,0))-(1));
    sa(((gr(8,0))-(1))-(1000));
    if(sp()!=0)goto _18; else goto _68;
_68:
    sp();
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _19; else goto _20;
_69:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    if(sp()!=0)goto _78; else goto _51;
_70:
    sa((gr(8,0))-(1));
    sa(((gr(8,0))-(1))-(100));
    if(sp()!=0)goto _29; else goto _71;
_71:
    sp();
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _41; else goto _30;
_72:
    sa(gr(gr(8,0),2));
    sa(((gr(gr(8,0),2))!=0)?0:1);
    if(sp()!=0)goto _40; else goto _77;
_73:
    sa(gr(7,0));
    sa((gr(7,0))-(1));
    if(sp()!=0)goto _32; else goto _74;
_74:
    sp();
    sa(gr(8,0));
    sa((gr(8,0))-(2));
    if(sp()!=0)goto _33; else goto _34;
_75:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    if(sp()!=0)goto _39; else goto _38;
_76:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _36; else goto _37;
_77:
    sa(gr(gr(7,0),2));
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _73; else goto _31;
_78:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _79; else goto _50;
_79:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _24; else goto _69;
_80:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    if(sp()!=0)goto _81; else goto _49;
_81:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _82; else goto _47;
_82:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _25; else goto _80;
_83:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    if(sp()!=0)goto _84; else goto _46;
_84:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _85; else goto _44;
_85:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _26; else goto _83;
_86:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _87; else goto _62;
_87:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _13; else goto _66;
_88:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    if(sp()!=0)goto _89; else goto _61;
_89:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _90; else goto _59;
_90:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _14; else goto _88;
_91:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    if(sp()!=0)goto _92; else goto _58;
_92:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _93; else goto _56;
_93:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15; else goto _91;
}