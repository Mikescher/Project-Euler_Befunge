/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
    int64 x0=1000;
    s=(int64*)calloc(q,sizeof(int64));
    sa(1002001);
    sa(1002001-x0);
    sa(1002001-x0-x0);
    sa(1002001-x0-x0-x0);
    sa(1002001-x0-x0-x0-x0);
    sa(1002001-x0-x0-x0-x0-1);
_1:
    if(sp()!=0)goto _5;else goto _2;
_2:
    sa(sp()+sp());
    t0=sp();
    sa(sr());
    if(sp()!=0)goto _4;else goto _3;
_3:
    sp();
    printf("%lld", t0);
    return 0;
_4:
    sa(sp()+t0);
    goto _2;
_5:
    x0=x0-2;
    sa(sr()-x0);
    sa(sr()-x0);
    sa(sr()-x0);
    sa(sr()-x0);
    sa(sr()-1);
    goto _1;
}