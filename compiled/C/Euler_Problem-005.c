/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
    int64 x0=52;
    int64 x1=53;
    int64 x2=42;
    int64 x3=48;
    int64 x4=48;
    int64 x5=112;
    s=(int64*)calloc(q,sizeof(int64));
    goto _2;
_0:
    if((tm(x1,x3))!=0)goto _8;else goto _4;
_1:
    if((((tm(x4,x5))!=0)?0:1)!=0)goto _9;else goto _8;
_2:
    x0=20;
    x1=1;
    x2=1;
    goto _7;
_3:
    x3=1;
    goto _8;
_4:
    x4=td(x1,x3);
    x5=1;
    goto _9;
_5:
    x1=td(x1,x3);
    goto _0;
_6:
    printf("%lld", (int64)(x1));
    return 0;
_7:
    x1=(x1)*(x2);
    sa(x0);
    sa((x2)+(1));
    x2=(x2)+(1);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _3; else goto _6;
_8:
    sa(x3);
    x3=(x3)+(1);
    {int64 v0=x0;sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _7; else goto _0;
_9:
    sa(x2);
    sa((x5)+(1));
    x5=(x5)+(1);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _1; else goto _5;
}