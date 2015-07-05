/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1LL,0LL,400LL);
    gw(0LL,0LL,10000LL);
    sa(gr(0LL,0LL)-1LL);
    sa(gr(0LL,0LL)-1LL);
    gw(2LL,0LL,gr(0LL,0LL)-1LL);
_1:
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),2L));
    sa(sr());
    if(sp()!=0)goto _2;else goto _16;
_2:
    sa(sr());
    sa(gr(2LL,0LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    if(sp()!=0)goto _15;else goto _3;
_3:
    sa(sr());
    gw(3LL,0LL,sp());
    sa(sp()+sp());
    sa(gr(3LL,0LL)-1LL);
    sa(gr(3LL,0LL)-1LL);
_4:
    if(sp()!=0)goto _2;else goto _5;
_5:
    sp();
    gw(tm(gr(2LL,0LL),gr(1LL,0LL)),(td(gr(2LL,0LL),gr(1LL,0LL)))+1LL,sp());
_6:
    sa(sr());
    if(sp()!=0)goto _14;else goto _7;
_7:
    gw(0LL,1LL,0LL);
    gw(2LL,0LL,gr(0LL,0LL)-1LL);
    gw(9LL,0LL,0LL);
    gw(4LL,0LL,gr(tm(gr(2LL,0LL),gr(1LL,0LL)),(td(gr(2LL,0LL),gr(1LL,0LL)))+1LL));
    gw(5LL,0LL,gr(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL));
    sp();
    sp();
_8:
    if(gr(2LL,0LL)!=gr(5LL,0LL))goto _9;else goto _12;
_9:
    sa(gr(2LL,0LL));
    gw(2LL,0LL,gr(2LL,0LL)-1LL);
    if(sp()!=0)goto _10;else goto _11;
_10:
    gw(4LL,0LL,gr(tm(gr(2LL,0LL),gr(1LL,0LL)),(td(gr(2LL,0LL),gr(1LL,0LL)))+1LL));
    gw(5LL,0LL,gr(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL));
    goto _8;
_11:
    printf("%lld", (int64)(gr(9LL,0LL)));
    return 0;
_12:
    if(gr(2L,0L)<=gr(4L,0L))goto _9;else goto _13;
_13:
    printf("%lld", (int64)(gr(2LL,0LL)));
    sa(32LL);
    sa(45LL);
    printf(" ");
    printf("%c", (char)(sp()));
    printf("%c", (char)(sp()));
    printf("%lld", (int64)(gr(4LL,0LL)));
    gw(9LL,0LL,gr(9LL,0LL)+gr(2LL,0LL)+gr(4LL,0LL));
    printf("\n");
    goto _9;
_14:
    sa(sp()-1LL);
    sa(sr());
    sa(sr());
    gw(2LL,0LL,sp());
    goto _1;
_15:
    sa(sp()-1LL);
    sa(sr());
    goto _4;
_16:
    gw(tm(gr(2LL,0LL),gr(1LL,0LL)),(td(gr(2LL,0LL),gr(1LL,0LL)))+1LL,1LL);
    goto _6;
}