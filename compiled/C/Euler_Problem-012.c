/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v     // Project Euler - Problem 12{ } ?4{#}0Zz{ } +@v  p03+1g03 p04+1g04   p +3/g01\\%g01:g04 g03 <{ } )6>\"d\"55+*:10p3\"2\"*:20p*0"
           "0p230p\" \":03p13p{ }  ,v{ }  .>130p040p  > 30g:10g%\\10g/3+g\" \"- 00g30g` !#v_{ }  *|{ } )6v{ }  R<{ }  -_^#`g03g00 <^{ }  8p03+1g0"
           "3{ }  ,<{ } )6> \"X\" 30g:10g%\\10g/3+p30g >30g+ : 00g\\`     #v_$>30g1+:30p:10g%\\10g/3+g\" \"- |{ } )~^p+3/g01\\%g01:\\\" \":<  ^{ }  ;<{"
           " } *(v{ }  \\+1$<{ } )]>:1+2/>:01p31p111p0>::10g%\\10g/3+g::*01g`#v_121p>:31g\\%{ }  )!#v_11g21g*11p31g1-|{ } * v{ }  (<    ^p13/\\g"
           "13:p12+1g12<{ } )jv{ }  6<{ }  *vp21<*2g11$$<^g11$${ }  B<{ } )M>2 212p222p >:2%|{ }  =>12g22g*\"d\"5*` #v_1+    1v{ } *-|{ }  C<{"
           " }  70+1$<{ } )]>:1+  >:01p31p111p0>::10g%\\10g/3+g::*01g`#v_121p>:31g\\%{ }  )!#v_11g21g*11p31g1-|{ } ){#   v{ }  (<  v ^p13/\\g13"
           ":p12+1g12<{ } *-^p22<*2g11$$<^g11$${ }  B<{ } *,>$$:1+*2/.@{ } )h^{ } !%$p05-1g04<{ } )B";
int t=0;int z=0;
int64 g[170000];
int d(){int s,w,i,j,h;h=z;for(;t<856;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<1000&&y<170){return g[y*1000+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<1000&&y<170){g[y*1000+x]=v;}}
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
    gw(1LL,0LL,1000LL);
    gw(2LL,0LL,150LL);
    gw(0LL,0LL,150000LL);
    gw(3LL,0LL,2LL);
    gw(0LL,3LL,32LL);
    gw(1LL,3LL,32LL);
_1:
    gw(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+3LL,88LL);
    sa(gr(3LL,0LL)+gr(3LL,0LL));
    sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
_2:
    if(sp()!=0)goto _34;else goto _3;
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
    gw(3LL,0LL,1LL);
    gw(4LL,0LL,0LL);
_8:
    sa(gr(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+3LL)-32LL);
    if(gr(0L,0L)<=gr(3L,0L))goto _9;else goto _31;
_9:
    gw(5LL,0LL,gr(4LL,0LL)-1LL);
    gw(1LL,2LL,2LL);
    gw(2LL,2LL,2LL);
    sp();
    sa(2LL);
_10:
    sa(sr()+1LL);
    sa(sr());
    gw(0LL,1LL,sp());
    gw(3LL,1LL,sp());
    gw(1LL,1LL,1LL);
    sa(0LL);
    sa(gr(0LL,3LL));
    sa((gr(0L,3L)*gr(0L,3L))>gr(0L,1L)?1:0);
_11:
    if(sp()!=0)goto _30;else goto _12;
_12:
    gw(2LL,1LL,1LL);
_13:
    sa(sr());
    sa(gr(3LL,1LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _29;else goto _14;
_14:
    gw(1LL,1LL,gr(1LL,1LL)*gr(2LL,1LL));
    if(gr(3LL,1LL)!=1LL)goto _15;else goto _16;
_15:
    sp();
    sa(sp()+1LL);
    sa(sr());
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa((sp()>gr(0L,1L))?1:0);
    goto _11;
_16:
    gw(2LL,2LL,gr(1LL,1LL));
    sp();
    sp();
_17:
    if((gr(1L,2L)*gr(2L,2L))>500L)goto _28;else goto _18;
_18:
    sa(sp()+1LL);
    if(tm(sr(),2LL)!=0)goto _19;else goto _10;
_19:
    sa(td(sr()+1LL,2LL));
    sa(sr());
    gw(0LL,1LL,sp());
    gw(3LL,1LL,sp());
    gw(1LL,1LL,1LL);
    sa(0LL);
    sa(gr(0LL,3LL));
    sa((gr(0L,3L)*gr(0L,3L))>gr(0L,1L)?1:0);
_20:
    if(sp()!=0)goto _27;else goto _21;
_21:
    gw(2LL,1LL,1LL);
_22:
    sa(sr());
    sa(gr(3LL,1LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _26;else goto _23;
_23:
    gw(1LL,1LL,gr(1LL,1LL)*gr(2LL,1LL));
    if(gr(3LL,1LL)!=1LL)goto _24;else goto _25;
_24:
    sp();
    sa(sp()+1LL);
    sa(sr());
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa((sp()>gr(0L,1L))?1:0);
    goto _20;
_25:
    gw(1LL,2LL,gr(1LL,1LL));
    sp();
    sp();
    goto _17;
_26:
    gw(2LL,1LL,gr(2LL,1LL)+1LL);
    sa(sr());
    sa(gr(3LL,1LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}
    gw(3LL,1LL,sp());
    goto _22;
_27:
    gw(1LL,2LL,gr(1LL,1LL)*2LL);
    sp();
    sp();
    goto _17;
_28:
    sa(sr()+1LL);
    sa(sp()*sp());
    sa(td(sp(),2L));
    printf("%lld", (int64)(sp()));
    return 0;
_29:
    gw(2LL,1LL,gr(2LL,1LL)+1LL);
    sa(sr());
    sa(gr(3LL,1LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}
    gw(3LL,1LL,sp());
    goto _13;
_30:
    gw(2LL,2LL,gr(1LL,1LL)*2LL);
    sp();
    sp();
    goto _17;
_31:
    if(sp()!=0)goto _32;else goto _33;
_32:
    gw(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+3LL,gr(3LL,0LL));
    gw(4LL,0LL,gr(4LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    goto _8;
_33:
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    goto _8;
_34:
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