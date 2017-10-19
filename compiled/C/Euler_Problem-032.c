/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    sa(31);
    sa(31);
_1:
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr());
    goto _1;
_3:
    gw(1,0,1);
    gw(8,0,9999);
    sp();
    sa(9);
    sa(9);
_4:
    sa(gr(8,0));
    sa(9);
    sa(9);
_5:
    if(sp()!=0)goto _6;else goto _7;
_6:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr());
    goto _5;
_7:
    sp();
    sa(sr());
_8:
    sa(sr()%10);
    sa(sr());

    if(sp()!=0)goto _9;else goto _79;
_9:
    sa(sr());
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}

    if((t0)!=0)goto _79;else goto _10;
_10:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()/10LL);

    sa(sr());

    if(sp()!=0)goto _8;else goto _11;
_11:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
_12:
    sa(sr()%10);
    sa(sr());

    if(sp()!=0)goto _13;else goto _79;
_13:
    sa(sr());
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}

    if((t0)!=0)goto _79;else goto _14;
_14:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()/10LL);

    sa(sr());

    if(sp()!=0)goto _12;else goto _15;
_15:
    sp();
    sa(sp()*sp());

    sa(sr());
_16:
    sa(sr()%10);
    sa(sr());

    if(sp()!=0)goto _17;else goto _78;
_17:
    sa(sr());
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}

    if((t0)!=0)goto _78;else goto _18;
_18:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()/10LL);

    sa(sr());

    if(sp()!=0)goto _16;else goto _19;
_19:
    sp();
    sa(9);
    sa(9);
_20:
    if(sp()!=0)goto _21;else goto _22;
_21:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);

    sa(sr());
    goto _20;
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
_23:
    if((t0)!=0)goto _77;else goto _24;
_24:
    sp();
_25:
    t0=gr(8,0)-1;

    if(gr(8,0)!=1001)goto _76;else goto _26;
_26:
    sa(sp()-1LL);


    if(sr()!=1)goto _27;else goto _28;
_27:
    gw(8,0,9999);
    sa(sr());
    goto _4;
_28:
    gw(8,0,999);
    sp();
    sa(99);
    sa(99);
_29:
    sa(gr(8,0));
    sa(9);
    sa(9);
_30:
    if(sp()!=0)goto _31;else goto _32;
_31:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr());
    goto _30;
_32:
    sp();
    sa(sr());
_33:
    sa(sr()%10);
    sa(sr());

    if(sp()!=0)goto _34;else goto _75;
_34:
    sa(sr());
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}

    if((t0)!=0)goto _75;else goto _35;
_35:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()/10LL);

    sa(sr());

    if(sp()!=0)goto _33;else goto _36;
_36:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
_37:
    sa(sr()%10);
    sa(sr());

    if(sp()!=0)goto _38;else goto _75;
_38:
    sa(sr());
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}

    if((t0)!=0)goto _75;else goto _39;
_39:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()/10LL);

    sa(sr());

    if(sp()!=0)goto _37;else goto _40;
_40:
    sp();
    sa(sp()*sp());

    sa(sr());
_41:
    sa(sr()%10);
    sa(sr());

    if(sp()!=0)goto _42;else goto _74;
_42:
    sa(sr());
    sa(1);
    {int64 v0=sp();t0=gr(sp(),v0);}

    if((t0)!=0)goto _74;else goto _43;
_43:
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()/10LL);

    sa(sr());

    if(sp()!=0)goto _41;else goto _44;
_44:
    sp();
    sa(9);
    sa(9);
_45:
    if(sp()!=0)goto _46;else goto _47;
_46:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);

    sa(sr());
    goto _45;
_47:
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
_48:
    if((t0)!=0)goto _73;else goto _49;
_49:
    sp();
_50:
    t0=gr(8,0)-1;

    if(gr(8,0)!=101)goto _72;else goto _51;
_51:
    sa(sp()-1LL);


    if(sr()!=10)goto _70;else goto _52;
_52:
    gw(8,0,32);
    sp();
_53:
    gw(7,0,gr(8,0)-1);
_54:
    t0=gr(gr(8,0),2);

    if((gr(gr(8,0),2))==0)goto _56;else goto _55;
_55:
    t0-=gr(gr(7,0),2);

    if((t0)!=0)goto _56;else goto _69;
_56:
    t0=gr(7,0);

    if(gr(7,0)!=1)goto _68;else goto _57;
_57:
    t0=gr(8,0);

    if(gr(8,0)!=2)goto _67;else goto _58;
_58:
    sa(0);
    sa(31);
    sa(31);
_59:
    if(sp()!=0)goto _60;else goto _63;
_60:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());

    if(sp()!=0)goto _61;else goto _62;
_61:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);

    sa(sr());
    goto _59;
_62:
    sp();
    sa(sp()-1LL);

    sa(sr());
    goto _59;
_63:
    sp();
_64:
    sa(sp()+sp());

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _66;else goto _65;
_65:
    sa(sp()+sp());

    printf("%lld ", (int64)(sp()));
    return 0;
_66:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _64;
_67:
    t0--;
    gw(8,0,t0);
    goto _53;
_68:
    t0--;
    gw(7,0,t0);
    goto _54;
_69:
    gw(gr(7,0),2,0);
    goto _56;
_70:
    gw(8,0,999);
_71:
    sa(sr());
    goto _29;
_72:
    gw(8,0,t0);
    goto _71;
_73:
    sa(gr(1,0));
    gw(1,0,gr(1,0)+1);
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _50;
_74:
    sp();
    t0=0;
    sp();
    sp();
    sa(0);
    goto _48;
_75:
    sp();
    goto _74;
_76:
    gw(8,0,t0);
    sa(sr());
    goto _4;
_77:
    sa(gr(1,0));
    gw(1,0,gr(1,0)+1);
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _25;
_78:
    sp();
    t0=0;
    sp();
    sp();
    sa(0);
    goto _23;
_79:
    sp();
    goto _78;
}
