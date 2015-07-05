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
    int64 x0=1000;
    int64 x1=2;
    int64 x2=34;
    int64 x3=53;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    x2=1LL;
_2:
    sa((x2*x2)+(x1*x1));
    x3=(x2*x2)+(x1*x1);
    sa(0LL);
    sa(0LL-x3);
_3:
    if(sp()!=0)goto _10;else goto _4;
_4:
    x3=sr();
    sa(sp()+x2+x1);
    sa(sp()-x0);
    if(sp()!=0)goto _5;else goto _9;
_5:
    sp();
_6:
    sa(x2+1LL);
    x2=x2+1LL;
    sa(sp()-x1);
    if(sp()!=0)goto _2;else goto _7;
_7:
    sa(x1+1LL);
    x1=x1+1LL;
    sa(sp()-x0);
    if(sp()!=0)goto _1;else goto _8;
_8:
    return 0;
_9:
    sa(x2);
    printf("%lld", (int64)(x2));
    printf(" ");
    sa(x1);
    printf("%lld", (int64)(x1));
    printf(" ");
    sa(x3);
    printf("%lld", (int64)(x3));
    printf("=");
    sa(sp()*sp());
    sa(sp()*sp());
    printf("%lld", (int64)(sp()));
    return 0;
_10:
    sa(sp()+1LL);
    if(sr()!=x0)goto _12;else goto _11;
_11:
    sp();
    sp();
    goto _6;
_12:
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sp()-x3);
    goto _3;
}