/* compiled with BefunCompile v1.0 (c) 2015 */
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
        goto _5;
    _0:
        if(sp()!=0)goto _6; else goto _7;
    _1:
        if(sp()!=0)goto _16; else goto _8;
    _2:
        if(sp()!=0)goto _11; else goto _10;
    _3:
        if(sp()!=0)goto _12; else goto _9;
    _4:
        if(sp()!=0)goto _15; else goto _14;
    _5:
        sa(0);
        sa(1);
        sa(1);
        sa(0);
        sa(59049);
        sa(59049);
        goto _0;
    _6:
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _0;
    _7:
        sp();
        {long v0=sp();sa(sp()-v0);}
        goto _1;
    _8:
        sa(59049);
        sa(sp()*sp());
        goto _9;
    _9:
        sa(sr());
        sa(sr());
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
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
        goto _2;
    _10:
        sa(sr());
        goto _11;
    _11:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _3;
    _12:
        sp();
        sp();
        goto _13;
    _13:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _4;
    _14:
        sp();
        System.Console.Out.WriteLine((long)(sp()));
        return;
    _15:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _13;
    _16:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(sr());
        sa(59049);
        sa(sp()*sp());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _0;
}}