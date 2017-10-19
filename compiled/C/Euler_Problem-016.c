/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
int main(void)
{
    int64 t0;
    d();
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
_1:
    t0=gr(4,6);

    if((gr(4,6))!=0)goto _6;else goto _2;
_2:
    gw(6,6,gr(0,6)-1);
    t0=gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48;
_3:
    if((gr(6,6))!=0)goto _4;else goto _5;
_4:
    gw(6,6,gr(6,6)-1);
    t0+=gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48;
    goto _3;
_5:
    printf("%lld ", t0);
    return 0;
_6:
    t0--;
    gw(4,6,t0);
    gw(6,6,gr(0,6)-1);
    gw(7,6,0);
_7:
    if((gr(6,6))!=0)goto _8;else goto _1;
_8:
    t0=(((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48)*2)+gr(7,6))/10;
    gw(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)),((((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48)*2)+gr(7,6))%10)+48);
    gw(7,6,t0);
    gw(6,6,gr(6,6)-1);
    goto _7;
}
