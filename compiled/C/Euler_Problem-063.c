/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(2,1,1);
    gw(2,0,1);
    gw(3,0,1);
    gw(9,0,48);
    sa(0);
    sa(1);
    sa(1);
    sa(10);
    sa(-69);
_1:
    if(sp()!=0)goto _18;else goto _2;
_2:
    sa(49);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
_3:
    gw(4,0,79);
    gw(5,0,0);
_4:
    t0=(((gr(gr(4,0),0)-48)*gr(2,0))+gr(5,0))/10;
    gw(gr(4,0),0,((((gr(gr(4,0),0)-48)*gr(2,0))+gr(5,0))%10)+48);
    gw(5,0,t0);
    t0=gr(4,0)-9;
    gw(4,0,gr(4,0)-1);
    if((t0)!=0)goto _4;else goto _6;
_6:
    t0=gr(3,0)-1;
    gw(3,0,gr(3,0)-1);

    if((t0)!=0)goto _3;else goto _7;
_7:
    sa(9);
    sa(gr(9,0)-48);
_8:
    if(sp()!=0)goto _9;else goto _17;
_9:
    t0=80;
    sa(t0);
    t0=0;
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}


    if((sr()-gr(2,1))!=0)goto _14;else goto _10;
_10:
    t0=10;
    sp();
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}

    sa(sr());

    if(sp()!=0)goto _12;else goto _11;
_11:
    sp();
    sp();
    printf("%lld ", (int64)(sp()));
    return 0;
_12:
    gw(2,2,sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+gr(2,2));

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);

    sa(sr());
    sa(sr());
    gw(2,1,sp());
    gw(2,0,1);
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_13:
    gw(3,0,sp());
    gw(9,0,48);
    sa(10);
    sa(-69);
    goto _1;
_14:
    sa((sp()>gr(2,1))?1:0);


    if(sp()!=0)goto _15;else goto _16;
_15:
    sp();
    sa(10);
    sa(0);
    goto _10;
_16:
    sa(sp()+1LL);

    sa(sr());
    sa(gr(2,1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    gw(2,0,sp());
    goto _13;
_17:
    sa(sp()+1LL);

    sa(sr());
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48LL);
    goto _8;
_18:
    sa(sr());
    sa(48);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+1LL);

    sa(sr()-79);
    goto _1;
}
