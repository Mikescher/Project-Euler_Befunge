/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
    int64 x0=2000000;
    int64 x1=2000000;
    int64 x2=0;
    int64 x3=89;
    int64 x4=0;
    int64 x5=89;
    int64 x6=89;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    if(x0>x4)goto _3;else goto _2;
_2:
    printf("%lld", x3);
    return 0;
_3:
    x5=1;
    x6=x4;
_4:
    if(((x2>x5?1:0)*(x0>x6?1LL:0LL))!=0)goto _5;else goto _12;
_5:
    sa(x0-x6);

    if((x0-x6)<0)goto _11;else goto _6;
_6:
    sa(sp()-0LL);
_7:
    if(sr()>x1)goto _8;else goto _10;
_8:
    sp();
_9:
    t0=x5+1;
    x5++;
    t0*=x4;
    t0+=x6;
    x6=t0;
    goto _4;
_10:
    x1=sp();
    x3=x5*x2;
    goto _9;
_11:
    t0=0;
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    goto _7;
_12:
    t0=x2+1;
    x2++;
    t0+=x4;
    x4=t0;
    goto _1;
}
