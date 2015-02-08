/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
    int64 x0=32;
    int64 x1=32;
    int64 x2=32;
    int64 x3=32;
    int64 x4=32;
    int64 x5=32;
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    x0=0;
    x1=0;
    x3=6;
    x4=1000;
    x5=0;
    x2=td(x3,3);
    goto _6;
_1:
    x5=(x5)+(1);
    goto _6;
_2:
    x0=sp();
    x1=x3;
    goto _8;
_3:
    sa(sp()+(2));
    x3=sp();
    x5=0;
    x2=td(x3,3);
    goto _6;
_4:
    sp();
    printf("%lld", (int64)(x1));
    return 0;
_5:
    sp();
    goto _8;
_6:
    sa(x2);
    if(((x2)-(2))!=0)goto _9;else goto _7;
_7:
    sp();
    sa(x5);
    if(((x5)>(x0)?1:0)!=0)goto _2;else goto _5;
_8:
    sa(x3);
    if(((x3)-(x4))!=0)goto _3;else goto _4;
_9:
    sa(sp()-(1));
    x2=sp();
    if((tm((x3)*((x3)-((2)*(x2))),((x3)-(x2))*(2)))!=0)goto _6;else goto _1;
}