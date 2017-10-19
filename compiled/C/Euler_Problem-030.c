/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    sa(59049);
    sa(59049);
_1:
    if(sp()!=0)goto _12;else goto _2;
_2:
    sp();
    {int64 v0=sp();sa(sp()-v0);}

    t0=sp();

    if((t0)!=0)goto _11;else goto _3;
_3:
    sa(sp()*59049LL);
_4:
    sa(sr());
    sa(sr());
    sa(sr()%10);
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t1=sp();
    sa(sp()/10LL);

    sa(sr()%10);
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t2=sp();
    sa(sp()/10LL);

    sa(sr()%10);
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t3=sp();
    sa(sp()/10LL);

    sa(sr()%10);
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t4=sp();
    sa(sp()/10LL);

    sa(sr()%10);
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t5=sp();
    sa(sp()/10LL);

    sa(sr()%10);
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t6=sp();
    sa(sp()/10LL);

    sa(sp()%10LL);

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t7=sp();
    t0=10;
    t0=t7+t6;
    t6=t5+t0;
    t0=t4+t6;
    t4=t3+t0;
    t0=t2+t4;
    t2=t1+t0;
    sa(sp()-t2);

    t0=sp();

    if((t0)!=0)goto _5;else goto _10;
_5:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _4;else goto _6;
_6:
    t0=9;
    sp();
    sp();
_7:
    sa(sp()+sp());

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)goto _8;else goto _9;
_8:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    goto _7;
_9:
    sp();
    printf("%lld ", (int64)(sp()));
    return 0;
_10:
    sa(sr());
    goto _5;
_11:
    sa(sp()+1LL);

    sa(sr());
    sa(sr()*59049);
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _1;
_12:
    sa(sp()/10LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+1LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _1;
}
