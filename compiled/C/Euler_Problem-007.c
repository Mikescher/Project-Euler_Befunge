/* compiled with BefunCompile v1.0.4 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v     // Project Euler - Problem 7{ } *0{#}0Zz{ }  mv{ }  @<{ } )B>\"d\"55+*:10p3\"2\"*:20p*00p230p\" \":01p11p10g5:+*1+50pv{ }  .> 03"
           "0p 040p>30g1+:30p:10g%\\10g/1+g\"X\"-      |{ } )Bv{ }  R<{ }  -_^#`g03g00 <|p+1/g01\\%g01:g03\"0\"-p04:+1g04g05<{ } )B> \"X\" 30g:10g%\\"
           "10g/1+p30g >30g+ : 00g\\`     #v_$>30g1+:30p:10g%\\10g/1+g\" \"- |>30g.@{ } )x^p+1/g01\\%g01:\\\" \":<  ^{ }  ;<{ } )d";
int t=0;int z=0;
int64 g[156000];
int d(){int s,w,i,j,h;h=z;for(;t<366;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<1000&&y<156){return g[y*1000+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<1000&&y<156){g[y*1000+x]=v;}}
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
    goto _3;
_0:
    if(sp()!=0)goto _5; else goto _6;
_1:
    if(sp()!=0)goto _11; else goto _7;
_2:
    if(sp()!=0)goto _9; else goto _12;
_3:
    gw(1,0,1000);
    gw(2,0,150);
    gw(0,0,150000);
    gw(3,0,2);
    gw(0,1,32);
    gw(1,1,32);
    gw(5,0,((gr(1,0))*(10))+(1));
    goto _4;
_4:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(1),88);
    sa((gr(3,0))+(gr(3,0)));
    sa((gr(0,0))>((gr(3,0))+(gr(3,0)))?1:0);
    goto _0;
_5:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(gr(3,0));
    sa(sp()+sp());
    sa(sr());
    sa(gr(0,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _0;
_6:
    sp();
    goto _7;
_7:
    sa((gr(3,0))+(1));
    gw(3,0,(gr(3,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(32);
    {int64 v0=sp();sa(sp()-v0);}
    goto _1;
_8:
    gw(3,0,0);
    gw(4,0,0);
    goto _9;
_9:
    sa((gr(3,0))+(1));
    gw(3,0,(gr(3,0))+(1));
    sa(sr());
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(gr(1,0));
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(88);
    {int64 v0=sp();sa(sp()-v0);}
    goto _2;
_10:
    printf("%lld", (int64)(gr(3,0)));
    return 0;
_11:
    sa((gr(0,0))>(gr(3,0))?1:0);
    if(sp()!=0)goto _4; else goto _8;
_12:
    sa(gr(5,0));
    sa((gr(4,0))+(1));
    gw(4,0,(gr(4,0))+(1));
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(1),48);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _9; else goto _10;
}