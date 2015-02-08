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
        goto _2;
    _0:
        if(sp()!=0)goto _18; else goto _3;
    _1:
        if(sp()!=0)goto _15; else goto _7;
    _2:
        x0=9990;
        sa(0);
        sa(0);
        sa(999);
        sa((9)+(x0));
        sa(99);
        sa(99);
        goto _0;
    _3:
        x0=0;
        sp();
        sa(sr());
        sa(sr());
        goto _19;
    _4:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*(2));
        x0=sp();
        goto _19;
    _5:
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((char)(10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _21;
    _6:
        x0=990;
        sa(999);
        sa((9)+(x0));
        sa(99);
        sa(99);
        goto _1;
    _7:
        x0=0;
        sp();
        sa(sr());
        sa(sr());
        goto _22;
    _8:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*(2));
        x0=sp();
        goto _22;
    _9:
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write((char)(10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _24;
    _10:
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
        goto _1;
    _11:
        sa(61);
        System.Console.Out.Write((char)(32));
        System.Console.Out.Write((char)(sp()));
        goto _25;
    _12:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _25;
    _13:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _14:
        sp();
        goto _24;
    _15:
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
    _16:
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
        goto _0;
    _17:
        sp();
        goto _21;
    _18:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*(10));
        x0=sp();
        sa(sr());
        {long v0=10;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=10;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _19:
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        if(sp()!=0)goto _4; else goto _20;
    _20:
        sp();
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _5; else goto _17;
    _21:
        sa(sp()-(1));
        sa(sr());
        if(sp()!=0)goto _16; else goto _6;
    _22:
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        sa(sp()+(x0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        if(sp()!=0)goto _8; else goto _23;
    _23:
        sp();
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _9; else goto _14;
    _24:
        sa(sp()-(1));
        sa(sr());
        if(sp()!=0)goto _10; else goto _11;
    _25:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _12; else goto _13;
}}