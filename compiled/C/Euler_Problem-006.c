/* compiled with BefunCompile v1.0.3 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "\"d\"10p000p>10g:00g+00p1-:#v_$010p>\"c\"10g::1+:*\\:5:+%\\5:+/6+p`#v_{ }  'v>$.@      ^{ }  ,p01<      ^{ }  3p01+1g01 <{ }  (0     >"
           "{ }  Cv{ }  >|!:\\<|p01-1:g01<$$_v#!:g+6/+:5\\%+:5:g01 :< p01\"c\"+<_v#!p01:-1g01<p01:g0<\\   ^<{ }  ->` >{ }  1#v_v{ }  <>{ }  )v{ }"
           "  ,v-g+6/+:5\\%+:5:g01<{ }  *>00g{ }  (^{ }  '{#}  *>{ }  G^{ }  5{#}  *{ }  ->010g:5:+%\\5:+/6+pv{ }  >{#}  *{ }  ^{#}  *     ^{ "
           "}  9< <{ }  <{#}  *{ }  ^{#}  *{ }  ^{#}  *{ }  ^{#}  *{ }  ^{#}  *{ }  ^{#}  *{ }  ^";
int t=0;int z=0;
int64 g[1152];
int d(){int s,w,i,j,h;h=z;for(;t<469;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<72&&y<16){return g[y*72+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<72&&y<16){g[y*72+x]=v;}}
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    d();
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _7;
_0:
    if(sp()!=0)goto _25; else goto _9;
_1:
    if(sp()!=0)goto _11; else goto _12;
_2:
    if(sp()!=0)goto _15; else goto _14;
_3:
    if(sp()!=0)goto _17; else goto _21;
_4:
    if(sp()!=0)goto _23; else goto _22;
_5:
    if(sp()!=0)goto _19; else goto _20;
_6:
    if((((gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)))!=0)?0:1)!=0)goto _24;else goto _18;
_7:
    gw(1,0,100);
    gw(0,0,0);
    goto _8;
_8:
    sa(gr(1,0));
    gw(0,0,(gr(1,0))+(gr(0,0)));
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _0;
_9:
    gw(1,0,0);
    sp();
    goto _10;
_10:
    sa(99);
    sa(gr(1,0));
    gw(tm(gr(1,0),10),(td(gr(1,0),10))+(6),((gr(1,0))+(1))*((gr(1,0))+(1)));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _1;
_11:
    gw(1,0,(gr(1,0))+(1));
    goto _10;
_12:
    sa(gr(0,0));
    gw(1,0,gr(0,0));
    goto _13;
_13:
    sa((gr(1,0))-(1));
    gw(1,0,(gr(1,0))-(1));
    sa((sp()!=0)?0:1);
    goto _2;
_14:
    sa(gr(0,0));
    goto _13;
_15:
    gw(1,0,99);
    goto _16;
_16:
    sa(sp()+sp());
    goto _17;
_17:
    sa(sr());
    sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)));
    goto _6;
_18:
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _5;
_19:
    sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)));
    gw(tm(gr(1,0),10),(td(gr(1,0),10))+(6),0);
    {int64 v0=sp();sa(sp()-v0);}
    goto _20;
_20:
    sa(gr(1,0));
    gw(1,0,(gr(1,0))-(1));
    goto _3;
_21:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _4;
_22:
    gw(1,0,99);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _16;
_23:
    sp();
    printf("%lld", (int64)(sp()));
    goto __;
_24:
    sp();
    sp();
    goto _20;
_25:
    gw(1,0,sp());
    goto _8;
__:
    return 0;
}