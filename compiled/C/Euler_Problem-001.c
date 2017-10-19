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
    int64 t0,t1;
    s=(int64*)calloc(q,sizeof(int64));
    sa(1);
    sa(1);
    sa(1);
_1:
    sp();
    sa(sp()+1LL);

    sa(sr());
    sa(sr());
    t0=(sr()/3)*3;
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)goto _2;else goto _3;
_2:
    sa(sr());
    t0=(sr()/5)*5;
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)goto _4;else goto _3;
_3:
    sa(sr());
_4:
    if(sr()!=1000)goto _1;else goto _5;
_5:
    sp();
    sp();
    sp();
_6:
    sa(sp()+sp());

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sr()!=1)goto _8;else goto _7;
_7:
    sp();
    printf("%lld ", (int64)(sp()));
    return 0;
_8:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _6;
}
