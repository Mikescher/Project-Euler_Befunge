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
        goto _0;
    _0:
        sa(1);
        sa(2);
        sa(2);
        sa(0);
    _1:
        if(sp()!=0)goto _9; else goto _2;
    _2:
        sa(sr());
        sa(sr());
        {long v0=5;sa((v0==0)?0:(sp()/v0));}
        sa(sp()*(5));
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _9; else goto _3;
    _3:
        sa(sr());
        sa(sp()-(1000));
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _4; else goto _8;
    _4:
        sp();
        sp();
        sp();
    _5:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sp()-(1));
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _6; else goto _7;
    _6:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _7:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _5;
    _8:
        sp();
        sa(sp()+(1));
        sa(sr());
        sa(sr());
        sa(sr());
        {long v0=3;sa((v0==0)?0:(sp()/v0));}
        sa(sp()*(3));
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _1;
    _9:
        sa(sr());
        goto _3;
}}