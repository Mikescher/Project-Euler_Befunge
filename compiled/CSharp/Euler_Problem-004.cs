/* compiled with BefunCompile v1.0 (c) 2015 */
public static class Program 
{
private static readonly long[,] g = {{49,58,48,49,48,58,112,112,53,53,53,56,42,42,42,48,52,112,62,49,48,103,49,43,58,58,49,48,112,48,52,103,45,48,48,103,32,92,35,118,95,49,43,58,48,48,112,92,36,49,58,49,48,112,92,58,48,52,103,45,32,35,118,95,36,36,48,51,103,46,64},{32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,94,32,32,32,32,32,32,32,32,32,118,32,36,60,32,32,32,32,32,32,32,62,49,35,32,48,35,32,49,35,32,112,35,32,42,35,32,58,35,32,118,35,32,32,60,32,32,32,32,32,32,32,32},{32,32,32,118,95,118,35,45,103,49,45,103,50,48,103,49,48,103,32,49,103,50,48,60,112,50,48,49,60,118,95,94,35,58,47,43,53,53,112,49,48,43,49,103,49,48,112,49,103,49,48,37,43,53,53,58,32,32,60,32,32,32,32,32,32,32,32,32,32,32,32},{32,32,32,36,32,62,48,50,103,49,43,58,48,50,112,32,48,49,32,103,32,45,32,124,32,32,32,32,32,62,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,94,32,32,32,32,32,32,32,32,32,32,32,32},{32,32,32,62,32,32,32,32,32,32,32,32,32,32,32,32,32,32,94,32,32,32,32,62,58,48,51,103,92,96,35,118,95,48,51,112,118,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32},{32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,94,32,32,32,32,32,32,32,32,32,32,32,36,60,32,32,32,48,60,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32}};
private static long gr(long x,long y){return(x>=0&&y>=0&&x<71&&y<6)?g[y, x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<71&&y<6)g[y, x]=v;}
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
        goto _6;
    _0:
        if(sp()!=0)goto _8; else goto _16;
    _1:
        if(sp()!=0)goto _9; else goto _10;
    _2:
        if(sp()!=0)goto _5; else goto _12;
    _3:
        if(sp()!=0)goto _14; else goto _13;
    _4:
        if(sp()!=0)goto _8; else goto _17;
    _5:
        if((((gr(gr(0,2),1))-(gr(((gr(0,1))-(gr(0,2))),1))))!=0)goto _15;else goto _11;
    _6:
        gw(0,0,1);
        gw(1,0,1);
        gw(0,4,1000);
        goto _7;
    _7:
        sa(((gr(1,0))+(1)));
        sa(((gr(1,0))+(1)));
        gw(1,0,((gr(1,0))+(1)));
        sa(gr(0,4));
        {long v0=sp();sa(sp()-v0);}
        sa(gr(0,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _0;
    _8:
        gw(0,1,1);
        sa(sp()*sp());
        sa(sr());
        goto _9;
    _9:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        gw(gr(0,1),1,sp());
        gw(0,1,((gr(0,1))+(1)));
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _1;
    _10:
        gw(0,2,1);
        sp();
        goto _5;
    _11:
        sa(((gr(0,2))+(1)));
        gw(0,2,((gr(0,2))+(1)));
        sa(gr(0,1));
        {long v0=sp();sa(sp()-v0);}
        goto _2;
    _12:
        sa(sr());
        sa(gr(0,3));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _3;
    _13:
        gw(0,3,sp());
        goto _7;
    _14:
        sp();
        goto _7;
    _15:
        sp();
        goto _7;
    _16:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        gw(0,0,sp());
        gw(1,0,1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sp();
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(gr(0,4));
        {long v0=sp();sa(sp()-v0);}
        goto _4;
    _17:
        sp();
        sp();
        System.Console.Out.WriteLine((long)(gr(0,3)));
        return;
}}