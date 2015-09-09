/* compiled with BefunCompile v1.0.8 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{XXX {#}  f }  \"    {#}  f{ }  k>{ }  (\"c\"v  _v#   `*95:<{ }  Pv+\"I~\"<\\\"c\":<{ }  '>:55+%|{ }  P>1-:0\\:\"F\"%v    >1-:|:-1  <{ }  "
           "P|:p/\"F\"\\+5 <@.g1$#2$<{ }  V>$188*2p020p10p>030p\"~J\"+>1-:::\"F\"%5+\\\"F\"/g10g*20g+:55+/v{ }  7>21p > 1-:|^$<      |:p/\"F\"\\+5%\"F\":\\p"
           "03+g03:%+55p02<{ }  7^g03_^#`g1># ^#2g03$<{ }  Q";
int t=0;int z=0;
int64 g[825];
int d(){int s,w,i,j,h;h=z;for(;t<304;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<75&&y<11){return g[y*75+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<75&&y<11){g[y*75+x]=v;}}
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
    gw(63,2,0);
    sa(99);
    sa(99);
    sa(99);
_1:
    sa(197);
_2:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),70))+5);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),70));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    if(sp()!=0)goto _18;else goto _3;
_3:
    gw(64,2,1);
    gw(2,0,0);
    sp();
    gw(1,0,sp());
_4:
    gw(3,0,0);
    sa(199);
    sa(199);
    sa((gr(64,2)*gr(1,0))+gr(2,0));
    gw(2,0,td((gr(64,2)*gr(1,0))+gr(2,0),10));
_5:
    sa(tm(sp(),10));
    t0=sr()+gr(3,0);
    gw(3,0,t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),70))+5);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),70));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    if(sp()!=0)goto _17;else goto _6;
_6:
    sp();
    if(gr(3,0)>gr(2,1))goto _16;else goto _7;
_7:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _4;else goto _8;
_8:
    sp();
_9:
    sa(sp()-1LL);
    sa(sr());
_10:
    if(sp()!=0)goto _12;else goto _11;
_11:
    printf("%lld", gr(2,1));
    sp();
    return 0;
_12:
    if(tm(sr(),10)!=0)goto _14;else goto _13;
_13:
    sa(sp()-1LL);
    sa(sr());
    goto _10;
_14:
    if(sr()>45)goto _15;else goto _9;
_15:
    gw(63,2,0);
    sa(sr());
    sa(99);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _1;
_16:
    gw(2,1,gr(3,0));
    goto _7;
_17:
    sa(sp()-1LL);
    sa(sr());
    sa(sr());
    sa((tm(sr(),70))+5);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),70));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(1,0));
    sa(sp()+gr(2,0));
    t0=td(sr(),10);
    gw(2,0,t0);
    goto _5;
_18:
    sa(sp()-1LL);
    goto _2;
}