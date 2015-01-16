/* compiled with BefunCompile v1.0.3 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } !<{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R "
           "{0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0"
           "}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }  6{0}  R {0}  R{ }"
           "  6{0}  Q1 {0}  Q1{ } !Q>5567***00p\"2\"10p 230p>v{ } !${>{ }  6}  \"  00g40p050p>40g1-40p40g10g%\"4\"+40g10g/1+g\"0\"-:40g10g%1+40g10g"
           "/1+g\"0\"-50g++ v{ v<{ }  .}  \"{ }  8|g04p+1/g01g04+1%g01g04+\"0\"p+1/g01g04+\"4\"%g01g04+\"0\"%+55p05/+55:<^<|-*+55\"d\"-g07g00<|-\"0\"g+1/"
           "g01g07+\"4\"%g01g07<p070p03+1g03<{ }  b>30g.@{ }  +>70g1+70p{ }  1^{ }  m";
int t=0;int z=0;
int64 g[3444];
int d(){int s,w,i,j,h;h=z;for(;t<711;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<123&&y<28){return g[y*123+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<123&&y<28){g[y*123+x]=v;}}
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    d();
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _3;
_0:
    if(sp()!=0)goto _4; else goto _8;
_1:
    if((gr(4,0))!=0)goto _5;else goto _6;
_2:
    if(((gr((tm(gr(7,0),gr(1,0)))+(52),(td(gr(7,0),gr(1,0)))+(1)))-(48))!=0)goto _7;else goto _9;
_3:
    gw(0,0,1050);
    gw(1,0,50);
    gw(3,0,2);
    goto _4;
_4:
    gw(4,0,gr(0,0));
    gw(5,0,0);
    goto _5;
_5:
    gw(4,0,(gr(4,0))-(1));
    sa((gr((tm(gr(4,0),gr(1,0)))+(52),(td(gr(4,0),gr(1,0)))+(1)))-(48));
    sa(((gr((tm(gr(4,0),gr(1,0)))+(52),(td(gr(4,0),gr(1,0)))+(1)))-(48))+(((gr((tm(gr(4,0),gr(1,0)))+(1),(td(gr(4,0),gr(1,0)))+(1)))-(48))+(gr(5,0))));
    gw(5,0,td(((gr((tm(gr(4,0),gr(1,0)))+(52),(td(gr(4,0),gr(1,0)))+(1)))-(48))+(((gr((tm(gr(4,0),gr(1,0)))+(1),(td(gr(4,0),gr(1,0)))+(1)))-(48))+(gr(5,0))),10));
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(48);
    sa(sp()+sp());
    gw((tm(gr(4,0),gr(1,0)))+(52),(td(gr(4,0),gr(1,0)))+(1),sp());
    sa(48);
    sa(sp()+sp());
    gw((tm(gr(4,0),gr(1,0)))+(1),(td(gr(4,0),gr(1,0)))+(1),sp());
    goto _1;
_6:
    gw(3,0,(gr(3,0))+(1));
    gw(7,0,0);
    goto _2;
_7:
    sa(((gr(0,0))-(gr(7,0)))-(1000));
    goto _0;
_8:
    printf("%lld", (int64)(gr(3,0)));
    goto __;
_9:
    gw(7,0,(gr(7,0))+(1));
    goto _2;
__:
    return 0;
}