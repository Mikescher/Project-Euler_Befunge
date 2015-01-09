/* compiled with BefunCompile v1.0.1 (c) 2015 */
public static class Program 
{
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long x0=32;
        goto _9;
    _0:
        if(sp()!=0)goto _32; else goto _10;
    _1:
        if(sp()!=0)goto _12; else goto _13;
    _2:
        if(sp()!=0)goto _14; else goto _31;
    _3:
        if(sp()!=0)goto _30; else goto _16;
    _4:
        if(sp()!=0)goto _29; else goto _17;
    _5:
        if(sp()!=0)goto _19; else goto _20;
    _6:
        if(sp()!=0)goto _21; else goto _28;
    _7:
        if(sp()!=0)goto _23; else goto _24;
    _8:
        if(sp()!=0)goto _26; else goto _27;
    _9:
        x0=9990;
        sa(0);
        sa(0);
        sa(999);
        sa((9)+(x0));
        sa(99);
        sa(99);
        goto _0;
    _10:
        x0=0;
        sp();
        sa(sr());
        sa(sr());
        goto _11;
    _11:
        sa(sr());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(x0);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _1;
    _12:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        sa(sp()*sp());
        x0=sp();
        goto _11;
    _13:
        sp();
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _2;
    _14:
        sa(sr());
        System.Console.Out.WriteLine((long)(sp()));
        System.Console.Out.WriteLine((char)(10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _15;
    _15:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _3;
    _16:
        x0=990;
        sa(999);
        sa((9)+(x0));
        sa(99);
        sa(99);
        goto _4;
    _17:
        x0=0;
        sp();
        sa(sr());
        sa(sr());
        goto _18;
    _18:
        sa(sr());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(x0);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _5;
    _19:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        sa(sp()*sp());
        x0=sp();
        goto _18;
    _20:
        sp();
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _6;
    _21:
        sa(sr());
        System.Console.Out.WriteLine((long)(sp()));
        System.Console.Out.WriteLine((char)(10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _22;
    _22:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _7;
    _23:
        sa(sr());
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(10);
        sa(sp()*sp());
        x0=sp();
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(x0);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _4;
    _24:
        sa(61);
        System.Console.Out.WriteLine((char)(32));
        System.Console.Out.WriteLine((char)(sp()));
        goto _25;
    _25:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _8;
    _26:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _25;
    _27:
        sa(sp()+sp());
        System.Console.Out.WriteLine((long)(sp()));
        return;
    _28:
        sp();
        goto _22;
    _29:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        sa(sp()*sp());
        x0=sp();
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(x0);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _4;
    _30:
        sa(sr());
        sa(sr());
        sa(10);
        sa(sp()*sp());
        x0=sp();
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(x0);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _31:
        sp();
        goto _15;
    _32:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        sa(sp()*sp());
        x0=sp();
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(x0);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
}}