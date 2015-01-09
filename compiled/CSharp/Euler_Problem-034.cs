/* compiled with BefunCompile v1.0.1 (c) 2015 */
public static class Program 
{
private static readonly long[,] g = {{118,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32},{62,49,58,48,48,112,49,42,58,49,48,112,50,42,58,50,48,112,51,42,58,51,48,112,52,42,58,52,48,112,53,42,58,118,32,32,32,32,32,32,32,32,32,32,32},{118,112,49,49,48,36,112,48,57,58,42,57,112,48,56,58,42,56,112,48,55,58,42,55,112,48,54,58,42,54,112,48,53,60,32,32,32,32,32,32,32,32,32,32,32},{32,32,32,32,32,32,118,95,118,35,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,58,45,49,60,112,49,49,32,60},{62,57,48,103,55,42,62,58,58,48,92,62,58,53,53,43,37,48,103,92,53,53,43,47,58,35,118,95,62,43,35,60,92,58,35,60,95,43,45,124,32,32,32,32,43},{32,32,32,32,62,51,45,46,36,64,32,124,58,47,43,53,53,92,103,48,37,43,53,53,58,32,60,32,32,32,32,32,32,32,32,32,32,32,32,62,58,49,49,103,94},{32,32,32,32,94,103,49,49,60,32,32,62,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,94,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32}};
private static long gr(long x,long y){return(x>=0&&y>=0&&x<45&&y<7)?g[y, x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<45&&y<7)g[y, x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
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
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _2;
    _7:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _6;
    _8:
        sa(sp()+sp());
        {long v0=sp();sa(sp()-v0);}
        goto _3;
    _9:
        sa(sr());
        sa(gr(1,1));
        sa(sp()+sp());
        gw(1,1,sp());
        goto _10;
    _10:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _4;
    _11:
        sa(sr());
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _12:
        sa(sr());
        sp();
        System.Console.Out.WriteLine((long)((gr(1,1))-(3)));
        sp();
        return;
    _13:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _1;
    _14:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
}}