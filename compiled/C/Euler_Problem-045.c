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
    int64 x0=1152921504606846976;
    int64 x1=991873;
    int64 x2=0;
    s=(int64*)calloc(q,sizeof(int64));
    sa(144LL);
    sa(991873LL);
_1:
    sa(x0);
    sa(x0>x1?1:0);
_2:
    if(sp()!=0)goto _12;else goto _3;
_3:
    sa(sr());
    if(sp()!=0)goto _9;else goto _4;
_4:
    sp();
    sa(sp()-(x2*x2));
    if((tm(x2,6L))-5L==0)goto _5;else goto _8;
_5:
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _7;else goto _6;
_6:
    x2=0LL;
    sa(sp()+1LL);
    sa(sr());
    sa((sr()*2LL)-1LL);
    sa(sp()*sp());
    sa(sp()*24LL);
    sa(sp()+1LL);
    x1=sr();
    goto _1;
_7:
    sa((sr()*2LL)-1LL);
    sa(sp()*sp());
    printf("%lld", (int64)(sp()));
    return 0;
_8:
    x2=0LL;
    sp();
    sa(sp()+1LL);
    sa(sr());
    sa((sr()*2LL)-1LL);
    sa(sp()*sp());
    sa(sp()*24LL);
    sa(sp()+1LL);
    x1=sr();
    goto _1;
_9:
    if((sr()+x2)<=x1)goto _11;else goto _10;
_10:
    x2=td(x2,2LL);
    sa(td(sp(),4L));
    sa(sr());
    if(sp()!=0)goto _9;else goto _4;
_11:
    sa(sr()+x2);
    sa(x1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    x1=sp();
    sa((sr()*2LL)+x2);
    x2=sp();
    x2=td(x2,2LL);
    sa(td(sp(),4L));
    goto _3;
_12:
    sa(td(sp(),4L));
    sa(sr()>x1?1:0);
    goto _2;
}