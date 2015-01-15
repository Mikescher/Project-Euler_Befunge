/* compiled with BefunCompile v1.0.2 (c) 2015 */
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
        long x0=32;
        long x1=32;
        long x2=32;
        long x3=32;
        long x4=32;
        long x5=32;
        goto _4;
    _0:
        if(((x2)-(2))!=0)goto _12;else goto _6;
    _1:
        if(((x5)>(x0)?1:0)!=0)goto _7;else goto _11;
    _2:
        if(((x3)-(x4))!=0)goto _10;else goto _9;
    _3:
        if((tm((x3)*((x3)-((2)*(x2))),((x3)-(x2))*(2)))!=0)goto _5;else goto _13;
    _4:
        x0=0;
        x1=0;
        x3=6;
        x4=1000;
        x5=0;
        x2=td(x3,3);
        goto _5;
    _5:
        sa(x2);
        goto _0;
    _6:
        sp();
        sa(x5);
        goto _1;
    _7:
        x0=sp();
        x1=x3;
        goto _8;
    _8:
        sa(x3);
        goto _2;
    _9:
        sp();
        System.Console.Out.Write((long)(x1));
        return;
    _10:
        sa(2);
        sa(sp()+sp());
        x3=sp();
        x5=0;
        x2=td(x3,3);
        goto _5;
    _11:
        sp();
        goto _8;
    _12:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        x2=sp();
        goto _3;
    _13:
        x5=(x5)+(1);
        goto _5;
}}