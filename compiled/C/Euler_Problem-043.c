/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{X}  ){ }  Zv{X}  ){ } !?>902p012p9>:0\\1pv{ }  ]|\\-1: <{ }  S>12g55+, #$ \" =\",, . @{ }  Gvp20<  |`9g20    <{ }  R<  <{ }  0>$0v"
           "{ }  (> v{ }  9>002g0g\"0\"-1p v>02g0g\"0\"-:9`|  >:22p55+-| >22g1g     #v_ 02g0g\"9\"`!#^_{ }  )## v{ }  ->1+^{ }  (>0|-9p22+1:g22<vp"
           "20-1g20p0g20+\"0\"g22p1g221<v!`g200{ }  A<{ }  -p20+1g20< ##{ }  =>  02g0g\"9\"`!#v_{ }  3^  +{ }  K>002g0g\"0\"-1p\"X\"02g0p^  1  >#v_0"
           "02p{ }  3032p0>:0g\"0\"-32g55v>12p>{ }  -^g    >02g9-!02g8-!02g7-!++v{ }  (|-9\\+1:p23+*+<+{ }  22    v{ }  4<{ }  (>$32g:.55+,12g^"
           "{ }  20    >02g6-70g\"0\"-55+*80g\"0\"-+55+*90g\"0\"-+89+%+!v>++#^_02g0g\"9\"`!#v_^    v!+%+58+-\"0\"g08*+55+-\"0\"g07*+55-\"0\"g06-5g20<+v\"X\""
           "p1-\"0\"g0g200<#     >02g4-50g\"0\"-55+*60g\"0\"-+55+*70g\"0\"-+47+%+!v+>02g0p02g1+02p   ^     v!+%+70+-\"0\"g06*+55+-\"0\"g05*+55-\"0\"g04-3g"
           "20<+{ }  7>02g2-30g\"0\"-55+*40g\"0\"-+55+*50g\"0\"-+05+%+!v+{ }  7v!+%+30+-\"0\"g04*+55+-\"0\"g03*+55-\"0\"g02-1g20<+{ }  7>02g0-10g\"0\"-55+"
           "*20g\"0\"-+55+*30g\"0\"-+02+%+!>^{ }  5";
int t=0;int z=0;
int64 g[1564];
int d(){int s,w,i,j,h;h=z;for(;t<931;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<68&&y<23){return g[y*68+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<68&&y<23){g[y*68+x]=v;}}
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
    gw(0LL,2LL,9LL);
    gw(1LL,2LL,0LL);
    gw(9LL,1LL,0LL);
    sa(8LL);
_1:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr()-1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _1;else goto _3;
_3:
    sp();
_4:
    if(gr(0L,2L)>9L)goto _25;else goto _5;
_5:
    sa(gr(gr(0LL,2LL),0LL)-48LL);
    if((gr(gr(0L,2L),0L)-48L)>9L)goto _24;else goto _6;
_6:
    sa(sp()+1LL);
    sa(sr());
    gw(2LL,2LL,sp());
    sa(sp()-10LL);
    if(sp()!=0)goto _19;else goto _7;
_7:
    if(gr(gr(0L,2L),0L)<=57L)goto _18;else goto _8;
_8:
    gw(0LL,2LL,gr(0LL,2LL)+1LL);
_9:
    if(0L<=gr(0L,2L))goto _14;else goto _10;
_10:
    gw(0LL,2LL,0LL);
    gw(3LL,2LL,0LL);
    gw(3LL,2LL,(gr(0LL,0LL)-48LL)+(gr(3LL,2LL)*10LL));
    sa(1LL);
_11:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    sa(sp()+(gr(3LL,2LL)*10LL));
    gw(3LL,2LL,sp());
    sa(sr()+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-9LL);
    if(sp()!=0)goto _11;else goto _13;
_13:
    sp();
    sa(gr(3LL,2LL));
    printf("%lld", (int64)(gr(3LL,2LL)));
    printf("\n");
    sa(sp()+gr(1LL,2LL));
    gw(1LL,2LL,sp());
    goto _4;
_14:
    if((((gr(0L,2L)-9L!=0)?0:1)+((gr(0L,2L)-8L!=0)?0:1)+((gr(0L,2L)-7L!=0)?0:1)+(((gr(0L,2L)-6L)+(tm(((((gr(7L,0L)-48L)*10L)+(gr(8L,0L)-48L))*10L)+(gr(9L,0L)-48L),17L))!=0)?0:1)+(((gr(0L,2L)-5L)+(tm(((((gr(6L,0L)-48L)*10L)+(gr(7L,0L)-48L))*10L)+(gr(8L,0L)-48L),13L))!=0)?0:1)+(((gr(0L,2L)-4L)+(tm(((((gr(5L,0L)-48L)*10L)+(gr(6L,0L)-48L))*10L)+(gr(7L,0L)-48L),11L))!=0)?0:1)+(((gr(0L,2L)-3L)+(tm(((((gr(4L,0L)-48L)*10L)+(gr(5L,0L)-48L))*10L)+(gr(6L,0L)-48L),7L))!=0)?0:1)+(((gr(0L,2L)-2L)+(tm(((((gr(3L,0L)-48L)*10L)+(gr(4L,0L)-48L))*10L)+(gr(5L,0L)-48L),5L))!=0)?0:1)+(((gr(0L,2L)-1L)+(tm(((((gr(2L,0L)-48L)*10L)+(gr(3L,0L)-48L))*10L)+(gr(4L,0L)-48L),3L))!=0)?0:1)+((gr(0L,2L)+(tm(((((gr(1L,0L)-48L)*10L)+(gr(2L,0L)-48L))*10L)+(gr(3L,0L)-48L),2L))!=0)?0:1))!=0)goto _4;else goto _15;
_15:
    if(gr(gr(0L,2L),0L)<=57L)goto _17;else goto _16;
_16:
    gw(0LL,2LL,gr(0LL,2LL)+1LL);
    goto _4;
_17:
    gw(gr(gr(0LL,2LL),0LL)-48LL,1LL,0LL);
    gw(gr(0LL,2LL),0LL,88LL);
    gw(0LL,2LL,gr(0LL,2LL)+1LL);
    goto _4;
_18:
    gw(gr(gr(0LL,2LL),0LL)-48LL,1LL,0LL);
    gw(gr(0LL,2LL),0LL,88LL);
    goto _8;
_19:
    if((gr(gr(2LL,2LL),1LL))!=0)goto _20;else goto _21;
_20:
    sa(gr(2LL,2LL));
    gw(2LL,2LL,gr(2LL,2LL)+1LL);
    sa(sp()-9LL);
    if(sp()!=0)goto _19;else goto _7;
_21:
    if(gr(gr(0L,2L),0L)<=57L)goto _23;else goto _22;
_22:
    gw(gr(2LL,2LL),1LL,1LL);
    gw(gr(0LL,2LL),0LL,gr(2LL,2LL)+48LL);
    gw(0LL,2LL,gr(0LL,2LL)-1LL);
    goto _9;
_23:
    gw(gr(gr(0LL,2LL),0LL)-48LL,1LL,0LL);
    goto _22;
_24:
    gw(2LL,2LL,0LL);
    sp();
    goto _19;
_25:
    sa(gr(1LL,2LL));
    printf("\n");
    sa(32LL);
    printf("=");
    printf("%c", (char)(sp()));
    printf("%lld", (int64)(sp()));
    return 0;
}