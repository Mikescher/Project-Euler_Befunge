/* compiled with BefunCompile v1.0 (c) 2015 */
public static class Program 
{
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long x0=34;
        long x1=100;
        long x2=34;
        long x3=53;
        goto _5;
    _0:
        if(sp()!=0)goto _8; else goto _14;
    _1:
        if(sp()!=0)goto _9; else goto _10;
    _2:
        if(sp()!=0)goto _7; else goto _12;
    _3:
        if(sp()!=0)goto _6; else goto _13;
    _4:
        if(sp()!=0)goto _16; else goto _15;
    _5:
        x0=1000;
        x1=2;
        goto _6;
    _6:
        x2=1;
        goto _7;
    _7:
        sa(((((x2)*(x2)))+(((x1)*(x1)))));
        x3=((((x2)*(x2)))+(((x1)*(x1))));
        sa(0);
        sa(((0)-(x3)));
        goto _0;
    _8:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(x0);
        {long v0=sp();sa(sp()-v0);}
        goto _1;
    _9:
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(x3);
        {long v0=sp();sa(sp()-v0);}
        goto _0;
    _10:
        sp();
        sp();
        goto _11;
    _11:
        sa(((x2)+(1)));
        x2=((x2)+(1));
        sa(x1);
        {long v0=sp();sa(sp()-v0);}
        goto _2;
    _12:
        sa(((x1)+(1)));
        x1=((x1)+(1));
        sa(x0);
        {long v0=sp();sa(sp()-v0);}
        goto _3;
    _13:
        return;
    _14:
        sa(sr());
        x3=sp();
        sa(((x2)+(x1)));
        sa(sp()+sp());
        sa(x0);
        {long v0=sp();sa(sp()-v0);}
        goto _4;
    _15:
        sa(x2);
        System.Console.Out.WriteLine((long)(x2));
        System.Console.Out.WriteLine((char)(32));
        sa(x1);
        System.Console.Out.WriteLine((long)(x1));
        System.Console.Out.WriteLine((char)(32));
        sa(x3);
        System.Console.Out.WriteLine((long)(x3));
        System.Console.Out.WriteLine((char)(61));
        sa(sp()*sp());
        sa(sp()*sp());
        System.Console.Out.WriteLine((long)(sp()));
        return;
    _16:
        sp();
        goto _11;
}}