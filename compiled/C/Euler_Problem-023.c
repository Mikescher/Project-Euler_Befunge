/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ } $3{#}#>k{ } $W>v{ }  '>#{ }  (v#   <{ } #W>\"d\"4*:10p355***00p00g>1-::20p0\\2/:|>:20g\\%#^_:30p+30g>1-:#^_$v{ } #j|:p+1/g01g02"
           "% g01g02`g02{<{ }  /}  \"{ } #Ev{ }  0$p100<{ }  ,>{ }  )1^ vp+1/g01+g05g04%g01+g05g04+2%2g+1/g01+g05g04%g01+<{ } #1${ }  0>v{ } "
           " 3{>v{ }  2}  \" >v{ }  'v   <    g{ } #1>00g40p>40g1-:40p|>40g10g%40g10g/1+g2%|>40g1+50p>50g1-:50p|>50g10g%50g10g/1+g2%|>40g50g+"
           "00g`|    0{ } #8^{ }  ><{ }  )^{ }  ><{ }  '$<   >40g5^{ } #1v{ }  0<{ }  4^{ }  3<{ } #X>080p00g20p>20g1-20p20g10g%20g10g/1+g2/"
           "#v_v{ } #s|g02{ }  /<p08+g02g0 8<{ } #s>80g.@{ }  -^{ }  )<{ } #j";
int t=0;int z=0;
int64 g[35200];
int d(){int s,w,i,j,h;h=z;for(;t<577;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<400&&y<88){return g[y*400+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<400&&y<88){g[y*400+x]=v;}}
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
    gw(0LL,0LL,30000LL);
    sa(gr(0LL,0LL)-1LL);
    sa(gr(0LL,0LL)-1LL);
    gw(2LL,0LL,gr(0LL,0LL)-1LL);
_1:
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),2L));
    sa(sr());
    if(sp()!=0)goto _2;else goto _22;
_2:
    sa(sr());
    sa(gr(2LL,0LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    if(sp()!=0)goto _21;else goto _3;
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
    sa((sp()>gr(2L,0L))?1:0);
    gw(tm(gr(2LL,0LL),gr(1LL,0LL)),(td(gr(2LL,0LL),gr(1LL,0LL)))+1LL,sp());
_6:
    sa(sr());
    if(sp()!=0)goto _20;else goto _7;
_7:
    gw(0LL,1LL,0LL);
    gw(4LL,0LL,gr(0LL,0LL));
    sp();
    sp();
_8:
    sa(gr(4LL,0LL)-1LL);
    gw(4LL,0LL,gr(4LL,0LL)-1LL);
    if(sp()!=0)goto _14;else goto _9;
_9:
    gw(8LL,0LL,0LL);
    gw(2LL,0LL,gr(0LL,0LL));
_10:
    gw(2LL,0LL,gr(2LL,0LL)-1LL);
    if(td(gr(tm(gr(2LL,0LL),gr(1LL,0LL)),(td(gr(2LL,0LL),gr(1LL,0LL)))+1LL),2LL)!=0)goto _12;else goto _11;
_11:
    gw(8LL,0LL,gr(8LL,0LL)+gr(2LL,0LL));
_12:
    if((gr(2LL,0LL))!=0)goto _10;else goto _13;
_13:
    printf("%lld", (int64)(gr(8LL,0LL)));
    return 0;
_14:
    if(tm(gr(tm(gr(4LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL),gr(1LL,0LL)))+1LL),2LL)!=0)goto _15;else goto _8;
_15:
    gw(5LL,0LL,gr(4LL,0LL)+1LL);
_16:
    sa(gr(5LL,0LL)-1LL);
    gw(5LL,0LL,gr(5LL,0LL)-1LL);
    if(sp()!=0)goto _17;else goto _8;
_17:
    if(tm(gr(tm(gr(5LL,0LL),gr(1LL,0LL)),(td(gr(5LL,0LL),gr(1LL,0LL)))+1LL),2LL)!=0)goto _18;else goto _16;
_18:
    if((gr(4L,0L)+gr(5L,0L))>gr(0L,0L))goto _16;else goto _19;
_19:
    gw(tm(gr(4LL,0LL)+gr(5LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL)+gr(5LL,0LL),gr(1LL,0LL)))+1LL,(tm(gr(tm(gr(4LL,0LL)+gr(5LL,0LL),gr(1LL,0LL)),(td(gr(4LL,0LL)+gr(5LL,0LL),gr(1LL,0LL)))+1LL),2LL))+2LL);
    goto _16;
_20:
    sa(sp()-1LL);
    sa(sr());
    sa(sr());
    gw(2LL,0LL,sp());
    goto _1;
_21:
    sa(sp()-1LL);
    sa(sr());
    goto _4;
_22:
    gw(tm(gr(2LL,0LL),gr(1LL,0LL)),(td(gr(2LL,0LL),gr(1LL,0LL)))+1LL,1L>gr(2L,0L)?1:0);
    goto _6;
}