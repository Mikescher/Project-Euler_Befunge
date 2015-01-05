/* compiled with BefunCompile v1.0 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int random(){return rand()%2==0;}
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
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _5;
_0:
    if(sp()!=0)goto _7; else goto _12;
_1:
    if(sp()!=0)goto _6; else goto _3;
_2:
    if(sp()!=0)goto _4; else goto _11;
_3:
    if((tm(x1,x3))!=0)goto _8;else goto _9;
_4:
    if((((tm(x4,x5))!=0)?0:1)!=0)goto _10;else goto _8;
_5:
    x0=20;
    x1=1;
    x2=1;
    goto _6;
_6:
    x1=((x1)*(x2));
    sa(x0);
    sa(((x2)+(1)));
    x2=((x2)+(1));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _0;
_7:
    x3=1;
    goto _8;
_8:
    sa(x3);
    x3=((x3)+(1));
    sa(x0);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _1;
_9:
    x4=td(x1,x3);
    x5=1;
    goto _10;
_10:
    sa(x2);
    sa(((x5)+(1)));
    x5=((x5)+(1));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _2;
_11:
    x1=td(x1,x3);
    goto _3;
_12:
    printf("%lld", (int64)(x1));
    goto __;
__:
    return 0;
}