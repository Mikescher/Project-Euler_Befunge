/* compiled with BefunCompile v1.0.2 (c) 2015 */
#include <time.h>
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
int64 g[7][45]={{118,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32},{62,49,58,48,48,112,49,42,58,49,48,112,50,42,58,50,48,112,51,42,58,51,48,112,52,42,58,52,48,112,53,42,58,118,32,32,32,32,32,32,32,32,32,32,32},{118,112,49,49,48,36,112,48,57,58,42,57,112,48,56,58,42,56,112,48,55,58,42,55,112,48,54,58,42,54,112,48,53,60,32,32,32,32,32,32,32,32,32,32,32},{32,32,32,32,32,32,118,95,118,35,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,58,45,49,60,112,49,49,32,60},{62,57,48,103,55,42,62,58,58,48,92,62,58,53,53,43,37,48,103,92,53,53,43,47,58,35,118,95,62,43,35,60,92,58,35,60,95,43,45,124,32,32,32,32,43},{32,32,32,32,62,51,45,46,36,64,32,124,58,47,43,53,53,92,103,48,37,43,53,53,58,32,60,32,32,32,32,32,32,32,32,32,32,32,32,62,58,49,49,103,94},{32,32,32,32,94,103,49,49,60,32,32,62,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,94,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32}};
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<45&&y<7){return g[y][x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<45&&y<7){g[y][x]=v;}}
int rd(){return rand()%2==0;}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    srand(time(NULL));
    s=(int64*)calloc(q,sizeof(int64));
    goto _5;
_0:
    if(sp()!=0)goto _13; else goto _6;
_1:
    if(sp()!=0)goto _14; else goto _6;
_2:
    if(sp()!=0)goto _7; else goto _8;
_3:
    if(sp()!=0)goto _10; else goto _9;
_4:
    if(sp()!=0)goto _11; else goto _12;
_5:
    gw(0,0,1);
    gw(1,0,1);
    gw(2,0,2);
    gw(3,0,6);
    gw(4,0,24);
    gw(5,0,120);
    gw(6,0,720);
    gw(7,0,5040);
    gw(8,0,40320);
    gw(9,0,362880);
    gw(1,1,0);
    sa((gr(9,0))*(7));
    sa((gr(9,0))*(7));
    sa(0);
    sa(gr(tm((gr(9,0))*(7),10),0));
    sa(td((gr(9,0))*(7),10));
    sa(td((gr(9,0))*(7),10));
    goto _0;
_6:
    sa(sp()+sp());
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    goto _2;
_7:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _6;
_8:
    sa(sp()+sp());
    {int64 v0=sp();sa(sp()-v0);}
    goto _3;
_9:
    sa(sr());
    sa(gr(1,1));
    sa(sp()+sp());
    gw(1,1,sp());
    goto _10;
_10:
    sa(1);
    {int64 v0=sp();sa(sp()-v0);}
    sa(sr());
    goto _4;
_11:
    sa(sr());
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _0;
_12:
    sa(sr());
    sp();
    printf("%lld", (int64)((gr(1,1))-(3)));
    sp();
    goto __;
_13:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _1;
_14:
    sa(sr());
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()%v0));}
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(10);
    {int64 v0=sp();sa((v0==0)?0:(sp()/v0));}
    sa(sr());
    goto _0;
__:
    return 0;
}