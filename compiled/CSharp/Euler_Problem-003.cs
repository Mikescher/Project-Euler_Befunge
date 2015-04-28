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
        long x0=57;
        long x1=56;
        long x2=55;
        long x3=57;
        goto _0;
    _0:
        x0=775146;
        x1=600851475143;
    _1:
        sa(x1);
        sa((x0)-(1));
        x0=(x0)-(1);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
    _2:
        if(sp()!=0)goto _1; else goto _3;
    _3:
        sa(x0);
        x3=x0;
        sa(sp()-(1));
        x2=sp();
    _4:
        if((((tm(x3,x2))!=0)?0:1)!=0)goto _1;else goto _5;
    _5:
        sa(x2);
        x2=(x2)-(1);
        sa(sp()-(2));
        if(sp()!=0)goto _4; else goto _6;
    _6:
        System.Console.Out.Write((long)(x3));
        return;
}}