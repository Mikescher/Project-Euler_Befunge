/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v303232332323{ }  [v313232332323{ }  [6{ }  g>2*>::0g\"0\"-47*+\\0p::v{ }  U|:-1p1\\+*74-\"0\"g1 <{ }  Rv $<{ }  d>202p112p122p\"2&\"*1+"
           "32p092pv{ }  Lv20+1g20p29+g29!+-1g21%7g20<>#{ }  '0# v#   <      >{ }  1>v>p12g1+12p32g4%{ }  -|{ }  '>1 >>22g\\g12g1--|{ }  O>32"
           "g\"d\"%|  0^ <  #      >112p22g:1+22p66+-|{ }  ;v%*4\"d\"g23<>#^_1^  |-+1*\"(2\"g23<p23+1g23p221<{ }  ;>{ }  *^>1^    >92g.@      ^{ }"
           "  -<";
int t=0;int z=0;
int64 g[864];
int d(){int s,w,i,j,h;h=z;for(;t<388;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<72&&y<12){return g[y*72+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<72&&y<12){g[y*72+x]=v;}}
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
    gw(12LL,0LL,gr(12LL,0LL)-20LL);
    gw(12LL,1LL,gr(12LL,1LL)-20LL);
    sa(11LL);
_1:
    sa(sr());
    sa(sr());
    sa(0LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    sa(sp()+28LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    sa(sp()+28LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _1;else goto _3;
_3:
    gw(0LL,2LL,2LL);
    gw(1LL,2LL,1LL);
    gw(2LL,2LL,1LL);
    gw(3LL,2LL,1901LL);
    gw(9LL,2LL,0LL);
    gw(9LL,2LL,(((tm(gr(0L,2L),7L))+(gr(1L,2L)-1L)!=0)?0:1)+gr(9LL,2LL));
    gw(0LL,2LL,gr(0LL,2LL)+1LL);
    gw(1LL,2LL,gr(1LL,2LL)+1LL);
    sp();
_4:
    if(tm(gr(3LL,2LL),4LL)!=0)goto _5;else goto _12;
_5:
    sa(gr(gr(2LL,2LL),0LL)-(gr(1LL,2LL)-1LL));
_6:
    if(sp()!=0)goto _9;else goto _7;
_7:
    gw(1LL,2LL,1LL);
    sa(gr(2LL,2LL));
    gw(2LL,2LL,gr(2LL,2LL)+1LL);
    sa(sp()-12LL);
    if(sp()!=0)goto _9;else goto _8;
_8:
    gw(2LL,2LL,1LL);
    gw(3LL,2LL,gr(3LL,2LL)+1LL);
_9:
    if(gr(3LL,2LL)!=2001LL)goto _10;else goto _11;
_10:
    gw(9LL,2LL,(((tm(gr(0L,2L),7L))+(gr(1L,2L)-1L)!=0)?0:1)+gr(9LL,2LL));
    gw(0LL,2LL,gr(0LL,2LL)+1LL);
    gw(1LL,2LL,gr(1LL,2LL)+1LL);
    goto _4;
_11:
    printf("%lld", (int64)(gr(9LL,2LL)));
    return 0;
_12:
    if(tm(gr(3LL,2LL),100LL)!=0)goto _13;else goto _14;
_13:
    sa(gr(gr(2LL,2LL),1LL)-(gr(1LL,2LL)-1LL));
    goto _6;
_14:
    if(tm(gr(3LL,2LL),400LL)!=0)goto _16;else goto _15;
_15:
    sa(gr(gr(2LL,2LL),1LL)-(gr(1LL,2LL)-1LL));
    goto _6;
_16:
    sa(gr(gr(2LL,2LL),0LL)-(gr(1LL,2LL)-1LL));
    goto _6;
}