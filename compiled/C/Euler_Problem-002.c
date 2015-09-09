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
    int64 t0,t1;
    int64 x0=1;
    int64 x1=2;
    int64 x2=2;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    t0=x0;
    t1=x1;
    x0=x1;
    sa(t0+t1);
    x1=sr();
    if(sr()>10240000)goto _5;else goto _2;
_2:
    sa(sr());
    t0=(td(sr(),2))*2;
    sa(sp()-t0);
    t1=sp();
    if((t1)!=0)goto _3;else goto _4;
_3:
    sp();
    goto _1;
_4:
    sa(sp()+x2);
    x2=sp();
    goto _1;
_5:
    printf("%lld", x2);
    sp();
    return 0;
}