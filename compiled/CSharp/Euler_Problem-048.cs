/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
        sa(0L);
        sa(1000L);
    _1:
        x2=sr();
        sa(sr());
        x1=sr();
    _2:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _5;else goto _3;
    _3:
        sp();
        sp();
        sa(sp()+x1);
        sa(tm(sp(),x0));
        sa(x2-1L);
        if(x2!=1L)goto _1;else goto _4;
    _4:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _5:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr()*x1,x0));
        x1=sp();
        goto _2;
}}