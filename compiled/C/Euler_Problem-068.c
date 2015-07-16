/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v  X   X {#}  *{ }  9X   {O}  *{ }  4>\":\"v   v{ }  ;< <v   <   vp1+9-\"0\"g0+9p03:-1g03\"O\"    < >90p030p>30g9+0g1-:30g9+0p\"0\"-:70p"
           "0\\`| v   g03_^#!{ }  )-\"O\"g1+9g07     #<$>:#v_70g5`{ }  ;>|v-1< v  _v#!`g039${ }  4<>:#v_     70g9-!{ }  5^ v-1<     >\"X\"70g9+1p"
           "\":\"30g1+:30p9+0p^  >:#v_ 90+0g91+0g92+0g++51p70g9-!     ^ v-1< >91+0g\"/\"- 98+0g\"/\"- 99+0g\"/\"- v  >:#v_90g\"0\"-70g`{ }  5^ v-1< v-"
           "\"/\"g0+79 -\"/\"g0+69 -\"/\"g0+89 <  >:#v_ 92+0g93+0g94+0g++51g-!!70g9-!+ ^ v-1< >96+0g\"/\"- 94+0g\"/\"- 95+0g\"/\"- v  >:#v_90g\"0\"-70g`{ "
           "}  5^ v-1< v-\"/\"g0+39 -\"/\"g0+29 -\"/\"g0+49 <  >:#v_ 94+0g95+0g96+0g++51g-!!70g9-!+ ^ v-1< >92+0g\"/\"- 91+0g\"/\"- 90+0g\"/\"- v  >:#v_"
           "90g\"0\"-70g`{ }  5^ v-1<{ }  +@{ ...}  %<  >:#v_96+0g97+0g98+0g++51g-!!70g9-!+  ^ v89<{ }  C>+0g99+0g91+0g++51g-!!90g\"0\"-70g`!!+ "
           "^ ";
int t=0;int z=0;
int64 g[975];
int d(){int s,w,i,j,h;h=z;for(;t<770;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<39&&y<25){return g[y*39+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<39&&y<25){g[y*39+x]=v;}}
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
    gw(9LL,0LL,58LL);
    gw(3LL,0LL,0LL);
_1:
    sa(gr(gr(3LL,0LL)+9LL,0LL)-1LL);
    gw(gr(3LL,0LL)+9LL,0LL,gr(gr(3LL,0LL)+9LL,0LL)-1LL);
    sa(sp()-48LL);
    sa(sr());
    gw(7LL,0LL,sp());
    sa((sp()<0L)?1:0);
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(79LL);
    sa(gr(3LL,0LL)-1LL);
    gw(3LL,0LL,gr(3LL,0LL)-1LL);
    sa(sp()+9LL);
    sa(0LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    sa(sp()+9LL);
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _1;
_3:
    if(gr(gr(7L,0L)+9L,1L)-79L==0)goto _4;else goto _1;
_4:
    sa(gr(3LL,0LL));
    if((gr(3LL,0LL))!=0)goto _5;else goto _27;
_5:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _6;else goto _26;
_6:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _7;else goto _25;
_7:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _8;else goto _24;
_8:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _9;else goto _23;
_9:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _10;else goto _22;
_10:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _11;else goto _21;
_11:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _12;else goto _20;
_12:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _19;else goto _13;
_13:
    sa((((gr(15L,0L)+gr(16L,0L)+gr(17L,0L))-gr(5L,1L)!=0)?1:0)+((gr(7L,0L)-9L!=0)?0:1));
_14:
    if(sp()!=0)goto _18;else goto _15;
_15:
    sp();
    if(9L<=gr(3L,0L))goto _16;else goto _17;
_16:
    sa(gr(10LL,0LL)-47LL);
    sa(gr(17LL,0LL)-47LL);
    sa(gr(18LL,0LL)-47LL);
    sa(gr(17LL,0LL)-47LL);
    sa(gr(15LL,0LL)-47LL);
    sa(gr(16LL,0LL)-47LL);
    sa(gr(15LL,0LL)-47LL);
    sa(gr(13LL,0LL)-47LL);
    sa(gr(14LL,0LL)-47LL);
    sa(gr(13LL,0LL)-47LL);
    sa(gr(11LL,0LL)-47LL);
    sa(gr(12LL,0LL)-47LL);
    sa(gr(11LL,0LL)-47LL);
    sa(gr(10LL,0LL)-47LL);
    printf("%lld", (int64)(gr(9LL,0LL)-47LL));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    printf("%lld", (int64)(sp()));
    return 0;
_17:
    gw(gr(7LL,0LL)+9LL,1LL,88LL);
    sa(58LL);
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(sp()+9LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _1;
_18:
    sp();
    goto _1;
_19:
    sa((((gr(17L,0L)+gr(18L,0L)+gr(10L,0L))-gr(5L,1L)!=0)?1:0)+((gr(9L,0L)-48L)>gr(7L,0L)?1:0));
    goto _14;
_20:
    sa((gr(9L,0L)-48L)>gr(7L,0L)?1:0);
    goto _14;
_21:
    sa((((gr(13L,0L)+gr(14L,0L)+gr(15L,0L))-gr(5L,1L)!=0)?1:0)+((gr(7L,0L)-9L!=0)?0:1));
    goto _14;
_22:
    sa((gr(9L,0L)-48L)>gr(7L,0L)?1:0);
    goto _14;
_23:
    sa((((gr(11L,0L)+gr(12L,0L)+gr(13L,0L))-gr(5L,1L)!=0)?1:0)+((gr(7L,0L)-9L!=0)?0:1));
    goto _14;
_24:
    sa((gr(9L,0L)-48L)>gr(7L,0L)?1:0);
    goto _14;
_25:
    gw(5LL,1LL,gr(9LL,0LL)+gr(10LL,0LL)+gr(11LL,0LL));
    sa((gr(7L,0L)-9L!=0)?0:1);
    goto _14;
_26:
    sa((gr(7L,0L)-9L!=0)?0:1);
    goto _14;
_27:
    sa(gr(7L,0L)>5L?1:0);
    goto _14;
}