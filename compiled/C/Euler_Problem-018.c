/* transpiled with BefunCompile v1.1.0 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "  >53* 00p00g1-20p010p>10g3*:20g1+g\"0\"-55+*\\1+20g1+g\"0\"-+10g20g1+p10g1+:10p20g-1-#v_20g:1-20p010p#v_v{ }  375{ }  4^{ }  [<{ }  "
           "/< v{ }  395 64{ }  1v{ }  m<{ }  317 47 82{ }  a> $v{ }  K18 35 87 10{ }  +>00g2-:10p20p>10g20g1+g10g20g2+g:10g1+20g2+g -:0`>#^"
           "_->+10g20g1+p10g:1-10p#v_20g:1-:20p10p#v_01g.@20 04 82 47 65{ }  5^{ }  ]<{ }  /<      19 01 23 75 03 34{ } !(88 02 77 73 07 63 "
           "67{ } !%99 65 04 28 06 16 70 92{ } !\"41 41 26 56 83 40 80 70 33{ }  ~41 48 72 33 47 32 37 16 94 29{ }  {53 71 44 65 25 43 91 52 "
           "97 51 14{ }  x70 11 33 28 77 73 17 78 39 68 17 57{ }  u91 71 52 38 17 14 91 43 58 50 27 29 48{ }  r63 66 04 68 89 53 67 30 73 16"
           " 69 87 40 31{ }  o04 62 98 27 23 09 70 98 73 93 38 53 60 04 23{ }  l";
int t=0;int z=0;
int64 g[1920];
int d(){int s,w,i,j,h;h=z;for(;t<708;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<120&&y<16){return g[y*120+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<120&&y<16){g[y*120+x]=v;}}
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
    gw(0,0,15);
    gw(2,0,gr(0,0)-1);
    gw(1,0,0);
_1:
    gw(gr(1,0),gr(2,0)+1,((gr(gr(1,0)*3,gr(2,0)+1)-48)*10)+(gr((gr(1,0)*3)+1,gr(2,0)+1)-48));
    t0=gr(1,0)+1;
    gw(1,0,gr(1,0)+1);
    t0-=gr(2,0);
    t0--;
    if((t0)!=0)goto _1;else goto _3;
_3:
    t0=gr(2,0);
    gw(2,0,gr(2,0)-1);
    gw(1,0,0);

    if((t0)!=0)goto _1;else goto _4;
_4:
    t0=gr(0,0)-2;
    gw(1,0,gr(0,0)-2);
    gw(2,0,t0);
_5:
    sa(gr(gr(1,0),gr(2,0)+1));
    sa(gr(gr(1,0),gr(2,0)+2));
    t0=gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2);

    if((gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2))>0)goto _6;else goto _9;
_6:
    sa(sp()+sp());

    t0=sp();
    gw(gr(1,0),gr(2,0)+1,t0);
    t0=gr(1,0);
    gw(1,0,gr(1,0)-1);

    if((t0)!=0)goto _5;else goto _7;
_7:
    t0=gr(2,0);
    t1=gr(2,0)-1;
    gw(2,0,gr(2,0)-1);
    gw(1,0,t1);

    if((t0)!=0)goto _5;else goto _8;
_8:
    printf("%lld", gr(0,1));
    return 0;
_9:
    sa(sp()-t0);
    goto _6;
}
