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
    int64 x0=9990;
    s=(int64*)calloc(q,sizeof(int64));
    sa(0LL);
    sa(0LL);
    sa(999LL);
    sa(9LL+x0);
    sa(99LL);
_1:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*10LL);
    x0=sp();
    sa((tm(sr(),10LL))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(sr());
_2:
    if(sp()!=0)goto _1;else goto _3;
_3:
    x0=0LL;
    sp();
    sa(sr());
    sa(sr());
_4:
    sa((tm(sr(),2LL))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),2L));
    sa(sr());
    if(sp()!=0)goto _25;else goto _5;
_5:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _24;else goto _6;
_6:
    sp();
_7:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _8;else goto _9;
_8:
    sa(sr());
    sa(sr()*10LL);
    x0=sp();
    sa((tm(sr(),10LL))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(sr());
    goto _2;
_9:
    x0=990LL;
    sa(999LL);
    sa(9LL+x0);
    sa(99LL);
_10:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*10LL);
    x0=sp();
    sa((tm(sr(),10LL))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(sr());
_11:
    if(sp()!=0)goto _10;else goto _12;
_12:
    x0=0LL;
    sp();
    sa(sr());
    sa(sr());
_13:
    sa((tm(sr(),2LL))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),2L));
    sa(sr());
    if(sp()!=0)goto _23;else goto _14;
_14:
    sp();
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _22;else goto _15;
_15:
    sp();
_16:
    sa(sp()-1LL);
    sa(sr());
    if(sp()!=0)goto _21;else goto _17;
_17:
    sa(61LL);
    printf(" ");
    printf("%c", (char)(sp()));
_18:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _20;else goto _19;
_19:
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    return 0;
_20:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _18;
_21:
    sa(sr());
    sa((td(sr(),10LL))*10LL);
    x0=sp();
    sa((tm(sr(),10LL))+x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(sr());
    goto _11;
_22:
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("\n");
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _16;
_23:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*2LL);
    x0=sp();
    goto _13;
_24:
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("\n");
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _7;
_25:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*2LL);
    x0=sp();
    goto _4;
}