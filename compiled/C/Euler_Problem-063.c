/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v XXXX   {#}  g  XX{ } !'v1\\1p12::+1   \\+g2<{ }  C0{ }  1v9p03p02<{ }  )\\g12:+1<^2\\p22_v{ }  <1{ }  *>{v     }  \"{ }  )<  v-\\\"P\""
           "<{ }  ':${ }  <>{ }  (:v1v>0p>9>:\"0\"\\0p1+:\"O\"-|>:0g\"0\"-||!`g12<-${ }  F:p\\3v p050p04\"O\"<p0\\\"1\"<^+>#1 $#< :21g-|\\.{ }  F211p> 40g"
           "0g\"0\"-2 0g*50g+:55+%\"0\"v>$55+0v+@{ }  F>^20|-8p04:-1g04 p05/+5 #5p0g04+<>5#$5#<^{ }  I>^>30g1-:30p #^_9     ^{ }  M";
int t=0;int z=0;
int64 g[800];
int d(){int s,w,i,j,h;h=z;for(;t<371;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
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
    gw(2LL,1LL,1LL);
    gw(2LL,0LL,1LL);
    gw(3LL,0LL,1LL);
    gw(9LL,0LL,48LL);
    sa(0LL);
    sa(1LL);
    sa(1LL);
    sa(10LL);
_1:
    sa(sr());
    sa(48LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+1LL);
    if(sr()!=79LL)goto _1;else goto _3;
_3:
    sa(49LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
_4:
    gw(4LL,0LL,79LL);
    gw(5LL,0LL,0LL);
_5:
    sa(((gr(gr(4LL,0LL),0LL)-48LL)*gr(2LL,0LL))+gr(5LL,0LL));
    gw(gr(4LL,0LL),0LL,(tm(((gr(gr(4LL,0LL),0LL)-48LL)*gr(2LL,0LL))+gr(5LL,0LL),10LL))+48LL);
    sa(td(sp(),10L));
    gw(5LL,0LL,sp());
    sa(gr(4LL,0LL)-1LL);
    gw(4LL,0LL,gr(4LL,0LL)-1LL);
    sa(sp()-8LL);
    if(sp()!=0)goto _5;else goto _7;
_7:
    sa(gr(3LL,0LL)-1LL);
    gw(3LL,0LL,gr(3LL,0LL)-1LL);
    if(sp()!=0)goto _4;else goto _8;
_8:
    sa(9LL);
    sa(gr(9LL,0LL)-48LL);
_9:
    if(sp()!=0)goto _10;else goto _18;
_10:
    sa(80LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    if(sr()!=gr(2LL,1LL))goto _11;else goto _16;
_11:
    sa((sp()>gr(2L,1L))?1:0);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _14;else goto _12;
_12:
    sp();
    sa(0LL);
_13:
    sp();
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_14:
    sa(sp()+1LL);
    sa(sr());
    sa(gr(2LL,1LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    gw(2LL,0LL,sp());
_15:
    gw(3LL,0LL,sp());
    gw(9LL,0LL,48LL);
    sa(10LL);
    goto _1;
_16:
    sp();
    sa(10LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    if(sp()!=0)goto _17;else goto _13;
_17:
    gw(2LL,2LL,sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+gr(2LL,2LL));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);
    sa(sr());
    sa(sr());
    gw(2LL,1LL,sp());
    gw(2LL,0LL,1LL);
    sa(1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _15;
_18:
    sa(sp()+1LL);
    sa(sr());
    sa(0LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    goto _9;
}