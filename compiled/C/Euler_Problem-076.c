/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v  X OO    // Project Euler - Problem 76{ }  `v{ } !(v{ } !+{{+} !&   } !%{+} !&{ } !1v+1{ }  +p:+3\\+1g06:$<{ }  ,> :50g\\-3v{ } "
           " O>\"d\"30p1>:30g`#v_:50p060p1>:50g-!#^_::::50g\\-`#^_:     3v{ }  ^>1+:1+g.@  ^+1p+3g05+3\\p06:+g06g+3-\\g05\\+<{ }  O";
int t=0;int z=0;
int64 g[11232];
int d(){int s,w,i,j,h;h=z;for(;t<241;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<104&&y<108){return g[y*104+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<104&&y<108){g[y*104+x]=v;}}
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
    gw(3,0,100);
    sa(1);
    sa(1>gr(3,0)?1:0);
_1:
    if(sp()!=0)goto _9;else goto _2;
_2:
    sa(sr());
    gw(5,0,sp());
    gw(6,0,0);
    sa(1);
    sa(1-gr(5,0));
_3:
    if(sp()!=0)goto _4;else goto _8;
_4:
    t0=gr(5,0);
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}

    t1=sp();
    sa((sp()>t1)?1:0);

    t0=sp();

    if((t0)!=0)goto _7;else goto _5;
_5:
    sa(sr()+3);
_6:
    t0=gr(5,0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}

    sa(sp()+3LL);

    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()+gr(6,0));

    sa(sr());
    gw(6,0,sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+3LL);

    sa(gr(5,0)+3);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+1LL);

    sa(sr()-gr(5,0));
    goto _3;
_7:
    t0=gr(5,0);
    sa(sr());
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}

    sa(sp()+3LL);
    goto _6;
_8:
    sp();
    sa(sr());
    sa(gr(6,0)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+3LL);

    sa(sr());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+1LL);

    sa(sr()>gr(3,0)?1:0);
    goto _1;
_9:
    sa(sp()+1LL);

    sa(sr()+1);
    {int64 v0=sp();t0=gr(sp(),v0);}
    printf("%lld ", t0);
    return 0;
}
