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
    int64 t0,t1,t2;
    int64 x0=1152921504606846976;
    int64 x1=991873;
    int64 x2=0;
    s=(int64*)calloc(q,sizeof(int64));
    sa(144);
    sa(991873);
_1:
    sa(x0);
    sa(x0>x1?1:0);
_2:
    if(sp()!=0)goto _13;else goto _3;
_3:
    sa(sr());
_4:
    if(sp()!=0)goto _10;else goto _5;
_5:
    sp();
    sa(sp()-(x2*x2));


    if((tm(x2,6))-5==0)goto _6;else goto _9;
_6:
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _8;else goto _7;
_7:
    x2=0;
    sa(sp()+1LL);

    sa(sr());
    t0=(sr()*2)-1;
    sa(sp()*t0);

    sa(sp()*24LL);

    sa(sp()+1LL);

    x1=sr();
    goto _1;
_8:
    t0=(sr()*2)-1;
    sa(sp()*t0);

    t1=sp();
    printf("%lld ", t1);
    return 0;
_9:
    x2=0;
    sp();
    sa(sp()+1LL);

    sa(sr());
    t0=(sr()*2)-1;
    sa(sp()*t0);

    sa(sp()*24LL);

    sa(sp()+1LL);

    x1=sr();
    goto _1;
_10:
    if((sr()+x2)<=x1)goto _12;else goto _11;
_11:
    x2/=2;
    sa(td(sp(),4));

    sa(sr());
    goto _4;
_12:
    t0=sr()+x2;
    t1=x1;
    t2=t1-t0;
    x1=t2;
    t0=(sr()*2)+x2;
    x2=t0;
    x2/=2;
    sa(td(sp(),4));
    goto _3;
_13:
    sa(td(sp(),4));

    sa(sr()>x1?1:0);
    goto _2;
}
