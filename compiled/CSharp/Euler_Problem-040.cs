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
        long t0,t1;
        long x0=32;
        long x1=32;
        long x2=1;
        sa(0);
        sa(1);
        sa(10);
        sa(100);
        sa(1000);
        sa(10000);
        sa(100000);
        sa(1000000);
    _1:
        x0=1;
        x1=1;
    _2:
        if(sr()<=(x0*9*x1))goto _3;else goto _9;
    _3:
        sa(sp()-1L);

        t0=(td(sr(),x0))+x1;
        sa(tm(sp(),x0));

        t1=x0;
        sa(t1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}

        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _8;else goto _4;
    _4:
        sa(sr());
    _5:
        if(sp()!=0)goto _8;else goto _6;
    _6:
        sp();
        t0%=10;
        t0*=x2;
        x2=t0;
        sa(sr());

        if(sp()!=0)goto _1;else goto _7;
    _7:
        System.Console.Out.Write(x2+" ");
        sp();
        return;
    _8:
        t0/=10;
        sa(sp()-1L);

        sa(sr());
        goto _5;
    _9:
        t0=x0*9*x1;
        x0++;
        x1*=10;
        sa(sp()-t0);
        goto _2;
}
}
