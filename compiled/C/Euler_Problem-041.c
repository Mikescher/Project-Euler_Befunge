/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "{vXXXXXX{ }  A}  \"${ }  G>7  12p 0>:0\\1p::\"1\"+v{ }  ;|-g21:+1p0\\ <{ }  2v   p231$<{ }  L>32g1gv{ }  ;>32g2%| vp24<>2g1g1+32gv{ }"
           "  (>32g:1g`|     >0    ^^3p0g23p0<1{ }  (^{ }  '>032g1pv>42g0g32g0g42g^p{ }  (^p23+1g23      <{ }  *vp230<{ }  -v6:-1g26*+ 55<0p"
           "26g21<{ }  *@.<     >2p0g\"0\"-+62g|{ }  4${ }  /#  >:>302pv >:02g2-:*` !|{ }  /$    >!\\2% +|%p20+1:g20:<{ }  4^`2::< ${ }  ;^{ } "
           " +<{ }  ,";
int t=0;int z=0;
int64 g[680];
int d(){int s,w,i,j,h;h=z;for(;t<393;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<40&&y<17){return g[y*40+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<40&&y<17){g[y*40+x]=v;}}
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
    gw(1,2,7);
    gw(0,1,0);
    gw(0,0,49);
    sp();
    sa(1);
    sa((1)-(gr(1,2)));
_1:
    if(sp()!=0)goto _2; else goto _3;
_2:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr());
    sa(49);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(gr(1,2));
    {int64 v0=sp();sa(sp()-v0);}
    goto _1;
_3:
    gw(3,2,1);
    sp();
_4:
    sa((gr(3,2))>(gr(gr(3,2),1))?1:0);
    if(sp()!=0)goto _5; else goto _18;
_5:
    sa(tm(gr(3,2),2));
    if(sp()!=0)goto _17; else goto _6;
_6:
    gw(4,2,0);
_7:
    sa(gr(gr(4,2),0));
    gw(gr(4,2),0,gr(gr(3,2),0));
    gw(gr(3,2),0,sp());
    gw(gr(3,2),1,(gr(gr(3,2),1))+(1));
    gw(3,2,0);
    gw(6,2,gr(1,2));
    sa(0);
_8:
    sa((gr(6,2))-(1));
    gw(6,2,(gr(6,2))-(1));
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sp()+sp());
    sa(gr(6,2));
    if(sp()!=0)goto _16; else goto _9;
_9:
    gw(0,2,3);
    sa(sr());
    sa(sr());
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sp()+sp());
    if(sp()!=0)goto _10; else goto _15;
_10:
    sa(sr());
    sa(((gr(0,2))-(2))*((gr(0,2))-(2)));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _14; else goto _11;
_11:
    sa(sr());
    sa(gr(0,2));
    gw(0,2,(gr(0,2))+(1));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    if(sp()!=0)goto _10; else goto _12;
_12:
    gw(3,2,(gr(3,2))+(1));
    sp();
_13:
    sp();
    goto _4;
_14:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_15:
    gw(3,2,(gr(3,2))+(1));
    sp();
    goto _13;
_16:
    sa(10);
    sa(sp()*sp());
    goto _8;
_17:
    gw(4,2,gr(gr(3,2),1));
    goto _7;
_18:
    gw(gr(3,2),1,0);
    gw(3,2,(gr(3,2))+(1));
    goto _4;
}