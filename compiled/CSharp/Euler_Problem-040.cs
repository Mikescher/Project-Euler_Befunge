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
        long x0=1;
        long x1=32;
        long x2=32;
        sa(0L);
        sa(1L);
        sa(10L);
        sa(100L);
        sa(1000L);
        sa(10000L);
        sa(100000L);
        sa(1000000L);
    _1:
        x1=1L;
        x2=1L;
    _2:
        if(sr()<=x1*9L*x2)goto _3;else goto _9;
    _3:
        sa(sp()-1L);
        sa((td(sr(),x1))+x2);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),x1));
        sa(x1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _7;else goto _4;
    _4:
        sa(sr());
        if(sp()!=0)goto _7;else goto _5;
    _5:
        sp();
        sa(tm(sp(),10L));
        sa(sp()*x0);
        x0=sp();
        sa(sr());
        if(sp()!=0)goto _1;else goto _6;
    _6:
        sp();
        System.Console.Out.Write((long)(x0));
        return;
    _7:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _7;else goto _5;
    _9:
        sa(x1*9L*x2);
        x1=x1+1L;
        x2=x2*10L;
        {long v0=sp();sa(sp()-v0);}
        goto _2;
}}