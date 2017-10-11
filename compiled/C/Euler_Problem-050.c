/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1,0,2000);
    gw(2,0,500);
    gw(0,0,1000000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
_1:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
_2:
    if(sp()!=0)goto _31;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    if((t0)!=0)goto _6;else goto _4;
_6:
    if(gr(0,0)>gr(3,0))goto _1;else goto _7;
_7:
    gw(4,0,0);
    gw(3,0,0);
_8:
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=88;
    if((t0)!=0)goto _8;else goto _10;
_10:
    sa(gr(3,0));
    sa(gr(4,0));
    gw(4,0,gr(4,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}

    if(gr(0,0)>gr(3,0))goto _8;else goto _11;
_11:
    sa(0);
    sa(gr(4,0)-1);
    gw(4,0,gr(4,0)-1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(6,0,0);
    gw(7,0,-1);
    gw(8,0,0);
    gw(9,0,1);
_12:
    sa(gr(7,0)+1);
    gw(7,0,gr(7,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0+=gr(8,0);

    if(t0<gr(0,0))goto _30;else goto _13;
_13:
    gw(7,0,gr(7,0)-1);
_14:
    sa(gr(8,0));
    gw(5,0,gr(4,0));
_15:
    sa(sr());
    t0=gr(5,0);
    sa(sp()-gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+1));


    if(sp()!=0)goto _17;else goto _16;
_16:
    printf("%lld ", (int64)(sp()));
    return 0;
_17:
    if((t0)!=0)goto _29;else goto _18;
_18:
    sp();

    if(0>(gr(6,0)+gr(9,0)))goto _19;else goto _23;
_19:
    if(gr(9,0)!=1)goto _20;else goto _22;
_20:
    gw(8,0,gr(8,0)-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1));
    gw(7,0,gr(7,0)-1);
_21:
    gw(9,0,gr(9,0)*-1);
    goto _14;
_22:
    gw(8,0,gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1));
    gw(6,0,gr(6,0)+1);
    goto _21;
_23:
    if(gr(9,0)!=1)goto _28;else goto _24;
_24:
    sa((gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1))+gr(tm(gr(7,0)+1,gr(1,0)),(td(gr(7,0)+1,gr(1,0)))+1));
    sa(((gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1))+gr(tm(gr(7,0)+1,gr(1,0)),(td(gr(7,0)+1,gr(1,0)))+1))>=gr(0,0)?1:0);
_25:
    if(sp()!=0)goto _26;else goto _27;
_26:
    sp();
    goto _19;
_27:
    gw(8,0,sp());
    t0=gr(9,0);
    gw(6,0,gr(9,0)+gr(6,0));
    t0+=gr(7,0);
    gw(7,0,t0);
    goto _14;
_28:
    sa((gr(8,0)+gr(tm(gr(6,0)-1,gr(1,0)),(td(gr(6,0)-1,gr(1,0)))+1))-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1));
    sa(((gr(8,0)+gr(tm(gr(6,0)-1,gr(1,0)),(td(gr(6,0)-1,gr(1,0)))+1))-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1))>=gr(0,0)?1:0);
    goto _25;
_29:
    gw(5,0,gr(5,0)-1);
    goto _15;
_30:
    gw(8,0,t0);
    goto _12;
_31:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(0,0)?1:0);
    goto _2;
}
