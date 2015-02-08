/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
    int64 x0=63;
    s=(int64*)calloc(q,sizeof(int64));
    goto _2;
_0:
    if(sp()!=0)goto _5; else goto _12;
_1:
    if(((((tm(x0,10))+(2))*(((tm(td(x0,10),10))+(2))*(((tm(td(td(x0,10),10),10))+(2))*((td(td(td(x0,10),10),10))+(2)))))-(((tm((x0)+(3330),10))+(2))*(((tm(td((x0)+(3330),10),10))+(2))*(((tm(td(td((x0)+(3330),10),10),10))+(2))*((td(td(td((x0)+(3330),10),10),10))+(2))))))!=0)goto _3;else goto _8;
_2:
    x0=4818;
    sa(1488);
    sa(1800);
    sa(1800);
    goto _1;
_3:
    sp();
    sp();
    sa(sp()+(1));
    sa(sr());
    sa(sr());
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sp()+(2));
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+(3330));
    x0=sp();
    sa(sr());
    goto _1;
_4:
    sp();
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(32));
    sa(sp()+(3330));
    sa(sr());
    printf("%lld", (int64)(sp()));
    printf("%c", (char)(32));
    sa(sp()+(3330));
    printf("%lld", (int64)(sp()));
    return 0;
_5:
    sp();
    sp();
    sa(sp()+(1));
    sa(sr());
    sa(sr());
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    {int64 v0=10;sa((v0==0)?0:(sp()%v0));}
    sa(sp()+(2));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=10;sa((v0==0)?0:(sp()/v0));}
    sa(sp()+(2));
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+(3330));
    x0=sp();
    sa(sr());
    goto _1;
_6:
    x0=sp();
    sa(7);
    sa(((tm(x0,7))!=0)?0:1);
    goto _0;
_7:
    sa(sp()+(6));
    sa(sr());
    sa(x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    goto _0;
_8:
    {int64 v0=sp();sa(sp()-v0);}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _9; else goto _3;
_9:
    sa(sr());
    sa(sr());
    {int64 v0=9999;sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _4; else goto _10;
_10:
    sa(sr());
    sa(sr());
    {int64 v0=2;sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _5; else goto _11;
_11:
    sa(sr());
    {int64 v0=3;sa((v0==0)?0:(sp()%v0));}
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _5; else goto _6;
_12:
    sa(sr());
    {int64 v0=td(x0,2);sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _14; else goto _13;
_13:
    sa(sr());
    sa(sp()-(2));
    sa(x0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    if(sp()!=0)goto _7; else goto _5;
_14:
    sp();
    sa(sp()+(3330));
    sa(sr());
    {int64 v0=9999;sa((sp()>v0)?1:0);}
    if(sp()!=0)goto _4; else goto _10;
}