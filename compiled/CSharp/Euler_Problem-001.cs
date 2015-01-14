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
        goto _4;
    _0:
        if(sp()!=0)goto _12; else goto _5;
    _1:
        if(sp()!=0)goto _8; else goto _7;
    _2:
        if(sp()!=0)goto _11; else goto _10;
    _3:
        if(sp()!=0)goto _12; else goto _6;
    _4:
        sa(1);
        sa(2);
        sa(2);
        sa(0);
        goto _0;
    _5:
        sa(sr());
        sa(sr());
        sa(5);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(5);
        sa(sp()*sp());
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _3;
    _6:
        sa(sr());
        sa(1000);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _1;
    _7:
        sp();
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(sr());
        sa(sr());
        sa(3);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()*sp());
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _0;
    _8:
        sp();
        sp();
        sp();
        goto _9;
    _9:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _2;
    _10:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _9;
    _11:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _12:
        sa(sr());
        goto _6;
}}