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
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _4;
_0:
    if(sp()!=0)goto _12; else goto _5;
_1:
    if(sp()!=0)goto _8; else goto _7;
_2:
    if(sp()!=0)goto _11; else goto _10;
_3:
    if(sp()!=0)goto _12; else goto _6;
_4:
    sa(1);
    sa(2);
    sa(2);
    sa(0);
    goto _0;
_5:
    sa(sr());
    sa(sr());
    sa(5);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(5);
    sa(sp()*sp());
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _3;
_6:
    sa(sr());
    sa(1000);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _1;
_7:
    sp();
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(3);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(3);
    sa(sp()*sp());
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _0;
_8:
    sp();
    sp();
    sp();
    goto _9;
_9:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _2;
_10:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _9;
_11:
    sp();
    printf("%lld", (int64)(sp()));
    goto __;
_12:
    sa(sr());
    goto _6;
__:
    return 0;
}