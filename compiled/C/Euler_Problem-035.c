/* compiled with BefunCompile v1.0.5 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ }  *// Project Euler - Problem 35{ } ^f{#}~~~{#}/l?{ } J*>\"d\"45**:10p5\"d\"*:20p*00p230p\" \":03p13pv    v0{ }  -p090<{ } 4Dv{ } "
           " F<{ }  6_^#`g03g00<{ } 4;>\"X\"30g:10g%\\10g/3+p30g>30g+:00g\\`{ }  '#v_$>30g1+:30p:10g%\\10g/3+g\" \"-|{ } 4>>90g\"= \",,.@{ }  (^p+3/g"
           "01\\%g01:\\\" \":<  ^{ }  :<{ } 4;v{ }  K<{ } 4Z^_v#      !-g00p03:+1g03$<0{ }  v<{ } 4=v{ }  A<{ }  <>     v{ } 3o>230p>30g::10g%\\1"
           "0g/3+g\"X\"-#^_:150p1\\55+/:!#v_>:2%!#v_:5%!#v_55+/\\55+*\\50g1+50p:|>$60p:70p>::10g%\\10g/3+g\" \"-|     :{ } 4<>{ }  C>^{ }  (|p05:-1g"
           "05+*g06%+55 \\/+55<{ } 4j>55+70g.,90g1+90p0> $>$   ^{ } 4C{>      }  \"{ }  I$^> ^{ } 3s";
int t=0;int z=0;
int64 g[1032000];
int d(){int s,w,i,j,h;h=z;for(;t<598;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<2000&&y<516){return g[y*2000+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<2000&&y<516){g[y*2000+x]=v;}}
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
    gw(1,0,2000);
    gw(2,0,500);
    gw(0,0,1000000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
_1:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(0,0))>(gr(3,0)+gr(3,0))?1:0);
_2:
    if(sp()!=0)goto _22;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(32);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _6;else goto _4;
_6:
    sa((gr(0,0))>(gr(3,0))?1:0);
    if(sp()!=0)goto _1;else goto _7;
_7:
    gw(9,0,0);
    gw(3,0,2);
_8:
    sa(gr(3,0));
    sa(gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3)-88);
    if(sp()!=0)goto _21;else goto _9;
_9:
    gw(5,0,1);
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _13;else goto _10;
_10:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _20;else goto _11;
_11:
    sa(sr());
    sa(5);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _20;else goto _12;
_12:
    gw(5,0,gr(5,0)+1);
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _10;else goto _13;
_13:
    sp();
    gw(6,0,sp());
    sa(sr());
    gw(7,0,sp());
_14:
    sa(sr());
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(32);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _15;else goto _17;
_15:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(gr(6,0));
    sa(sp()*sp());
    sa(sp()+sp());
    sa(gr(5,0)-1);
    gw(5,0,gr(5,0)-1);
    if(sp()!=0)goto _14;else goto _16;
_16:
    sa(10);
    printf("%lld", (int64)(gr(7,0)));
    gw(9,0,gr(9,0)+1);
    printf("%c", (char)(sp()));
_17:
    sp();
_18:
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(gr(0,0));
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _19;else goto _8;
_19:
    sa(gr(9,0));
    sa(61);
    printf(" ");
    printf("%c", (char)(sp()));
    printf("%lld", (int64)(sp()));
    return 0;
_20:
    sp();
    sp();
    goto _17;
_21:
    sp();
    goto _18;
_22:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(gr(3,0));
    sa(sp()+sp());
    sa(sr());
    sa(gr(0,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _2;
}