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
        long x0=88;
        long x1=88;
        long x2=88;
        long x3=88;
        long x4=88;
        goto _1;
    _0:
        if(sp()!=0)goto _9; else goto _2;
    _1:
        x0=10;
        x3=1;
        x1=1;
        sa(10);
        sa(1);
        sa(1);
        sa(1);
        sa(1);
        goto _0;
    _2:
        x2=2;
        sp();
        sa(sr());
        sa(x2);
        goto _3;
    _3:
        x4=1;
        sa(sp()*sp());
        sa(sp()*(10));
        goto _10;
    _4:
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(2));
        sa(sp()*(x4));
        x4=sp();
        goto _10;
    _5:
        System.Console.Out.Write((long)(sp()));
        sp();
        sp();
        return;
    _6:
        sa(sr());
        sa(x2);
        goto _3;
    _7:
        x1=1;
        sa(sr());
        sa(sr());
        sa(sp()*(10));
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _8:
        sp();
        sa(sp()*(10));
        sa(sr());
        x0=sp();
        sa(sr());
        {long v0=6;sa((v0==0)?0:(sp()/v0));}
        x3=sp();
        x1=1;
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(sr());
        sa(sp()*(10));
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _9:
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(2));
        sa(sp()*(x1));
        x1=sp();
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _10:
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _11; else goto _4;
    _11:
        sp();
        if(((x4)-(x1))!=0)goto _12;else goto _13;
    _12:
        sp();
        sa(sp()+(1));
        sa(sr());
        sa(x3);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _8; else goto _7;
    _13:
        sa((x2)+(1));
        x2=(x2)+(1);
        sa(sp()-(7));
        if(sp()!=0)goto _6; else goto _5;
}}