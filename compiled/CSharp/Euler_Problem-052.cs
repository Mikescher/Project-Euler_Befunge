/* compiled with BefunCompile v1.0.3 (c) 2015 */
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
        long x0=88;
        long x1=88;
        long x2=88;
        long x3=88;
        long x4=88;
        goto _5;
    _0:
        if(sp()!=0)goto _17; else goto _6;
    _1:
        if(sp()!=0)goto _10; else goto _9;
    _2:
        if(sp()!=0)goto _16; else goto _15;
    _3:
        if(sp()!=0)goto _13; else goto _12;
    _4:
        if(((x4)-(x1))!=0)goto _14;else goto _11;
    _5:
        x0=10;
        x3=1;
        x1=1;
        sa(10);
        sa(1);
        sa(1);
        sa(1);
        sa(1);
        goto _0;
    _6:
        x2=2;
        sp();
        sa(sr());
        sa(x2);
        goto _7;
    _7:
        x4=1;
        sa(sp()*sp());
        sa(10);
        sa(sp()*sp());
        goto _8;
    _8:
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _1;
    _9:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(2);
        sa(sp()+sp());
        sa(x4);
        sa(sp()*sp());
        x4=sp();
        goto _8;
    _10:
        sp();
        goto _4;
    _11:
        sa((x2)+(1));
        x2=(x2)+(1);
        sa(7);
        {long v0=sp();sa(sp()-v0);}
        goto _3;
    _12:
        System.Console.Out.Write((long)(sp()));
        sp();
        sp();
        return;
    _13:
        sa(sr());
        sa(x2);
        goto _7;
    _14:
        sp();
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(x3);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        goto _2;
    _15:
        x1=1;
        sa(sr());
        sa(sr());
        sa(10);
        sa(sp()*sp());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _16:
        sp();
        sa(10);
        sa(sp()*sp());
        sa(sr());
        x0=sp();
        sa(sr());
        sa(6);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        x3=sp();
        x1=1;
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(sr());
        sa(10);
        sa(sp()*sp());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _17:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(2);
        sa(sp()+sp());
        sa(x1);
        sa(sp()*sp());
        x1=sp();
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
}}