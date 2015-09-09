/* compiled with BefunCompile v1.0.8 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{#}  ){ }  S###{ } !5>{0}  )10p20p30p40p50p60p70p80p90p  \"d\"2*  11p921p031p 0vv{ }  Y$<{ }  -vp0p12:+1g120<  >g25**+70g5*+80g2*"
           "+90g+v{ }  '>21g0g1+21g0p>21g9-{ }  '|>10g5\"d\"**20g2\"d\"**+\"d\"3v>:11g\\`|p{ }  9>^ ^6+**45g05+*\"2\"g04+*g0<v<      ^12-1<{ }  >v<  "
           "    v{ }  '<|-g11 <     |{ }  ;-1:<|g0:g12<p13+1g13<{ }  +>$31g.@{ }  9>1-21p ^{ }  /";
int t=0;int z=0;
int64 g[660];
int d(){int s,w,i,j,h;h=z;for(;t<341;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<60&&y<11){return g[y*60+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<60&&y<11){g[y*60+x]=v;}}
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
    gw(1,0,0);
    gw(2,0,0);
    gw(3,0,0);
    gw(4,0,0);
    gw(5,0,0);
    gw(6,0,0);
    gw(7,0,0);
    gw(8,0,0);
    gw(9,0,0);
    gw(1,1,200);
    gw(2,1,9);
    gw(3,1,0);
    gw(gr(2,1),0,gr(gr(2,1),0)+1);
_1:
    if(gr(2,1)!=9)goto _11;else goto _2;
_2:
    t0=(gr(1,0)*500)+(gr(2,0)*200)+(100*gr(3,0))+(gr(4,0)*50)+(gr(5,0)*20)+(gr(6,0)*10)+(gr(7,0)*5)+(gr(8,0)*2)+gr(9,0);
    if(((gr(1,0)*500)+(gr(2,0)*200)+(100*gr(3,0))+(gr(4,0)*50)+(gr(5,0)*20)+(gr(6,0)*10)+(gr(7,0)*5)+(gr(8,0)*2)+gr(9,0))<gr(1,1))goto _10;else goto _3;
_3:
    t0-=gr(1,1);
    if((t0)!=0)goto _4;else goto _9;
_4:
    t0=gr(2,1);
    if((gr(gr(2,1),0))!=0)goto _6;else goto _5;
_5:
    t0--;
    gw(2,1,t0);
    goto _4;
_6:
    if(t0!=1)goto _8;else goto _7;
_7:
    printf("%lld", gr(3,1));
    return 0;
_8:
    t0--;
    gw(2,1,t0);
    gw(gr(2,1),0,gr(gr(2,1),0)+1);
    goto _1;
_9:
    gw(3,1,gr(3,1)+1);
    goto _4;
_10:
    gw(gr(2,1),0,gr(gr(2,1),0)+1);
    goto _1;
_11:
    sa(0);
    sa(gr(2,1)+1);
    gw(2,1,gr(2,1)+1);
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _1;
}