/* compiled with BefunCompile v1.0.7 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v XX  O OO // Project Euler - Problem 75{ } *,AAA A A{ } 4{{#}~~~{#}g3N{ } 5%> \";}\"8* 20p  \";};}`\"** 30p     30g>:0\\:20g%\\20v{ }"
           " *%v{ }  9p060$_^#!\\-1:p+3/g<{ } **v{ }  Jp08+1g08<{ } )x>180p>80g::*4*\\6*2++30g`#v_>80g1+:90p>::2**\\80g2**+30g` |{ } *-@.g06<{ "
           "}  +^p09:+1g09<{ } *\"v g13g12p16++p14:+*:g08*:g09p13:**2g09g08p12:-*:g08*:g09<{ } )x>`#v_{ }  +>1>:61g*30g`#v_:21g7*31g+5*41g+# "
           "*81p:61g*:20g%\\20g/3+g:#v_v{ } )h>21g31g21p31p^ ^+1{ }  '<># $#{ }  -^#{ }  )_v#<`\\0_v#-g18:<{ } *$^p06-1g06p+3/g02\\%g02:\\-10*g1"
           "6:<v1#{ }  ,<{ } *\"^p06+1g06p+3/g02\\%g02:\\g18*g16:$<^   $<{ } )n";
int t=0;int z=0;
int64 g[1515000];
int d(){int s,w,i,j,h;h=z;for(;t<576;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<1000&&y<1515){return g[y*1000+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<1000&&y<1515){g[y*1000+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0,t1,t2,t3;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(2,0,1000);
    gw(3,0,1500000);
    sa(gr(3,0));
    gw(tm(gr(3,0),gr(2,0)),(td(gr(3,0),gr(2,0)))+3,0);
_1:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _3;else goto _2;
_2:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(2,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,0)));
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _1;
_3:
    gw(6,0,0);
    gw(8,0,1);
    sp();
_4:
    if(((gr(8,0)*gr(8,0)*4)+(gr(8,0)*6)+2)>gr(3,0))goto _20;else goto _5;
_5:
    sa(gr(8,0)+1);
    gw(9,0,gr(8,0)+1);
_6:
    sa(sr());
    t0=sr()*2;
    sa(sp()*t0);
    t1=sp();
    sa(sp()*gr(8,0)*2);
    sa(t1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    t0=sp();
    t0=t0>gr(3,0)?1:0;
    if((t0)!=0)goto _19;else goto _7;
_7:
    t0=(gr(9,0)*gr(9,0))-(gr(8,0)*gr(8,0));
    gw(2,1,(gr(9,0)*gr(9,0))-(gr(8,0)*gr(8,0)));
    t1=gr(8,0)*gr(9,0)*2;
    gw(3,1,gr(8,0)*gr(9,0)*2);
    t2=(gr(9,0)*gr(9,0))+(gr(8,0)*gr(8,0));
    gw(4,1,(gr(9,0)*gr(9,0))+(gr(8,0)*gr(8,0)));
    t3=t1+t2;
    t1=t0+t3;
    gw(6,1,t1);
    if(gr(2,1)>gr(3,1))goto _18;else goto _8;
_8:
    sa(1);
    sa(gr(6,1)>gr(3,0)?1:0);
_9:
    if(sp()!=0)goto _17;else goto _10;
_10:
    t0=sr()*(((gr(2,1)*7)+gr(3,1))*5)+gr(4,1);
    gw(8,1,t0);
    sa(sr()*gr(6,1));
    sa(tm(sr(),gr(2,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,0)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    if(sp()!=0)goto _13;else goto _11;
_11:
    sp();
    sa(sr()*gr(6,1));
    sa(gr(8,1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(2,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,0)));
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(6,0,gr(6,0)+1);
_12:
    sa(sp()+1LL);
    sa((sr()*gr(6,1))>gr(3,0)?1:0);
    goto _9;
_13:
    if(sr()!=gr(8,1))goto _14;else goto _16;
_14:
    sa((sp()<0)?1:0);
    if(sp()!=0)goto _12;else goto _15;
_15:
    sa(sr()*gr(6,1));
    sa(-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(2,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,0)));
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(6,0,gr(6,0)-1);
    goto _12;
_16:
    sp();
    goto _12;
_17:
    sp();
    sa(gr(9,0)+1);
    gw(9,0,gr(9,0)+1);
    goto _6;
_18:
    t0=gr(2,1);
    gw(2,1,gr(3,1));
    gw(3,1,t0);
    goto _8;
_19:
    gw(8,0,gr(8,0)+1);
    goto _4;
_20:
    printf("%lld", gr(6,0));
    return 0;
}