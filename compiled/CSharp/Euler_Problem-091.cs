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
        long x0=50;
        long x1=0;
        long x2=50;
        long x3=88;
        long x4=88;
    _1:
        x3=x0;
        x4=x3+1;
    _2:
        if(((x3*(x4-x3))>(x2*x2)?1:0)+(x4>x0?1L:0L)==0)goto _7;else goto _3;
    _3:
        t0=x3-1;
        x3--;
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _4;else goto _6;
    _4:
        t0=x2-1;
        x2--;

        if((t0)!=0)goto _1;else goto _5;
    _5:
        System.Console.Out.Write(x1+(3*x0*x0));
        return;
    _6:
        x4=x3+1;
        goto _2;
    _7:
        x1+=((tm((x3-x4)*x3,x2)!=0)?0:1)*2L;
        x4++;
        goto _2;
}
}
