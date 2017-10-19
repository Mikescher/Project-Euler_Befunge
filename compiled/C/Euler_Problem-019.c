/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(12,0,gr(12,0)-20);
    gw(12,1,gr(12,1)-20);
    sa(11);
    sa(11);
_1:
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(sr());
    sa(sr());
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);

    sa(sp()+28LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);

    sa(sp()+28LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr());
    goto _1;
_3:
    gw(0,2,2);
    gw(1,2,1);
    gw(2,2,1);
    gw(3,2,1901);
    gw(9,2,0);
    sp();
_4:
    gw(9,2,(((gr(0,2)%7)+(gr(1,2)-1)!=0)?0:1)+gr(9,2));
    gw(0,2,gr(0,2)+1);
    gw(1,2,gr(1,2)+1);

    if((gr(3,2)%4)!=0)goto _5;else goto _11;
_5:
    sa(gr(gr(2,2),0)-(gr(1,2)-1));
_6:
    if(sp()!=0)goto _9;else goto _7;
_7:
    gw(1,2,1);
    t0=gr(2,2)-12;
    gw(2,2,gr(2,2)+1);

    if((t0)!=0)goto _9;else goto _8;
_8:
    gw(2,2,1);
    gw(3,2,gr(3,2)+1);
_9:
    if(gr(3,2)!=2001)goto _4;else goto _10;
_10:
    printf("%lld ", gr(9,2));
    return 0;
_11:
    if((gr(3,2)%100)!=0)goto _12;else goto _13;
_12:
    sa(gr(gr(2,2),1)-(gr(1,2)-1));
    goto _6;
_13:
    if((gr(3,2)%400)!=0)goto _5;else goto _12;
}
