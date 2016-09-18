/* compiled with BefunCompile v1.0.8 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v      # {#} *R{ }  ({#} *R   {X   # {#} *R{ }  ({#} *R XX}  \"{    # {#} *R{ }  ({#} *R X }  \"    {# {#} *R{ }  ({#} *R{ }  '}  "
           "## {#} *R{ }  ({#} *R CCC   {# {#} *R{ }  ({#} *R{ }  '} *H# {#} *R{ }  ({#} *R{ } 56>\";}\"8*19p\"q\"9*29p\";};}@\"**39p012p014p39g15"
           "p39g>1-:0\\:19g/9+\\19g%p v{ } 4Tv{ }  2<{ }  8|:p%g91\\+g92/g91:\\0:<{ } 4T1     v+1p%g91\\+g92 /g91:\\+g31g%g91\\+g92/g91 ::<{ } 4e>:"
           "13p2>:13g*:39g\\`#^{ }  4#$ #<  |{ } 4e^_$# 6# v#{ }  <-g93:+1$$<{ }  Dvp51g\\7:<{ } 48v{ }  '<{ }  ,>v>g+\\19g%g22p{v      >}  \"v "
           "    >v{ }  +>{ }  Cv{ } 4*> :23p :19g/9+\\19g%g!|> 23g:70p11v >22g:0`|>:39g\\`|>:23g-|$  >:7\\g22g-|{ }  -#      > 32g14p:7\\g15pv{ "
           "} 4*|     -g93:+1    g32 <{ }  3$<{ }  '<      <0  ^     <  >131p:12g\\-32p32g14g`||*g13`\\g51g\\7:<{ } 4*>$15g.@{ }  0^92/g91:p2< "
           "^p22g%g<{ }  />31p032p0^{ }  '<{ }  /v{ } 4O>9g%p22g:19g/29g+\\19^{ }  :v<    |-g21:+1{ <      }  \"{ } 4G^{ }  =<{ }  1<|g13${<{ "
           "}  /}  \"{ } 4@^1\\+9/g91:\\1pp21+1:g217:g22<_^#!g%g91\\+9/g91:g22<{ } 4N";
int t=0;int z=0;
int64 g[2043221];
int d(){int s,w,i,j,h;h=z;for(;t<965;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<2017&&y<1013){return g[y*2017+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<2017&&y<1013){g[y*2017+x]=v;}}
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
    gw(1,9,1000);
    gw(2,9,1017);
    gw(3,9,1000000);
    gw(1,2,0);
    gw(1,4,0);
    gw(1,5,gr(3,9));
    sa(gr(3,9)-1);
    gw((td(gr(3,9)-1,gr(1,9)))+9,tm(gr(3,9)-1,gr(1,9)),0);
_1:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((td(sr(),gr(1,9)))+gr(2,9));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    if(sp()!=0)goto _28;else goto _2;
_2:
    gw(1,3,1);
    sp();
    sa(1);
_3:
    sa(2);
    sa(2*gr(1,3));
    sa((2*gr(1,3))<gr(3,9)?1:0);
_4:
    if(sp()!=0)goto _27;else goto _5;
_5:
    sp();
    sp();
    sa(sp()+1LL);
    if(sr()!=gr(3,9))goto _6;else goto _7;
_6:
    sa(sr());
    gw(1,3,sp());
    goto _3;
_7:
    gw(2,3,6);
    sp();
    sa(((gr((td(6,gr(1,9)))+9,tm(6,gr(1,9))))!=0)?0:1);
_8:
    if(sp()!=0)goto _12;else goto _9;
_9:
    sa(gr(2,3)+1);
    if((gr(2,3)+1)!=gr(3,9))goto _10;else goto _11;
_10:
    sa(sr());
    gw(2,3,sp());
    sa((td(sr(),gr(1,9)))+9);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    goto _8;
_11:
    printf("%lld", gr(1,5));
    sp();
    return 0;
_12:
    sa(gr(2,3));
    gw(7,0,gr(2,3));
    gw(1,2,1);
    sa((td(sr(),gr(1,9)))+gr(2,9));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));
    {int64 v0=sp();t0=gr(sp(),v0);}
    gw(2,2,t0);
_13:
    t0=gr(2,2);
    if(gr(2,2)>0)goto _14;else goto _9;
_14:
    if(t0<gr(3,9))goto _15;else goto _9;
_15:
    if(t0!=gr(2,3))goto _16;else goto _9;
_16:
    gw(3,1,0);
    gw(3,2,0);
    sa(0);
    sa(gr(7,0)-gr(2,2));
_17:
    if(sp()!=0)goto _23;else goto _18;
_18:
    gw(3,1,1);
    sa(sr());
    t0=gr(1,2);
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    t1=sp();
    gw(3,2,t1);
    if(gr(3,2)>gr(1,4))goto _22;else goto _19;
_19:
    sp();
    if((gr(3,1))!=0)goto _9;else goto _20;
_20:
    if((gr((td(gr(2,2),gr(1,9)))+9,tm(gr(2,2),gr(1,9))))==0)goto _21;else goto _9;
_21:
    sa(gr(2,2));
    sa(gr(2,2));
    sa(7);
    sa(gr(1,2));
    gw(1,2,gr(1,2)+1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((td(sr(),gr(1,9)))+9);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(2,2,gr((td(gr(2,2),gr(1,9)))+gr(2,9),tm(gr(2,2),gr(1,9))));
    goto _13;
_22:
    gw(1,4,gr(3,2));
    sa(sr());
    sa(7);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();t0=gr(sp(),v0);}
    gw(1,5,t0);
_23:
    sa(sr());
    sa(7);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0=t0<gr(1,5)?1:0;
    t0*=gr(3,1);
    if((t0)!=0)goto _26;else goto _24;
_24:
    sa(sp()+1LL);
    if(sr()!=gr(1,2))goto _25;else goto _19;
_25:
    sa(sr());
    sa(7);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-gr(2,2));
    goto _17;
_26:
    sa(sr());
    sa(7);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();t0=gr(sp(),v0);}
    gw(1,5,t0);
    goto _24;
_27:
    sa(sr());
    sa((td(sr(),gr(1,9)))+gr(2,9));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()+gr(1,3));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((td(sr(),gr(1,9)))+gr(2,9));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+1LL);
    sa(sr()*gr(1,3));
    sa(sr()<gr(3,9)?1:0);
    goto _4;
_28:
    sa(sp()-1LL);
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((td(sr(),gr(1,9)))+9);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _1;
}