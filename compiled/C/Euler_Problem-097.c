/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    s=(int64*)calloc(q,sizeof(int64));
    sa(56866);
    sa(7830456);
    sa(7830456);
_1:
    if(sp()!=0)goto _3;else goto _2;
_2:
    sp();
    sa(sp()+1LL);

    sa(sp()%10000000000LL);

    printf("%lld ", (int64)(sp()));
    return 0;
_3:
    sa(sp()-1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*2LL);

    sa(sp()%10000000000LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _1;
}
