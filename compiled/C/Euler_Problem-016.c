/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "{v{0}  [}  %v{0}  Z1{ }  \\> \"0\":::::00p01p02p03p04p05p v  // INIT{ }  5v  p64*8\";}\"p60*p62:6p61:\"<\"  <v p66-1g66{ }  0<{ }  *>06"
           "g1-66p{ }  -0> 66g16g%66g16g/g\"0\"-+ 66g|   v      $#{ }  <<{ }  2.   >46g:!#^_ 1-46p 06g1-66p 076p > 66g!#^_  v{ }  .@   v61g66+"
           "\"0\"%+55:+g67*2-\"0\"g/g61 g66%g61g66<{ }  2>g%66g16g/p55+/76p 66g1-66p   ^{ }  =";
int t=0;int z=0;
int64 g[840];
int d(){int s,w,i,j,h;h=z;for(;t<334;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<60&&y<14){return g[y*60+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<60&&y<14){g[y*60+x]=v;}}
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
    goto _2;
_0:
    if((((gr(6,6))!=0)?0:1)!=0)goto _8;else goto _7;
_1:
    if((gr(6,6))!=0)goto _4;else goto _5;
_2:
    gw(0,0,48);
    gw(0,1,48);
    gw(0,2,48);
    gw(0,3,48);
    gw(0,4,48);
    gw(0,5,48);
    gw(1,6,60);
    gw(2,6,6);
    gw(0,6,360);
    gw(4,6,1000);
    goto _8;
_3:
    gw(6,6,(gr(0,6))-(1));
    sp();
    sa((0)+((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6))))-(48)));
    goto _1;
_4:
    gw(6,6,(gr(6,6))-(1));
    sa((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6))))-(48));
    sa(sp()+sp());
    goto _1;
_5:
    printf("%lld", (int64)(sp()));
    return 0;
_6:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    gw(4,6,sp());
    gw(6,6,(gr(0,6))-(1));
    gw(7,6,0);
    goto _0;
_7:
    sa((((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6))))-(48))*(2))+(gr(7,6)));
    gw(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)),(tm((((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6))))-(48))*(2))+(gr(7,6)),10))+(48));
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    gw(7,6,sp());
    gw(6,6,(gr(6,6))-(1));
    goto _0;
_8:
    sa(gr(4,6));
    if((((gr(4,6))!=0)?0:1)!=0)goto _3;else goto _6;
}