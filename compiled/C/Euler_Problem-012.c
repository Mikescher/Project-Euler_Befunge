/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    int64 t0,t1;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1,0,1000);
    gw(2,0,150);
    gw(0,0,150000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
_1:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
_2:
    if(sp()!=0)goto _35;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sp(),gr(1,0)));

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    if((t0)!=0)goto _6;else goto _4;
_6:
    if(gr(0,0)>gr(3,0))goto _1;else goto _7;
_7:
    gw(3,0,1);
    gw(4,0,0);
_8:
    t0=gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3)-32;

    if(gr(0,0)>gr(3,0))goto _32;else goto _9;
_9:
    gw(5,0,gr(4,0)-1);
    gw(1,2,2);
    gw(2,2,2);
    sa(2);
    sa(0);
_10:
    if(sp()!=0)goto _23;else goto _11;
_11:
    sa(sr()+1);
    sa(sr());
    gw(0,1,sp());
    gw(3,1,sp());
    gw(1,1,1);
    sa(0);
    sa(gr(0,3));
    sa((gr(0,3)*gr(0,3))>gr(0,1)?1:0);
_12:
    if(sp()!=0)goto _22;else goto _13;
_13:
    gw(2,1,1);
_14:
    t0=gr(3,1);
    sa(sr());
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}

    t1=sp();

    if((t1)!=0)goto _15;else goto _21;
_15:
    gw(1,1,gr(1,1)*gr(2,1));

    if(gr(3,1)!=1)goto _16;else goto _17;
_16:
    sp();
    sa(sp()+1LL);

    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa((sp()>gr(0,1))?1:0);
    goto _12;
_17:
    gw(2,2,gr(1,1));
    sp();
    sp();
_18:
    if((gr(1,2)*gr(2,2))>500)goto _20;else goto _19;
_19:
    sa(sp()+1LL);

    sa(sr()%2);
    goto _10;
_20:
    t0=1;
    t1=1;
    t0=sr()+1;
    sa(sp()*t0);

    t1=sp();
    t1/=2;
    printf("%lld ", t1);
    return 0;
_21:
    gw(2,1,gr(2,1)+1);
    t0=gr(3,1);
    sa(sr());
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}

    t1=sp();
    gw(3,1,t1);
    goto _14;
_22:
    gw(2,2,gr(1,1)*2);
    sp();
    sp();
    goto _18;
_23:
    sa((sr()+1)/2);
    sa(sr());
    gw(0,1,sp());
    gw(3,1,sp());
    gw(1,1,1);
    sa(0);
    sa(gr(0,3));
    sa((gr(0,3)*gr(0,3))>gr(0,1)?1:0);
_24:
    if(sp()!=0)goto _31;else goto _25;
_25:
    gw(2,1,1);
_26:
    t0=gr(3,1);
    sa(sr());
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}

    t1=sp();

    if((t1)!=0)goto _27;else goto _30;
_27:
    gw(1,1,gr(1,1)*gr(2,1));

    if(gr(3,1)!=1)goto _28;else goto _29;
_28:
    sp();
    sa(sp()+1LL);

    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa((sp()>gr(0,1))?1:0);
    goto _24;
_29:
    gw(1,2,gr(1,1));
    sp();
    sp();
    goto _18;
_30:
    gw(2,1,gr(2,1)+1);
    t0=gr(3,1);
    sa(sr());
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(td(sp(),v0));}

    t1=sp();
    gw(3,1,t1);
    goto _26;
_31:
    gw(1,2,gr(1,1)*2);
    sp();
    sp();
    goto _18;
_32:
    if((t0)!=0)goto _33;else goto _34;
_33:
    gw(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3,gr(3,0));
    gw(4,0,gr(4,0)+1);
    gw(3,0,gr(3,0)+1);
    goto _8;
_34:
    gw(3,0,gr(3,0)+1);
    goto _8;
_35:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(0,0)?1:0);
    goto _2;
}
