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
    int64 x0=10;
    int64 x1=1;
    int64 x2=88;
    int64 x3=1;
    int64 x4=88;
    s=(int64*)calloc(q,sizeof(int64));
    sa(10);
    sa(1);
    sa(1);
    sa(1);
_1:
    t0=((tm(sr(),10))+2)*x1;
    x1=t0;
    sa(td(sp(),10));

    sa(sr());
_2:
    if(sp()!=0)goto _1;else goto _3;
_3:
    x2=2;
    sp();
    sa(sr());
    sa(x2);
_4:
    x4=1;
    sa(sp()*sp());

    sa(sp()*10LL);
_5:
    sa(td(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _6;else goto _13;
_6:
    sp();

    if(x4!=x1)goto _10;else goto _7;
_7:
    t0=x2+1;
    x2++;
    t0-=7;

    if((t0)!=0)goto _8;else goto _9;
_8:
    sa(sr());
    sa(x2);
    goto _4;
_9:
    printf("%lld ", (int64)(sp()));
    sp();
    sp();
    return 0;
_10:
    sp();
    sa(sp()+1LL);


    if(sr()>=x3)goto _11;else goto _12;
_11:
    sp();
    sa(sp()*10LL);

    x0=sr();
    t0=td(sr(),6);
    x3=t0;
    x1=1;
    sa(td(sr(),10));
    sa(sr());
    sa(td(sr()*10,10));
    sa(sr());
    goto _2;
_12:
    x1=1;
    sa(sr());
    sa(td(sr()*10,10));
    sa(sr());
    goto _2;
_13:
    t0=((tm(sr(),10))+2)*x4;
    x4=t0;
    goto _5;
}
