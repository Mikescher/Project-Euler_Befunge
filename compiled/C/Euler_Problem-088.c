/* compiled with BefunCompile v1.0.8 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v XXXX{ } *fOOOO{ } 5O{#}!BA{ } *j{#}!BA{ } +7vp+8+8/g05\\%g05:\\1:p+3/<{ } *&>\"`` \"+*20p\";}`\"*30p8{:*}  $40p28*8*8*50p20g>:!#v_1-"
           ":40g\\:50g%\\50g ^{ } *'vp142p13+1g03p122p+8812{ }  7$<v:--g14g13g03g14<{ } *)v{ }  :<{ }  4#{ }  ._^#-3++`g14g+3/g05\\%g05:--g1<{ "
           "}  9<p+3/g05\\%g05:-<{ } )D>31g1+31p 082*g::41g\\/\\1+*4 1p1+082*p051p  >41g31g30g21g-+`#v_30g31g41g--1`41g31g`!30g31g4 ^g--:50g%\\5"
           "0g/3+g41g`++3-#^_41g30g31g41g-^{ } )_^p+3/g05\\{ }  (%g05<{ }  +> 51g:50g%\\50g/82*+g:41g\\/41p3v{ } )nvp15+1g15p13+\\g13p14*\\g14:g+"
           "*28/g05\\%g05:g1 5p+*28/g05\\%g05:g15g+*28/g05\\%g05:+1g15p13-\\g1<{ } )n>51g30g1+-#v_{ }  .v{ }  /^{ }  ><{ } )~v  p13+1g13<{ } *^>"
           "51g:50g%\\50g/82*+g::1+51g:50g%\\50g/82*+p 41g\\/41p1+41g*41p51g21g`#v_     ^{ } )}vp310p300{ }  3<{ }  G>51g21p^{ } */>3+g61g1+:50"
           "g%\\50g/3+p61g:50   v >$$v{ } *8>1pv>71g-  #v v#{ }  1<{ }  *#  $_v#`\\g18<{ } *17v0<^:g+3/g< ^ /g05\\%g05:g16g+3/g 05\\%g05:+1:p16:"
           "< >81g-|{ } *->01-^>::50g%\\50^ v_$:0\\:50g%\\5 0g/3+p^>::50g%\\50g/3+g::|    ${ } *2^_v#-g02:+1<>:71g`#v_81p:>1-:1+  |{ }  )# ^  $$"
           "<    1{ } *4${ }  (^      $># 7#  1 p# <$<0  p+3/g05\\%g05:\\0  +<{ } *1v00<{ }  6^p+3/g05{ }  (\\%<{ } *=v+1{ }  8<{ } *N>::91p50g"
           "%\\50g/3+g+91g:30g-|{ } *i>$.$@{ } *F";
