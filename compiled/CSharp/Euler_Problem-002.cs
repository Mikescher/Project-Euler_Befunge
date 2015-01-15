/* compiled with BefunCompile v1.0.3 (c) 2015 */
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
        long x0=62;
        long x1=118;
        long x2=118;
        goto _2;
    _0:
        if(sp()!=0)goto _4; else goto _5;
    _1:
        if(sp()!=0)goto _7; else goto _6;
    _2:
        x1=2;
        x0=1;
        x2=2;
        goto _3;
    _3:
        sa(x0);
        sa(x1);
        x0=x1;
        sa(sp()+sp());
        sa(sr());
        x1=sp();
        sa(sr());
        sa(10240000);
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _0;
    _4:
        System.Console.Out.Write((long)(x2));
        sp();
        return;
    _5:
        sa(sr());
        sa(sr());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(2);
        sa(sp()*sp());
        {long v0=sp();sa(sp()-v0);}
        goto _1;
    _6:
        sa(x2);
        sa(sp()+sp());
        x2=sp();
        goto _3;
    _7:
        sp();
        goto _3;
}}