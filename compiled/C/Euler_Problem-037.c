/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ }  *// Project Euler - Problem 37{ } ^f{#}~~~{#}/l?{ } 5%>\"d\"45**:10p5\"d\"*:20p*00p230p\" \":03p13pv    v075320{ }  (p090<{ } 4D"
           "v{ }  F<{ }  6_^#`g03g00<{ } 4;>\"X\"30g:10g%\\10g/3+p30g>30g+:00g\\`{ }  '#v_$>30g1+:30p:10g%\\10g/3+g\" \"-|{ } 4>>90g\"= \",,.@{ }  (^"
           "p+3/g01\\%g01:\\\" \":<  ^{ }  :<{ } 4;v{ }  K<{ } !'<{ } 3Yv{ }  ,>#{ }  7># $#{ }  vv# -1<{ } 3i$   >v{ }  I>$\\{ }  *v{ }  D< >::."
           "55+,90g+90pv{ } 3Y>:!#v_70p9> :70g55+*+:00g\\`|>::10g%\\10g/3+g\"X\"-#^_::55+\\`#v_:55+/1\\:!#^_55+/\\55+*\\v>::10g%\\10g/3+g\"X\"-#v_\\:50p"
           "%50g55+/\\:|>|{ }  .>\\>:1-#^_$^{ } 3S>$\"= \",,90g.@      ^   <{ }  >>${ }  *#^!:{ }  '#<{ }  4>$$0{ }  )>    ^>{ }  .^{ } 4n^1$$<{"
           " } 3j";
int t=0;int z=0;
int64 g[1028000];
int d(){int s,w,i,j,h;h=z;for(;t<645;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<2000&&y<514){return g[y*2000+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<2000&&y<514){g[y*2000+x]=v;}}
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
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
_2:
    if(sp()!=0)goto _29;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sp(),gr(1,0)));

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    if((t0)!=0)goto _6;else goto _4;
_6:
    if(gr(0,0)>gr(3,0))goto _1;else goto _7;
_7:
    gw(9,0,0);
    t0=0;
    sa(0);
    sa(2);
    sa(3);
    sa(5);
    sa(7);
    sa(7);
_8:
    if(sp()!=0)goto _10;else goto _9;
_9:
    printf(" =");
    printf("%lld ", gr(9,0));
    sp();
    return 0;
_10:
    gw(7,0,sp());
    sa(9);
    sa(9+(gr(7,0)*10));
    sa((9+(gr(7,0)*10))<gr(0,0)?1:0);
_11:
    if(sp()!=0)goto _12;else goto _28;
_12:
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=88;

    if((t0)!=0)goto _27;else goto _13;
_13:
    sa(sr());

    if(sr()<10)goto _14;else goto _20;
_14:
    sp();
    sa((sp()!=0)?0:1);
    sa(sr());
_15:
    sp();
    sp();
_16:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_17:
    if(sr()!=1)goto _19;else goto _18;
_18:
    sp();
    sa(sr());
    goto _8;
_19:
    sa(sp()-1LL);

    sa(sr()+(gr(7,0)*10));
    sa(sr()<gr(0,0)?1:0);
    goto _11;
_20:
    sa(sr()/10);
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
_21:
    if(sp()!=0)goto _22;else goto _23;
_22:
    sa(sp()/10LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*10LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _21;
_23:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_24:
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=88;

    if((t0)!=0)goto _15;else goto _25;
_25:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    gw(5,0,sp());
    {int64 v0=sp();sa(tm(sp(),v0));}

    sa(gr(5,0)/10);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _24;else goto _26;
_26:
    sp();
    sp();
    sa(sr());
    sa(sr());
    printf("%lld ", (int64)(sp()));
    printf("\n");
    sa(sp()+gr(9,0));

    gw(9,0,sp());
    goto _16;
_27:
    sp();
    goto _17;
_28:
    t0=0;
    goto _27;
_29:
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
