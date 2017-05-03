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
    int64 t0,t1,t2;
    int64 x0=775146;
    int64 x1=600851475143;
    int64 x2=55;
    int64 x3=57;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    t0=x1;
    t1=x0-1;
    x0--;
    t2=tm(t0,t1);
    if((t2)!=0)goto _1;else goto _3;
_3:
    t0=x0;
    x3=x0;
    t0--;
    x2=t0;
_4:
    if(tm(x3,x2)==0)goto _1;else goto _5;
_5:
    t0=x2;
    x2--;
    t0-=2;

    if((t0)!=0)goto _4;else goto _6;
_6:
    printf("%lld", x3);
    return 0;
}
