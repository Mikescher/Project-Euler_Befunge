/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ }  L>1:00p1*:10p2*:20p3*:30p4*:40p5*:v{ }  +vp110$p09:*9p08:*8p07:*7p06:*6p05<{ }  1v_v#{ }  ::-1<p11 <>90g7*>::0\\>:55+%0g\\55"
           "+/:#v_>+#<\\:#<_+-|    +    >3-.$@ |:/+55\\g0%+55: <{ }  ,>:11g^    ^g11<  >{ }  0^{ }  0";
int t=0;int z=0;
int64 g[315];
int d(){int s,w,i,j,h;h=z;for(;t<215;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<45&&y<7){return g[y*45+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<45&&y<7){g[y*45+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0,t1;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(0,0,1);
    gw(1,0,1);
    gw(2,0,2);
    gw(3,0,6);
    gw(4,0,24);
    gw(5,0,120);
    gw(6,0,720);
    gw(7,0,5040);
    gw(8,0,40320);
    gw(9,0,362880);
    gw(1,1,0);
    t0=362880;
    sa(gr(9,0)*7);
    sa(gr(9,0)*7);
    sa(0);
    sa(gr((gr(9,0)*7)%10,0));
    sa((gr(9,0)*7)/10);
    sa((gr(9,0)*7)/10);
_1:
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(gr(sr()%10,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/10LL);

    sa(sr());

    if(sp()!=0)goto _10;else goto _3;
_3:
    sa(sp()+sp());

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _9;else goto _4;
_4:
    sa(sp()+sp());

    t0=sp();
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)goto _5;else goto _8;
_5:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _6;else goto _7;
_6:
    sa(sr());
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(sr()%10,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/10LL);

    sa(sr());
    goto _1;
_7:
    printf("%lld ", gr(1,1)-3);
    sa(sr());
    sp();
    sp();
    return 0;
_8:
    gw(1,1,sr()+gr(1,1));
    goto _5;
_9:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _3;
_10:
    sa(gr(sr()%10,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/10LL);

    sa(sr());
    goto _1;
}
