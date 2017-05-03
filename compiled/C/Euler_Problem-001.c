/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
    int64 t0,t1;
    s=(int64*)calloc(q,sizeof(int64));
    sa(1);
    sa(2);
    sa(2);
_1:
    sa(sr());
    t0=(td(sr(),5))*5;
    sa(sp()-t0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)goto _2;else goto _3;
_2:
    sa(sr());
_3:
    if(sr()-1000==0)goto _5;else goto _4;
_4:
    sp();
    sa(sp()+1LL);

    sa(sr());
    sa(sr());
    t0=(td(sr(),3))*3;
    sa(sp()-t0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)goto _2;else goto _1;
_5:
    sp();
    sp();
    sp();
_6:
    sa(sp()+sp());

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}

    if(sr()-1==0)goto _7;else goto _8;
_7:
    sp();
    printf("%lld", (int64)(sp()));
    return 0;
_8:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _6;
}
