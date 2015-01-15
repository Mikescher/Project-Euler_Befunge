/* compiled with BefunCompile v1.0.2 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 x0=34;
    int64 x1=100;
    int64 x2=34;
    int64 x3=53;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _5;
_0:
    if(sp()!=0)goto _8; else goto _14;
_1:
    if(sp()!=0)goto _9; else goto _10;
_2:
    if(sp()!=0)goto _7; else goto _12;
_3:
    if(sp()!=0)goto _6; else goto _13;
_4:
    if(sp()!=0)goto _16; else goto _15;
_5:
    x0=1000;
    x1=2;
    goto _6;
_6:
    x2=1;
    goto _7;
_7:
    sa(((x2)*(x2))+((x1)*(x1)));
    x3=((x2)*(x2))+((x1)*(x1));
    sa(0);
    sa((0)-(x3));
    goto _0;
_8:
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(x0);
    {int64 v0=sp();sa(sp()-v0);}
    goto _1;
_9:
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(x3);
    {int64 v0=sp();sa(sp()-v0);}
    goto _0;
_10:
    sp();
    sp();
    goto _11;
_11:
    sa((x2)+(1));
    x2=(x2)+(1);
    sa(x1);
    {int64 v0=sp();sa(sp()-v0);}
    goto _2;
_12:
    sa((x1)+(1));
    x1=(x1)+(1);
    sa(x0);
    {int64 v0=sp();sa(sp()-v0);}
    goto _3;
_13:
    goto __;
_14:
    sa(sr());
    x3=sp();
    sa((x2)+(x1));
    sa(sp()+sp());
    sa(x0);
    {int64 v0=sp();sa(sp()-v0);}
    goto _4;
_15:
    sa(x2);
    printf("%lld", (int64)(x2));
    printf("%c", (char)(32));
    sa(x1);
    printf("%lld", (int64)(x1));
    printf("%c", (char)(32));
    sa(x3);
    printf("%lld", (int64)(x3));
    printf("%c", (char)(61));
    sa(sp()*sp());
    sa(sp()*sp());
    printf("%lld", (int64)(sp()));
    goto __;
_16:
    sp();
    goto _11;
__:
    return 0;
}