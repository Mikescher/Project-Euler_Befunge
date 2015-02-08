/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ }  *// Project Euler - Problem 37{ } ^f{#}~~~{#}/l?{ } 5%>\"d\"45**:10p5\"d\"*:20p*00p230p\" \":03p13pv    v075320{ }  (p090<{ } 4D"
           "v{ }  F<{ }  6_^#`g03g00<{ } 4;>\"X\"30g:10g%\\10g/3+p30g>30g+:00g\\`{ }  '#v_$>30g1+:30p:10g%\\10g/3+g\" \"-|{ } 4>>90g\"= \",,.@{ }  (^"
           "p+3/g01\\%g01:\\\" \":<  ^{ }  :<{ } 4;v{ }  K<{ } !'<{ } 3Yv{ }  ,>#{ }  7># $#{ }  vv# -1<{ } 3i$   >v{ }  I>$\\{ }  *v{ }  D< >::."
           "55+,90g+90pv{ } 3Y>:!#v_70p9> :70g55+*+:00g\\`|>::10g%\\10g/3+g\"X\"-#^_::55+\\`#v_:55+/1\\:!#^_55+/\\55+*\\v>::10g%\\10g/3+g\"X\"-#v_\\:50p"
           "%50g55+/\\:|>|{ }  .>\\>:1-#^_$^{ } 3S>$\"= \",,90g.@      ^   <{ }  >>${ }  *#^!:{ }  '#<{ }  4>$$0{ }  )>    ^>{ }  .^{ } 4n^1$$<{"
           " } 3j";
int t=0;int z=0;
int64 g[1028000];
int d(){int s,w,i,j,h;h=z;for(;t<645;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<2000&&y<514){return g[y*2000+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<2000&&y<514){g[y*2000+x]=v;}}
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
    goto _6;
_0:
    if(sp()!=0)goto _8; else goto _9;
_1:
    if(sp()!=0)goto _24; else goto _10;
_2:
    if(sp()!=0)goto _23; else goto _12;
_3:
    if(sp()!=0)goto _25; else goto _13;
_4:
    if(sp()!=0)goto _19; else goto _18;
_5:
    if(sp()!=0)goto _20; else goto _22;
_6:
    gw(1,0,2000);
    gw(2,0,500);
    gw(0,0,1000000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
    goto _7;
_7:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3),88);
    sa((gr(3,0))+(gr(3,0)));
    sa((gr(0,0))>((gr(3,0))+(gr(3,0)))?1:0);
    goto _0;
_8:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(gr(3,0));
    sa(sp()+sp());
    sa(sr());
    sa(gr(0,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _0;
_9:
    sp();
    goto _10;
_10:
    sa((gr(3,0))+(1));
    gw(3,0,(gr(3,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(32);
    {int64 v0=sp();sa(sp()-v0);}
    goto _1;
_11:
    gw(9,0,0);
    sa(0);
    sa(2);
    sa(3);
    sa(5);
    sa(7);
    sa(0);
    goto _2;
_12:
    gw(7,0,sp());
    sa(9);
    sa((9)+((gr(7,0))*(10)));
    sa((gr(0,0))>((9)+((gr(7,0))*(10)))?1:0);
    goto _3;
_13:
    sp();
    goto _30;
_14:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa((gr(7,0))*(10));
    sa(sp()+sp());
    sa(sr());
    sa(gr(0,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _3;
_15:
    sp();
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _2;
_16:
    sp();
    sa((sp()!=0)?0:1);
    sa(sr());
    goto _17;
_17:
    sp();
    sp();
    sa(0);
    goto _4;
_18:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _30;
_19:
    sa(sr());
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(10));
    sa(gr(9,0));
    sa(sp()+sp());
    gw(9,0,sp());
    goto _18;
_20:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _28;
_21:
    sp();
    sp();
    sa(1);
    goto _4;
_22:
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _5;
_23:
    sp();
    sa(61);
    printf("%c", (char)(32));
    printf("%c", (char)(sp()));
    printf("%lld", (int64)(gr(9,0)));
    return 0;
_24:
    sa((gr(0,0))>(gr(3,0))?1:0);
    if(sp()!=0)goto _7; else goto _11;
_25:
    sa(sr());
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(88);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _13; else goto _26;
_26:
    sa(sr());
    sa(sr());
    sa(10);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _16; else goto _27;
_27:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _20; else goto _22;
_28:
    sa(sr());
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(88);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _17; else goto _29;
_29:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    gw(5,0,sp());
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(td(gr(5,0),10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _28; else goto _21;
_30:
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _14; else goto _15;
}