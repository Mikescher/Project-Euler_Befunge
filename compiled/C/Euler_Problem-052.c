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
    int64 t0;
    int64 x1=1;
    int64 x2=88;
    int64 x3=1;
    int64 x4=88;
    s=(int64*)calloc(q,sizeof(int64));
    sa(10);
    sa(1);
    sa(1);
    sa(1);
    sa(1);
_1:
    if(sp()!=0)goto _12;else goto _2;
_2:
    x2=2;
    sp();
    sa((sr()*x2*10)/10);
    x4=1;
_3:
    sa(sr());

    if(sp()!=0)goto _11;else goto _4;
_4:
    sp();

    if((x4-x1)!=0)goto _8;else goto _5;
_5:
    t0=x2-6;
    x2++;

    if((t0)!=0)goto _7;else goto _6;
_6:
    printf("%lld ", (int64)(sp()));
    sp();
    sp();
    return 0;
_7:
    sa((sr()*x2*10)/10);
    x4=1;
    goto _3;
_8:
    sp();
    sa(sp()+1LL);


    if(sr()<x3)goto _10;else goto _9;
_9:
    sp();
    sa(sp()*10LL);

    t0=sr()/6;
    x3=t0;
    x1=1;
    sa(sr()/10);
    sa(sr());
    sa((sr()*10)/10);
    sa(sr());
    goto _1;
_10:
    x1=1;
    sa(sr());
    sa((sr()*10)/10);
    sa(sr());
    goto _1;
_11:
    t0=((sr()%10)+2)*x4;
    x4=t0;
    sa(sp()/10LL);
    goto _3;
_12:
    t0=((sr()%10)+2)*x1;
    x1=t0;
    sa(sp()/10LL);

    sa(sr());
    goto _1;
}
