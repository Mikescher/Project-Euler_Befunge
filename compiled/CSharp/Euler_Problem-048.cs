/* compiled with BefunCompile v1.0.1 (c) 2015 */
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
        long x0=32;
        long x1=32;
        long x2=32;
        goto _2;
    _0:
        if(sp()!=0)goto _4; else goto _3;
    _1:
        if(sp()!=0)goto _6; else goto _7;
    _2:
        x0=10000000000;
        sa(0);
        sa(1000);
        sa(1000);
        goto _0;
    _3:
        sp();
        System.Console.Out.WriteLine((long)(sp()));
        return;
    _4:
        sa(sr());
        x2=sp();
        sa(sr());
        sa(sr());
        goto _5;
    _5:
        x1=sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _1;
    _6:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(x1);
        sa(sp()*sp());
        sa(x0);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _5;
    _7:
        sp();
        sp();
        sa(x1);
        sa(sp()+sp());
        sa(x0);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((x2)-(1));
        sa((x2)-(1));
        goto _0;
}}