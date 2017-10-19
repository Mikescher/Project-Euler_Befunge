/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } $3{#}!*9{ }  A>v{ }  '>#{ }  (v#   <{ } #Y>\"d\"4*:10p55**00p00g>1-::20p0\\2/:|>:20g\\%#^_:30p+30g>1-:#^_$v{ } #j|:{ }  5p+1/g0"
           "1g02%g01g02<{ } #Vv$${ }  -p100<{ }  ,>1{ }  9^{ } #V>00g1-20p090p>20g10g%20g10g/1+g40p40g10g%40g10g/1+g50p 20g50g-#v_20g40g`!#v"
           "_20g.\" - \",,,40g.55+,v{ } #?|p02-1:g02{ }  H<{ }  *<{ }  'p09++g04g02g09<{ } #:@.g09<{ } $&";
int t=0;int z=0;
int64 g[13200];
int d(){int s,w,i,j,h;h=z;for(;t<347;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
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
    int64 t0,t1,t2;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1,0,400);
    gw(0,0,10000);
    sa(gr(0,0)-1);
    sa(0);
    sa((gr(0,0)-1)/2);
    sa((gr(0,0)-1)/2);
    gw(2,0,gr(0,0)-1);
_1:
    if(sp()!=0)goto _2;else goto _15;
_2:
    t0=gr(2,0);
    sa(sr());
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}

    t1=sp();

    if((t1)!=0)goto _14;else goto _3;
_3:
    sa(sr());
    gw(3,0,sp());
    sa(sp()+sp());

    sa(gr(3,0)-1);
    sa(gr(3,0)-1);
_4:
    if(sp()!=0)goto _2;else goto _5;
_5:
    sp();
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,sp());
_6:
    sa(sr());

    if(sp()!=0)goto _13;else goto _7;
_7:
    gw(0,1,0);
    gw(2,0,gr(0,0)-1);
    gw(9,0,0);
    sp();
    sp();
_8:
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1));
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1));

    if((gr(2,0)-gr(5,0))!=0)goto _9;else goto _11;
_9:
    t2=gr(2,0);
    gw(2,0,gr(2,0)-1);

    if((t2)!=0)goto _8;else goto _10;
_10:
    printf("%lld ", gr(9,0));
    return 0;
_11:
    if(gr(2,0)>gr(4,0))goto _12;else goto _9;
_12:
    printf("%lld ", gr(2,0));
    printf(" - ");
    printf("%lld ", gr(4,0));
    printf("\n");
    gw(9,0,gr(9,0)+gr(2,0)+gr(4,0));
    goto _9;
_13:
    sa(sp()-1LL);

    sa(sr());
    sa(sr());
    gw(2,0,sp());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/2LL);

    sa(sr());
    goto _1;
_14:
    sa(sp()-1LL);

    sa(sr());
    goto _4;
_15:
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,1);
    goto _6;
}
