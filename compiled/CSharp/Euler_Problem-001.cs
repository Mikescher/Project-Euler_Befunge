/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
        sa(1L);
        sa(2L);
        sa(2L);
    _1:
        sa(sr());
        sa((td(sr(),5L))*5L);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _2;else goto _3;
    _2:
        sa(sr());
    _3:
        if(sr()-1000L==0)goto _5;else goto _4;
    _4:
        sp();
        sa(sp()+1L);
        sa(sr());
        sa(sr());
        sa((td(sr(),3L))*3L);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _2;else goto _1;
    _5:
        sp();
        sp();
        sp();
    _6:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sr()-1L==0)goto _7;else goto _8;
    _7:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _8:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _6;
}}