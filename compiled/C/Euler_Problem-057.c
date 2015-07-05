/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } !a{{#}  o }  ${{#}  o{ }  q{{#}  o }  $}  %{#}  o{ }  p>77*8*2+>:0\\:\"O\"%1+\\\"O\"/2+p:0\\:\"O\"%1+\\\"O\"/8+p:0\\:\"O\"%1+\\\"O\"/72*+p:0\\"
           ":   v{ }  /|+1:-1p+*84/\"O\"\\+1%\"O\":\\0:p++*298/\"O\"\\+1%\"O\":\\0:p+*45/\"O\"\\+1%\"O\"<{ }  />$ 1\"O\"6p1\"O\"62*p1\"O\"56*p v{ }  Mv{ }  A<{ }  "
           "M>60*70p61*80p62*90p60*71p61*81p v{ }  2>   0>${ }  1v    v*\"o\"9 p040p121p111p19*26{ }  '<{ }  2^p11_^#`g11 :-g02*5\"O\"<      > 0"
           "10p\"O\"5*>1-:::20p:\"O\"%1+\\\"O\"/70g2++g\\:\"O\"%1+\\\"O\"/80g2++g2*10g++:55+%:#^_v{ }  /^{ }  >_v#:p01/+55p++2g09/\"O\"\\+1%\"O\":g02<     v  "
           "  p09%+99+6g09p08%+99+6g08p07%+99+6g07$<{ }  +>   0>${ }  1v{ }  W^p12_^#`g12 :-g02*5\"O\"<   >010p\"O\"5*>1-:::20p:\"O\"%1+\\\"O\"/71g54"
           "*++g\\:\"O\"%1+\\\"O\"/81g54*++g2*10g++:55+%:#^_v{ }  +^{ }  @_v#:p01/+55p++*45g19/\"O\"\\+1%\"O\":g02< v      p19%+99+6g19p18%+99+6g18p17%"
           "+99+6g17$<{ }  C>11g21g`!#v_40g1+40pv{ }  Z|:{ }  '-1{<{ }  )}  \"{ }  Q>$40g.@{ }  i";
int t=0;int z=0;
int64 g[4320];
int d(){int s,w,i,j,h;h=z;for(;t<852;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
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
    gw(79LL,6LL,0LL);
    gw(79LL,12LL,0LL);
    gw(79LL,18LL,0LL);
    gw(79LL,24LL,0LL);
    gw(79LL,30LL,0LL);
    gw(79LL,36LL,0LL);
    sa(393LL);
_1:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+8LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+14LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+20LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+26LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+32LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);
    if((sr()+1LL)!=0)goto _1;else goto _3;
_3:
    gw(79LL,6LL,1LL);
    gw(79LL,12LL,1LL);
    gw(79LL,30LL,1LL);
    gw(7LL,0LL,0LL);
    gw(8LL,0LL,6LL);
    gw(9LL,0LL,12LL);
    gw(7LL,1LL,0LL);
    gw(8LL,1LL,6LL);
    gw(9LL,1LL,12LL);
    gw(1LL,1LL,1LL);
    gw(2LL,1LL,1LL);
    gw(4LL,0LL,0LL);
    gw(1LL,0LL,0LL);
    gw(2LL,0LL,394LL);
    sp();
    sa(999LL);
_4:
    sa(394LL);
    sa(gr(79LL,4LL+gr(7LL,0LL)+2LL)+(gr(79LL,4LL+gr(8LL,0LL)+2LL)*2LL)+gr(1LL,0LL));
    sa(tm(gr(79LL,4LL+gr(7LL,0LL)+2LL)+(gr(79LL,4LL+gr(8LL,0LL)+2LL)*2LL)+gr(1LL,0LL),10LL));
    sa(tm(gr(79LL,4LL+gr(7LL,0LL)+2LL)+(gr(79LL,4LL+gr(8LL,0LL)+2LL)*2LL)+gr(1LL,0LL),10LL));
_5:
    if(sp()!=0)goto _6;else goto _8;
_6:
    sa(395LL-gr(2LL,0LL));
    if((395L-gr(2L,0L))>gr(1L,1L))goto _22;else goto _7;
_7:
    sp();
_8:
    gw((tm(gr(2LL,0LL),79LL))+1LL,(td(gr(2LL,0LL),79LL))+gr(9LL,0LL)+2LL,sp());
    sa(td(sp(),10L));
    gw(1LL,0LL,sp());
    sa(sr());
    if(sp()!=0)goto _21;else goto _9;
_9:
    gw(7LL,0LL,tm(gr(7LL,0LL)+6LL,18LL));
    gw(8LL,0LL,tm(gr(8LL,0LL)+6LL,18LL));
    gw(9LL,0LL,tm(gr(9LL,0LL)+6LL,18LL));
    gw(1LL,0LL,0LL);
    gw(2LL,0LL,394LL);
    sp();
    sa(394LL);
    sa(gr(79LL,4LL+gr(7LL,1LL)+20LL)+(gr(79LL,4LL+gr(8LL,1LL)+20LL)*2LL)+gr(1LL,0LL));
    sa(tm(gr(79LL,4LL+gr(7LL,1LL)+20LL)+(gr(79LL,4LL+gr(8LL,1LL)+20LL)*2LL)+gr(1LL,0LL),10LL));
    sa(tm(gr(79LL,4LL+gr(7LL,1LL)+20LL)+(gr(79LL,4LL+gr(8LL,1LL)+20LL)*2LL)+gr(1LL,0LL),10LL));
_10:
    if(sp()!=0)goto _11;else goto _13;
_11:
    sa(395LL-gr(2LL,0LL));
    if((395L-gr(2L,0L))>gr(2L,1L))goto _20;else goto _12;
_12:
    sp();
_13:
    gw((tm(gr(2LL,0LL),79LL))+1LL,(td(gr(2LL,0LL),79LL))+gr(9LL,1LL)+20LL,sp());
    sa(td(sp(),10L));
    gw(1LL,0LL,sp());
    sa(sr());
    if(sp()!=0)goto _19;else goto _14;
_14:
    gw(7LL,1LL,tm(gr(7LL,1LL)+6LL,18LL));
    gw(8LL,1LL,tm(gr(8LL,1LL)+6LL,18LL));
    gw(9LL,1LL,tm(gr(9LL,1LL)+6LL,18LL));
    sp();
    if(gr(1L,1L)<=gr(2L,1L))goto _15;else goto _18;
_15:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _17;else goto _16;
_16:
    sp();
    printf("%lld", (int64)(gr(4LL,0LL)));
    return 0;
_17:
    gw(1LL,0LL,0LL);
    gw(2LL,0LL,394LL);
    goto _4;
_18:
    gw(4LL,0LL,gr(4LL,0LL)+1LL);
    goto _15;
_19:
    sa(sp()-1LL);
    sa(sr());
    sa(sr());
    sa(sr());
    gw(2LL,0LL,sp());
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+gr(7LL,1LL)+20LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+gr(8LL,1LL)+20LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*2LL);
    sa(sp()+gr(1LL,0LL));
    sa(sp()+sp());
    sa(tm(sr(),10LL));
    sa(sr());
    goto _10;
_20:
    gw(2LL,1LL,sp());
    goto _13;
_21:
    sa(sp()-1LL);
    sa(sr());
    sa(sr());
    sa(sr());
    gw(2LL,0LL,sp());
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+gr(7LL,0LL)+2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79LL))+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79L));
    sa(sp()+gr(8LL,0LL)+2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*2LL);
    sa(sp()+gr(1LL,0LL));
    sa(sp()+sp());
    sa(tm(sr(),10LL));
    sa(sr());
    goto _5;
_22:
    gw(1LL,1LL,sp());
    goto _8;
}