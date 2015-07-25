/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
    int64 t0,t1,t2,t3,t4,t5,t6,t7;
    s=(int64*)calloc(q,sizeof(int64));
    sa(0);
    sa(1);
    sa(1);
    sa(0);
    sa(5904);
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
    t0=sp();
    if((t0)!=0)goto _12;else goto _4;
_4:
    sa(sp()*59049LL);
_5:
    sa(sr());
    sa(sr());
    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    t0=sp();
    sa(sp()*t0);
    t1=sp();
    sa(td(sp(),10));
    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    t0=sp();
    sa(sp()*t0);
    t2=sp();
    sa(td(sp(),10));
    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    t0=sp();
    sa(sp()*t0);
    t3=sp();
    sa(td(sp(),10));
    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    t0=sp();
    sa(sp()*t0);
    t4=sp();
    sa(td(sp(),10));
    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    t0=sp();
    sa(sp()*t0);
    t5=sp();
    sa(td(sp(),10));
    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    t0=sp();
    sa(sp()*t0);
    t6=sp();
    sa(td(sp(),10));
    sa(tm(sp(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());
    sa(sr());
    sa(sp()*sp());
    t0=sp();
    sa(sp()*t0);
    t7=sp();
    t0=t7+t6;
    t6=t5+t0;
    t0=t4+t6;
    t4=t3+t0;
    t0=t2+t4;
    t2=t1+t0;
    sa(sp()-t2);
    t0=sp();
    if((t0)!=0)goto _6;else goto _11;
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
    sa(sr()*59049);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _2;
_13:
    sa(td(sp(),10));
    goto _1;
}