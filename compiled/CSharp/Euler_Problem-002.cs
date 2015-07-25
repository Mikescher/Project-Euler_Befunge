/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
        long t0,t1;
        long x0=1;
        long x1=2;
        long x2=2;
    _1:
        t0=x0;
        t1=x1;
        x0=x1;
        sa(t0+t1);
        x1=sr();
        if(sr()>10240000)goto _5;else goto _2;
    _2:
        sa(sr());
        t0=(td(sr(),2))*2;
        sa(sp()-t0);
        t1=sp();
        if((t1)!=0)goto _3;else goto _4;
    _3:
        sp();
        goto _1;
    _4:
        sa(sp()+x2);
        x2=sp();
        goto _1;
    _5:
        System.Console.Out.Write(x2);
        sp();
        return;
}}