/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ }  *// Project Euler - Problem 73{ } 4]XX  ????{ } J!{{#}~~~}  ;{#}~Ow{ } 5%>\";}`\"*11p051p0v{ } 4uvp12*\"(2\"     <     v+1{ } "
           " 4{<{ }  1}  \"{ } 45>1+:1+2/61p:71p:3/1+>:61g\\`!#v_:21g%71g3+g!|>81g11g`91g11g`+#^_081g21gv{ } 4=|-g11:{ }  2>#$ #<{ }  .^p19+g1"
           "9g17p18+g18:p+3g19%<{ } 4=>$51g.@{ }  1^p19g17p18:p15+1g15<{ } 4X";
int t=0;int z=0;
int64 g[24020000];
int d(){int s,w,i,j,h;h=z;for(;t<321;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<2000&&y<12010){return g[y*2000+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<2000&&y<12010){g[y*2000+x]=v;}}
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
    gw(1,1,12000);
    gw(5,1,0);
    gw(2,1,2000);
    gw(6,1,1);
    gw(7,1,1);
    sa(1);
    sa(1);
    sa(1<gr(6,1)?1:0);
_1:
    if(sp()!=0)goto _5;else goto _2;
_2:
    sp();

    if((sr()-gr(1,1))!=0)goto _4;else goto _3;
_3:
    printf("%lld ", gr(5,1));
    sp();
    return 0;
_4:
    sa(sp()+1LL);

    gw(6,1,(sr()+1)/2);
    sa(sr());
    gw(7,1,sp());
    sa((sr()/3)+1);
    sa(sr()<gr(6,1)?1:0);
    goto _1;
_5:
    if((gr(tm(sr(),gr(2,1)),gr(7,1)+3))!=0)goto _6;else goto _9;
_6:
    gw(5,1,gr(5,1)+1);
    sa(sr());
    gw(8,1,sp());
    gw(9,1,gr(7,1));
_7:
    if(((gr(8,1)>gr(1,1)?1:0)+(gr(9,1)>gr(1,1)?1LL:0LL))!=0)goto _9;else goto _8;
_8:
    gw(tm(gr(8,1),gr(2,1)),gr(9,1)+3,0);
    gw(8,1,sr()+gr(8,1));
    gw(9,1,gr(7,1)+gr(9,1));
    goto _7;
_9:
    sa(sp()+1LL);

    sa(sr()<gr(6,1)?1:0);
    goto _1;
}
