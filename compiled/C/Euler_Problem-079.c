/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{ }  X{+}  * 319 680 180 690 129 620 762 689 762 318      {+}  * 368 710 720 710 629 168 160 689 716 731      {+}  * 736 729 31"
           "6 729 729 710 769 290 719 680      {+}  * 318 389 162 289 162 718 729 319 790 680      {+}  * 890 362 319 760 316 729 380 319 72"
           "8 716      {+}  *{ }  N{+}  * {#}  *{ }  C{+}  *{ }  N{+}  * {X}  *{ }  C{+}  *{ } !&>55+>:1\\:v>:55+/1+30p:55+%4*66++20p020g0+30"
           "gg\"0\"-:50p66v    |:-1p< v1g070p+1g07+1g062p+1g07+1g052p+1g06+1g052< +    >$ 77*^>+50g1+p070g1+60g1vv{<{ }  *}  \"p +{ }  *|\\-1:p+"
           "1g05+1g060p+<1|!\\-1:   <p 9++66 p0< 7 7{ }  (v+># $# 0# 9# 0# p# 9#<>:66++7g#^_ :90g:1+9^ + p{ }  (>:90g-!#v_:::66++9g1+\\65++9g1"
           "+g*!#^_::v      + 0{ }  (^p9++66\\ g02:-1p9++66\\g9++56p02g9++66:<      6 2{ }  0>$0>:66++9g68*+v >020g2+30gg\"0\"-:70p6^ 0{ }  0@$_"
           "^#!-g09:+1, < ^p7++66p06:-\"0\"gg03+1g<";
int t=0;int z=0;
int64 g[1176];
int d(){int s,w,i,j,h;h=z;for(;t<805;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<56&&y<21){return g[y*56+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<56&&y<21){g[y*56+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0,t1;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(10,10,1);
    sa(9);
    sa(9);
_1:
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr());
    goto _1;
_3:
    gw(3,0,5);
    gw(2,0,48);
    sp();
    sa(49);
_4:
    sa(0);
    sa(gr(gr(2,0),gr(3,0))-36);
    gw(5,0,gr(gr(2,0),gr(3,0))-48);
    sa(7);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(0);
    sa(gr(gr(2,0)+1,gr(3,0))-36);
    gw(6,0,gr(gr(2,0)+1,gr(3,0))-48);
    sa(7);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(0);
    sa(gr(gr(2,0)+2,gr(3,0))-36);
    gw(7,0,gr(gr(2,0)+2,gr(3,0))-48);
    sa(7);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(gr(5,0)+1,gr(6,0)+1,2);
    gw(gr(5,0)+1,gr(7,0)+1,2);
    gw(gr(6,0)+1,gr(7,0)+1,2);
    gw(gr(7,0)+1,gr(5,0)+1,0);
    gw(gr(7,0)+1,gr(6,0)+1,0);
    gw(gr(6,0)+1,gr(5,0)+1,0);
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _18;else goto _5;
_5:
    gw(9,0,0);
    sp();
    sa(9);
    sa(gr(21,7));
_6:
    if(sp()!=0)goto _7;else goto _17;
_7:
    sa(sr()-1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)goto _8;else goto _9;
_8:
    sa(gr(sr()+12,7));
    goto _6;
_9:
    sa(sp()+1LL);
_10:
    if((sr()-gr(9,0))!=0)goto _11;else goto _13;
_11:
    sa(sr());
    sa(sr());
    sa(gr(sr()+12,9)+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+11LL);

    sa(9);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()+1LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    sa(sp()*t0);

    t1=sp();

    if((t1)!=0)goto _12;else goto _9;
_12:
    sa(sr());
    sa(sr());
    gw(2,0,gr(sr()+12,9));
    sa(sp()+11LL);

    sa(9);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+12LL);

    sa(9);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr());
    sa(gr(2,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+12LL);

    sa(9);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _10;
_13:
    printf("%c", (char)(gr(12,9)+48));
    sp();
    sa(1);
    sa(1-gr(9,0));
_14:
    if(sp()!=0)goto _16;else goto _15;
_15:
    sp();
    return 0;
_16:
    printf("%c", (char)(gr(sr()+12,9)+48));
    sa(sp()+1LL);

    sa(sr()-gr(9,0));
    goto _14;
_17:
    sa(sr());
    sa(gr(9,0)+12);
    gw(9,0,gr(9,0)+1);
    sa(9);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _7;
_18:
    gw(3,0,(sr()/10)+1);
    gw(2,0,((sr()%10)*4)+12);
    goto _4;
}
