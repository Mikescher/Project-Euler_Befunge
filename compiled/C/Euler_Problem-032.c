/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    sa(31LL);
_1:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _1;else goto _3;
_3:
    gw(1LL,0LL,1LL);
    gw(8LL,0LL,9999LL);
    sp();
    sa(9LL);
    sa(9LL);
_4:
    sa(gr(8LL,0LL));
    sa(9LL);
_5:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _5;else goto _7;
_7:
    sp();
    sa(sr());
_8:
    sa(tm(sr(),10LL));
    sa(sr());
    if(sp()!=0)goto _9;else goto _88;
_9:
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _10;else goto _87;
_10:
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10L));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _11;else goto _8;
_11:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
_12:
    sa(tm(sr(),10LL));
    sa(sr());
    if(sp()!=0)goto _13;else goto _86;
_13:
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _14;else goto _84;
_14:
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10L));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15;else goto _12;
_15:
    sp();
    sa(sp()*sp());
    sa(sr());
_16:
    sa(tm(sr(),10LL));
    sa(sr());
    if(sp()!=0)goto _17;else goto _83;
_17:
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _18;else goto _81;
_18:
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10L));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _19;else goto _16;
_19:
    sp();
    sa(9LL);
_20:
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _20;else goto _22;
_22:
    sp();
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()-9LL);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _80;else goto _23;
_23:
    sp();
_24:
    sa(gr(8LL,0LL)-1LL);
    if(gr(8LL,0LL)!=1001LL)goto _79;else goto _25;
_25:
    sp();
    sa(sp()-1LL);
    if(sr()!=1LL)goto _78;else goto _26;
_26:
    sp();
    gw(8LL,0LL,999LL);
    sa(99LL);
    sa(99LL);
_27:
    sa(gr(8LL,0LL));
    sa(9LL);
_28:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _28;else goto _30;
_30:
    sp();
    sa(sr());
_31:
    sa(tm(sr(),10LL));
    sa(sr());
    if(sp()!=0)goto _32;else goto _77;
_32:
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _33;else goto _76;
_33:
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10L));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _34;else goto _31;
_34:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
_35:
    sa(tm(sr(),10LL));
    sa(sr());
    if(sp()!=0)goto _36;else goto _75;
_36:
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _37;else goto _73;
_37:
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10L));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _38;else goto _35;
_38:
    sp();
    sa(sp()*sp());
    sa(sr());
_39:
    sa(tm(sr(),10LL));
    sa(sr());
    if(sp()!=0)goto _40;else goto _72;
_40:
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _41;else goto _70;
_41:
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10L));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _42;else goto _39;
_42:
    sp();
    sa(9LL);
_43:
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _43;else goto _45;
_45:
    sp();
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()-9LL);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _69;else goto _46;
_46:
    sp();
_47:
    sa(gr(8LL,0LL)-1LL);
    if(gr(8LL,0LL)!=101LL)goto _50;else goto _48;
_48:
    sp();
    sa(sp()-1LL);
    if(sr()!=10LL)goto _49;else goto _51;
_49:
    sa(999LL);
_50:
    gw(8LL,0LL,sp());
    sa(sr());
    goto _27;
_51:
    gw(8LL,0LL,32LL);
    gw(7LL,0LL,gr(8LL,0LL)-1LL);
    sp();
_52:
    sa(gr(gr(8LL,0LL),2LL));
    if((gr(gr(8L,0L),2L))==0)goto _68;else goto _53;
_53:
    sa(sp()-gr(gr(7LL,0LL),2LL));
    if(sp()!=0)goto _54;else goto _67;
_54:
    sa(gr(7LL,0LL));
    if(gr(7LL,0LL)!=1LL)goto _66;else goto _55;
_55:
    sp();
    sa(gr(8LL,0LL));
    if(gr(8LL,0LL)!=2LL)goto _65;else goto _56;
_56:
    sp();
    sa(0LL);
    sa(31LL);
_57:
    sa(sr());
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    if(sp()!=0)goto _58;else goto _64;
_58:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    sa(sr());
_59:
    if(sp()!=0)goto _57;else goto _60;
_60:
    sp();
_61:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _63;else goto _62;
_62:
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    return 0;
_63:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _61;
_64:
    sp();
    sa(sp()-1LL);
    sa(sr());
    goto _59;
_65:
    sa(sp()-1LL);
    gw(8LL,0LL,sp());
    gw(7LL,0LL,gr(8LL,0LL)-1LL);
    goto _52;
_66:
    sa(sp()-1LL);
    gw(7LL,0LL,sp());
    goto _52;
_67:
    gw(gr(7LL,0LL),2LL,0LL);
    goto _54;
_68:
    sp();
    goto _54;
_69:
    sa(gr(1LL,0LL));
    gw(1LL,0LL,gr(1LL,0LL)+1LL);
    sa(2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _47;
_70:
    sp();
_71:
    sp();
    sp();
    sa(0LL);
    goto _46;
_72:
    sp();
    goto _71;
_73:
    sp();
_74:
    sp();
    goto _71;
_75:
    sp();
    goto _74;
_76:
    sp();
    goto _74;
_77:
    sp();
    goto _74;
_78:
    gw(8LL,0LL,9999LL);
    sa(sr());
    goto _4;
_79:
    gw(8LL,0LL,sp());
    sa(sr());
    goto _4;
_80:
    sa(gr(1LL,0LL));
    gw(1LL,0LL,gr(1LL,0LL)+1LL);
    sa(2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _24;
_81:
    sp();
_82:
    sp();
    sp();
    sa(0LL);
    goto _23;
_83:
    sp();
    goto _82;
_84:
    sp();
_85:
    sp();
    goto _82;
_86:
    sp();
    goto _85;
_87:
    sp();
    goto _85;
_88:
    sp();
    goto _85;
}