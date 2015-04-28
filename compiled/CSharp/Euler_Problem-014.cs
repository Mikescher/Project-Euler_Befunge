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
        long x0=118;
        long x1=32;
        goto _0;
    _0:
        x0=0;
        sa(4);
        sa(1);
        sa(4);
        sa(0);
    _1:
        if(sp()!=0)goto _11; else goto _2;
    _2:
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
    _3:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+(1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sp()-(1));
        if(sp()!=0)goto _10; else goto _4;
    _4:
        sp();
        sa(sr());
        sa(x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _5; else goto _9;
    _5:
        sp();
    _6:
        sa(sr());
        {long v0=1000000;sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _8; else goto _7;
    _7:
        System.Console.Out.Write((long)(x1));
        sa(x0);
        sa(58);
        System.Console.Out.Write((char)(32));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((long)(sp()));
        return;
    _8:
        sa(sp()+(1));
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        goto _1;
    _9:
        x0=sp();
        sa(sr());
        x1=sp();
        goto _6;
    _10:
        {long v0=1;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        goto _1;
    _11:
        sa(sp()*(3));
        sa(sp()+(1));
        goto _3;
}}