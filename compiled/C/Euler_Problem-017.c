/* compiled with BefunCompile v1.0.3 (c) 2015 */
#include <time.h>
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
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    d();
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _10;
_0:
    if(sp()!=0)goto _30; else goto _11;
_1:
    if(sp()!=0)goto _29; else goto _12;
_2:
    if(sp()!=0)goto _13; else goto _20;
_3:
    if(sp()!=0)goto _14; else goto _15;
_4:
    if(sp()!=0)goto _16; else goto _17;
_5:
    if(sp()!=0)goto _19; else goto _18;
_6:
    if(sp()!=0)goto _26; else goto _21;
_7:
    if(sp()!=0)goto _28; else goto _27;
_8:
    if(sp()!=0)goto _22; else goto _25;
_9:
    if(sp()!=0)goto _24; else goto _23;
_10:
    gw(20,1,(gr(20,1))-(48));
    sa(20);
    sa(20);
    goto _0;
_11:
    gw(20,2,(gr(20,2))-(48));
    sa(20);
    sa(20);
    goto _1;
_12:
    sp();
    sp();
    sa(0);
    sa(1000);
    sa(0);
    sa(1000);
    sa(0);
    goto _2;
_13:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _3;
_14:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _13;
_15:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _4;
_16:
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _2;
_17:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _5;
_18:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _17;
_19:
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    goto __;
_20:
    sa(sr());
    sa(100);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _6;
_21:
    sa(sr());
    sa(1000);
    {int64 v0=sp();sa(sp()-v0);}
    goto _8;
_22:
    sa(sr());
    sa(100);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    goto _9;
_23:
    sa(sr());
    sa(100);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(100);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(7);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(3);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _2;
_24:
    sa(100);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(7);
    sa(0);
    sa(1);
    goto _2;
_25:
    sp();
    sa(3);
    sa(8);
    sa(0);
    sa(1);
    goto _2;
_26:
    sa(sr());
    sa(20);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _7;
_27:
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(0);
    sa(1);
    goto _2;
_28:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _2;
_29:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(sr());
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _1;
_30:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(sr());
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(48);
    {int64 v0=sp();sa(sp()-v0);}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _0;
__:
    return 0;
}