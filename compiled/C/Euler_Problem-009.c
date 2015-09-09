/* compiled with BefunCompile v1.0.8 (c) 2015 */
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
    int64 t0,t1,t2,t3;
    int64 x0=1000;
    int64 x1=2;
    int64 x2=34;
    int64 x3=53;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    x2=1;
_2:
    sa((x2*x2)+(x1*x1));
    x3=(x2*x2)+(x1*x1);
    sa(0);
    sa(0-x3);
_3:
    if(sp()!=0)goto _4;else goto _10;
_4:
    sa(sp()+1LL);
    if(sr()!=x0)goto _9;else goto _5;
_5:
    sp();
    sp();
_6:
    t0=x2+1;
    x2++;
    t0-=x1;
    if((t0)!=0)goto _2;else goto _7;
_7:
    t0=x1+1;
    x1++;
    t0-=x0;
    if((t0)!=0)goto _1;else goto _8;
_8:
    return 0;
_9:
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sp()-x3);
    goto _3;
_10:
    x3=sr();
    sa(sp()+x2+x1);
    sa(sp()-x0);
    if(sp()!=0)goto _11;else goto _12;
_11:
    sp();
    goto _6;
_12:
    t0=x2;
    printf("%lld", x2);
    printf(" ");
    t1=x1;
    printf("%lld", x1);
    printf(" ");
    t2=x3;
    printf("%lld", x3);
    printf("=");
    t3=t1*t2;
    t1=t0*t3;
    printf("%lld", t1);
    return 0;
}