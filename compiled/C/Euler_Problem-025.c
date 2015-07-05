/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } !<{{0}  R {0}  R{ }  6}  4{0}  Q1 {0}  Q1{ } !Q>5567***00p\"2\"10p 230p>v{ } !${>{ }  6}  \"  00g40p050p>40g1-40p40g10g%\"4\"+40"
           "g10g/1+g\"0\"-:40g10g%1+40g10g/1+g\"0\"-50g++ v{ v<{ }  .}  \"{ }  8|g04p+1/g01g04+1%g01g04+\"0\"p+1/g01g04+\"4\"%g01g04+\"0\"%+55p05/+55:<"
           "^<|-*+55\"d\"-g07g00<|-\"0\"g+1/g01g07+\"4\"%g01g07<p070p03+1g03<{ }  b>30g.@{ }  +>70g1+70p{ }  1^{ }  m";
int t=0;int z=0;
int64 g[3444];
int d(){int s,w,i,j,h;h=z;for(;t<355;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<123&&y<28){return g[y*123+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<123&&y<28){g[y*123+x]=v;}}
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
    gw(0LL,0LL,1050LL);
    gw(1LL,0LL,50LL);
    gw(3LL,0LL,2LL);
_1:
    gw(4LL,0LL,gr(0LL,0LL));
    gw(5LL,0LL,0LL);
_2:
    gw(4LL,0LL,gr(4LL,0LL)-1LL);
    sa(gr((tm(gr(4LL,0LL),gr(1LL,0LL)))+52LL,(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL)-48LL);
    sa((gr((tm(gr(4LL,0LL),gr(1LL,0LL)))+52LL,(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL)-48LL)+(gr((tm(gr(4LL,0LL),gr(1LL,0LL)))+1LL,(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL)-48LL)+gr(5LL,0LL));
    gw(5LL,0LL,td((gr((tm(gr(4LL,0LL),gr(1LL,0LL)))+52LL,(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL)-48LL)+(gr((tm(gr(4LL,0LL),gr(1LL,0LL)))+1LL,(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL)-48LL)+gr(5LL,0LL),10LL));
    sa(tm(sp(),10L));
    sa(sp()+48LL);
    gw((tm(gr(4LL,0LL),gr(1LL,0LL)))+52LL,(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL,sp());
    sa(sp()+48LL);
    gw((tm(gr(4LL,0LL),gr(1LL,0LL)))+1LL,(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL,sp());
    if((gr(4LL,0LL))!=0)goto _2;else goto _4;
_4:
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    gw(7LL,0LL,0LL);
_5:
    if(gr((tm(gr(7LL,0LL),gr(1LL,0LL)))+52LL,(td(gr(7LL,0LL),gr(1LL,0LL)))+1LL)!=48LL)goto _7;else goto _6;
_6:
    gw(7LL,0LL,gr(7LL,0LL)+1LL);
    goto _5;
_7:
    if(gr(0LL,0LL)-gr(7LL,0LL)!=1000LL)goto _1;else goto _8;
_8:
    printf("%lld", (int64)(gr(3LL,0LL)));
    return 0;
}