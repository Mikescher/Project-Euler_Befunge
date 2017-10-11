/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
    int64 t0,t1;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1,0,400);
    gw(2,0,500);
    gw(0,0,200000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
_1:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
_2:
    if(sp()!=0)goto _33;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

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

    sa(sp()+3LL);

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

    sa(sp()+3LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}

    if(gr(0,0)>gr(3,0))goto _8;else goto _11;
_11:
    gw(tm(gr(4,0)-1,gr(1,0)),(td(gr(4,0)-1,gr(1,0)))+3,0);
    gw(4,0,0);
    gw(5,0,0);
    sa(1);
    sa(1);
    sa(tm(1,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)));
_12:
    if(sp()!=0)goto _13;else goto _32;
_13:
    sa(sr());
    sa(gr(4,0)+1);
    gw(4,0,gr(4,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    sa((sp()<t0)?1:0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)goto _31;else goto _14;
_14:
    sp();

    if(gr(5,0)!=4)goto _30;else goto _15;
_15:
    gw(8,0,0);
    sa(sr());
    sa(sr());
    t0=sr()+4;
    gw(6,0,t0);
    gw(7,0,sp());
    sa(sp()-3LL);
_16:
    if(sr()!=gr(7,0))goto _22;else goto _17;
_17:
    t0=gr(8,0)+1;
    gw(8,0,gr(8,0)+1);
    t0-=4;

    if((t0)!=0)goto _18;else goto _21;
_18:
    sa(sp()+1LL);


    if(sr()!=gr(6,0))goto _16;else goto _19;
_19:
    gw(4,0,0);
    gw(5,0,0);
    sp();
_20:
    sa(sp()+4LL);

    sa(sr());
    sa(tm(sr(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)));
    goto _12;
_21:
    sa(sp()-3LL);

    printf("%lld ", (int64)(sp()));
    sp();
    return 0;
_22:
    gw(4,0,0);
    gw(5,0,0);
    sa(sr());
_23:
    if(tm(sr(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3))!=0)goto _24;else goto _29;
_24:
    sa(sr());
    sa(gr(4,0)+1);
    gw(4,0,gr(4,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    sa((sp()<t0)?1:0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)goto _23;else goto _25;
_25:
    sp();

    if(gr(5,0)!=4)goto _26;else goto _28;
_26:
    gw(8,0,0);

    if(sr()<gr(7,0))goto _27;else goto _19;
_27:
    if(gr(8,0)!=4)goto _18;else goto _21;
_28:
    gw(8,0,gr(8,0)+1);
    goto _27;
_29:
    t0=gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3);
    gw(5,0,gr(5,0)+1);
    sa(td(sp(),t0));
    goto _24;
_30:
    gw(4,0,0);
    gw(5,0,0);
    goto _20;
_31:
    sa(tm(sr(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)));
    goto _12;
_32:
    t0=gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3);
    gw(5,0,gr(5,0)+1);
    sa(td(sp(),t0));
    goto _13;
_33:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(0,0)?1:0);
    goto _2;
}
