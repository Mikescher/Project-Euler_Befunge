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
    int64 x0=4818;
    s=(int64*)calloc(q,sizeof(int64));
    sa(1488LL);
    sa(1800LL);
    sa(1800LL);
_1:
    if((((tm(x0,10LL))+2LL)*((tm(td(x0,10LL),10LL))+2LL)*((tm(td(td(x0,10LL),10LL),10LL))+2LL)*((td(td(td(x0,10LL),10LL),10LL))+2LL))!=(((tm(x0+3330LL,10LL))+2LL)*((tm(td(x0+3330LL,10LL),10LL))+2LL)*((tm(td(td(x0+3330LL,10LL),10LL),10LL))+2LL)*((td(td(td(x0+3330LL,10LL),10LL),10LL))+2LL)))goto _14;else goto _2;
_2:
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _3;else goto _14;
_3:
    sa(sr());
    if(sr()>9999L)goto _11;else goto _4;
_4:
    sa(sr());
    if(tm(sr(),2L)==0)goto _5;else goto _6;
_5:
    sp();
    sp();
    sa(sp()+1LL);
    sa(sr());
    sa(sr());
    sa((tm(sr(),10LL))+2LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa((tm(sr(),10LL))+2LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa((tm(sr(),10LL))+2LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(sp()+2LL);
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+3330LL);
    x0=sp();
    sa(sr());
    goto _1;
_6:
    if(tm(sr(),3L)==0)goto _5;else goto _7;
_7:
    x0=sp();
    sa(7LL);
    sa((tm(x0,7L)!=0)?0:1);
_8:
    if(sp()!=0)goto _5;else goto _9;
_9:
    if(sr()>td(x0,2L))goto _10;else goto _12;
_10:
    sp();
    sa(sp()+3330LL);
    if(sr()>9999L)goto _11;else goto _4;
_11:
    sp();
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf(" ");
    sa(sp()+3330LL);
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf(" ");
    sa(sp()+3330LL);
    printf("%lld", (int64)(sp()));
    return 0;
_12:
    sa(sr()-2LL);
    sa(x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    if(sp()!=0)goto _13;else goto _5;
_13:
    sa(sp()+6LL);
    sa(sr());
    sa(x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(tm(sp(),v0));}
    sa((sp()!=0)?0:1);
    goto _8;
_14:
    sp();
    sp();
    sa(sp()+1LL);
    sa(sr());
    sa(sr());
    sa((tm(sr(),10LL))+2LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa((tm(sr(),10LL))+2LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa((tm(sr(),10LL))+2LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10L));
    sa(sp()+2LL);
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+3330LL);
    x0=sp();
    sa(sr());
    goto _1;
}