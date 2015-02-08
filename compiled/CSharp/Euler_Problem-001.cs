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
        goto _1;
    _0:
        if(sp()!=0)goto _6; else goto _9;
    _1:
        sa(1);
        sa(2);
        sa(2);
        sa(0);
        goto _0;
    _2:
        sp();
        sa(sp()+(1));
        sa(sr());
        sa(sr());
        sa(sr());
        {long v0=3;sa((v0==0)?0:(sp()/v0));}
        sa(sp()*(3));
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _0;
    _3:
        sp();
        sp();
        sp();
        goto _8;
    _4:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _8;
    _5:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _6:
        sa(sr());
        goto _7;
    _7:
        sa(sr());
        sa(sp()-(1000));
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _3; else goto _2;
    _8:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sp()-(1));
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _5; else goto _4;
    _9:
        sa(sr());
        sa(sr());
        {long v0=5;sa((v0==0)?0:(sp()/v0));}
        sa(sp()*(5));
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _6; else goto _7;
}}