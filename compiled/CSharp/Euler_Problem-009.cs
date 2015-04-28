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
        goto _0;
    _0:
        x0=1000;
        x1=2;
    _1:
        x2=1;
    _2:
        sa(((x2)*(x2))+((x1)*(x1)));
        x3=((x2)*(x2))+((x1)*(x1));
        sa(0);
        sa((0)-(x3));
    _3:
        if(sp()!=0)goto _4; else goto _10;
    _4:
        sa(sp()+(1));
        sa(sr());
        sa(sp()-(x0));
        if(sp()!=0)goto _9; else goto _5;
    _5:
        sp();
        sp();
    _6:
        sa((x2)+(1));
        x2=(x2)+(1);
        sa(sp()-(x1));
        if(sp()!=0)goto _2; else goto _7;
    _7:
        sa((x1)+(1));
        x1=(x1)+(1);
        sa(sp()-(x0));
        if(sp()!=0)goto _1; else goto _8;
    _8:
        return;
    _9:
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sp()-(x3));
        goto _3;
    _10:
        sa(sr());
        x3=sp();
        sa(sp()+((x2)+(x1)));
        sa(sp()-(x0));
        if(sp()!=0)goto _11; else goto _12;
    _11:
        sp();
        goto _6;
    _12:
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
}}