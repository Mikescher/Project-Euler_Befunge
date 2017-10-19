/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    int64 t0,t1;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(79,6,0);
    gw(79,12,0);
    gw(79,18,0);
    gw(79,24,0);
    gw(79,30,0);
    gw(79,36,0);
    sa(393);
    sa(394);
_1:
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+2LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+8LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+14LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+20LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+26LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+32LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr()+1);
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
    sp();
    sa(999);
_4:
    gw(1,0,0);
    gw(2,0,394);
    sa(394);
    sa(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0));
    sa((gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0))%10);
    sa((gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0))%10);
_5:
    if(sp()!=0)goto _6;else goto _8;
_6:
    sa(395-gr(2,0));

    if((395-gr(2,0))>gr(1,1))goto _21;else goto _7;
_7:
    sp();
_8:
    gw((gr(2,0)%79)+1,(gr(2,0)/79)+gr(9,0)+2,sp());
    sa(sp()/10LL);

    gw(1,0,sp());
    sa(sr());

    if(sp()!=0)goto _20;else goto _9;
_9:
    gw(7,0,(gr(7,0)+6)%18);
    gw(8,0,(gr(8,0)+6)%18);
    gw(9,0,(gr(9,0)+6)%18);
    gw(1,0,0);
    gw(2,0,394);
    sp();
    sa(394);
    sa(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0));
    sa((gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0))%10);
    sa((gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0))%10);
_10:
    if(sp()!=0)goto _11;else goto _13;
_11:
    sa(395-gr(2,0));

    if((395-gr(2,0))>gr(2,1))goto _19;else goto _12;
_12:
    sp();
_13:
    gw((gr(2,0)%79)+1,(gr(2,0)/79)+gr(9,1)+20,sp());
    sa(sp()/10LL);

    gw(1,0,sp());
    sa(sr());

    if(sp()!=0)goto _18;else goto _14;
_14:
    gw(7,1,(gr(7,1)+6)%18);
    gw(8,1,(gr(8,1)+6)%18);
    gw(9,1,(gr(9,1)+6)%18);
    sp();

    if(gr(1,1)>gr(2,1))goto _17;else goto _15;
_15:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _4;else goto _16;
_16:
    printf("%lld ", gr(4,0));
    sp();
    return 0;
_17:
    gw(4,0,gr(4,0)+1);
    goto _15;
_18:
    sa(sp()-1LL);

    sa(sr());
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+gr(7,1)+20);

    {int64 v0=sp();t0=gr(sp(),v0);}
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+gr(8,1)+20);

    {int64 v0=sp();t1=gr(sp(),v0);}
    t1*=2;
    t1+=gr(1,0);
    sa(t0+t1);
    sa(sr()%10);
    sa(sr());
    goto _10;
_19:
    gw(2,1,sp());
    sa(0);
    goto _12;
_20:
    sa(sp()-1LL);

    sa(sr());
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+gr(7,0)+2);

    {int64 v0=sp();t0=gr(sp(),v0);}
    sa((sr()%79)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/79LL);

    sa(sp()+gr(8,0)+2);

    {int64 v0=sp();t1=gr(sp(),v0);}
    t1*=2;
    t1+=gr(1,0);
    sa(t0+t1);
    sa(sr()%10);
    sa(sr());
    goto _5;
_21:
    gw(1,1,sp());
    sa(0);
    goto _7;
}
