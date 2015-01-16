/* compiled with BefunCompile v1.0.3 (c) 2015 */
#include <time.h>
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
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    d();
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _16;
_0:
    if(sp()!=0)goto _18; else goto _19;
_1:
    if(sp()!=0)goto _21; else goto _20;
_2:
    if(sp()!=0)goto _17; else goto _22;
_3:
    if(sp()!=0)goto _23; else goto _24;
_4:
    if(sp()!=0)goto _23; else goto _25;
_5:
    if(sp()!=0)goto _27; else goto _26;
_6:
    if(sp()!=0)goto _28; else goto _29;
_7:
    if(sp()!=0)goto _30; else goto _32;
_8:
    if(sp()!=0)goto _38; else goto _34;
_9:
    if(sp()!=0)goto _41; else goto _40;
_10:
    if(sp()!=0)goto _39; else goto _42;
_11:
    if(sp()!=0)goto _46; else goto _43;
_12:
    if(sp()!=0)goto _44; else goto _36;
_13:
    if(sp()!=0)goto _35; else goto _45;
_14:
    if(sp()!=0)goto _33; else goto _36;
_15:
    if(sp()!=0)goto _35; else goto _37;
_16:
    gw(1,0,400);
    gw(2,0,500);
    gw(0,0,200000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
    goto _17;
_17:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3),88);
    sa((gr(3,0))+(gr(3,0)));
    sa((gr(0,0))>((gr(3,0))+(gr(3,0)))?1:0);
    goto _0;
_18:
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
_19:
    sp();
    goto _20;
_20:
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
_21:
    sa((gr(0,0))>(gr(3,0))?1:0);
    goto _2;
_22:
    gw(4,0,0);
    gw(3,0,0);
    goto _23;
_23:
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
    goto _3;
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
    goto _4;
_25:
    gw(tm((gr(4,0))-(1),gr(1,0)),(td((gr(4,0))-(1),gr(1,0)))+(3),0);
    gw(4,0,0);
    gw(5,0,0);
    sa(1);
    sa(1);
    sa(tm(1,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3))));
    goto _5;
_26:
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    gw(5,0,(gr(5,0))+(1));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    goto _27;
_27:
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
    goto _6;
_28:
    sa(sr());
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _5;
_29:
    sp();
    sa((gr(5,0))-(4));
    goto _7;
_30:
    gw(4,0,0);
    gw(5,0,0);
    goto _31;
_31:
    sa(4);
    sa(sp()+sp());
    sa(sr());
    sa(sr());
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _5;
_32:
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
    goto _33;
_33:
    sa(sr());
    sa(gr(7,0));
    {int64 v0=sp();sa(sp()-v0);}
    goto _8;
_34:
    sa((gr(8,0))+(1));
    gw(8,0,(gr(8,0))+(1));
    sa(4);
    {int64 v0=sp();sa(sp()-v0);}
    goto _15;
_35:
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(gr(6,0));
    {int64 v0=sp();sa(sp()-v0);}
    goto _14;
_36:
    gw(4,0,0);
    gw(5,0,0);
    sp();
    goto _31;
_37:
    sa(3);
    {int64 v0=sp();sa(sp()-v0);}
    printf("%lld", (int64)(sp()));
    sp();
    goto __;
_38:
    gw(4,0,0);
    gw(5,0,0);
    sa(sr());
    goto _39;
_39:
    sa(sr());
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _9;
_40:
    sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
    gw(5,0,(gr(5,0))+(1));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    goto _41;
_41:
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
    goto _10;
_42:
    sp();
    sa((gr(5,0))-(4));
    goto _11;
_43:
    gw(8,0,(gr(8,0))+(1));
    goto _44;
_44:
    sa((gr(8,0))-(4));
    goto _13;
_45:
    sa(3);
    {int64 v0=sp();sa(sp()-v0);}
    printf("%lld", (int64)(sp()));
    sp();
    goto __;
_46:
    gw(8,0,0);
    sa(sr());
    sa(gr(7,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _12;
__:
    return 0;
}