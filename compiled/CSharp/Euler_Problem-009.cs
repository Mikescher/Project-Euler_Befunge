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
        long t0,t1,t2,t3;
        long x0=1000;
        long x1=2;
        long x2=34;
        long x3=53;
    _1:
        x2=1;
    _2:
        sa((x2*x2)+(x1*x1));
        x3=(x2*x2)+(x1*x1);
        sa(0);
        sa(0-x3);
    _3:
        if(sp()!=0)goto _4;else goto _10;
    _4:
        sa(sp()+1L);


        if(sr()!=x0)goto _9;else goto _5;
    _5:
        sp();
        sp();
    _6:
        t0=x2+1;
        x2++;
        t0-=x1;

        if((t0)!=0)goto _2;else goto _7;
    _7:
        t0=x1+1;
        x1++;
        t0-=x0;

        if((t0)!=0)goto _1;else goto _8;
    _8:
        return;
    _9:
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sp()-x3);
        goto _3;
    _10:
        x3=sr();
        sa(sp()+x2+x1);

        sa(sp()-x0);


        if(sp()!=0)goto _11;else goto _12;
    _11:
        sp();
        goto _6;
    _12:
        t0=x2;
        System.Console.Out.Write(x2);
        System.Console.Out.Write(' ');
        t1=x1;
        System.Console.Out.Write(x1);
        System.Console.Out.Write(' ');
        t2=x3;
        System.Console.Out.Write(x3);
        System.Console.Out.Write('=');
        t3=t1*t2;
        t1=t0*t3;
        System.Console.Out.Write(t1);
        return;
}
}
