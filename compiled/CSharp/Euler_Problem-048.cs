/* compiled with BefunCompile v1.0.4 (c) 2015 */
public static class Program 
{
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long x0=32;
        long x1=32;
        long x2=32;
        goto _1;
    _0:
        if(sp()!=0)goto _3; else goto _2;
    _1:
        x0=10000000000;
        sa(0);
        sa(1000);
        sa(1000);
        goto _0;
    _2:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _3:
        sa(sr());
        x2=sp();
        sa(sr());
        sa(sr());
        goto _6;
    _4:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sp()*(x1));
        {long v0=x0;sa((v0==0)?0:(sp()%v0));}
        goto _6;
    _5:
        sp();
        sp();
        sa(sp()+(x1));
        {long v0=x0;sa((v0==0)?0:(sp()%v0));}
        sa((x2)-(1));
        sa((x2)-(1));
        goto _0;
    _6:
        x1=sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-(1));
        sa(sr());
        if(sp()!=0)goto _4; else goto _5;
}}