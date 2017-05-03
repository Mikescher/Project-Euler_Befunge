/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(20,1,gr(20,1)-48);
    sa(19);
_1:
    sa(sr());
    sa(sr());
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}

    if(sp()!=0)goto _24;else goto _2;
_2:
    gw(20,2,gr(20,2)-48);
    sa(19);
_3:
    sa(sr());
    sa(sr());
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}

    if(sp()!=0)goto _23;else goto _4;
_4:
    sp();
    sp();
    sa(0);
    sa(1000);
    sa(0);
    sa(1000);
_5:
    if(sr()<100)goto _6;else goto _18;
_6:
    if(sr()>20)goto _17;else goto _7;
_7:
    sa(1);
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

    if(sp()!=0)goto _12;else goto _11;
_11:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _10;
_12:
    sa(sp()+sp());

    t0=sp();
    printf("%lld", t0);
    return 0;
_13:
    sa(sr());
    sa(0);
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
    sa(td(sr(),10));
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);
    goto _14;
_18:
    if(sr()!=1000)goto _20;else goto _19;
_19:
    sp();
    sa(3);
    sa(8);
    goto _8;
_20:
    if(tm(sr(),100)==0)goto _22;else goto _21;
_21:
    sa(td(sr(),100));
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),100));

    sa(7);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(3);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _14;
_22:
    sa(td(sp(),100));

    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(7);
    goto _8;
_23:
    sa(sp()-1LL);
    goto _3;
_24:
    sa(sp()-1LL);
    goto _1;
}
