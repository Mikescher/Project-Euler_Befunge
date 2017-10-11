/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
        long x0=1000;
        sa(1002001);
        sa(1002001-x0);
        sa(1002001-x0-x0);
        sa(1002001-x0-x0-x0);
        sa(1002001-x0-x0-x0-x0);
        sa(1002001-x0-x0-x0-x0-1);
    _1:
        if(sp()!=0)goto _5;else goto _2;
    _2:
        sa(sp()+sp());

        t0=sp();
        sa(sr());

        if(sp()!=0)goto _4;else goto _3;
    _3:
        sp();
        System.Console.Out.Write(t0+" ");
        return;
    _4:
        sa(sp()+t0);
        goto _2;
    _5:
        x0-=2;
        sa(sr()-x0);
        sa(sr()-x0);
        sa(sr()-x0);
        sa(sr()-x0);
        sa(sr()-1);
        goto _1;
}
}
