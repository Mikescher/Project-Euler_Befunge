/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    gw(1LL,0LL,2000LL);
    gw(2LL,0LL,500LL);
    gw(0LL,0LL,1000000LL);
    gw(3LL,0LL,2LL);
    gw(0LL,3LL,32LL);
    gw(1LL,3LL,32LL);
_1:
    gw(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+3LL,88LL);
    sa(gr(3LL,0LL)+gr(3LL,0LL));
    sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
_2:
    if(sp()!=0)goto _27;else goto _3;
_3:
    sp();
_4:
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-32LL);
    if(sp()!=0)goto _6;else goto _4;
_6:
    if(gr(0L,0L)>gr(3L,0L))goto _1;else goto _7;
_7:
    gw(9LL,0LL,0LL);
    sa(0LL);
    sa(2LL);
    sa(3LL);
    sa(5LL);
    sa(7LL);
_8:
    gw(7LL,0LL,sp());
    sa(9LL);
    sa(9LL+(gr(7LL,0LL)*10LL));
    sa((9L+(gr(7L,0L)*10L))<gr(0L,0L)?1:0);
_9:
    if(sp()!=0)goto _10;else goto _26;
_10:
    sa(sr());
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-88LL);
    if(sp()!=0)goto _26;else goto _11;
_11:
    sa(sr());
    if(sr()<10L)goto _25;else goto _12;
_12:
    sa(td(sr(),10LL));
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15;else goto _13;
_13:
    sa(td(sp(),10L));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*10LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15;else goto _13;
_15:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_16:
    sa(sr());
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-88LL);
    if(sp()!=0)goto _24;else goto _17;
_17:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    gw(5LL,0LL,sp());
    {int64 v0=sp();sa(tm(sp(),v0));}
    sa(td(gr(5LL,0LL),10LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _16;else goto _18;
_18:
    sp();
    sp();
    sa(sr());
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("\n");
    sa(sp()+gr(9LL,0LL));
    gw(9LL,0LL,sp());
_19:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_20:
    if(sr()!=1LL)goto _23;else goto _21;
_21:
    sp();
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _22;else goto _8;
_22:
    sp();
    sa(61LL);
    printf(" ");
    printf("%c", (char)(sp()));
    printf("%lld", (int64)(gr(9LL,0LL)));
    return 0;
_23:
    sa(sp()-1LL);
    sa(sr()+gr(7LL,0LL)*10LL);
    sa(sr()<gr(0L,0L)?1:0);
    goto _9;
_24:
    sp();
    sp();
    goto _19;
_25:
    sp();
    sa((sp()!=0)?0:1);
    sa(sr());
    goto _24;
_26:
    sp();
    goto _20;
_27:
    sa(sr());
    sa(32LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3LL,0LL));
    sa(sr()<gr(0L,0L)?1:0);
    goto _2;
}