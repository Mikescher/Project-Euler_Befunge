/* compiled with BefunCompile v1.0.2 (c) 2015 */
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
        long x0=118;
        long x1=32;
        goto _4;
    _0:
        if(sp()!=0)goto _14; else goto _5;
    _1:
        if(sp()!=0)goto _7; else goto _8;
    _2:
        if(sp()!=0)goto _13; else goto _9;
    _3:
        if(sp()!=0)goto _12; else goto _11;
    _4:
        x0=0;
        sa(4);
        sa(1);
        sa(4);
        sa(0);
        goto _0;
    _5:
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        goto _6;
    _6:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        goto _1;
    _7:
        sa(1);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _0;
    _8:
        sp();
        sa(sr());
        sa(x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _2;
    _9:
        x0=sp();
        sa(sr());
        x1=sp();
        goto _10;
    _10:
        sa(sr());
        sa(1000000);
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        goto _3;
    _11:
        System.Console.Out.Write((long)(x1));
        sa(x0);
        sa(58);
        System.Console.Out.Write((char)(32));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((long)(sp()));
        return;
    _12:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _0;
    _13:
        sp();
        goto _10;
    _14:
        sa(3);
        sa(sp()*sp());
        sa(1);
        sa(sp()+sp());
        goto _6;
}}