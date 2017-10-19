/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0;
        long x0=10000000000;
        long x1=32;
        long x2=32;
        sa(0);
        sa(1000);
        sa(1000);
    _1:
        if(sp()!=0)goto _3;else goto _2;
    _2:
        sp();
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _3:
        x2=sr();
        sa(sr());
        x1=sr();
    _4:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _6;else goto _5;
    _5:
        sp();
        sp();
        sa(sp()+x1);

        sa(tm(sp(),x0));

        sa(x2-1);
        sa(x2-1);
        goto _1;
    _6:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        t0=tm(sr()*x1,x0);
        x1=t0;
        goto _4;
}
}
