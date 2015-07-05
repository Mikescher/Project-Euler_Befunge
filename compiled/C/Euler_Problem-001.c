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
    s=(int64*)calloc(q,sizeof(int64));
    sa(1LL);
    sa(2LL);
    sa(2LL);
_1:
    sa(sr());
    sa((td(sr(),5LL))*5LL);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _2;else goto _3;
_2:
    sa(sr());
_3:
    if(sr()-1000L==0)goto _5;else goto _4;
_4:
    sp();
    sa(sp()+1LL);
    sa(sr());
    sa(sr());
    sa((td(sr(),3LL))*3LL);
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _2;else goto _1;
_5:
    sp();
    sp();
    sp();
_6:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    if(sr()-1L==0)goto _7;else goto _8;
_7:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_8:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _6;
}