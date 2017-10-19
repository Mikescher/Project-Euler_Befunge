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
        long t0,t1;
        long x0=1;
        long x1=2;
        long x2=2;
        sa(0);
    _1:
        sp();
        sa(x0+x1);
        t0=x0+x1;
        x0=x1;
        x1=t0;

        if(sr()>10240000)goto _4;else goto _2;
    _2:
        sa(sr());
        t0=(sr()/2)*2;
        sa(sp()-t0);

        t1=sp();

        if((t1)!=0)goto _1;else goto _3;
    _3:
        sa(sp()+x2);

        x2=sp();
        sa(0);
        goto _1;
    _4:
        System.Console.Out.Write(x2+" ");
        sp();
        return;
}
}
