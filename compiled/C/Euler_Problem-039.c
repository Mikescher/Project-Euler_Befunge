/* compiled with BefunCompile v1.0.5 (c) 2015 */
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
    int64 x0=0;
    int64 x1=0;
    int64 x2=32;
    int64 x3=6;
    int64 x4=1000;
    int64 x5=0;
    s=(int64*)calloc(q,sizeof(int64));
    x2=td(x3,3);
_1:
    sa(x2);
    if((x2-2)!=0)goto _2;else goto _4;
_2:
    sa(sp()-(1));
    x2=sp();
    if((tm(x3*(x3-(2*x2)),(x3-x2)*2))!=0)goto _1;else goto _3;
_3:
    x5=x5+1;
    goto _1;
_4:
    sp();
    sa(x5);
    if(((x5)>(x0)?1:0)!=0)goto _9;else goto _5;
_5:
    sp();
_6:
    sa(x3);
    if((x3-x4)!=0)goto _8;else goto _7;
_7:
    sp();
    printf("%lld", (int64)(x1));
    return 0;
_8:
    sa(sp()+(2));
    x3=sp();
    x5=0;
    x2=td(x3,3);
    goto _1;
_9:
    x0=sp();
    x1=x3;
    goto _6;
}