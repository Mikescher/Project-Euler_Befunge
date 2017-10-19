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
    int64 x0=32;
    int64 x1=32;
    s=(int64*)calloc(q,sizeof(int64));
    sa(0);
    sa(10000);
    sa(10000);
    sa(0);
    sa(10000);
    sa(0);
_1:
    if(sp()!=0)goto _3;else goto _2;
_2:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*10LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    t0=sr()%10;
    x1=t0;
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+x1);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()/10LL);

    sa(sr());
    sa((sp()!=0)?0:1);
    goto _1;
_3:
    sp();
    sa(sp()+sp());

    sa(24);
    sa(0);
_4:
    if(sp()!=0)goto _5;else goto _9;
_5:
    sp();
    sp();
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
_6:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _8;else goto _7;
_7:
    sp();
    printf("%lld ", (int64)(sp()));
    return 0;
_8:
    sa(sr());
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    goto _1;
_9:
    t0=0;
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sr());
_10:
    sa(sr());

    if(sp()!=0)goto _14;else goto _11;
_11:
    x0=t0;
    sp();
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)goto _12;else goto _13;
_12:
    sa(sr());
    sp();
    sa(sp()+x0);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-1LL);

    sa(sr());
    sa((sp()!=0)?0:1);
    goto _4;
_13:
    sp();
    sp();
    goto _6;
_14:
    t0*=10;
    t1=sr()%10;
    x1=t1;
    t0+=x1;
    sa(sp()/10LL);
    goto _10;
}
