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
        long x0=62;
        long x1=118;
        long x2=118;
        goto _0;
    _0:
        x1=2;
        x0=1;
        x2=2;
    _1:
        sa(x0);
        sa(x1);
        x0=x1;
        sa(sp()+sp());
        sa(sr());
        x1=sp();
        sa(sr());
        {long v0=10240000;sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _5; else goto _2;
    _2:
        sa(sr());
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
        sa(sp()*(2));
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _3; else goto _4;
    _3:
        sp();
        goto _1;
    _4:
        sa(sp()+(x2));
        x2=sp();
        goto _1;
    _5:
        System.Console.Out.Write((long)(x2));
        sp();
        return;
}}