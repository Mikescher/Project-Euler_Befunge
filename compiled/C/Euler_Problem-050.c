/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    gw(1LL,0LL,2000LL);
    gw(2LL,0LL,500LL);
    gw(0LL,0LL,1000000LL);
    gw(3LL,0LL,2LL);
    gw(0LL,3LL,32LL);
    gw(1LL,3LL,32LL);
_1:
    gw(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+1LL,88LL);
    sa(gr(3LL,0LL)+gr(3LL,0LL));
    sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
_2:
    if(sp()!=0)goto _31;else goto _3;
_3:
    sp();
_4:
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-32LL);
    if(sp()!=0)goto _6;else goto _4;
_6:
    if(gr(0L,0L)>gr(3L,0L))goto _1;else goto _7;
_7:
    gw(4LL,0LL,0LL);
    gw(3LL,0LL,0LL);
_8:
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-88LL);
    if(sp()!=0)goto _8;else goto _10;
_10:
    sa(gr(3LL,0LL));
    sa(gr(4LL,0LL));
    gw(4LL,0LL,gr(4LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    if(gr(0L,0L)>gr(3L,0L))goto _8;else goto _11;
_11:
    sa(0LL);
    sa(gr(4LL,0LL)-1LL);
    gw(4LL,0LL,gr(4LL,0LL)-1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(6LL,0LL,0LL);
    gw(7LL,0LL,-1LL);
    gw(8LL,0LL,0LL);
    gw(9LL,0LL,1LL);
_12:
    sa(gr(7LL,0LL)+1LL);
    gw(7LL,0LL,gr(7LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()+gr(8LL,0LL));
    if(sr()<gr(0L,0L))goto _13;else goto _14;
_13:
    gw(8LL,0LL,sp());
    goto _12;
_14:
    gw(7LL,0LL,gr(7LL,0LL)-1LL);
    sp();
_15:
    sa(gr(8LL,0LL));
    gw(5LL,0LL,gr(4LL,0LL));
_16:
    sa(sr());
    sa(gr(5LL,0LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-gr(tm(gr(5LL,0LL),gr(1LL,0LL)),(td(gr(5LL,0LL),gr(1LL,0LL)))+1LL));
    if(sp()!=0)goto _18;else goto _17;
_17:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_18:
    if(sp()!=0)goto _30;else goto _19;
_19:
    sp();
    if(0L>(gr(6L,0L)+gr(9L,0L)))goto _20;else goto _24;
_20:
    if(gr(9LL,0LL)!=1LL)goto _21;else goto _23;
_21:
    gw(8LL,0LL,gr(8LL,0LL)-gr(tm(gr(7LL,0LL),gr(1LL,0LL)),(td(gr(7LL,0LL),gr(1LL,0LL)))+1LL));
    gw(7LL,0LL,gr(7LL,0LL)-1LL);
_22:
    gw(9LL,0LL,gr(9LL,0LL)*-1LL);
    goto _15;
_23:
    gw(8LL,0LL,gr(8LL,0LL)-gr(tm(gr(6LL,0LL),gr(1LL,0LL)),(td(gr(6LL,0LL),gr(1LL,0LL)))+1LL));
    gw(6LL,0LL,gr(6LL,0LL)+1LL);
    goto _22;
_24:
    if(gr(9LL,0LL)!=1LL)goto _29;else goto _25;
_25:
    sa((gr(8LL,0LL)-gr(tm(gr(6LL,0LL),gr(1LL,0LL)),(td(gr(6LL,0LL),gr(1LL,0LL)))+1LL))+gr(tm(gr(7LL,0LL)+1LL,gr(1LL,0LL)),(td(gr(7LL,0LL)+1LL,gr(1LL,0LL)))+1LL));
    sa(((gr(8L,0L)-gr(tm(gr(6L,0L),gr(1L,0L)),(td(gr(6L,0L),gr(1L,0L)))+1L))+gr(tm(gr(7L,0L)+1L,gr(1L,0L)),(td(gr(7L,0L)+1L,gr(1L,0L)))+1L))>=gr(0L,0L)?1:0);
_26:
    if(sp()!=0)goto _27;else goto _28;
_27:
    sp();
    goto _20;
_28:
    gw(8LL,0LL,sp());
    sa(gr(9LL,0LL));
    gw(6LL,0LL,gr(9LL,0LL)+gr(6LL,0LL));
    sa(sp()+gr(7LL,0LL));
    gw(7LL,0LL,sp());
    goto _15;
_29:
    sa((gr(8LL,0LL)+gr(tm(gr(6LL,0LL)-1LL,gr(1LL,0LL)),(td(gr(6LL,0LL)-1LL,gr(1LL,0LL)))+1LL))-gr(tm(gr(7LL,0LL),gr(1LL,0LL)),(td(gr(7LL,0LL),gr(1LL,0LL)))+1LL));
    sa(((gr(8L,0L)+gr(tm(gr(6L,0L)-1L,gr(1L,0L)),(td(gr(6L,0L)-1L,gr(1L,0L)))+1L))-gr(tm(gr(7L,0L),gr(1L,0L)),(td(gr(7L,0L),gr(1L,0L)))+1L))>=gr(0L,0L)?1:0);
    goto _26;
_30:
    gw(5LL,0LL,gr(5LL,0LL)-1LL);
    goto _16;
_31:
    sa(sr());
    sa(32LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3LL,0LL));
    sa(sr()<gr(0L,0L)?1:0);
    goto _2;
}