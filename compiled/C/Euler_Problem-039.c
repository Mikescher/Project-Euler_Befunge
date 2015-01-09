/* compiled with BefunCompile v1.0.1 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int rd(){return rand()%2==0;}
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
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _4;
_0:
    if(((x2)-(2))!=0)goto _12;else goto _6;
_1:
    if(((x5)>(x0)?1:0)!=0)goto _7;else goto _11;
_2:
    if(((x3)-(x4))!=0)goto _10;else goto _9;
_3:
    if((tm((x3)*((x3)-((2)*(x2))),((x3)-(x2))*(2)))!=0)goto _5;else goto _13;
_4:
    x0=0;
    x1=0;
    x3=6;
    x4=1000;
    x5=0;
    x2=td(x3,3);
    goto _5;
_5:
    sa(x2);
    goto _0;
_6:
    sp();
    sa(x5);
    goto _1;
_7:
    x0=sp();
    x1=x3;
    goto _8;
_8:
    sa(x3);
    goto _2;
_9:
    sp();
    printf("%lld", (int64)(x1));
    goto __;
_10:
    sa(2);
    sa(sp()+sp());
    x3=sp();
    x5=0;
    x2=td(x3,3);
    goto _5;
_11:
    sp();
    goto _8;
_12:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    x2=sp();
    goto _3;
_13:
    x5=(x5)+(1);
    goto _5;
__:
    return 0;
}