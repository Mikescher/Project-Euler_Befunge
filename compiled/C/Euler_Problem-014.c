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
    int64 x0=0;
    int64 x1=32;
    s=(int64*)calloc(q,sizeof(int64));
    sa(4);
    sa(1);
    sa(4);
    sa(0);
_1:
    if(sp()!=0)goto _11;else goto _2;
_2:
    sa(sp()/2LL);
_3:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sr()!=1)goto _10;else goto _4;
_4:
    sp();

    if(sr()<x0)goto _5;else goto _9;
_5:
    sp();
_6:
    if(sr()>1000000)goto _7;else goto _8;
_7:
    printf("%lld ", x1);
    printf(" :");
    printf("%lld ", x0);
    return 0;
_8:
    sa(sp()+1LL);

    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr()%2);
    goto _1;
_9:
    x0=sp();
    x1=sr();
    goto _6;
_10:
    sa(sp()/1LL);

    sa(sr()%2);
    goto _1;
_11:
    sa(sp()*3LL);

    sa(sp()+1LL);
    goto _3;
}
