/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ }  O033544355436688779886{ }  ;0366555766{ }  F${ }  O$   v-1{ }  +<    v-1{ }  *<{ }  +>54*>:::1g\"0\"-\\1p#^_54*>:::2g\"0\"-\\2p|"
           "{ }  +v{ }  7**25\"d\" 0 $$<{ }  +v{ }  N<   v{ }  ,$<   >:55+/2g\\55+%{ }  +v  :{ }  .>:54*`|{ }  )>\"d\"/1g70     v  >0\\>:!#v_:\"d\"\\"
           "`| ^0g1<  >:\"d\"%!|{ }  (v    <  v      <{ }  '>:\";}\"8*-#^_$380v>:\"d\"/1g\\ \"d\"%v     ^{ }  :<{ }  )<\\3\\7<  >+# \\:# _+{ }  *\\ 1-{ }"
           "  6:|{ }  A@.+_ #! #:\\ #+<";
int t=0;int z=0;
int64 g[720];
int d(){int s,w,i,j,h;h=z;for(;t<410;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<48&&y<15){return g[y*48+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<48&&y<15){g[y*48+x]=v;}}
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
    gw(20LL,1LL,gr(20LL,1LL)-48LL);
    sa(19LL);
_1:
    sa(sr());
    sa(sr());
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    if(sp()!=0)goto _24;else goto _2;
_2:
    gw(20LL,2LL,gr(20LL,2LL)-48LL);
    sa(19LL);
_3:
    sa(sr());
    sa(sr());
    sa(sr());
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    if(sp()!=0)goto _23;else goto _4;
_4:
    sp();
    sp();
    sa(0LL);
    sa(1000LL);
    sa(0LL);
    sa(1000LL);
_5:
    if(sr()<100L)goto _6;else goto _18;
_6:
    if(sr()>20L)goto _17;else goto _7;
_7:
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()+0LL);
_8:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _16;else goto _9;
_9:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _13;else goto _10;
_10:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _11;else goto _12;
_11:
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    return 0;
_12:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _10;
_13:
    sa(sr());
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
_14:
    if(sp()!=0)goto _15;else goto _5;
_15:
    sa(sp()+sp());
    goto _8;
_16:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _8;
_17:
    sa(td(sr(),10LL));
    sa(2LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),10L));
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _14;
_18:
    if(sr()!=1000LL)goto _20;else goto _19;
_19:
    sp();
    sa(3LL);
    sa(8LL);
    goto _8;
_20:
    if(tm(sr(),100L)==0)goto _22;else goto _21;
_21:
    sa(td(sr(),100LL));
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),100L));
    sa(7LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(3LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _14;
_22:
    sa(td(sp(),100L));
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(7LL);
    goto _8;
_23:
    sa(sp()-1LL);
    goto _3;
_24:
    sa(sp()-1LL);
    goto _1;
}