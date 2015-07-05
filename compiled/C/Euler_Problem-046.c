/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1LL,0LL,200LL);
    gw(2LL,0LL,50LL);
    gw(4LL,0LL,10000LL);
    gw(3LL,0LL,2LL);
_1:
    gw(0LL,1LL,32LL);
    gw(1LL,1LL,32LL);
    gw(8LL,0LL,1073741824LL);
    gw(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+1LL,88LL);
    sa(gr(3LL,0LL)+gr(3LL,0LL));
    sa((gr(3L,0L)+gr(3L,0L))<gr(4L,0L)?1:0);
_2:
    if(sp()!=0)goto _25;else goto _3;
_3:
    sp();
_4:
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-32LL);
    if(sp()!=0)goto _6;else goto _4;
_6:
    if(gr(4L,0L)>gr(3L,0L))goto _1;else goto _7;
_7:
    gw(3LL,0LL,0LL);
    gw(5LL,0LL,3LL);
_8:
    sa(gr(5LL,0LL)+2LL);
    gw(5LL,0LL,gr(5LL,0LL)+2LL);
    sa(sr());
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-32LL);
    if(sp()!=0)goto _9;else goto _10;
_9:
    sa(79LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _8;
_10:
    sp();
    sa(3LL);
    sa((3L-gr(5L,0L)!=0)?0:1);
_11:
    if(sp()!=0)goto _24;else goto _12;
_12:
    sa(sr());
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-32LL);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _23;else goto _13;
_13:
    sa(sr());
    sa(gr(5LL,0LL));
    gw(9LL,0LL,0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    sa(td(sp(),2L));
    sa(sr());
    gw(7LL,0LL,sp());
    sa(gr(8LL,0LL));
    sa(gr(8L,0L)>gr(7L,0L)?1:0);
_14:
    if(sp()!=0)goto _22;else goto _15;
_15:
    sa(sr());
    if(sp()!=0)goto _19;else goto _16;
_16:
    sp();
    sa(sp()-(gr(9LL,0LL)*gr(9LL,0LL)));
    if(sp()!=0)goto _18;else goto _17;
_17:
    sp();
    goto _8;
_18:
    sa(sp()+1LL);
    sa((sr()-gr(5L,0L)!=0)?0:1);
    goto _11;
_19:
    if((sr()+gr(9L,0L))<=gr(7L,0L))goto _21;else goto _20;
_20:
    gw(9LL,0LL,td(gr(9LL,0LL),2LL));
    sa(td(sp(),4L));
    sa(sr());
    if(sp()!=0)goto _19;else goto _16;
_21:
    sa(sr()+gr(9LL,0LL));
    sa(gr(7LL,0LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    gw(7LL,0LL,sp());
    sa((sr()*2LL)+gr(9LL,0LL));
    gw(9LL,0LL,sp());
    gw(9LL,0LL,td(gr(9LL,0LL),2LL));
    sa(td(sp(),4L));
    goto _15;
_22:
    sa(td(sp(),4L));
    sa(sr()>gr(7L,0L)?1:0);
    goto _14;
_23:
    sa(sp()+1LL);
    sa((sr()-gr(5L,0L)!=0)?0:1);
    goto _11;
_24:
    printf("%lld", (int64)(sp()));
    return 0;
_25:
    sa(sr());
    sa(32LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3LL,0LL));
    sa(sr()<gr(4L,0L)?1:0);
    goto _2;
}