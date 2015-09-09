/* compiled with BefunCompile v1.0.8 (c) 2015 */
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
        long t0,t1;
        sa(1);
        sa(2);
        sa(2);
    _1:
        sa(sr());
        t0=(td(sr(),5))*5;
        sa(sp()-t0);
        t1=sp();
        t1=(t1!=0)?0:1;
        if((t1)!=0)goto _2;else goto _3;
    _2:
        sa(sr());
    _3:
        if(sr()-1000==0)goto _5;else goto _4;
    _4:
        sp();
        sa(sp()+1L);
        sa(sr());
        sa(sr());
        t0=(td(sr(),3))*3;
        sa(sp()-t0);
        t1=sp();
        t1=(t1!=0)?0:1;
        if((t1)!=0)goto _2;else goto _1;
    _5:
        sp();
        sp();
        sp();
    _6:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sr()-1==0)goto _7;else goto _8;
    _7:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _8:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _6;
}}