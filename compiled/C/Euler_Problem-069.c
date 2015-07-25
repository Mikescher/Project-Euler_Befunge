/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(7,0,1);
    gw(1,0,80);
    gw(2,0,3);
    gw(4,0,240);
    gw(3,0,2);
_1:
    gw(0,1,32);
    gw(1,1,32);
    gw(8,0,1073741824);
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
_2:
    if(sp()!=0)goto _15;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));
    sa(sp()+1LL);
    {int64 v0=sp();t0=gr(sp(),v0);}
    t0=t0-32;
    if((t0)!=0)goto _6;else goto _4;
_6:
    if(gr(4,0)>gr(3,0))goto _1;else goto _7;
_7:
    gw(3,0,0);
    gw(5,0,0);
_8:
    if(gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1)!=32)goto _14;else goto _9;
_9:
    t0=gr(3,0)+1;
    gw(3,0,gr(3,0)+1);
    t0=t0-gr(4,0);
    if((t0)!=0)goto _8;else goto _10;
_10:
    gw(6,0,1000000);
    sa(0);
    sa(gr(0,1)*gr(7,0));
    sa((gr(0,1)*gr(7,0))>gr(6,0)?1:0);
_11:
    if(sp()!=0)goto _13;else goto _12;
_12:
    gw(7,0,sp());
    sa(sp()+1LL);
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(7,0));
    sa(sr()>gr(6,0)?1:0);
    goto _11;
_13:
    printf("%lld", gr(7,0));
    sp();
    sp();
    return 0;
_14:
    gw(gr(5,0),1,gr(3,0));
    gw(5,0,gr(5,0)+1);
    goto _9;
_15:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));
    sa(sr()<gr(4,0)?1:0);
    goto _2;
}