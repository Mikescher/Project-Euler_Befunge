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
        long x2=32;
        goto _2;
    _0:
        if(sp()!=0)goto _3; else goto _7;
    _1:
        if(sp()!=0)goto _5; else goto _4;
    _2:
        x0=1;
        sa(0);
        sa(1);
        sa(10);
        sa(100);
        sa(1000);
        sa(10000);
        sa(100000);
        sa(1000000);
        sa(1000000);
        goto _0;
    _3:
        x1=1;
        x2=1;
        goto _8;
    _4:
        sp();
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()*(x0));
        x0=sp();
        sa(sr());
        goto _0;
    _5:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-(1));
        sa(sr());
        goto _1;
    _6:
        sa((x1)*((9)*(x2)));
        x1=(x1)+(1);
        x2=(x2)*(10);
        {long v0=sp();sa(sp()-v0);}
        goto _8;
    _7:
        sp();
        System.Console.Out.Write((long)(x0));
        return;
    _8:
        sa(sr());
        {long v0=(x1)*((9)*(x2));sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _9; else goto _6;
    _9:
        sa(sp()-(1));
        sa(sr());
        {long v0=x1;sa((v0==0)?0:(sp()/v0));}
        sa(sp()+(x2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=x1;sa((v0==0)?0:(sp()%v0));}
        sa(x1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        sa(sp()-(1));
        sa(sr());
        if(sp()!=0)goto _5; else goto _10;
    _10:
        sa(sr());
        if(sp()!=0)goto _5; else goto _4;
}}