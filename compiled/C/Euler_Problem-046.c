/* transpiled with BefunCompile v1.2.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v##### ### // Project Euler - Problem 46{ } !a{#}!*9{ } !=>2{ }  ?v{ }  +>0v>vv p09+g09*2:p07-\\g07+g09:<{ }  }v{ }  +p+1/g01\\%g0"
           "1:\\\"O\"< $v{ }  ?<{ }  +9@pp8# v/4    <   >:90g+70g`! |>\"d\"2*:10p\"2\":20p*40p230pv{ }  E>030p 350p{ }  4>50g2+:50p::10g%\\10g/1+g\" "
           "\"-#^_^>1+:50g-!#v_::10g%\\10g/1+g\" \"-!#^_:50g\\-2/:0^.70>0g>:70g`#^_>:|:/4p09/2g09<vp08*8**::**::8p11p10:\" \"<{ }  D_^#`g03g04<{ } "
           " 4^{ }  I>{ }  B^>^ >90g2/90p4/^ >$90g:*-#v_v >\"X\"30g:10g%\\10g/1+p30g>30g+:40g\\`{ }  '#v_$>30g1+:30p:10g%\\10g/1+g\" \"-|{ }  4${ }"
           "  ?^{ }  f<{ }  :^p+1/g01\\%g01:\\\" \":<  ^{ }  :<{ }  4^{ } !)< ";
int t=0;int z=0;
int64 g[11400];
int d(){int s,w,i,j,h;h=z;for(;t<574;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<200&&y<57){return g[y*200+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<200&&y<57){g[y*200+x]=v;}}
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
    gw(1,0,200);
    gw(2,0,50);
    gw(4,0,10000);
    gw(3,0,2);
_1:
    gw(0,1,32);
    gw(1,1,32);
    gw(8,0,1073741824);
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
_2:
    if(sp()!=0)goto _25;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    if((t0)!=0)goto _6;else goto _4;
_6:
    if(gr(4,0)>gr(3,0))goto _1;else goto _7;
_7:
    gw(3,0,0);
    gw(5,0,3);
_8:
    sa(gr(5,0)+2);
    gw(5,0,gr(5,0)+2);
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;

    if((t0)!=0)goto _9;else goto _10;
_9:
    sa(79);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _8;
_10:
    sp();
    sa(3);
    sa((3-gr(5,0)!=0)?0:1);
_11:
    if(sp()!=0)goto _24;else goto _12;
_12:
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    t0=(t0!=0)?0:1;

    if((t0)!=0)goto _18;else goto _13;
_13:
    sa(sr());
    t0=gr(5,0);
    gw(9,0,0);
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}

    sa(td(sp(),2));

    sa(sr());
    gw(7,0,sp());
    sa(gr(8,0));
    sa(gr(8,0)>gr(7,0)?1:0);
_14:
    if(sp()!=0)goto _23;else goto _15;
_15:
    sa(sr());
_16:
    if(sp()!=0)goto _20;else goto _17;
_17:
    sp();
    sa(sp()-(gr(9,0)*gr(9,0)));


    if(sp()!=0)goto _18;else goto _19;
_18:
    sa(sp()+1LL);

    sa((sr()-gr(5,0)!=0)?0:1);
    goto _11;
_19:
    sp();
    goto _8;
_20:
    if((sr()+gr(9,0))<=gr(7,0))goto _22;else goto _21;
_21:
    gw(9,0,td(gr(9,0),2));
    sa(td(sp(),4));

    sa(sr());
    goto _16;
_22:
    t0=sr()+gr(9,0);
    t1=gr(7,0);
    t2=t1-t0;
    gw(7,0,t2);
    t0=(sr()*2)+gr(9,0);
    gw(9,0,t0);
    gw(9,0,td(gr(9,0),2));
    sa(td(sp(),4));
    goto _15;
_23:
    sa(td(sp(),4));

    sa(sr()>gr(7,0)?1:0);
    goto _14;
_24:
    printf("%lld ", (int64)(sp()));
    return 0;
_25:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(4,0)?1:0);
    goto _2;
}
