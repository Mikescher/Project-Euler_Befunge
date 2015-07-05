/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
    int64 x0=10;
    int64 x1=1;
    int64 x2=88;
    int64 x3=1;
    int64 x4=88;
    s=(int64*)calloc(q,sizeof(int64));
    sa(10LL);
    sa(1LL);
    sa(1LL);
    sa(1LL);
_1:
    sa(((tm(sr(),10LL))+2LL)*x1);
    x1=sp();
    sa(td(sp(),10L));
    sa(sr());
_2:
    if(sp()!=0)goto _1;else goto _3;
_3:
    x2=2LL;
    sp();
    sa(sr());
    sa(x2);
_4:
    x4=1LL;
    sa(sp()*sp());
    sa(sp()*10LL);
_5:
    sa(td(sp(),10L));
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _6;else goto _13;
_6:
    sp();
    if(x4!=x1)goto _7;else goto _10;
_7:
    sp();
    sa(sp()+1LL);
    if(sr()>=x3)goto _8;else goto _9;
_8:
    sp();
    sa(sp()*10LL);
    x0=sr();
    sa(td(sr(),6LL));
    x3=sp();
    x1=1LL;
    sa(td(sr(),10LL));
    sa(sr());
    sa(td(sr()*10LL,10LL));
    sa(sr());
    goto _2;
_9:
    x1=1LL;
    sa(sr());
    sa(td(sr()*10LL,10LL));
    sa(sr());
    goto _2;
_10:
    sa(x2+1LL);
    x2=x2+1LL;
    sa(sp()-7LL);
    if(sp()!=0)goto _11;else goto _12;
_11:
    sa(sr());
    sa(x2);
    goto _4;
_12:
    printf("%lld", (int64)(sp()));
    sp();
    sp();
    return 0;
_13:
    sa(((tm(sr(),10LL))+2LL)*x4);
    x4=sp();
    goto _5;
}