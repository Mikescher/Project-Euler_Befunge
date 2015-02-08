/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } $3{#}!*9{ }  @v{ }  '>#{ }  (v#   <{ } #[>\"d\"4*:10p55**00p00g>1-::20p0\\2/>:20g\\%#^_:30p+30g>1-:#^_$v{ } #l|:{ }  3p+1/g01g0"
           "2%g01g02<{ } #Xv$${ }  -p100<{ } #~>00g1-20p090p>20g10g%20g10g/1+g40p40g10g%40g10g/1+g50p 20g50g-#v_20g40g`!#v_20g.\" - \",,,40g.5"
           "5+,v{ } #?|p02-1:g02{ }  H<{ }  *<{ }  'p09++g04g02g09<{ } #:@.g09<{ } $&";
int t=0;int z=0;
int64 g[13200];
int d(){int s,w,i,j,h;h=z;for(;t<329;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<400&&y<33){return g[y*400+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<400&&y<33){g[y*400+x]=v;}}
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
    goto _2;
_0:
    if(sp()!=0)goto _11; else goto _12;
_1:
    if(((gr(2,0))-(gr(5,0)))!=0)goto _13;else goto _14;
_2:
    gw(1,0,400);
    gw(0,0,10000);
    sa((gr(0,0))-(1));
    sa((gr(0,0))-(1));
    gw(2,0,(gr(0,0))-(1));
    goto _3;
_3:
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    goto _11;
_4:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _0;
_5:
    gw(0,1,0);
    gw(2,0,(gr(0,0))-(1));
    gw(9,0,0);
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1)));
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(1)));
    sp();
    sp();
    goto _1;
_6:
    printf("%lld", (int64)(gr(2,0)));
    sa(32);
    sa(45);
    printf("%c", (char)(32));
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    printf("%lld", (int64)(gr(4,0)));
    printf("%c", (char)(10));
    gw(9,0,(gr(9,0))+((gr(2,0))+(gr(4,0))));
    goto _13;
_7:
    printf("%lld", (int64)(gr(9,0)));
    return 0;
_8:
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1)));
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(1)));
    goto _1;
_9:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    goto _3;
_10:
    sa(sr());
    gw(3,0,sp());
    sa(sp()+sp());
    sa((gr(3,0))-(1));
    sa((gr(3,0))-(1));
    goto _0;
_11:
    sa(sr());
    sa(gr(2,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    if(sp()!=0)goto _4; else goto _10;
_12:
    sp();
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1),sp());
    sa(sr());
    if(sp()!=0)goto _9; else goto _5;
_13:
    sa(gr(2,0));
    gw(2,0,(gr(2,0))-(1));
    if(sp()!=0)goto _8; else goto _7;
_14:
    sa((((gr(2,0))>(gr(4,0))?1:0)!=0)?0:1);
    if(sp()!=0)goto _13; else goto _6;
}