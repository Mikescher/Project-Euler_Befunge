/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v $$ T # {#}  g{ }  '# {#}  g  XX   {# {#}  g{ }  '}  %# {#}  g{ }  qv{ }  Cp1*93\"Y\" p0+551 $<{ }  9> \"G\"8*:32p\";}2((\"***22p020p"
           "030p  >1-:0\\:\"G\"%9+\\\"G\"/p:!|{ }  Fv     pp02+1:g027:$<^{ }  ,>#   v# <{ }  :>22g:>:32g`#v_::\"G\"%9+\\\"G\"/g:!#^_:\"Y\"-!#v_:1-|    # "
           "  >1-:20p7\\g50g\\:  v{ }  4>0\\>:55+%:*\\ :#v_$$11v>30g1+  30p>50p$20g:|:g02p/\"G\"\\+9%\"G\"<{ }  />3     v^/+55g05+p05< >$@  ^     <  "
           "   v1:: -1$<{ }  >^_^#  _^#># 0# g# .# $# ^#  <{ }  ,< *0<{ }  <";
int t=0;int z=0;
int64 g[1280];
int d(){int s,w,i,j,h;h=z;for(;t<448;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<80&&y<16){return g[y*80+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<80&&y<16){g[y*80+x]=v;}}
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
    gw(3,2,568);
    gw(2,2,10000000);
    gw(2,0,0);
    gw(3,0,0);
    gw(79,7,0);
    sa(567);
    sa(567);
_1:
    if(sp()!=0)goto _21;else goto _2;
_2:
    gw(10,0,1);
    gw(27,1,89);
    sp();
    sa(gr(2,2));
    sa(gr(2,2));
    sa(gr(2,2)>gr(3,2)?1:0);
_3:
    if(sp()!=0)goto _6;else goto _4;
_4:
    sa(sr());
    sa((sr()%71)+9);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/71LL);

    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sr());

    if(sp()!=0)goto _13;else goto _5;
_5:
    sp();
    sa(sr());
    sa(7);
    sa(gr(2,0));
    gw(2,0,gr(2,0)+1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
_6:
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr()%10);
    sa(sr());
    sa(sp()*sp());

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
_7:
    if(sp()!=0)goto _12;else goto _8;
_8:
    sp();
    sp();
    sa(1);
_9:
    if(sp()!=0)goto _11;else goto _10;
_10:
    printf("%lld ", gr(3,0));
    sp();
    sp();
    return 0;
_11:
    sa(sr()>gr(3,2)?1:0);
    goto _3;
_12:
    gw(5,0,sp());
    sa(sp()+sp());

    sa(((gr(5,0)/10)%10)*((gr(5,0)/10)%10));
    sa(gr(5,0)/10);
    sa(gr(5,0)/10);
    goto _7;
_13:
    if(sr()!=89)goto _19;else goto _14;
_14:
    gw(3,0,gr(3,0)+1);
_15:
    gw(5,0,sp());
    sp();
    sa(gr(2,0));
_16:
    if((gr(2,0))!=0)goto _18;else goto _17;
_17:
    sp();
    sa(sp()-1LL);

    sa(sr());
    sa(sr());
    goto _9;
_18:
    sa(sp()-1LL);

    sa(sr());
    gw(2,0,sp());
    sa(7);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(gr(5,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sr()%71)+9);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/71LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(gr(2,0));
    goto _16;
_19:
    if(sr()!=1)goto _20;else goto _15;
_20:
    sp();
    goto _6;
_21:
    sa(sp()-1LL);

    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa((sr()%71)+9);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/71LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    goto _1;
}
