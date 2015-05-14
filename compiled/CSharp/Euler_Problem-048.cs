/* compiled with BefunCompile v1.0.5 (c) 2015 */
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
        long x0=10000000000;
        long x1=32;
        long x2=32;
        sa(0);
        sa(1000);
        sa(1000);
    _1:
        if(sp()!=0)goto _2;else goto _6;
    _2:
        sa(sr());
        x2=sp();
        sa(sr());
        sa(sr());
    _3:
        x1=sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1);
        sa(sr());
        if(sp()!=0)goto _5;else goto _4;
    _4:
        sp();
        sp();
        sa(sp()+x1);
        {long v0=x0;sa((v0==0)?0:(sp()%v0));}
        sa(x2-1);
        sa(x2-1);
        goto _1;
    _5:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sp()*x1);
        {long v0=x0;sa((v0==0)?0:(sp()%v0));}
        goto _3;
    _6:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
}}