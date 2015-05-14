/* compiled with BefunCompile v1.0.5 (c) 2015 */
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
    gw(12,0,(gr(12,0)-48)+28);
    gw(12,1,(gr(12,1)-48)+28);
    sa(11);
    sa(11);
_1:
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(sr());
    sa(sr());
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    sa(28);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    sa(28);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _1;
_3:
    gw(0,2,2);
    gw(1,2,1);
    gw(2,2,1);
    gw(3,2,1901);
    gw(9,2,0);
    gw(9,2,(((tm(gr(0,2),7))+(gr(1,2)-1)!=0)?0:1)+gr(9,2));
    gw(0,2,gr(0,2)+1);
    gw(1,2,gr(1,2)+1);
    sp();
_4:
    sa(tm(gr(3,2),4));
    if(sp()!=0)goto _16;else goto _5;
_5:
    sa(tm(gr(3,2),100));
    if(sp()!=0)goto _15;else goto _6;
_6:
    sa(tm(gr(3,2),400));
    if(sp()!=0)goto _14;else goto _7;
_7:
    sa(gr(gr(2,2),1)-(gr(1,2)-1));
_8:
    if(sp()!=0)goto _9;else goto _12;
_9:
    sa(gr(3,2)-2001);
    if(sp()!=0)goto _10;else goto _11;
_10:
    gw(9,2,(((tm(gr(0,2),7))+(gr(1,2)-1)!=0)?0:1)+gr(9,2));
    gw(0,2,gr(0,2)+1);
    gw(1,2,gr(1,2)+1);
    goto _4;
_11:
    printf("%lld", (int64)(gr(9,2)));
    return 0;
_12:
    gw(1,2,1);
    sa(gr(2,2));
    gw(2,2,gr(2,2)+1);
    sa(12);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _9;else goto _13;
_13:
    gw(2,2,1);
    gw(3,2,gr(3,2)+1);
    goto _9;
_14:
    sa(gr(gr(2,2),0)-(gr(1,2)-1));
    goto _8;
_15:
    sa(gr(gr(2,2),1)-(gr(1,2)-1));
    goto _8;
_16:
    sa(gr(gr(2,2),0)-(gr(1,2)-1));
    goto _8;
}