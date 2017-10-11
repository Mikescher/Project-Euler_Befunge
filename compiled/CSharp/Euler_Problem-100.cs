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
        long t0,t1,t2;
        long x0=1;
        long x1=1;
        long x2=0;
        long x3=0;
    _1:
        t0=x0;
        t1=x2;
        x0=(x0*3)+(x2*4);
        t1*=3;
        t0*=2;
        t2=t1+t0;
        x2=t2;
        t0=x1;
        t1=x3;
        x1=(x1*3)-(x3*4);
        t1*=3;
        t0*=2;
        t2=t1-t0;
        x3=t2;
        if((td((2+(x2*2))-x0-(2*x3)-x1,4))<=1000000000000L)goto _1;else goto _3;
    _3:
        System.Console.Out.Write(td((4+(x1*2)+(x3*2)+(x0*2))-(x2*2),8)+" ");
        return;
}
}
