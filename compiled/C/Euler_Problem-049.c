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
    int64 t0,t1,t2,t3;
    int64 x0=4818;
    s=(int64*)calloc(q,sizeof(int64));
    sa(1488);
    sa(1800);
    sa(1800);
_1:
    if((((tm(x0,10))+2)*((tm(td(x0,10),10))+2)*((tm(td(td(x0,10),10),10))+2)*((td(td(td(x0,10),10),10))+2))!=(((tm(x0+3330,10))+2)*((tm(td(x0+3330,10),10))+2)*((tm(td(td(x0+3330,10),10),10))+2)*((td(td(td(x0+3330,10),10),10))+2)))goto _15;else goto _2;
_2:
    {int64 v0=sp();sa(sp()-v0);}
    t0=sp();
    t0=(t0!=0)?0:1;
    if((t0)!=0)goto _3;else goto _15;
_3:
    sa(sr());
_4:
    if(sr()>9999)goto _14;else goto _5;
_5:
    sa(sr());
    if(tm(sr(),2)==0)goto _6;else goto _7;
_6:
    sp();
    sp();
    sa(sp()+1LL);
    sa(sr());
    sa(sr());
    t0=(tm(sr(),10))+2;
    sa(td(sp(),10));
    t1=(tm(sr(),10))+2;
    sa(td(sp(),10));
    t2=(tm(sr(),10))+2;
    sa(td(sp(),10));
    sa(sp()+2LL);
    sa(t2);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*sp());
    t3=sp();
    t2=t1*t3;
    sa(t0*t2);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+3330LL);
    x0=sp();
    sa(sr());
    goto _1;
_7:
    if(tm(sr(),3)==0)goto _6;else goto _8;
_8:
    x0=sp();
    sa(7);
    sa((tm(x0,7)!=0)?0:1);
_9:
    if(sp()!=0)goto _6;else goto _10;
_10:
    if(sr()>td(x0,2))goto _13;else goto _11;
_11:
    t0=sr()-2;
    t1=x0;
    t2=tm(t1,t0);
    if((t2)!=0)goto _12;else goto _6;
_12:
    sa(sp()+6LL);
    sa(sr());
    t0=x0;
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    sa((sp()!=0)?0:1);
    goto _9;
_13:
    sp();
    sa(sp()+3330LL);
    goto _4;
_14:
    printf("  ");
    sp();
    sa(sr());
    printf("%lld", (int64)(sp()));
    sa(sp()+3330LL);
    sa(sr());
    printf("%lld", (int64)(sp()));
    sa(sp()+3330LL);
    printf("%lld", (int64)(sp()));
    return 0;
_15:
    sp();
    sp();
    sa(sp()+1LL);
    sa(sr());
    sa(sr());
    t0=(tm(sr(),10))+2;
    sa(td(sp(),10));
    t1=(tm(sr(),10))+2;
    sa(td(sp(),10));
    t2=(tm(sr(),10))+2;
    sa(td(sp(),10));
    sa(sp()+2LL);
    sa(t2);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*sp());
    t3=sp();
    t2=t1*t3;
    sa(t0*t2);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+3330LL);
    x0=sp();
    sa(sr());
    goto _1;
}