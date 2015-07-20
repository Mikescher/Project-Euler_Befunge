/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v000000    // Project Euler - Problem 69{ }  H{#} \"Rv{ }  5>p50g1+50pv{ }  I@.g07<v{ }  5^1g0<     >30g1+:30p40g-{ }  '#v_\";};}@"
           "\"**60p   0>:1g70g*v$>170p\"P\":10p3:20p*40p230pv^5g03_^#-\" \"g+1/g01\\%g01:g03<p050p030<      ^+1<v06:<$vp08*8**::**::8p11p10:\" \"<{ "
           "}  D_^#`g03g04< >g`  |>\"X\"30g:10g%\\10g/1+p30g>30g+:40g\\`{ }  '#v_$>30g1+:30p:10g%\\10g/1+g\" \"-|^  p07<{ }  7^p+1/g01\\%g01:\\\" \":< "
           " ^{ }  :<{ }  '";
int t=0;int z=0;
int64 g[800];
int d(){int s,w,i,j,h;h=z;for(;t<399;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<80&&y<10){return g[y*80+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<80&&y<10){g[y*80+x]=v;}}
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
    gw(7LL,0LL,1LL);
    gw(1LL,0LL,80LL);
    gw(2LL,0LL,3LL);
    gw(4LL,0LL,240LL);
    gw(3LL,0LL,2LL);
_1:
    gw(0LL,1LL,32LL);
    gw(1LL,1LL,32LL);
    gw(8LL,0LL,1073741824LL);
    gw(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+1LL,88LL);
    sa(gr(3LL,0LL)+gr(3LL,0LL));
    sa((gr(3L,0L)+gr(3L,0L))<gr(4L,0L)?1:0);
_2:
    if(sp()!=0)goto _15;else goto _3;
_3:
    sp();
_4:
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-32LL);
    if(sp()!=0)goto _6;else goto _4;
_6:
    if(gr(4L,0L)>gr(3L,0L))goto _1;else goto _7;
_7:
    gw(3LL,0LL,0LL);
    gw(5LL,0LL,0LL);
_8:
    if(gr(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+1LL)!=32LL)goto _14;else goto _9;
_9:
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(sp()-gr(4LL,0LL));
    if(sp()!=0)goto _8;else goto _10;
_10:
    gw(6LL,0LL,1000000LL);
    sa(0LL);
    sa(gr(0LL,1LL)*gr(7LL,0LL));
    sa((gr(0L,1L)*gr(7L,0L))>gr(6L,0L)?1:0);
_11:
    if(sp()!=0)goto _12;else goto _13;
_12:
    sp();
    sp();
    printf("%lld", (int64)(gr(7LL,0LL)));
    return 0;
_13:
    gw(7LL,0LL,sp());
    sa(sp()+1LL);
    sa(sr());
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(7LL,0LL));
    sa(sr()>gr(6L,0L)?1:0);
    goto _11;
_14:
    gw(gr(5LL,0LL),1LL,gr(3LL,0LL));
    gw(5LL,0LL,gr(5LL,0LL)+1LL);
    goto _9;
_15:
    sa(sr());
    sa(32LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3LL,0LL));
    sa(sr()<gr(4L,0L)?1:0);
    goto _2;
}