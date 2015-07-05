/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    gw(1LL,0LL,1000LL);
    gw(2LL,0LL,150LL);
    gw(0LL,0LL,150000LL);
    gw(3LL,0LL,2LL);
    gw(0LL,1LL,32LL);
    gw(1LL,1LL,32LL);
    gw(5LL,0LL,(gr(1LL,0LL)*10LL)+1LL);
_1:
    gw(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+1LL,88LL);
    sa(gr(3LL,0LL)+gr(3LL,0LL));
    sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
_2:
    if(sp()!=0)goto _12;else goto _3;
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
    if(gr(0L,0L)>gr(3L,0L))goto _1;else goto _7;
_7:
    gw(3LL,0LL,0LL);
    gw(4LL,0LL,0LL);
_8:
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-88LL);
    if(sp()!=0)goto _8;else goto _10;
_10:
    sa(gr(5LL,0LL));
    sa(gr(4LL,0LL)+1LL);
    gw(4LL,0LL,gr(4LL,0LL)+1LL);
    gw(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+1LL,48LL);
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _8;else goto _11;
_11:
    printf("%lld", (int64)(gr(3LL,0LL)));
    return 0;
_12:
    sa(sr());
    sa(32LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3LL,0LL));
    sa(sr()<gr(0L,0L)?1:0);
    goto _2;
}