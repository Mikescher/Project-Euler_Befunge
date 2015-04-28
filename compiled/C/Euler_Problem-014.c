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
    int64 x0=118;
    int64 x1=32;
    s=(int64*)calloc(q,sizeof(int64));
    goto _0;
_0:
    x0=0;
    sa(4);
    sa(1);
    sa(4);
    sa(0);
_1:
    if(sp()!=0)goto _11; else goto _2;
_2:
    {int64 v0=2;sa((v0==0)?0:(sp()/v0));}
_3:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+(1));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sp()-(1));
    if(sp()!=0)goto _10; else goto _4;
_4:
    sp();
    sa(sr());
    sa(x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _5; else goto _9;
_5:
    sp();
_6:
    sa(sr());
    {int64 v0=1000000;sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _8; else goto _7;
_7:
    printf("%lld", (int64)(x1));
    sa(x0);
    sa(58);
    printf("%c", (char)(32));
    printf("%c", (char)(sp()));
    printf("%lld", (int64)(sp()));
    return 0;
_8:
    sa(sp()+(1));
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    {int64 v0=2;sa((v0==0)?0:(sp()%v0));}
    goto _1;
_9:
    x0=sp();
    sa(sr());
    x1=sp();
    goto _6;
_10:
    {int64 v0=1;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=2;sa((v0==0)?0:(sp()%v0));}
    goto _1;
_11:
    sa(sp()*(3));
    sa(sp()+(1));
    goto _3;
}