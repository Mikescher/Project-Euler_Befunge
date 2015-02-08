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
        long x0=88;
        goto _1;
    _0:
        if(sp()!=0)goto _2; else goto _5;
    _1:
        x0=1000;
        sa(1002001);
        sa((1002001)-(x0));
        sa(((1002001)-(x0))-(x0));
        sa((((1002001)-(x0))-(x0))-(x0));
        sa(((((1002001)-(x0))-(x0))-(x0))-(x0));
        sa((((((1002001)-(x0))-(x0))-(x0))-(x0))-(1));
        goto _0;
    _2:
        x0=(x0)-(2);
        sa(sr());
        sa(sp()-(x0));
        sa(sr());
        sa(sp()-(x0));
        sa(sr());
        sa(sp()-(x0));
        sa(sr());
        sa(sp()-(x0));
        sa(sr());
        sa(sp()-(1));
        goto _0;
    _3:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _5;
    _4:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _5:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _3; else goto _4;
}}