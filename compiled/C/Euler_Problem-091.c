/* compiled with BefunCompile v1.0.8 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0;
    int64 x0=50;
    int64 x1=0;
    int64 x2=50;
    int64 x3=88;
    int64 x4=88;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    x3=x0;
    x4=x3+1;
_2:
    if(((x3*(x4-x3))>(x2*x2)?1:0)+(x4>x0?1LL:0LL)==0)goto _7;else goto _3;
_3:
    t0=x3-1;
    x3--;
    t0=(t0!=0)?0:1;
    if((t0)!=0)goto _4;else goto _6;
_4:
    t0=x2-1;
    x2--;
    if((t0)!=0)goto _1;else goto _5;
_5:
    printf("%lld", x1+(3*x0*x0));
    return 0;
_6:
    x4=x3+1;
    goto _2;
_7:
    x1+=((tm((x3-x4)*x3,x2)!=0)?0:1)*2LL;
    x4++;
    goto _2;
}