int t=0;int z=0;
int64 g[51200];
int d(){int s,w,i,j,h;h=z;for(;t<1188;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<1024&&y<50){return g[y*1024+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<1024&&y<50){g[y*1024+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0,t1,t2,t3,t4;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(2,0,12288);
    gw(3,0,12000);
    gw(4,0,281474976710656LL);
    gw(5,0,1024);
    sa(gr(2,0));
    sa(((gr(2,0))!=0)?0:1);
_1:
    if(sp()!=0)goto _2;else goto _31;
_2:
    gw(1,16,2);
    gw(2,1,2);
    gw(3,1,gr(3,0)+1);
    gw(4,1,2);
    gw(3,1,gr(3,1)+1);
    sp();
_3:
    t0=gr(0,16);
    gw(4,1,(td(gr(4,1),gr(0,16)))*(gr(0,16)+1));
    t0++;
    gw(0,16,t0);
    gw(5,1,0);
_4:
    if(gr(4,1)>(gr(3,1)+(gr(3,0)-gr(2,1))))goto _5;else goto _28;
_5:
    t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
    gw(4,1,td(gr(4,1),gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)));
    t1=gr(3,1);
    t2=t1-t0;
    gw(3,1,t2);
    gw(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16,gr(tm(gr(5,1)+1,gr(5,0)),(td(gr(5,1)+1,gr(5,0)))+16));
    t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
    gw(4,1,gr(4,1)*gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16));
    t1=gr(3,1);
    t2=t1+t0;
    gw(3,1,t2);
    gw(5,1,gr(5,1)+1);
    if(gr(5,1)!=(gr(3,0)+1))goto _6;else goto _8;
_6:
    gw(3,1,gr(3,1)+1);
    t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
    t1=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
    gw(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16,gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)+1);
    t2=gr(4,1);
    t3=td(t2,t1);
    gw(4,1,t3);
    t0++;
    t0*=gr(4,1);
    gw(4,1,t0);
    if(gr(5,1)>gr(2,1))goto _7;else goto _4;
_7:
    gw(2,1,gr(5,1));
    goto _4;
_8:
    gw(0,3,0);
    gw(1,3,0);
    gw(7,1,-1);
    sa(5);
    sa(0);
    sa(gr(0,3));
    sa(gr(0,3)-gr(7,1));
_9:
    if(sp()!=0)goto _17;else goto _10;
_10:
    sp();
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(5,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
_11:
    sa(sp()+1LL);
    if(sr()!=gr(2,0))goto _12;else goto _13;
_12:
    sa(sr());
    sa(tm(sr(),gr(5,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr()-gr(7,1));
    goto _9;
_13:
    gw(9,1,0);
    sp();
    t4=gr(0,3);
_14:
    sa(gr(9,1));
    if(gr(9,1)!=gr(3,0))goto _16;else goto _15;
_15:
    sp();
    printf("%lld", t4);
    sp();
    return 0;
_16:
    sa(sp()+1LL);
    sa(sr());
    sa(sr());
    gw(9,1,sp());
    sa(tm(sp(),gr(5,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));
    sa(sp()+3LL);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t4+=t0;
    goto _14;
_17:
    if(sr()>gr(7,1))goto _18;else goto _19;
_18:
    gw(7,1,sp());
    goto _11;
_19:
    gw(8,1,sp());
    sa(sr());
_20:
    sa(sp()-1LL);
    if((sr()+1)!=0)goto _21;else goto _24;
_21:
    sa(sr());
    sa(tm(sr(),gr(5,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa(sr());
    if(sp()!=0)goto _22;else goto _27;
_22:
    sa(sp()-gr(8,1));
    if(sp()!=0)goto _23;else goto _26;
_23:
    sa((sp()<gr(8,1))?1:0);
    if(sp()!=0)goto _24;else goto _25;
_24:
    sp();
    goto _11;
_25:
    sa(sr());
    gw(6,1,sp());
    sa(sr()+1);
    sa(tm(sr(),gr(5,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));
    sa(sp()+3LL);
    {int64 v0=sp();t0=gr(sp(),v0);}
    gw(tm(gr(6,1)+1,gr(5,0)),(td(gr(6,1)+1,gr(5,0)))+3,gr(tm(gr(6,1),gr(5,0)),(td(gr(6,1),gr(5,0)))+3));
    gw(tm(gr(6,1),gr(5,0)),(td(gr(6,1),gr(5,0)))+3,t0);
    goto _20;
_26:
    sp();
    sa(sp()+1LL);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(5,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _11;
_27:
    sp();
    sp();
    goto _25;
_28:
    if((((gr(3,0)-(gr(3,1)-gr(4,1)))>1?1:0)+(gr(4,1)<=gr(3,1)?1:0)+(gr(tm(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)),(td(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)))+3)>gr(4,1)?1LL:0LL))!=3)goto _29;else goto _30;
_29:
    gw(3,1,gr(3,1)+1);
    goto _3;
_30:
    gw(tm(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)),(td(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)))+3,gr(4,1));
    gw(3,1,gr(3,1)+1);
    goto _3;
_31:
    sa(sp()-1LL);
    sa(sr());
    sa(gr(4,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(5,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(5,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));
    sa(sp()+8LL);
    sa(sp()+8LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _1;
}