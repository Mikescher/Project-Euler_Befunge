/* compiled with BefunCompile v1.0.7 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v00000 00  // Project Euler - Problem 77{ }  ^XXXXXX{ }  ~{#} !&{ } !&{#} :W{ } !&> \"e\" :10p 1 :20p*40p230p\" \":02p12pvv03:+1g03<"
           "{ }  (>030p    0>::10g%\\10g/2+g\"X\"-#v_:30g:1+30p:v   v{ }  B<># p# :#  v#     _^#`g03g04<|-g04:+1{ }  ,<p+2/g01\\%g01<   >\"X\"30g:"
           "10g%\\10g/2+p30g>30g+:40g\\`{ }  '#v_$^>10g%\\10g/2+g\" \"-|>$30g:50p10g*>1-:0\\:10g%\\10g/4+pv{ }  ;^p+2/g01\\%g01:\\\" \":<  ^{ }  1<{ } "
           " -^_v#:{ }  .<    vp08\"d\"p07*\";}(\"${ }  _<{ }  50{ }  S>061p31g>:0\\`#v_:4+51g\\g61g+61pv{ }  1>1+:11p021p031p>31g:50g-\\2g:41p11g`"
           "!*!#v_11g41g-:51p|{ }  '^-1{ }  4<{ }  1^{ }  ;_v#!`g07g12<{ }  ,>111g31g4+pv  >$21g61g:1v{ }  G^{ }  -># 1# 1# g# .# @#{ }  )p1"
           "3+1g13<p12+p+4g13g1<{ }  8";
int t=0;int z=0;
int64 g[3939];
int d(){int s,w,i,j,h;h=z;for(;t<666;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<101&&y<39){return g[y*101+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<101&&y<39){g[y*101+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0,t1,t2;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1,0,101);
    gw(2,0,1);
    gw(4,0,101);
    gw(3,0,2);
    gw(0,2,32);
    gw(1,2,32);
_1:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+2,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
_2:
    if(sp()!=0)goto _27;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));
    sa(sp()+2LL);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0=t0-32;
    if((t0)!=0)goto _6;else goto _4;
_6:
    if(gr(4,0)>gr(3,0))goto _1;else goto _7;
_7:
    gw(3,0,0);
    sa(0);
    sa(gr(0,2)-88);
_8:
    if(sp()!=0)goto _9;else goto _26;
_9:
    sa(sp()+1LL);
    if(sr()!=gr(4,0))goto _25;else goto _10;
_10:
    sp();
    sa(gr(3,0));
    gw(5,0,gr(3,0));
    sa(sp()*gr(1,0));
_11:
    sa(sp()-1LL);
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));
    sa(sp()+4LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    if(sp()!=0)goto _11;else goto _13;
_13:
    gw(7,0,5000);
    gw(8,0,100);
    gw(1,1,1);
    gw(2,1,0);
    gw(3,1,0);
    sp();
    sa(1);
_14:
    t0=gr(3,1)-gr(5,0);
    t1=gr(gr(3,1),2);
    gw(4,1,gr(gr(3,1),2));
    t1=t1>gr(1,1)?1:0;
    t1=(t1!=0)?0:1;
    t2=t0*t1;
    t2=(t2!=0)?0:1;
    if((t2)!=0)goto _22;else goto _15;
_15:
    t0=gr(1,1)-gr(4,1);
    gw(5,1,gr(1,1)-gr(4,1));
    if((t0)!=0)goto _16;else goto _21;
_16:
    gw(6,1,0);
    sa(gr(3,1));
    sa(gr(3,1)<0?1:0);
_17:
    if(sp()!=0)goto _18;else goto _20;
_18:
    sp();
    t0=gr(2,1);
    t1=gr(6,1);
    gw(gr(1,1),gr(3,1)+4,gr(6,1));
    t2=t0+t1;
    gw(2,1,t2);
_19:
    gw(3,1,gr(3,1)+1);
    goto _14;
_20:
    sa(sr()+4);
    sa(gr(5,1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0=t0+gr(6,1);
    gw(6,1,t0);
    sa(sp()-1LL);
    sa(sr()<0?1:0);
    goto _17;
_21:
    gw(gr(1,1),gr(3,1)+4,1);
    goto _19;
_22:
    if(gr(2,1)<=gr(7,0))goto _24;else goto _23;
_23:
    printf("%lld", gr(1,1));
    return 0;
_24:
    sa(sp()+1LL);
    sa(sr());
    gw(1,1,sp());
    gw(2,1,0);
    gw(3,1,0);
    goto _14;
_25:
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));
    sa(sp()+2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-88LL);
    goto _8;
_26:
    sa(sr());
    sa(gr(3,0));
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));
    sa(sp()+2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _9;
_27:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));
    sa(sp()+2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));
    sa(sr()<gr(4,0)?1:0);
    goto _2;
}