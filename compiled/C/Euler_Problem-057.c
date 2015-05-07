/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } !a{#}  o {#}  o {#}  o {#}  o {#}  o{ }  q{#}  o {#}  o {#}  o {#}  o {#}  o{ }  q{#}  o {#}  o {#}  o {#}  o {#}  o{ }  q{"
           "#}  o {#}  o {#}  o {#}  o {#}  o{ }  q{#}  o {#}  o {#}  o {#}  o {#}  o{ }  q{#}  o {#}  o {#}  o {#}  o {#}  o{ }  p>77*8*2+>"
           ":0\\:\"O\"%1+\\\"O\"/2+p:0\\:\"O\"%1+\\\"O\"/8+p:0\\:\"O\"%1+\\\"O\"/72*+p:0\\:   v{ }  /|+1:-1p+*84/\"O\"\\+1%\"O\":\\0:p++*298/\"O\"\\+1%\"O\":\\0:p+*45/\"O\"\\"
           "+1%\"O\"<{ }  />$ 1\"O\"6p1\"O\"62*p1\"O\"56*p v{ }  Mv{ }  A<{ }  M>60*70p61*80p62*90p60*71p61*81p v{ }  2>   0>${ }  1v    v*\"o\"9 p040"
           "p121p111p19*26{ }  '<{ }  2^p11_^#`g11 :-g02*5\"O\"<      > 010p\"O\"5*>1-:::20p:\"O\"%1+\\\"O\"/70g2++g\\:\"O\"%1+\\\"O\"/80g2++g2*10g++:55+%:"
           "#^_v{ }  /^{ }  >_v#:p01/+55p++2g09/\"O\"\\+1%\"O\":g02<     v    p09%+99+6g09p08%+99+6g08p07%+99+6g07$<{ }  +>   0>${ }  1v{ }  W^p1"
           "2_^#`g12 :-g02*5\"O\"<   >010p\"O\"5*>1-:::20p:\"O\"%1+\\\"O\"/71g54*++g\\:\"O\"%1+\\\"O\"/81g54*++g2*10g++:55+%:#^_v{ }  +^{ }  @_v#:p01/+55p+"
           "+*45g19/\"O\"\\+1%\"O\":g02< v      p19%+99+6g19p18%+99+6g18p17%+99+6g17$<{ }  C>11g21g`!#v_40g1+40pv{ }  Z|:{ }  '-1{<{ }  )}  \"{ } "
           " Q>$40g.@{ }  i";
int t=0;int z=0;
int64 g[4320];
int d(){int s,w,i,j,h;h=z;for(;t<1039;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<80&&y<54){return g[y*80+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<80&&y<54){g[y*80+x]=v;}}
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
    goto _0;
_0:
    gw(79,6,0);
    gw(79,12,0);
    gw(79,18,0);
    gw(79,24,0);
    gw(79,30,0);
    gw(79,36,0);
    sa(393);
    sa(394);
_1:
    if(sp()!=0)goto _2; else goto _3;
_2:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(2);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(8);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(14);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(20);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(26);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(32);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(1);
    sa(sp()+sp());
    goto _1;
_3:
    gw(79,6,1);
    gw(79,12,1);
    gw(79,30,1);
    gw(7,0,0);
    gw(8,0,6);
    gw(9,0,12);
    gw(7,1,0);
    gw(8,1,6);
    gw(9,1,12);
    gw(1,1,1);
    gw(2,1,1);
    gw(4,0,0);
    gw(1,0,0);
    gw(2,0,394);
    sp();
    sa(999);
_4:
    sa(394);
    sa((gr(79,(4)+((gr(7,0))+(2))))+(((gr(79,(4)+((gr(8,0))+(2))))*(2))+(gr(1,0))));
    sa(tm((gr(79,(4)+((gr(7,0))+(2))))+(((gr(79,(4)+((gr(8,0))+(2))))*(2))+(gr(1,0))),10));
    sa(tm((gr(79,(4)+((gr(7,0))+(2))))+(((gr(79,(4)+((gr(8,0))+(2))))*(2))+(gr(1,0))),10));
_5:
    if(sp()!=0)goto _6; else goto _8;
_6:
    sa((395)-(gr(2,0)));
    sa(((395)-(gr(2,0)))>(gr(1,1))?1:0);
    if(sp()!=0)goto _22; else goto _7;
_7:
    sp();
_8:
    gw((tm(gr(2,0),79))+(1),(td(gr(2,0),79))+((gr(9,0))+(2)),sp());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    gw(1,0,sp());
    sa(sr());
    if(sp()!=0)goto _9; else goto _10;
_9:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa((gr(7,0))+(2));
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa((gr(8,0))+(2));
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(2);
    sa(sp()*sp());
    sa(gr(1,0));
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    goto _5;
_10:
    gw(7,0,tm((gr(7,0))+(6),18));
    gw(8,0,tm((gr(8,0))+(6),18));
    gw(9,0,tm((gr(9,0))+(6),18));
    gw(1,0,0);
    gw(2,0,394);
    sp();
    sa(394);
    sa((gr(79,(4)+((gr(7,1))+(20))))+(((gr(79,(4)+((gr(8,1))+(20))))*(2))+(gr(1,0))));
    sa(tm((gr(79,(4)+((gr(7,1))+(20))))+(((gr(79,(4)+((gr(8,1))+(20))))*(2))+(gr(1,0))),10));
    sa(tm((gr(79,(4)+((gr(7,1))+(20))))+(((gr(79,(4)+((gr(8,1))+(20))))*(2))+(gr(1,0))),10));
_11:
    if(sp()!=0)goto _12; else goto _14;
_12:
    sa((395)-(gr(2,0)));
    sa(((395)-(gr(2,0)))>(gr(2,1))?1:0);
    if(sp()!=0)goto _21; else goto _13;
_13:
    sp();
_14:
    gw((tm(gr(2,0),79))+(1),(td(gr(2,0),79))+((gr(9,1))+(20)),sp());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    gw(1,0,sp());
    sa(sr());
    if(sp()!=0)goto _20; else goto _15;
_15:
    gw(7,1,tm((gr(7,1))+(6),18));
    gw(8,1,tm((gr(8,1))+(6),18));
    gw(9,1,tm((gr(9,1))+(6),18));
    sp();
    sa((((gr(1,1))>(gr(2,1))?1:0)!=0)?0:1);
    if(sp()!=0)goto _16; else goto _19;
_16:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    if(sp()!=0)goto _18; else goto _17;
_17:
    sp();
    printf("%lld", (int64)(gr(4,0)));
    return 0;
_18:
    gw(1,0,0);
    gw(2,0,394);
    goto _4;
_19:
    gw(4,0,(gr(4,0))+(1));
    goto _16;
_20:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa((gr(7,1))+(20));
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(79);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa((gr(8,1))+(20));
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(2);
    sa(sp()*sp());
    sa(gr(1,0));
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    goto _11;
_21:
    gw(2,1,sp());
    goto _14;
_22:
    gw(1,1,sp());
    goto _8;
}