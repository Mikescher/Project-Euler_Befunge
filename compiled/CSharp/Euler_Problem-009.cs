/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
        long x0=1000;
        long x1=2;
        long x2=34;
        long x3=53;
    _1:
        x2=1L;
    _2:
        sa((x2*x2)+(x1*x1));
        x3=(x2*x2)+(x1*x1);
        sa(0L);
        sa(0L-x3);
    _3:
        if(sp()!=0)goto _10;else goto _4;
    _4:
        x3=sr();
        sa(sp()+x2+x1);
        sa(sp()-x0);
        if(sp()!=0)goto _5;else goto _9;
    _5:
        sp();
    _6:
        sa(x2+1L);
        x2=x2+1L;
        sa(sp()-x1);
        if(sp()!=0)goto _2;else goto _7;
    _7:
        sa(x1+1L);
        x1=x1+1L;
        sa(sp()-x0);
        if(sp()!=0)goto _1;else goto _8;
    _8:
        return;
    _9:
        sa(x2);
        System.Console.Out.Write((long)(x2));
        System.Console.Out.Write(' ');
        sa(x1);
        System.Console.Out.Write((long)(x1));
        System.Console.Out.Write(' ');
        sa(x3);
        System.Console.Out.Write((long)(x3));
        System.Console.Out.Write('=');
        sa(sp()*sp());
        sa(sp()*sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _10:
        sa(sp()+1L);
        if(sr()!=x0)goto _12;else goto _11;
    _11:
        sp();
        sp();
        goto _6;
    _12:
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sp()-x3);
        goto _3;
}}