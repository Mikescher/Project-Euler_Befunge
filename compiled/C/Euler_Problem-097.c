/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
    s=(int64*)calloc(q,sizeof(int64));
    t0=56866;
    sa(7830455);
_1:
    t0*=2;
    t0%=10000000000LL;
    sa(sr());

    if(sp()!=0)goto _3;else goto _2;
_2:
    sp();
    t0++;
    t0%=10000000000LL;
    printf("%lld ", t0);
    return 0;
_3:
    sa(sp()-1LL);
    goto _1;
}
