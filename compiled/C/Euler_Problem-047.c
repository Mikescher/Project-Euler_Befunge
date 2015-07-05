/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    gw(1LL,0LL,400LL);
    gw(2LL,0LL,500LL);
    gw(0LL,0LL,200000LL);
    gw(3LL,0LL,2LL);
    gw(0LL,3LL,32LL);
    gw(1LL,3LL,32LL);
_1:
    gw(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+3LL,88LL);
    sa(gr(3LL,0LL)+gr(3LL,0LL));
    sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
_2:
    if(sp()!=0)goto _34;else goto _3;
_3:
    sp();
_4:
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
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
    sa(sp()+3LL);
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
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    if(gr(0L,0L)>gr(3L,0L))goto _8;else goto _11;
_11:
    gw(tm(gr(4LL,0LL)-1LL,gr(1LL,0LL)),(td(gr(4LL,0LL)-1LL,gr(1LL,0LL)))+3LL,0LL);
    gw(4LL,0LL,0LL);
    gw(5LL,0LL,0LL);
    sa(1LL);
    sa(1LL);
    sa(tm(1LL,gr(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+3LL)));
_12:
    if(sp()!=0)goto _13;else goto _33;
_13:
    sa(sr());
    sa(gr(4LL,0LL)+1LL);
    gw(4LL,0LL,gr(4LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();sa((sp()<v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _32;else goto _14;
_14:
    sp();
    if(gr(5LL,0LL)!=4LL)goto _31;else goto _15;
_15:
    gw(8LL,0LL,0LL);
    sa(sr());
    sa(sr());
    sa(sr()+4LL);
    gw(6LL,0LL,sp());
    gw(7LL,0LL,sp());
    sa(sp()-3LL);
_16:
    if(sr()!=gr(7LL,0LL))goto _22;else goto _17;
_17:
    sa(gr(8LL,0LL)+1LL);
    gw(8LL,0LL,gr(8LL,0LL)+1LL);
    sa(sp()-4LL);
    if(sp()!=0)goto _18;else goto _21;
_18:
    sa(sp()+1LL);
    if(sr()!=gr(6LL,0LL))goto _16;else goto _19;
_19:
    gw(4LL,0LL,0LL);
    gw(5LL,0LL,0LL);
    sp();
_20:
    sa(sp()+4LL);
    sa(sr());
    sa(tm(sr(),gr(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+3LL)));
    goto _12;
_21:
    sa(sp()-3LL);
    printf("%lld", (int64)(sp()));
    sp();
    return 0;
_22:
    gw(4LL,0LL,0LL);
    gw(5LL,0LL,0LL);
    sa(sr());
_23:
    if(tm(sr(),gr(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+3LL))!=0)goto _24;else goto _30;
_24:
    sa(sr());
    sa(gr(4LL,0LL)+1LL);
    gw(4LL,0LL,gr(4LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();sa((sp()<v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _23;else goto _25;
_25:
    sp();
    if(gr(5LL,0LL)!=4LL)goto _26;else goto _29;
_26:
    gw(8LL,0LL,0LL);
    if(sr()<gr(7L,0L))goto _27;else goto _19;
_27:
    if(gr(8LL,0LL)!=4LL)goto _18;else goto _28;
_28:
    sa(sp()-3LL);
    printf("%lld", (int64)(sp()));
    sp();
    return 0;
_29:
    gw(8LL,0LL,gr(8LL,0LL)+1LL);
    goto _27;
_30:
    sa(gr(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+3LL));
    gw(5LL,0LL,gr(5LL,0LL)+1LL);
    {int64 v0=sp();sa(td(sp(),v0));}
    goto _24;
_31:
    gw(4LL,0LL,0LL);
    gw(5LL,0LL,0LL);
    goto _20;
_32:
    sa(tm(sr(),gr(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+3LL)));
    goto _12;
_33:
    sa(gr(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+3LL));
    gw(5LL,0LL,gr(5LL,0LL)+1LL);
    {int64 v0=sp();sa(td(sp(),v0));}
    goto _13;
_34:
    sa(sr());
    sa(32LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3LL,0LL));
    sa(sr()<gr(0L,0L)?1:0);
    goto _2;
}