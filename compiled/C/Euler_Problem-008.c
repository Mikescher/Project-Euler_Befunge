/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "\"v\"00p54*:10p552**:20p*30p85+40p050p060p070p080p    v{ }  _>150g60p>60g:20g%\\20g/9+g\"0\"-*60g1+:60p50g-40g-#v_:80g`#v_$>50g1+:50p"
           "30g-#v_ 970p >70g0g.70g8-40g-#v_\"=\",80g.@{ }  .^{ }  G<   $      ^{ }  W<{ }  X>80p060p>60g50g+:2 0g%\\20g /9+g\"0\"-60g9+0p6 0g1+:"
           "60p40g-#v_^^{ }  S<{ }  5<{ }  '^p07+1g07{ }  (<{ }  p^{ }  P<{ } #a73167176531330624919225119674426574742355349194934{ }  b9698"
           "3520312774506326239578318016984801869478851843{ }  b85861560789112949495459501737958331952853208805511{ }  b12540698747158523863"
           "050715693290963295227443043557{ }  b66896648950445244523161731856403098711121722383113{ }  b622298934233803081353362766142828064"
           "44486645238749{ }  b30358907296290491560440772390713810515859307960866{ }  b70172427121883998797908792274921901699720888093776{ "
           "}  b65727333001053367881220235421809751254540594752243{ }  b52584907711670556013604839586446706324415722155397{ }  b536978179778"
           "46174064955149290862569321978468622482{ }  b83972241375657056057490261407972968652414535100474{ }  b8216637048440319989000889524"
           "3450658541227588666881{ }  b16427171479924442928230863465674813919123162824586{ }  b17866458359124566529476545682848912883142607"
           "690042{ }  b24219022671055626321111109370544217506941658960408{ }  b07198403850962455444362981230987879927244284909188{ }  b8458"
           "0156166097919133875499200524063689912560717606{ }  b05886116467109405077541002256983155200055935729725{ }  b71636269561882670428"
           "252483600823257530420752963450{ }  b";
int t=0;int z=0;
int64 g[3364];
int d(){int s,w,i,j,h;h=z;for(;t<1444;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<116&&y<29){return g[y*116+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<116&&y<29){g[y*116+x]=v;}}
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
    gw(0LL,0LL,118LL);
    gw(1LL,0LL,20LL);
    gw(2LL,0LL,50LL);
    gw(3LL,0LL,1000LL);
    gw(4LL,0LL,13LL);
    gw(5LL,0LL,0LL);
    gw(6LL,0LL,0LL);
    gw(7LL,0LL,0LL);
    gw(8LL,0LL,0LL);
_1:
    gw(6LL,0LL,gr(5LL,0LL));
    sa(gr(tm(gr(6LL,0LL),gr(2LL,0LL)),(td(gr(6LL,0LL),gr(2LL,0LL)))+9LL)-48LL);
_2:
    sa(gr(6LL,0LL)+1LL);
    gw(6LL,0LL,gr(6LL,0LL)+1LL);
    sa(sp()-gr(5LL,0LL));
    sa(sp()-gr(4LL,0LL));
    if(sp()!=0)goto _3;else goto _4;
_3:
    sa(sp()*(gr(tm(gr(6LL,0LL),gr(2LL,0LL)),(td(gr(6LL,0LL),gr(2LL,0LL)))+9LL)-48LL));
    goto _2;
_4:
    if(sr()>gr(8L,0L))goto _11;else goto _5;
_5:
    sp();
_6:
    sa(gr(5LL,0LL)+1LL);
    gw(5LL,0LL,gr(5LL,0LL)+1LL);
    sa(sp()-gr(3LL,0LL));
    if(sp()!=0)goto _1;else goto _7;
_7:
    gw(7LL,0LL,9LL);
_8:
    printf("%lld", (int64)(gr(gr(7LL,0LL),0LL)));
    if(gr(7LL,0LL)-8LL!=gr(4LL,0LL))goto _10;else goto _9;
_9:
    printf("=");
    printf("%lld", (int64)(gr(8LL,0LL)));
    return 0;
_10:
    gw(7LL,0LL,gr(7LL,0LL)+1LL);
    goto _8;
_11:
    gw(8LL,0LL,sp());
    gw(6LL,0LL,0LL);
_12:
    gw(gr(6LL,0LL)+9LL,0LL,gr(tm(gr(6LL,0LL)+gr(5LL,0LL),gr(2LL,0LL)),(td(gr(6LL,0LL)+gr(5LL,0LL),gr(2LL,0LL)))+9LL)-48LL);
    sa(gr(6LL,0LL)+1LL);
    gw(6LL,0LL,gr(6LL,0LL)+1LL);
    sa(sp()-gr(4LL,0LL));
    if(sp()!=0)goto _12;else goto _6;
}