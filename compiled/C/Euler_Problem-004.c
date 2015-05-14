/* compiled with BefunCompile v1.0.5 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "1:010:pp5558***04p>10g1+::10p04g-00g \\#v_1+:00p\\$1:10p\\:04g- #v_$$03g.@{ }  2^{ }  )v $<{ }  '>1# 0# 1# p# *# :# v#  <{ }  +v_v#"
           "-g1-g20g10g 1g20<p201<v_^#:/+55p10+1g10p1g10%+55:  <{ }  /$ >02g1+:02p 01 g - |     >{ }  <^{ }  />{ }  .^    >:03g\\`#v_03pv{ } "
           " T^{ }  +$<   0<{ }  B";
int t=0;int z=0;
int64 g[426];
int d(){int s,w,i,j,h;h=z;for(;t<278;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<71&&y<6){return g[y*71+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<71&&y<6){g[y*71+x]=v;}}
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
    gw(0,0,1);
    gw(1,0,1);
    gw(0,4,1000);
_1:
    sa(gr(1,0)+1);
    sa(gr(1,0)+1);
    gw(1,0,gr(1,0)+1);
    sa(gr(0,4));
    {int64 v0=sp();sa(sp()-v0);}
    sa(gr(0,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sp()!=0)goto _4;else goto _2;
_2:
    sa(1);
    sa(sp()+sp());
    sa(sr());
    gw(0,0,sp());
    gw(1,0,1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sp();
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(gr(0,4));
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _4;else goto _3;
_3:
    sp();
    sp();
    printf("%lld", (int64)(gr(0,3)));
    return 0;
_4:
    gw(0,1,1);
    sa(sp()*sp());
    sa(sr());
_5:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    gw(gr(0,1),1,sp());
    gw(0,1,gr(0,1)+1);
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    if(sp()!=0)goto _5;else goto _7;
_7:
    gw(0,2,1);
    sp();
_8:
    if((gr(gr(0,2),1)-gr(gr(0,1)-gr(0,2),1))!=0)goto _13;else goto _9;
_9:
    sa(gr(0,2)+1);
    gw(0,2,gr(0,2)+1);
    sa(gr(0,1));
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _8;else goto _10;
_10:
    sa(sr());
    sa(gr(0,3));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _11;else goto _12;
_11:
    sp();
    goto _1;
_12:
    gw(0,3,sp());
    goto _1;
_13:
    sp();
    goto _1;
}