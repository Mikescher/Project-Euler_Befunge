/* compiled with BefunCompile v1.0.5 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v0123456789{ }  R>\"ddd\"**1v{ }  Svp129p11-<{ }  Z>v>{v     }  \"<  v    <   >  v   >\\1-\\vv    p14+1g14<>21g:1+|>|>21g0\\>:1-:#^_$>"
           "*\\:#^_$:|  >31p 141p >31g41g*11g`!|{ }  '${ }  :>$1^   |-\"x\" g0:\\<\\1<g14  <{ }  '@ >{ }  >v>    >1+\\:|  1      ^p12-1g12p11-*-1g"
           "14g13g11.p0\\\"x\"\\-\"0\"g0:>#- #1 #$ #<  ^      ";
int t=0;int z=0;
int64 g[488];
int d(){int s,w,i,j,h;h=z;for(;t<300;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<61&&y<8){return g[y*61+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<61&&y<8){g[y*61+x]=v;}}
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
    gw(1,1,999999);
    gw(2,1,9);
_1:
    sa(gr(2,1));
    if((gr(2,1)+1)!=0)goto _3;else goto _2;
_2:
    sp();
    return 0;
_3:
    if(sp()!=0)goto _11;else goto _4;
_4:
    sa(1);
_5:
    sa(1);
    sa(gr(1,0)-120);
_6:
    if(sp()!=0)goto _10;else goto _7;
_7:
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _9;else goto _8;
_8:
    sp();
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(120);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(1,1,gr(1,1)-(gr(3,1)*(gr(4,1)-1)));
    gw(2,1,gr(2,1)-1);
    printf("%lld", (int64)(sp()));
    goto _1;
_9:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(120);
    {int64 v0=sp();sa(sp()-v0);}
    goto _6;
_10:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _7;
_11:
    sa(0);
    sa(gr(2,1));
    sa(gr(2,1)-1);
    sa(gr(2,1)-1);
_12:
    if(sp()!=0)goto _22;else goto _13;
_13:
    sp();
_14:
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _14;else goto _16;
_16:
    sp();
    sa(sr());
    if(sp()!=0)goto _17;else goto _21;
_17:
    gw(3,1,sp());
    gw(4,1,1);
_18:
    sa((((gr(3,1)*gr(4,1))>(gr(1,1))?1:0)!=0)?0:1);
    if(sp()!=0)goto _20;else goto _19;
_19:
    sa(gr(4,1));
    goto _5;
_20:
    gw(4,1,gr(4,1)+1);
    goto _18;
_21:
    gw(3,1,1);
    gw(4,1,1);
    sp();
    goto _18;
_22:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _12;
}