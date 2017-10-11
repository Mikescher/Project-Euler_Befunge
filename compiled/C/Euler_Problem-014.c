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
    int64 x0=0;
    int64 x1=32;
    s=(int64*)calloc(q,sizeof(int64));
    sa(4);
    sa(1);
    sa(2);
_1:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sr()!=1)goto _11;else goto _2;
_2:
    sp();

    if(sr()<x0)goto _3;else goto _10;
_3:
    sp();
_4:
    if(sr()<=1000000)goto _6;else goto _5;
_5:
    printf("%lld ", x1);
    t0=x0;
    printf(" :");
    printf("%lld ", t0);
    return 0;
_6:
    sa(sp()+1LL);

    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),2));
_7:
    if(sp()!=0)goto _9;else goto _8;
_8:
    sa(td(sp(),2));
    goto _1;
_9:
    sa(sp()*3LL);

    sa(sp()+1LL);
    goto _1;
_10:
    x0=sp();
    x1=sr();
    goto _4;
_11:
    sa(td(sp(),1));

    sa(tm(sr(),2));
    goto _7;
}
