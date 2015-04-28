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
        long x0=32;
        long x1=32;
        goto _0;
    _0:
        sa(0);
        sa(10000);
        sa(10000);
        sa(0);
        sa(10000);
        sa(0);
    _1:
        if(sp()!=0)goto _3; else goto _2;
    _2:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*(10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        x1=sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+(x1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _1;
    _3:
        sp();
        sa(sp()+sp());
        sa(24);
        sa(0);
    _4:
        if(sp()!=0)goto _14; else goto _5;
    _5:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _6:
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _7; else goto _13;
    _7:
        sp();
        sa(sr());
        x0=sp();
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _8; else goto _9;
    _8:
        sa(sr());
        sp();
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-(1));
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _4;
    _9:
        sp();
        sp();
    _10:
        sa(sp()-(1));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _11; else goto _12;
    _11:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _12:
        sa(sr());
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _1;
    _13:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*(10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        x1=sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+(x1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        goto _6;
    _14:
        sp();
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+(1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _10;
}}