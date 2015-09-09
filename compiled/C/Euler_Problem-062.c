/* compiled with BefunCompile v1.0.8 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ $ {#} %: }  #  { {#} %:  $}  \"{ {#} %:   }  J {#} %:  v{ }  J_v#!:p/g42\\+ <{ } $b>5 28p    78*9*3-:    24p    68*:    25p*:26"
           "p >1-:0\\:24g%4^{ } $bv <{ }  ;v+1{ }  +<{ } $p0{ }  K|-g02<{ } $k>1+:::**:22p 0\\v   v\\-1 <>20p0>:3*:24g%4+\\24 g/g:|{ } $k${ }  )"
           "v+55:<>\\1>9*\\:|:{ }  5@$$$.g/g42\\+4%g42:+1${ }  '<{ } $[>%\\:#^|#/+55\\$<+{ }  2>    3*:2+:24g%4+\\24g/g1+:28g-!|{ } $Z>$ #\\>#<>\\# "
           ":#+_^{ }  7>*::2v   vp/g42\\+4%g42:+2\\<{ } $Q^p/g42\\+4%g42:+2\\1p/g42\\+4%g42:+1\\g22p/g42\\+4%g42:\\g0 <{ } $f^{ }  Y<{ } $b";
int t=0;int z=0;
int64 g[29290];
int d(){int s,w,i,j,h;h=z;for(;t<503;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<505&&y<58){return g[y*505+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<505&&y<58){g[y*505+x]=v;}}
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
    gw(2,8,5);
    gw(2,4,501);
    gw(2,5,48);
    gw(2,6,24048);
    gw((tm(24047,gr(2,4)))+4,td(24047,gr(2,4)),0);
    sa(24046);
_1:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),gr(2,4)))+4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _2;else goto _20;
_2:
    gw(2,2,1);
    sa(1);
    sa(0);
    sa(1);
    sa(1);
_3:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(9);
_4:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _19;else goto _5;
_5:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));
    sa(tm(sr(),10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
_6:
    if(sp()!=0)goto _3;else goto _7;
_7:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sp();
    sp();
_8:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _9;else goto _10;
_9:
    sa(sp()+sp());
    goto _8;
_10:
    sa(sp()+sp());
    sa(sr());
    gw(2,0,sp());
    sa(0);
    sa(gr(4,0));
    sa(gr(4,0));
_11:
    if(sp()!=0)goto _12;else goto _18;
_12:
    sa(sp()-gr(2,0));
    if(sp()!=0)goto _17;else goto _13;
_13:
    sa(sp()*3LL);
    sa(sr()+2);
    sa((tm(sr(),gr(2,4)))+4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()+1LL);
    if(sr()-gr(2,8)==0)goto _14;else goto _15;
_14:
    sp();
    sa(sp()+1LL);
    sa((tm(sr(),gr(2,4)))+4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));
    {int64 v0=sp();t0=gr(sp(),v0);}
    printf("%lld", t0);
    sp();
    sp();
    sp();
    return 0;
_15:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+2LL);
    sa((tm(sr(),gr(2,4)))+4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
_16:
    sp();
    sa(sp()+1LL);
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    t0=sp();
    sa(sp()*t0);
    sa(sr());
    gw(2,2,sp());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _6;
_17:
    sa(sp()+1LL);
    sa(sr()*3);
    sa((tm(sr(),gr(2,4)))+4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    goto _11;
_18:
    sp();
    sa(sp()*3LL);
    sa(sr());
    sa(sr());
    sa(gr(2,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),gr(2,4)))+4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(gr(2,2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);
    sa((tm(sr(),gr(2,4)))+4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+2LL);
    sa((tm(sr(),gr(2,4)))+4);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _16;
_19:
    sa(sp()-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*9LL);
    goto _4;
_20:
    sa(sp()-1LL);
    goto _1;
}