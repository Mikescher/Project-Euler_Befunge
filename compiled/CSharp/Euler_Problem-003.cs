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
        long t0,t1,t2;
        long x0=775146;
        long x1=600851475143;
        long x2=55;
        long x3=57;
    _1:
        t0=x1;
        t1=x0-1;
        x0--;
        t2=tm(t0,t1);
        if((t2)!=0)goto _1;else goto _3;
    _3:
        t0=x0;
        x3=x0;
        t0--;
        x2=t0;
    _4:
        if(tm(x3,x2)==0)goto _1;else goto _5;
    _5:
        t0=x2;
        x2--;
        t0-=2;

        if((t0)!=0)goto _4;else goto _6;
    _6:
        System.Console.Out.Write(x3);
        return;
}
}
