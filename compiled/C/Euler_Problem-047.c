/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ }  *// Project Euler - Problem 47{ } ,4{#}6/9{ } (H>\"d\"4  *:10p5\"d\"*:20p*00p230p\" \":03p13pv{ }  7>040p030p>>30g1+:30p:10g%\\10"
           "g/3+g\"X\"-#v_30g40g:1+40p:10g%\\10g/3+p00g30g`#v_v{ } \"gv{ }  F<{ }  6_^#`g03g00<^{ }  ;<{ }  B< 0{ } \"g>\"X\"30g:10g%\\10g/3+p30g>30"
           "g+:00g\\`{ }  '#v_$>30g1+:30p:10g%\\10g/3+g\" \"-|v{ }  Np+3/g01\\%g01:-1g04<{ } \"~^p+3/g01\\%g01:\\\" \":<  ^{ }  :<>1>:0:40p50p>:40g:10"
           "g%\\10g/3+g%{ }  '#v_40g:10g%\\10gv{ } #_+{ }  )|!`\\g+3/g01\\%g01:p04:+1g04:<p05+1g05/g+3/<{ } #_4{ }  )>$50g4-#v_080p:::4+60p70p3-"
           ">:70g-  #v_80g1+:80p4-#v_3-.$@{ } #P^{ }  1<{ }  2|-g06:+1{<{ }  .}  \"{ } #Z^{ }  1$<{ }  (>:0:40p50p>:40g:10g%\\10g/3+g%{ }  '#v"
           "_40g:10g%\\10gv{ } #^^{ }  )<|!`\\g+3/g01\\%g01:p04:+1g04:<p05+1g05/g+3/<{ } #i>$50g4-#v_80g1+80p v{ } #~|   -4g08{ }  +<{ } #~>3-."
           "$@   >080p:70g\\`|{ } #l^{ }  E<{ } \"[";
int t=0;int z=0;
int64 g[207200];
int d(){int s,w,i,j,h;h=z;for(;t<805;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<400&&y<518){return g[y*400+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<400&&y<518){g[y*400+x]=v;}}
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
    goto _4;
_0:
    if(sp()!=0)goto _6; else goto _7;
_1:
    if(sp()!=0)goto _23; else goto _8;
_2:
    if(sp()!=0)goto _10; else goto _24;
_3:
    if(sp()!=0)goto _25; else goto _12;
_4:
    gw(1,0,400);
    gw(2,0,500);
    gw(0,0,200000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
    goto _5;
_5:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3),88);
    sa((gr(3,0))+(gr(3,0)));
    sa((gr(0,0))>((gr(3,0))+(gr(3,0)))?1:0);
    goto _0;
_6:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(gr(3,0));
    sa(sp()+sp());
    sa(sr());
    sa(gr(0,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _0;
_7:
    sp();
    goto _8;
_8:
    sa((gr(3,0))+(1));
    gw(3,0,(gr(3,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(32);
    {int64 v0=sp();sa(sp()-v0);}
    goto _1;
_9:
    gw(4,0,0);
    gw(3,0,0);
    goto _10;
_10:
    sa((gr(3,0))+(1));
    gw(3,0,(gr(3,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(88);
    {int64 v0=sp();sa(sp()-v0);}
    goto _2;
_11:
    gw(tm((gr(4,0))-(1),gr(1,0)),(td((gr(4,0))-(1),gr(1,0)))+(3),0);
    gw(4,0,0);
    gw(5,0,0);
    sa(1);
    sa(1);
    sa(tm(1,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3))));
    goto _3;
_12:
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    gw(5,0,(gr(5,0))+(1));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    goto _25;
_13:
    sa(sr());
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _3;
_14:
    gw(4,0,0);
    gw(5,0,0);
    goto _15;
_15:
    sa(4);
    sa(sp()+sp());
    sa(sr());
    sa(sr());
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _3;
_16:
    gw(8,0,0);
    sa(sr());
    sa(sr());
    sa(sr());
    sa(4);
    sa(sp()+sp());
    gw(6,0,sp());
    gw(7,0,sp());
    sa(3);
    {int64 v0=sp();sa(sp()-v0);}
    goto _27;
_17:
    gw(4,0,0);
    gw(5,0,0);
    sp();
    goto _15;
_18:
    sa(3);
    {int64 v0=sp();sa(sp()-v0);}
    printf("%lld", (int64)(sp()));
    sp();
    return 0;
_19:
    gw(4,0,0);
    gw(5,0,0);
    sa(sr());
    goto _28;
_20:
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    gw(5,0,(gr(5,0))+(1));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    goto _29;
_21:
    gw(8,0,(gr(8,0))+(1));
    goto _32;
_22:
    sa(3);
    {int64 v0=sp();sa(sp()-v0);}
    printf("%lld", (int64)(sp()));
    sp();
    return 0;
_23:
    sa((gr(0,0))>(gr(3,0))?1:0);
    if(sp()!=0)goto _5; else goto _9;
_24:
    sa(gr(3,0));
    sa(gr(4,0));
    gw(4,0,(gr(4,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa((gr(0,0))>(gr(3,0))?1:0);
    if(sp()!=0)goto _10; else goto _11;
_25:
    sa(sr());
    sa((gr(4,0))+(1));
    gw(4,0,(gr(4,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _13; else goto _26;
_26:
    sp();
    sa((gr(5,0))-(4));
    if(sp()!=0)goto _14; else goto _16;
_27:
    sa(sr());
    sa(gr(7,0));
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _19; else goto _34;
_28:
    sa(sr());
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    if(sp()!=0)goto _29; else goto _20;
_29:
    sa(sr());
    sa((gr(4,0))+(1));
    gw(4,0,(gr(4,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _28; else goto _30;
_30:
    sp();
    sa((gr(5,0))-(4));
    if(sp()!=0)goto _31; else goto _21;
_31:
    gw(8,0,0);
    sa(sr());
    sa(gr(7,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _32; else goto _17;
_32:
    sa((gr(8,0))-(4));
    if(sp()!=0)goto _33; else goto _22;
_33:
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(gr(6,0));
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _27; else goto _17;
_34:
    sa((gr(8,0))+(1));
    gw(8,0,(gr(8,0))+(1));
    sa(4);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _33; else goto _18;
}