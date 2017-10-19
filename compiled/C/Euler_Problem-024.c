/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v0123456789{ }  R>\"ddd\"**1v{ }  Svp129p11-<{ }  Z>v>{v     }  \"<  v    <   >  v   >\\1-\\vv    p14+1g14<>21g:1+|>|>21g0\\>:1-:#^_v>"
           "*\\:#^_$:|  >31p 141p >31g41g*11g`!|{ }  '${ }  ->$1 ^ > p68*v>$1^   |-\"x\" g0:\\<\\1<g14  <{ }  '@ >{ }  *#^0#<#v0#,+ #<$     v>   "
           " >1+\\:|  1      ^p12-1g12p11-*-1g14g13g11 <^\\\"x\"\\-\"0\"g0:>#- #1 #$ #<  ^      ";
int t=0;int z=0;
int64 g[488];
int d(){int s,w,i,j,h;h=z;for(;t<333;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
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
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1,1,999999);
    gw(2,1,9);
_1:
    t0=gr(2,1);

    if(gr(2,1)!=-1)goto _3;else goto _2;
_2:
    return 0;
_3:
    if((t0)!=0)goto _4;else goto _23;
_4:
    sa(0);
    sa(gr(2,1));
    sa(gr(2,1)-1);
    sa(gr(2,1)-1);
_5:
    if(sp()!=0)goto _22;else goto _6;
_6:
    sp();
    sa(sp()*1LL);
_7:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _21;else goto _8;
_8:
    sp();
    sa(sr());

    if(sp()!=0)goto _9;else goto _20;
_9:
    gw(3,1,sp());
_10:
    gw(4,1,1);
_11:
    if((gr(3,1)*gr(4,1))>gr(1,1))goto _12;else goto _19;
_12:
    sa(gr(4,1));
_13:
    sa(1);
    sa(gr(1,0)-120);
_14:
    if(sp()!=0)goto _18;else goto _15;
_15:
    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _17;else goto _16;
_16:
    sp();
    sa(sp()-1LL);

    sa(sr());
    sa(0);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=48;
    sa(120);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(1,1,gr(1,1)-(gr(3,1)*(gr(4,1)-1)));
    gw(2,1,gr(2,1)-1);
    t0+=48;
    printf("%c", (char)(t0));
    goto _1;
_17:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-120LL);
    goto _14;
_18:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _15;
_19:
    gw(4,1,gr(4,1)+1);
    goto _11;
_20:
    gw(3,1,1);
    sp();
    goto _10;
_21:
    sa(sp()*sp());
    goto _7;
_22:
    sa(sr()-1);
    sa(sr());
    goto _5;
_23:
    t0=0;
    sa(1);
    goto _13;
}
