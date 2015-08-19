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
        long x0=0;
        long x1=1000000;
        long x2=0;
        long x3=1;
        long x4=1;
        long x5=63;
        long x6=63;
        long x7=63;
        long x8=63;
        t0=1;
    _1:
        x5=t0;
        t1=td(t0*3,7);
        x6=t1;
        t1=t1*7;
        t1=t1-(x5*3);
        if(t1>0)goto _2;else goto _8;
    _2:
        t1=t1;
    _3:
        x7=t1;
        x8=x5*7;
        if((x4*x8)>(x3*x7))goto _4;else goto _5;
    _4:
        x4=x7;
        x3=x8;
        x0=x6;
        x2=x5;
    _5:
        if(t0!=x1)goto _6;else goto _7;
    _6:
        t0=t0+1;
        if(tm(t0*3,7)==0)goto _5;else goto _1;
    _7:
        System.Console.Out.Write(x0);
        System.Console.Out.Write(" /");
        System.Console.Out.Write('\n');
        System.Console.Out.Write(x2);
        return;
    _8:
        t1=t1*-1;
        goto _3;
}}