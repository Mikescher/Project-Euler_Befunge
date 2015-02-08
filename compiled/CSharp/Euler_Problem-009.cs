/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
        long x0=34;
        long x1=100;
        long x2=34;
        long x3=53;
        goto _1;
    _0:
        if(sp()!=0)goto _12; else goto _9;
    _1:
        x0=1000;
        x1=2;
        goto _2;
    _2:
        x2=1;
        goto _3;
    _3:
        sa(((x2)*(x2))+((x1)*(x1)));
        x3=((x2)*(x2))+((x1)*(x1));
        sa(0);
        sa((0)-(x3));
        goto _0;
    _4:
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sp()-(x3));
        goto _0;
    _5:
        sp();
        sp();
        goto _10;
    _6:
        return;
    _7:
        sa(x2);
        System.Console.Out.Write((long)(x2));
        System.Console.Out.Write((char)(32));
        sa(x1);
        System.Console.Out.Write((long)(x1));
        System.Console.Out.Write((char)(32));
        sa(x3);
        System.Console.Out.Write((long)(x3));
        System.Console.Out.Write((char)(61));
        sa(sp()*sp());
        sa(sp()*sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _8:
        sp();
        goto _10;
    _9:
        sa(sr());
        x3=sp();
        sa(sp()+((x2)+(x1)));
        sa(sp()-(x0));
        if(sp()!=0)goto _8; else goto _7;
    _10:
        sa((x2)+(1));
        x2=(x2)+(1);
        sa(sp()-(x1));
        if(sp()!=0)goto _3; else goto _11;
    _11:
        sa((x1)+(1));
        x1=(x1)+(1);
        sa(sp()-(x0));
        if(sp()!=0)goto _2; else goto _6;
    _12:
        sa(sp()+(1));
        sa(sr());
        sa(sp()-(x0));
        if(sp()!=0)goto _4; else goto _5;
}}