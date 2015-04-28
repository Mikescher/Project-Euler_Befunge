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
        goto _0;
    _0:
        x0=9990;
        sa(0);
        sa(0);
        sa(999);
        sa((9)+(x0));
        sa(99);
        sa(99);
    _1:
        if(sp()!=0)goto _2; else goto _3;
    _2:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*(10));
        x0=sp();
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _1;
    _3:
        x0=0;
        sp();
        sa(sr());
        sa(sr());
    _4:
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        if(sp()!=0)goto _25; else goto _5;
    _5:
        sp();
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _24; else goto _6;
    _6:
        sp();
    _7:
        sa(sp()-(1));
        sa(sr());
        if(sp()!=0)goto _8; else goto _9;
    _8:
        sa(sr());
        sa(sr());
        sa(sp()*(10));
        x0=sp();
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _1;
    _9:
        x0=990;
        sa(999);
        sa((9)+(x0));
        sa(99);
        sa(99);
    _10:
        if(sp()!=0)goto _11; else goto _12;
    _11:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*(10));
        x0=sp();
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _10;
    _12:
        x0=0;
        sp();
        sa(sr());
        sa(sr());
    _13:
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        if(sp()!=0)goto _23; else goto _14;
    _14:
        sp();
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _22; else goto _15;
    _15:
        sp();
    _16:
        sa(sp()-(1));
        sa(sr());
        if(sp()!=0)goto _21; else goto _17;
    _17:
        sa(61);
        System.Console.Out.Write((char)(32));
        System.Console.Out.Write((char)(sp()));
    _18:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _20; else goto _19;
    _19:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _20:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _18;
    _21:
        sa(sr());
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sp()*(10));
        x0=sp();
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _10;
    _22:
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((char)(10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _16;
    _23:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*(2));
        x0=sp();
        goto _13;
    _24:
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((char)(10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _7;
    _25:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*(2));
        x0=sp();
        goto _4;
}}