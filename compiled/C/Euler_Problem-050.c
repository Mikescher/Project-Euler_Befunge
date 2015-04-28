/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ }  *// Project Euler - Problem 50{ } 4\\{#}~~~{#}/l?{ } 5%>\"d\"45**:10p5\"d\"*:20p*00p230p\" \":03p13pv{ }  7>040p030p>>30g1+:30p:1"
           "0g%\\10g/1+g\"X\"-#v_30g40g:1+40p:10g%\\10g/1+p00g30g`#v_v{ } 3Xv{ }  F<{ }  6_^#`g03g00<^{ }  ;<{ }  B< 0{ } 3X>\"X\"30g:10g%\\10g/1+p"
           "30g>30g+:00g\\`{ }  '#v_$>30g1+:30p:10g%\\10g/1+g\" \"-|v{ }  4p091 p080 p07-10 p060 p+1/g01\\%g01:p04:-1g04<{ } 3[>90g\"= \",,.@{ }  ("
           "^p+1/g01\\%g01:\\\" \":<  ^{ }  :<v{ }  >p08<{ } 4a>70g1+:70p:10g%\\10g/1+g80g+:00g\\`#^_70g1-70p$v{ } 3lvp05g04g08{ }  k<{ }  ?<<{ } "
           "3l>:50g\\50g:10g%\\10g/1+g-#v_$. @{ }  .>80g60g1-:10g%\\10g/1+g+70g:10g%\\10g/1+g-v^p09*-10g09<p07-1g07p08-g+1/g01\\ %g01:g07g08<{ } "
           "3a^{ }  .p05-1g05<_>$060g90g+`#v_90g1-|{ }  G>:00g\\`!#v_8 0p90g:60g+60p70g+70p^>90g1-     |{ } 4.>80g60g:10g%\\10g/1+g-70g1+:10g%"
           "\\10g/1+g+^{ }  ($  ^p06+1g06p08-g+1/g01\\% g01:g06g08<{ } 4'>{ }  W>{ }  8^{ } 3l";
int t=0;int z=0;
int64 g[1024000];
int d(){int s,w,i,j,h;h=z;for(;t<848;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<2000&&y<512){return g[y*2000+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<2000&&y<512){g[y*2000+x]=v;}}
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
    goto _0;
_0:
    gw(1,0,2000);
    gw(2,0,500);
    gw(0,0,1000000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
_1:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(1),88);
    sa((gr(3,0))+(gr(3,0)));
    sa((gr(0,0))>((gr(3,0))+(gr(3,0)))?1:0);
_2:
    if(sp()!=0)goto _31; else goto _3;
_3:
    sp();
_4:
    sa((gr(3,0))+(1));
    gw(3,0,(gr(3,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(32);
    {int64 v0=sp();sa(sp()-v0);}
_5:
    if(sp()!=0)goto _6; else goto _4;
_6:
    sa((gr(0,0))>(gr(3,0))?1:0);
    if(sp()!=0)goto _1; else goto _7;
_7:
    gw(4,0,0);
    gw(3,0,0);
_8:
    sa((gr(3,0))+(1));
    gw(3,0,(gr(3,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(88);
    {int64 v0=sp();sa(sp()-v0);}
_9:
    if(sp()!=0)goto _8; else goto _10;
_10:
    sa(gr(3,0));
    sa(gr(4,0));
    gw(4,0,(gr(4,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa((gr(0,0))>(gr(3,0))?1:0);
    if(sp()!=0)goto _8; else goto _11;
_11:
    sa(0);
    sa((gr(4,0))-(1));
    gw(4,0,(gr(4,0))-(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(6,0,0);
    gw(7,0,-1);
    gw(8,0,0);
    gw(9,0,1);
_12:
    sa((gr(7,0))+(1));
    gw(7,0,(gr(7,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(gr(8,0));
    sa(sp()+sp());
    sa(sr());
    sa(gr(0,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _13; else goto _14;
_13:
    gw(8,0,sp());
    goto _12;
_14:
    gw(7,0,(gr(7,0))-(1));
    sp();
_15:
    sa(gr(8,0));
    gw(5,0,gr(4,0));
_16:
    sa(sr());
    sa(gr(5,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+(1)));
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _18; else goto _17;
_17:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_18:
    if(sp()!=0)goto _30; else goto _19;
_19:
    sp();
    sa((0)>((gr(6,0))+(gr(9,0)))?1:0);
    if(sp()!=0)goto _24; else goto _20;
_20:
    sa((gr(9,0))-(1));
    if(sp()!=0)goto _29; else goto _21;
_21:
    sa(((gr(8,0))-(gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+(1))))+(gr(tm((gr(7,0))+(1),gr(1,0)),(td((gr(7,0))+(1),gr(1,0)))+(1))));
    sa((((gr(0,0))>(((gr(8,0))-(gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+(1))))+(gr(tm((gr(7,0))+(1),gr(1,0)),(td((gr(7,0))+(1),gr(1,0)))+(1))))?1:0)!=0)?0:1);
_22:
    if(sp()!=0)goto _23; else goto _28;
_23:
    sp();
_24:
    sa((gr(9,0))-(1));
    if(sp()!=0)goto _25; else goto _27;
_25:
    gw(8,0,(gr(8,0))-(gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+(1))));
    gw(7,0,(gr(7,0))-(1));
_26:
    gw(9,0,(gr(9,0))*(-1));
    goto _15;
_27:
    gw(8,0,(gr(8,0))-(gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+(1))));
    gw(6,0,(gr(6,0))+(1));
    goto _26;
_28:
    gw(8,0,sp());
    sa(gr(9,0));
    gw(6,0,(gr(9,0))+(gr(6,0)));
    sa(gr(7,0));
    sa(sp()+sp());
    gw(7,0,sp());
    goto _15;
_29:
    sa(((gr(8,0))+(gr(tm((gr(6,0))-(1),gr(1,0)),(td((gr(6,0))-(1),gr(1,0)))+(1))))-(gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+(1))));
    sa((((gr(0,0))>(((gr(8,0))+(gr(tm((gr(6,0))-(1),gr(1,0)),(td((gr(6,0))-(1),gr(1,0)))+(1))))-(gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+(1))))?1:0)!=0)?0:1);
    goto _22;
_30:
    gw(5,0,(gr(5,0))-(1));
    goto _16;
_31:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(gr(3,0));
    sa(sp()+sp());
    sa(sr());
    sa(gr(0,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _2;
}