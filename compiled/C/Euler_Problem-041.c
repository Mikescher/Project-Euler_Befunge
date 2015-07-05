/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    gw(1LL,2LL,7LL);
    gw(0LL,1LL,0LL);
    gw(0LL,0LL,49LL);
    sp();
    sa(1LL);
    sa(1LL-gr(1LL,2LL));
_1:
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+49LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+1LL);
    sa(sr()-gr(1LL,2LL));
    goto _1;
_3:
    gw(3LL,2LL,1LL);
    sp();
_4:
    if(gr(3L,2L)>gr(gr(3L,2L),1L))goto _6;else goto _5;
_5:
    gw(gr(3LL,2LL),1LL,0LL);
    gw(3LL,2LL,gr(3LL,2LL)+1LL);
    goto _4;
_6:
    if(tm(gr(3LL,2LL),2LL)!=0)goto _18;else goto _7;
_7:
    gw(4LL,2LL,0LL);
_8:
    sa(gr(gr(4LL,2LL),0LL));
    gw(gr(4LL,2LL),0LL,gr(gr(3LL,2LL),0LL));
    gw(gr(3LL,2LL),0LL,sp());
    gw(gr(3LL,2LL),1LL,gr(gr(3LL,2LL),1LL)+1LL);
    gw(3LL,2LL,0LL);
    gw(6LL,2LL,gr(1LL,2LL));
    sa(0LL);
_9:
    sa(gr(6LL,2LL)-1LL);
    gw(6LL,2LL,gr(6LL,2LL)-1LL);
    sa(0LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    sa(sp()+sp());
    if((gr(6LL,2LL))!=0)goto _17;else goto _10;
_10:
    gw(0LL,2LL,3LL);
    sa(sr());
    sa(sr());
    sa(sr()<=2L?1:0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),2L));
    sa(sp()+sp());
    if(sp()!=0)goto _13;else goto _11;
_11:
    gw(3LL,2LL,gr(3LL,2LL)+1LL);
    sp();
_12:
    sp();
    goto _4;
_13:
    if(sr()<=(gr(0L,2L)-2L)*(gr(0L,2L)-2L))goto _16;else goto _14;
_14:
    sa(sr());
    sa(gr(0LL,2LL));
    gw(0LL,2LL,gr(0LL,2LL)+1LL);
    {int64 v0=sp();sa(tm(sp(),v0));}
    if(sp()!=0)goto _13;else goto _15;
_15:
    gw(3LL,2LL,gr(3LL,2LL)+1LL);
    sp();
    goto _12;
_16:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_17:
    sa(sp()*10LL);
    goto _9;
_18:
    gw(4LL,2LL,gr(gr(3LL,2LL),1LL));
    goto _8;
}