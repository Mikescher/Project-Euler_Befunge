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
    int64 x0=57;
    int64 x1=56;
    int64 x2=55;
    int64 x3=57;
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    x0=775146;
    x1=600851475143;
_1:
    sa(x1);
    sa((x0)-(1));
    x0=(x0)-(1);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
_2:
    if(sp()!=0)goto _1; else goto _3;
_3:
    sa(x0);
    x3=x0;
    sa(sp()-(1));
    x2=sp();
_4:
    if((((tm(x3,x2))!=0)?0:1)!=0)goto _1;else goto _5;
_5:
    sa(x2);
    x2=(x2)-(1);
    sa(sp()-(2));
    if(sp()!=0)goto _4; else goto _6;
_6:
    printf("%lld", (int64)(x3));
    return 0;
}