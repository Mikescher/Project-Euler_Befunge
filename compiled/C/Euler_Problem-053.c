/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v ###    {#}  T{ }  <{#}  T{ }  3>190p191p020p130pv{ }  1>40g9+30g2%!g40g8+30g2%!g+vv!g!%2g03+9g04`**<>30g:\"d\"-!#v_1+:30p2/40p>3"
           "0g40g2*>-|{ }  9>:40g9+30g2%p\";};}@\"^^{ }  *>#<$ #<20g.@{ }  ,>40g8+30g2%!g2*{ }  +^>$40g9+1-30g2%!g!v{ }  6>30g40g2* -^v{ }  @{"
           "_v#!}  #<{ }  -^{ }  '_^#!p04:-1g04<p%2g03+9g040p02++1!!-*2g04g03g02{$<  }  # ";
int t=0;int z=0;
int64 g[560];
int d(){int s,w,i,j,h;h=z;for(;t<334;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<80&&y<7){return g[y*80+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<80&&y<7){g[y*80+x]=v;}}
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
    goto _1;
_0:
    if(sp()!=0)goto _3; else goto _10;
_1:
    gw(9,0,1);
    gw(9,1,1);
    gw(2,0,0);
    gw(3,0,1);
    goto _13;
_2:
    sa(1);
    sa(sp()+sp());
    sa(sr());
    gw(3,0,sp());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    gw(4,0,sp());
    sa((gr(3,0))-((gr(4,0))*(2)));
    goto _0;
_3:
    sa((gr((gr(4,0))+(9),((tm(gr(3,0),2))!=0)?0:1))+(gr((gr(4,0))+(8),((tm(gr(3,0),2))!=0)?0:1)));
    gw((gr(4,0))+(9),tm(gr(3,0),2),(gr((gr(4,0))+(9),((tm(gr(3,0),2))!=0)?0:1))+(gr((gr(4,0))+(8),((tm(gr(3,0),2))!=0)?0:1)));
    goto _12;
_4:
    gw(2,0,(gr(2,0))+(((((((gr(3,0))-((gr(4,0))*(2)))!=0)?0:1)!=0)?0:1)+(1)));
    gw((gr(4,0))+(9),tm(gr(3,0),2),0);
    sp();
    goto _5;
_5:
    sp();
    goto _6;
_6:
    sp();
    goto _16;
_7:
    sa((gr(3,0))-((gr(4,0))*(2)));
    {int64 v0=sp();sa(sp()-v0);}
    goto _0;
_8:
    gw(2,0,(gr(2,0))+(((((((gr(3,0))-((gr(4,0))*(2)))!=0)?0:1)!=0)?0:1)+(1)));
    gw((gr(4,0))+(9),tm(gr(3,0),2),0);
    goto _5;
_9:
    gw(2,0,(gr(2,0))+(((((((gr(3,0))-((gr(4,0))*(2)))!=0)?0:1)!=0)?0:1)+(1)));
    gw((gr(4,0))+(9),tm(gr(3,0),2),0);
    goto _6;
_10:
    sa((gr((gr(4,0))+(8),((tm(gr(3,0),2))!=0)?0:1))*(2));
    gw((gr(4,0))+(9),tm(gr(3,0),2),(gr((gr(4,0))+(8),((tm(gr(3,0),2))!=0)?0:1))*(2));
    goto _12;
_11:
    sp();
    printf("%lld", (int64)(gr(2,0)));
    return 0;
_12:
    sa(1000000);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa(((gr((gr(4,0))+(9),((tm(gr(3,0),2))!=0)?0:1))!=0)?0:1);
    sa(((((gr(((gr(4,0))+(9))-(1),((tm(gr(3,0),2))!=0)?0:1))!=0)?0:1)!=0)?0:1);
    if(sp()!=0)goto _14; else goto _4;
_13:
    sa(gr(3,0));
    if(((((gr(3,0))-(100))!=0)?0:1)!=0)goto _11;else goto _2;
_14:
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15; else goto _8;
_15:
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _16; else goto _9;
_16:
    sa((gr(4,0))-(1));
    gw(4,0,(gr(4,0))-(1));
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _13; else goto _7;
}