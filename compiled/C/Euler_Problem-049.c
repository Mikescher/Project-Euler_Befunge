/* compiled with BefunCompile v1.0.3 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 x0=63;
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _9;
_0:
    if(sp()!=0)goto _12; else goto _11;
_1:
    if(sp()!=0)goto _13; else goto _14;
_2:
    if(sp()!=0)goto _15; else goto _16;
_3:
    if(sp()!=0)goto _15; else goto _17;
_4:
    if(sp()!=0)goto _15; else goto _18;
_5:
    if(sp()!=0)goto _19; else goto _20;
_6:
    if(sp()!=0)goto _13; else goto _14;
_7:
    if(sp()!=0)goto _21; else goto _15;
_8:
    if(((((tm(x0,10))+(2))*(((tm(td(x0,10),10))+(2))*(((tm(td(td(x0,10),10),10))+(2))*((td(td(td(x0,10),10),10))+(2)))))-(((tm((x0)+(3330),10))+(2))*(((tm(td((x0)+(3330),10),10))+(2))*(((tm(td(td((x0)+(3330),10),10),10))+(2))*((td(td(td((x0)+(3330),10),10),10))+(2))))))!=0)goto _11;else goto _10;
_9:
    x0=4818;
    sa(1488);
    sa(1800);
    sa(1800);
    goto _8;
_10:
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    goto _0;
_11:
    sp();
    sp();
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(2);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(2);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(2);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(2);
    sa(sp()+sp());
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(3330);
    sa(sp()+sp());
    x0=sp();
    sa(sr());
    goto _8;
_12:
    sa(sr());
    sa(sr());
    sa(9999);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _1;
_13:
    sp();
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(32));
    sa(3330);
    sa(sp()+sp());
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(32));
    sa(3330);
    sa(sp()+sp());
    printf("%lld", (int64)(sp()));
    goto __;
_14:
    sa(sr());
    sa(sr());
    sa(2);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    goto _2;
_15:
    sp();
    sp();
    sa(1);
    sa(sp()+sp());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(2);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(2);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(2);
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(2);
    sa(sp()+sp());
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(3330);
    sa(sp()+sp());
    x0=sp();
    sa(sr());
    goto _8;
_16:
    sa(sr());
    sa(3);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    goto _3;
_17:
    x0=sp();
    sa(7);
    sa(((tm(x0,7))!=0)?0:1);
    goto _4;
_18:
    sa(sr());
    sa(td(x0,2));
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _5;
_19:
    sp();
    sa(3330);
    sa(sp()+sp());
    sa(sr());
    sa(9999);
    {int64 v0=sp();sa((sp()>v0)?1:0);}
    goto _6;
_20:
    sa(sr());
    sa(2);
    {int64 v0=sp();sa(sp()-v0);}
    sa(x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    goto _7;
_21:
    sa(6);
    sa(sp()+sp());
    sa(sr());
    sa(x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    goto _4;
__:
    return 0;
}