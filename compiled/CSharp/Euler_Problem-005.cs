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
        long t0,t1,t2;
        long x0=20;
        long x1=1;
        long x2=1;
        long x3=48;
        long x4=48;
        long x5=112;
    _1:
        x1*=x2;
        t0=x0;
        t1=x2+1;
        x2++;
        t2=t0>t1?1:0;
        if((t2)!=0)goto _3;else goto _2;
    _2:
        System.Console.Out.Write(x1);
        return;
    _3:
        x3=1;
    _4:
        t0=x3;
        x3++;
        t0=t0>x0?1:0;
        if((t0)!=0)goto _1;else goto _5;
    _5:
        if(tm(x1,x3)!=0)goto _4;else goto _6;
    _6:
        x4=td(x1,x3);
        x5=1;
    _7:
        t0=x2;
        t1=x5+1;
        x5++;
        t2=t0>t1?1:0;
        if((t2)!=0)goto _9;else goto _8;
    _8:
        x1/=x3;
        goto _5;
    _9:
        if(tm(x4,x5)==0)goto _7;else goto _4;
}}