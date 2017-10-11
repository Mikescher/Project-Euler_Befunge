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
    int64 t0,t1;
    int64 x0=9990;
    s=(int64*)calloc(q,sizeof(int64));
    sa(0);
    sa(0);
    sa(999);
    sa(9+x0);
    sa(99);
_1:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*10LL);

    x0=sp();
    sa((tm(sr(),10))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(sr());
_2:
    if(sp()!=0)goto _1;else goto _3;
_3:
    x0=0;
    sp();
    sa(sr());
    sa(sr());
_4:
    t0=(tm(sr(),2))+x0;
    sa(td(sp(),2));

    sa(sr());

    if(sp()!=0)goto _25;else goto _5;
_5:
    sp();
    sa(sp()-t0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)goto _24;else goto _6;
_6:
    sp();
_7:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _8;else goto _9;
_8:
    sa(sr());
    t0=sr()*10;
    x0=t0;
    sa((tm(sr(),10))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(sr());
    goto _2;
_9:
    x0=990;
    sa(999);
    sa(9+x0);
    sa(99);
_10:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*10LL);

    x0=sp();
    sa((tm(sr(),10))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(sr());
_11:
    if(sp()!=0)goto _10;else goto _12;
_12:
    x0=0;
    sp();
    sa(sr());
    sa(sr());
_13:
    t0=(tm(sr(),2))+x0;
    sa(td(sp(),2));

    sa(sr());

    if(sp()!=0)goto _23;else goto _14;
_14:
    sp();
    sa(sp()-t0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)goto _22;else goto _15;
_15:
    sp();
_16:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _17;else goto _18;
_17:
    sa(sr());
    t0=(td(sr(),10))*10;
    x0=t0;
    sa((tm(sr(),10))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(sr());
    goto _11;
_18:
    printf(" =");
_19:
    sa(sp()+sp());

    t0=sp();
    sa(sr());

    if(sp()!=0)goto _20;else goto _21;
_20:
    sa(sp()+t0);
    goto _19;
_21:
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());

    t1=sp();
    printf("%lld ", t1);
    return 0;
_22:
    sa(sr());
    printf("%lld ", (int64)(sp()));
    printf("\n");
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _16;
_23:
    t0*=2;
    x0=t0;
    goto _13;
_24:
    sa(sr());
    printf("%lld ", (int64)(sp()));
    printf("\n");
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _7;
_25:
    t0*=2;
    x0=t0;
    goto _4;
}
