/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1LL,0LL,0LL);
    gw(2LL,0LL,0LL);
    gw(3LL,0LL,0LL);
    gw(4LL,0LL,0LL);
    gw(5LL,0LL,0LL);
    gw(6LL,0LL,0LL);
    gw(7LL,0LL,0LL);
    gw(8LL,0LL,0LL);
    gw(9LL,0LL,0LL);
    gw(1LL,1LL,200LL);
    gw(2LL,1LL,9LL);
    gw(3LL,1LL,0LL);
    gw(gr(2LL,1LL),0LL,gr(gr(2LL,1LL),0LL)+1LL);
_1:
    if(gr(2LL,1LL)!=9LL)goto _11;else goto _2;
_2:
    sa((gr(1LL,0LL)*500LL)+(gr(2LL,0LL)*200LL)+(100LL*gr(3LL,0LL))+(gr(4LL,0LL)*50LL)+(gr(5LL,0LL)*20LL)+(gr(6LL,0LL)*10LL)+(gr(7LL,0LL)*5LL)+(gr(8LL,0LL)*2LL)+gr(9LL,0LL));
    if(((gr(1L,0L)*500L)+(gr(2L,0L)*200L)+(100L*gr(3L,0L))+(gr(4L,0L)*50L)+(gr(5L,0L)*20L)+(gr(6L,0L)*10L)+(gr(7L,0L)*5L)+(gr(8L,0L)*2L)+gr(9L,0L))<gr(1L,1L))goto _10;else goto _3;
_3:
    sa(sp()-gr(1LL,1LL));
    if(sp()!=0)goto _4;else goto _9;
_4:
    sa(gr(2LL,1LL));
    if((gr(gr(2LL,1LL),0LL))!=0)goto _6;else goto _5;
_5:
    sa(sp()-1LL);
    gw(2LL,1LL,sp());
    goto _4;
_6:
    if(sr()!=1LL)goto _8;else goto _7;
_7:
    sp();
    printf("%lld", (int64)(gr(3LL,1LL)));
    return 0;
_8:
    sa(sp()-1LL);
    gw(2LL,1LL,sp());
    gw(gr(2LL,1LL),0LL,gr(gr(2LL,1LL),0LL)+1LL);
    goto _1;
_9:
    gw(3LL,1LL,gr(3LL,1LL)+1LL);
    goto _4;
_10:
    gw(gr(2LL,1LL),0LL,gr(gr(2LL,1LL),0LL)+1LL);
    sp();
    goto _1;
_11:
    sa(0LL);
    sa(gr(2LL,1LL)+1LL);
    gw(2LL,1LL,gr(2LL,1LL)+1LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _1;
}