/* compiled with BefunCompile v1.0.5 (c) 2015 */
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
    gw(1,0,100);
    gw(0,0,0);
_1:
    sa(gr(1,0));
    gw(0,0,gr(1,0)+gr(0,0));
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    if(sp()!=0)goto _2;else goto _3;
_2:
    gw(1,0,sp());
    goto _1;
_3:
    gw(1,0,0);
    sp();
_4:
    sa(99);
    sa(gr(1,0));
    gw(tm(gr(1,0),10),(td(gr(1,0),10))+6,(gr(1,0)+1)*(gr(1,0)+1));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _18;else goto _5;
_5:
    sa(gr(0,0));
    gw(1,0,gr(0,0));
_6:
    sa(gr(1,0)-1);
    gw(1,0,gr(1,0)-1);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _7;else goto _17;
_7:
    gw(1,0,99);
_8:
    sa(sp()+sp());
_9:
    sa(sr());
    sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+6));
    if((((gr(tm(gr(1,0),10),(td(gr(1,0),10))+6))!=0)?0:1)!=0)goto _16;else goto _10;
_10:
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _15;else goto _11;
_11:
    sa(gr(1,0));
    gw(1,0,gr(1,0)-1);
    if(sp()!=0)goto _9;else goto _12;
_12:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _13;else goto _14;
_13:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_14:
    gw(1,0,99);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _8;
_15:
    sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+6));
    gw(tm(gr(1,0),10),(td(gr(1,0),10))+6,0);
    {int64 v0=sp();sa(sp()-v0);}
    goto _11;
_16:
    sp();
    sp();
    goto _11;
_17:
    sa(gr(0,0));
    goto _6;
_18:
    gw(1,0,gr(1,0)+1);
    goto _4;
}