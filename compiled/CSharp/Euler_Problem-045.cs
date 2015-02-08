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
        goto _1;
    _0:
        if(sp()!=0)goto _3; else goto _8;
    _1:
        x0=1152921504606846976;
        x2=0;
        x1=991873;
        sa(144);
        sa(991873);
        goto _2;
    _2:
        sa(x0);
        sa((x0)>(x1)?1:0);
        goto _0;
    _3:
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=x1;sa((sp()>v0)?1:0);}
        goto _0;
    _4:
        x2=0;
        sp();
        sa(sp()+(1));
        sa(sr());
        sa(sr());
        sa(sp()*(2));
        sa(sp()-(1));
        sa(sp()*sp());
        sa(sp()*(24));
        sa(sp()+(1));
        sa(sr());
        x1=sp();
        goto _2;
    _5:
        x2=0;
        sa(sp()+(1));
        sa(sr());
        sa(sr());
        sa(sp()*(2));
        sa(sp()-(1));
        sa(sp()*sp());
        sa(sp()*(24));
        sa(sp()+(1));
        sa(sr());
        x1=sp();
        goto _2;
    _6:
        sa(sr());
        sa(sp()*(2));
        sa(sp()-(1));
        sa(sp()*sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _7:
        sa(sr());
        sa(sp()+(x2));
        sa(x1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x1=sp();
        sa(sr());
        sa(sp()*(2));
        sa(sp()+(x2));
        x2=sp();
        x2=td(x2,2);
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        goto _8;
    _8:
        sa(sr());
        if(sp()!=0)goto _11; else goto _9;
    _9:
        sp();
        sa(sp()-((x2)*(x2)));
        sa((((tm(x2,6))-(5))!=0)?0:1);
        if(sp()!=0)goto _10; else goto _4;
    _10:
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _6; else goto _5;
    _11:
        sa(sr());
        sa(sp()+(x2));
        {long v0=x1;sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _7; else goto _12;
    _12:
        x2=td(x2,2);
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        if(sp()!=0)goto _11; else goto _9;
}}