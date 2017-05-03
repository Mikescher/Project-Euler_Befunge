/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
    int64 x0=2;
    int64 x1=0;
    int64 x2=1000000000;
    int64 x3=1;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    if(x2>(x0*2))goto _3;else goto _2;
_2:
    printf("%lld", x1);
    return 0;
_3:
    x1=((x0>2?1:0)*(((tm(2*x0,3))-1!=0)?0:1)*((tm((x0-2)*x3,3)!=0)?0LL:1LL)*((x0*2)-2))+x1;
    x1=((((tm(x0*2,3))-2!=0)?0:1)*((tm((x0+2)*x3,3)!=0)?0LL:1LL)*(2+(2*x0)))+x1;
    t0=x0+(x3*2);
    x0=(x0*2)+(x3*3);
    x3=t0;
    goto _1;
}
