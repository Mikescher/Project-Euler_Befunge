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
    int64 x0=118;
    int64 x1=32;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _4;
_0:
    if(sp()!=0)goto _14; else goto _5;
_1:
    if(sp()!=0)goto _7; else goto _8;
_2:
    if(sp()!=0)goto _13; else goto _9;
_3:
    if(sp()!=0)goto _12; else goto _11;
_4:
    x0=0;
    sa(4);
    sa(1);
    sa(4);
    sa(0);
    goto _0;
_5:
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    goto _6;
_6:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(1);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    goto _1;
_7:
    sa(1);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _0;
_8:
    sp();
    sa(sr());
    sa(x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _2;
_9:
    x0=sp();
    sa(sr());
    x1=sp();
    goto _10;
_10:
    sa(sr());
    sa(1000000);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    sa((sp()!=0)?0:1);
    goto _3;
_11:
    printf("%lld", (int64)(x1));
    sa(x0);
    sa(58);
    printf("%c", (char)(32));
    printf("%c", (char)(sp()));
    printf("%lld", (int64)(sp()));
    goto __;
_12:
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _0;
_13:
    sp();
    goto _10;
_14:
    sa(3);
    sa(sp()*sp());
    sa(1);
    sa(sp()+sp());
    goto _6;
__:
    return 0;
}