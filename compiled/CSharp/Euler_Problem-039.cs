/* compiled with BefunCompile v1.0.8 (c) 2015 */
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
        long t0;
        long x0=0;
        long x1=0;
        long x2=32;
        long x3=6;
        long x4=1000;
        long x5=0;
        x2=td(x3,3);
    _1:
        t0=x2;
        if(x2!=2)goto _2;else goto _4;
    _2:
        t0--;
        x2=t0;
        if(tm(x3*(x3-(2*x2)),(x3-x2)*2)!=0)goto _1;else goto _3;
    _3:
        x5++;
        goto _1;
    _4:
        t0=x5;
        if(x5>x0)goto _8;else goto _5;
    _5:
        t0=x3;
        if(x3!=x4)goto _7;else goto _6;
    _6:
        System.Console.Out.Write(x1);
        return;
    _7:
        t0+=2;
        x3=t0;
        x5=0;
        x2=td(x3,3);
        goto _1;
    _8:
        x0=t0;
        x1=x3;
        goto _5;
}}