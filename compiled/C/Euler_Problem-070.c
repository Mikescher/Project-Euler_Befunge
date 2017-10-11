/* transpiled with BefunCompile v1.2.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v00000 000 // Project Euler - Problem 70{ } !0ccc{ } !T{?? }  #{ } !M{#} W9{ } !W>55*6*:10p57*:20p*40p230p\"2(\"*11p\";}(\"*21p022p1"
           "12p\";}22 \"***31p1v>030p     v{>g   0\\v   v\\-1 < }  \"{ }  Hvp08*8**::**::8p31p30:\" \"{ }  E_^#`g03g04<{ 2 v+55:<>\\1>9*\\:|}  \"{ }  "
           "I>\"X\"30g:10g%\\10g/3+p30g>30g+:40g\\`{ }  '#v_$>30g1+:30p:10g%\\10g/3+g\" \"-| 7 >%\\:#^|#/+55\\$< 8 >%\\:#^|#/+55\\$<{ }  `^p+3/g01\\%g01"
           ":\\\" \":<  ^{ }  :<  >$ #\\>#<>\\# :#+_+^>$ #\\>#<>\\# :#+_vv{ }  Gvg11{ }  e<^{ }  << v -+<-{ }  G>:42p::10g%\\10g/3+g\"X\"-#v_:1+>:52p:"
           ":10g%\\10g/3+g\"X\"-#v_42g52g*:72p31g`#v_72g22g*42g1-52g1-*:82p12g*`#v_^v_v{ }  M>$12g.@{ }  3v $<{ }  G<{ }  5v{ }  '<  <{ }  M^_^"
           "#-g12:+1{ }  -<   <^_^#-g12:+1{ }  -<{ }  G<p22g28p21g27<{ }  K";
int t=0;int z=0;
int64 g[7050];
int d(){int s,w,i,j,h;h=z;for(;t<703;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<150&&y<47){return g[y*150+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<150&&y<47){g[y*150+x]=v;}}
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
    gw(1,0,150);
    gw(2,0,35);
    gw(4,0,5250);
    gw(3,0,2);
    gw(1,1,2000);
    gw(2,1,5000);
    gw(2,2,0);
    gw(1,2,1);
    gw(3,1,10000000);
_1:
    gw(0,3,32);
    gw(1,3,32);
    gw(8,0,1073741824);
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
_2:
    if(sp()!=0)goto _38;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    if((t0)!=0)goto _6;else goto _4;
_6:
    if(gr(4,0)>gr(3,0))goto _1;else goto _7;
_7:
    gw(3,0,0);
    sa(gr(1,1));
    gw(4,2,gr(1,1));
_8:
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=88;

    if((t0)!=0)goto _9;else goto _12;
_9:
    sa(sp()+1LL);


    if(sr()!=gr(2,1))goto _10;else goto _11;
_10:
    sa(sr());
    gw(4,2,sp());
    goto _8;
_11:
    printf("%lld ", gr(1,2));
    sp();
    return 0;
_12:
    sa(sr()+1);
_13:
    sa(sr());
    gw(5,2,sp());
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=88;

    if((t0)!=0)goto _16;else goto _14;
_14:
    t0=gr(4,2)*gr(5,2);
    gw(7,2,gr(4,2)*gr(5,2));
    t0=t0>gr(3,1)?1:0;

    if((t0)!=0)goto _17;else goto _15;
_15:
    t0=gr(7,2)*gr(2,2);
    t1=(gr(4,2)-1)*(gr(5,2)-1);
    gw(8,2,(gr(4,2)-1)*(gr(5,2)-1));
    t1*=gr(1,2);
    t2=t0>t1?1:0;

    if((t2)!=0)goto _16;else goto _18;
_16:
    sa(sp()+1LL);


    if(sr()!=gr(2,1))goto _13;else goto _17;
_17:
    sp();
    goto _9;
_18:
    sa(0);
    sa(tm(gr(7,2),10));
    sa(gr(7,2));
    sa(gr(7,2));
_19:
    if(sp()!=0)goto _20;else goto _24;
_20:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(9);
_21:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _23;else goto _22;
_22:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(tm(sr(),10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _19;
_23:
    sa(sp()-1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*9LL);
    goto _21;
_24:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sp();
    sp();
_25:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _26;else goto _27;
_26:
    sa(sp()+sp());
    goto _25;
_27:
    sa(sp()+sp());

    sa(0);
    sa(tm(gr(8,2),10));
    sa(gr(8,2));
    sa(gr(8,2));
_28:
    if(sp()!=0)goto _29;else goto _33;
_29:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(9);
_30:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _32;else goto _31;
_31:
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(tm(sr(),10));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _28;
_32:
    sa(sp()-1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*9LL);
    goto _30;
_33:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sp();
    sp();
_34:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _37;else goto _35;
_35:
    sa(sp()+sp());

    t0=sp();
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)goto _16;else goto _36;
_36:
    gw(1,2,gr(7,2));
    gw(2,2,gr(8,2));
    goto _16;
_37:
    sa(sp()+sp());
    goto _34;
_38:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(4,0)?1:0);
    goto _2;
}
