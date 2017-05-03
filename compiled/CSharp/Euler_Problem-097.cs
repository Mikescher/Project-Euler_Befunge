/* transpiled with BefunCompile v1.1.0 (c) 2015 */
public static class Program
{
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        t0=56866;
        sa(7830455);
    _1:
        t0*=2;
        t0%=10000000000L;
        sa(sr());

        if(sp()!=0)goto _3;else goto _2;
    _2:
        sp();
        t0++;
        t0%=10000000000L;
        System.Console.Out.Write(t0);
        return;
    _3:
        sa(sp()-1L);
        goto _1;
}
}
