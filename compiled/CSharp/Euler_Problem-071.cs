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
        long x0=0;
        long x1=1000000;
        long x2=0;
        long x3=1;
        long x4=1;
        long x5=63;
        long x6=63;
        long x7=63;
        long x8=63;
        sa(1);
        sa(0);
    _1:
        if(sp()!=0)goto _5;else goto _2;
    _2:
        x5=sr();
        t0=(sr()*3)/7;
        x6=t0;
        t0*=7;
        t0-=x5*3;

        if(t0>0)goto _3;else goto _8;
    _3:
        x7=t0;
        x8=x5*7;

        if((x4*x8)>(x3*x7))goto _4;else goto _5;
    _4:
        x4=x7;
        x3=x8;
        x0=x6;
        x2=x5;
    _5:
        if((sr()-x1)!=0)goto _7;else goto _6;
    _6:
        System.Console.Out.Write(x0+" ");
        System.Console.Out.Write(" /");
        System.Console.Out.Write('\n');
        System.Console.Out.Write(x2+" ");
        sp();
        return;
    _7:
        sa(sp()+1L);

        sa(((sr()*3)%7!=0)?0:1);
        goto _1;
    _8:
        t0*=-1;
        goto _3;
}
}
