/* compiled with BefunCompile v1.0.5 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } !${#} *R{ } !%>\"d\"00p\";}\"8*60p080p090p{ }  .#v v#{ }  2p+1/g00g04%g00g04g05<{ }  3>60g>:30p>:10p>0\\00g%10g00g/v>140p050p>4 "
           "0g55+*30g%40p50g1+50p40g00g%40g00g/1+g!|{ }  5>80g.@      |p01::-1g01p+1<{ }  +vp08g03p09_v#`g09:-g+1/g00g04%g00g04g05 <{ }  3^_"
           "^#p06:-1g06 ># $#{ }  *^#{ }  )<{ }  )$<{ }  P";
int t=0;int z=0;
int64 g[1600];
int d(){int s,w,i,j,h;h=z;for(;t<302;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<100&&y<16){return g[y*100+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<100&&y<16){g[y*100+x]=v;}}
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
    gw(0,0,100);
    gw(6,0,1000);
    gw(8,0,0);
    gw(9,0,0);
_1:
    sa(gr(6,0)-1);
    gw(6,0,gr(6,0)-1);
    if(sp()!=0)goto _3;else goto _2;
_2:
    printf("%lld", (int64)(gr(8,0)));
    return 0;
_3:
    sa(gr(6,0));
    gw(3,0,gr(6,0));
    sa(sr());
    gw(1,0,sp());
_4:
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(0,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((td(gr(1,0),gr(0,0)))+1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(gr(1,0)-1);
    sa(gr(1,0)-1);
    gw(1,0,gr(1,0)-1);
    if(sp()!=0)goto _4;else goto _6;
_6:
    gw(4,0,1);
    gw(5,0,0);
    gw(4,0,tm(gr(4,0)*10,gr(3,0)));
    gw(5,0,gr(5,0)+1);
    sp();
_7:
    if((((gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1))!=0)?0:1)!=0)goto _11;else goto _8;
_8:
    sa(gr(5,0)-gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1));
    if(((gr(5,0)-gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1))>(gr(9,0))?1:0)!=0)goto _9;else goto _10;
_9:
    gw(9,0,sp());
    gw(8,0,gr(3,0));
    goto _1;
_10:
    sp();
    goto _1;
_11:
    gw(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1,gr(5,0));
    gw(4,0,tm(gr(4,0)*10,gr(3,0)));
    gw(5,0,gr(5,0)+1);
    goto _7;
}