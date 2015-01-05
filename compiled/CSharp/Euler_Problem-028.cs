/* compiled with BefunCompile v1.0 (c) 2015 */
public static class Program 
{
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
        long x0=88;
        goto _2;
    _0:
        if(sp()!=0)goto _3; else goto _4;
    _1:
        if(sp()!=0)goto _5; else goto _6;
    _2:
        x0=1000;
        sa(1002001);
        sa(((1002001)-(x0)));
        sa(((((1002001)-(x0)))-(x0)));
        sa(((((((1002001)-(x0)))-(x0)))-(x0)));
        sa(((((((((1002001)-(x0)))-(x0)))-(x0)))-(x0)));
        sa(((((((((((1002001)-(x0)))-(x0)))-(x0)))-(x0)))-(1)));
        goto _0;
    _3:
        x0=((x0)-(2));
        sa(sr());
        sa(x0);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(x0);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(x0);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(x0);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        goto _0;
    _4:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _1;
    _5:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _4;
    _6:
        sp();
        System.Console.Out.WriteLine((long)(sp()));
        return;
}}