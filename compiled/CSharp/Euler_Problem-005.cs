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
        long x0=52;
        long x1=53;
        long x2=42;
        long x3=48;
        long x4=48;
        long x5=112;
        goto _5;
    _0:
        if(sp()!=0)goto _7; else goto _12;
    _1:
        if(sp()!=0)goto _6; else goto _3;
    _2:
        if(sp()!=0)goto _4; else goto _11;
    _3:
        if((tm(x1,x3))!=0)goto _8;else goto _9;
    _4:
        if((((tm(x4,x5))!=0)?0:1)!=0)goto _10;else goto _8;
    _5:
        x0=20;
        x1=1;
        x2=1;
        goto _6;
    _6:
        x1=((x1)*(x2));
        sa(x0);
        sa(((x2)+(1)));
        x2=((x2)+(1));
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _0;
    _7:
        x3=1;
        goto _8;
    _8:
        sa(x3);
        x3=((x3)+(1));
        sa(x0);
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _1;
    _9:
        x4=td(x1,x3);
        x5=1;
        goto _10;
    _10:
        sa(x2);
        sa(((x5)+(1)));
        x5=((x5)+(1));
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _2;
    _11:
        x1=td(x1,x3);
        goto _3;
    _12:
        System.Console.Out.WriteLine((long)(x1));
        return;
}}