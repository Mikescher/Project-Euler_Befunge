/* compiled with BefunCompile v1.0.3 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } $3{#}#>k{ } $Vv{ }  '>#{ }  (v#   <{ } #Y>\"d\"4*:10p355***00p00g>1-::20p0\\2/>:20g\\%#^_:30p+30g>1-:#^_$v{ } #l|:p{ }  /+1/g01"
           "g02%g01g02`g02<{ } #Vv{ }  0$p100<{ }  9vp+1/g01+g05g04%g01+g05g04+2%2g+1/g01+g05g04%g01+<{ } #1${ }  0>v{ }  3{>v{ }  2}  \" >v{"
           " }  'v   <    g{ } #1>00g40p>40g1-:40p|>40g10g%40g10g/1+g2%|>40g1+50p>50g1-:50p|>50g10g%50g10g/1+g2%|>40g50g+00g`|    0{ } #8^{ "
           "}  ><{ }  )^{ }  ><{ }  '$<   >40g5^{ } #1v{ }  0<{ }  4^{ }  3<{ } #X>080p00g20p>20g1-20p20g10g%20g10g/1+g2/#v_v{ } #s|g02{ }  "
           "/<p08+g02g0 8<{ } #s>80g.@{ }  -^{ }  )<{ } #j";
int t=0;int z=0;
int64 g[35200];
int d(){int s,w,i,j,h;h=z;for(;t<558;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<400&&y<88){return g[y*400+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<400&&y<88){g[y*400+x]=v;}}
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
    goto _10;
_0:
    if(sp()!=0)goto _13; else goto _27;
_1:
    if(sp()!=0)goto _12; else goto _14;
_2:
    if(sp()!=0)goto _26; else goto _15;
_3:
    if(sp()!=0)goto _8; else goto _21;
_4:
    if(sp()!=0)goto _9; else goto _16;
_5:
    if(sp()!=0)goto _18; else goto _20;
_6:
    if(sp()!=0)goto _22; else goto _24;
_7:
    if((td(gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1)),2))!=0)goto _23;else goto _25;
_8:
    if((tm(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(1)),2))!=0)goto _17;else goto _16;
_9:
    if((tm(gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+(1)),2))!=0)goto _19;else goto _18;
_10:
    gw(1,0,400);
    gw(0,0,30000);
    sa((gr(0,0))-(1));
    sa((gr(0,0))-(1));
    gw(2,0,(gr(0,0))-(1));
    goto _11;
_11:
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    goto _12;
_12:
    sa(sr());
    sa(gr(2,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _0;
_13:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _1;
_14:
    sp();
    sa(gr(2,0));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1),sp());
    sa(sr());
    goto _2;
_15:
    gw(0,1,0);
    gw(4,0,gr(0,0));
    sp();
    sp();
    goto _16;
_16:
    sa((gr(4,0))-(1));
    gw(4,0,(gr(4,0))-(1));
    goto _3;
_17:
    gw(5,0,(gr(4,0))+(1));
    goto _18;
_18:
    sa((gr(5,0))-(1));
    gw(5,0,(gr(5,0))-(1));
    goto _4;
_19:
    sa(((gr(4,0))+(gr(5,0)))>(gr(0,0))?1:0);
    goto _5;
_20:
    gw(tm((gr(4,0))+(gr(5,0)),gr(1,0)),(td((gr(4,0))+(gr(5,0)),gr(1,0)))+(1),(tm(gr(tm((gr(4,0))+(gr(5,0)),gr(1,0)),(td((gr(4,0))+(gr(5,0)),gr(1,0)))+(1)),2))+(2));
    goto _18;
_21:
    gw(8,0,0);
    gw(2,0,gr(0,0));
    goto _22;
_22:
    gw(2,0,(gr(2,0))-(1));
    goto _7;
_23:
    sa(gr(2,0));
    goto _6;
_24:
    printf("%lld", (int64)(gr(8,0)));
    goto __;
_25:
    gw(8,0,(gr(8,0))+(gr(2,0)));
    goto _23;
_26:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    goto _11;
_27:
    sa(sr());
    gw(3,0,sp());
    sa(sp()+sp());
    sa((gr(3,0))-(1));
    sa((gr(3,0))-(1));
    goto _1;
__:
    return 0;
}