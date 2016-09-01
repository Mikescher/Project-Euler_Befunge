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
        long x0=2;
        long x1=0;
        long x2=1000000000;
        long x3=1;
    _1:
        if(x2>(x0*2))goto _3;else goto _2;
    _2:
        System.Console.Out.Write(x1);
        return;
    _3:
        x1=((x0>2?1:0)*(((tm(2*x0,3))-1!=0)?0:1)*((tm((x0-2)*x3,3)!=0)?0L:1L)*((x0*2)-2))+x1;
        x1=((((tm(x0*2,3))-2!=0)?0:1)*((tm((x0+2)*x3,3)!=0)?0L:1L)*(2+(2*x0)))+x1;
        t0=x0+(x3*2);
        x0=(x0*2)+(x3*3);
        x3=t0;
        goto _1;
}}