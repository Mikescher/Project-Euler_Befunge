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
        long x1=32;
        long x2=32;
        goto _6;
    _0:
        if(sp()!=0)goto _17; else goto _8;
    _1:
        if(sp()!=0)goto _9; else goto _11;
    _2:
        if(sp()!=0)goto _16; else goto _10;
    _3:
        if(sp()!=0)goto _9; else goto _11;
    _4:
        if(sp()!=0)goto _13; else goto _12;
    _5:
        if(sp()!=0)goto _15; else goto _14;
    _6:
        x0=1152921504606846976;
        x2=0;
        x1=991873;
        sa(144);
        sa(991873);
        goto _7;
    _7:
        sa(x0);
        sa((x0)>(x1)?1:0);
        goto _0;
    _8:
        sa(sr());
        goto _1;
    _9:
        sa(sr());
        sa(x2);
        sa(sp()+sp());
        sa(x1);
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        goto _2;
    _10:
        x2=td(x2,2);
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _3;
    _11:
        sp();
        sa((x2)*(x2));
        {long v0=sp();sa(sp()-v0);}
        sa((((tm(x2,6))-(5))!=0)?0:1);
        goto _4;
    _12:
        x2=0;
        sp();
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(sr());
        sa(2);
        sa(sp()*sp());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sp()*sp());
        sa(24);
        sa(sp()*sp());
        sa(1);
        sa(sp()+sp());
        sa(sr());
        x1=sp();
        goto _7;
    _13:
        sa((sp()!=0)?0:1);
        goto _5;
    _14:
        x2=0;
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(sr());
        sa(2);
        sa(sp()*sp());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sp()*sp());
        sa(24);
        sa(sp()*sp());
        sa(1);
        sa(sp()+sp());
        sa(sr());
        x1=sp();
        goto _7;
    _15:
        sa(sr());
        sa(2);
        sa(sp()*sp());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sp()*sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _16:
        sa(sr());
        sa(x2);
        sa(sp()+sp());
        sa(x1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x1=sp();
        sa(sr());
        sa(2);
        sa(sp()*sp());
        sa(x2);
        sa(sp()+sp());
        x2=sp();
        x2=td(x2,2);
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        goto _8;
    _17:
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(x1);
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _0;
}}