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
    sa(0LL);
    sa(1LL);
    sa(1LL);
    sa(0LL);
    sa(5904LL);
_1:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
_2:
    if(sp()!=0)goto _13;else goto _3;
_3:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _12;else goto _4;
_4:
    sa(sp()*59049LL);
_5:
    sa(sr());
    sa(sr());
    sa(tm(sr(),10LL));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(tm(sr(),10LL));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(tm(sr(),10LL));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(tm(sr(),10LL));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(tm(sr(),10LL));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(tm(sr(),10LL));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(tm(sp(),10L));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sp()+sp());
    {int64 v0=sp();sa(sp()-v0);}
    if(sp()!=0)goto _6;else goto _11;
_6:
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _7;else goto _5;
_7:
    sp();
    sp();
_8:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _9;else goto _10;
_9:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _8;
_10:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_11:
    sa(sr());
    goto _6;
_12:
    sa(sp()+1LL);
    sa(sr());
    sa(sr()*59049LL);
    sa(0LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _2;
_13:
    sa(td(sp(),10L));
    goto _1;
}