/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0,t1;
        sa(1);
        sa(1);
        sa(1);
    _1:
        sp();
        sa(sp()+1L);

        sa(sr());
        sa(sr());
        t0=(sr()/3)*3;
        sa(sp()-t0);

        t1=sp();

        if((t1)!=0)goto _2;else goto _3;
    _2:
        sa(sr());
        t0=(sr()/5)*5;
        sa(sp()-t0);

        t1=sp();

        if((t1)!=0)goto _4;else goto _3;
    _3:
        sa(sr());
    _4:
        if(sr()!=1000)goto _1;else goto _5;
    _5:
        sp();
        sp();
        sp();
    _6:
        sa(sp()+sp());

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sr()!=1)goto _8;else goto _7;
    _7:
        sp();
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _8:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _6;
}
}
