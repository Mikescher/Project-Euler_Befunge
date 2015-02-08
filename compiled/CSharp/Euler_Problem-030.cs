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
        if(sp()!=0)goto _2; else goto _9;
    _1:
        sa(0);
        sa(1);
        sa(1);
        sa(0);
        sa(59049);
        sa(59049);
        goto _0;
    _2:
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+(1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _0;
    _3:
        sa(sp()+(1));
        sa(sr());
        sa(sr());
        sa(sp()*(59049));
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _0;
    _4:
        sa(sp()*(59049));
        goto _10;
    _5:
        sp();
        sp();
        goto _12;
    _6:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _7:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _12;
    _8:
        sa(sr());
        goto _11;
    _9:
        sp();
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _3; else goto _4;
    _10:
        sa(sr());
        sa(sr());
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _11; else goto _8;
    _11:
        sa(sp()-(1));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _5; else goto _10;
    _12:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _7; else goto _6;
}}