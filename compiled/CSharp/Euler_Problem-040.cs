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
        long x0=32;
        long x1=32;
        long x2=32;
        goto _5;
    _0:
        if(sp()!=0)goto _6; else goto _13;
    _1:
        if(sp()!=0)goto _9; else goto _8;
    _2:
        if(sp()!=0)goto _12; else goto _10;
    _3:
        if(sp()!=0)goto _12; else goto _11;
    _4:
        if(sp()!=0)goto _12; else goto _11;
    _5:
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
    _6:
        x1=1;
        x2=1;
        goto _7;
    _7:
        sa(sr());
        sa((x1)*((9)*(x2)));
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        goto _1;
    _8:
        sa((x1)*((9)*(x2)));
        x1=(x1)+(1);
        x2=(x2)*(10);
        {long v0=sp();sa(sp()-v0);}
        goto _7;
    _9:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(x1);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(x2);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(x1);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(x1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _2;
    _10:
        sa(sr());
        goto _4;
    _11:
        sp();
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(x0);
        sa(sp()*sp());
        x0=sp();
        sa(sr());
        goto _0;
    _12:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _3;
    _13:
        sp();
        System.Console.Out.Write((long)(x0));
        return;
}}