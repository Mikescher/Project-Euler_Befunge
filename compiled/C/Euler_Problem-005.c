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
    int64 t0,t1,t2;
    int64 x0=20;
    int64 x1=1;
    int64 x2=1;
    int64 x3=48;
    int64 x4=48;
    int64 x5=112;
    s=(int64*)calloc(q,sizeof(int64));
_1:
    x1*=x2;
    t0=x0;
    t1=x2+1;
    x2++;
    t2=t0>t1?1:0;
    if((t2)!=0)goto _3;else goto _2;
_2:
    printf("%lld", x1);
    return 0;
_3:
    x3=1;
_4:
    t0=x3;
    x3++;
    t0=t0>x0?1:0;
    if((t0)!=0)goto _1;else goto _5;
_5:
    if(tm(x1,x3)!=0)goto _4;else goto _6;
_6:
    x4=td(x1,x3);
    x5=1;
_7:
    t0=x2;
    t1=x5+1;
    x5++;
    t2=t0>t1?1:0;
    if((t2)!=0)goto _9;else goto _8;
_8:
    x1/=x3;
    goto _5;
_9:
    if(tm(x4,x5)==0)goto _7;else goto _4;
}