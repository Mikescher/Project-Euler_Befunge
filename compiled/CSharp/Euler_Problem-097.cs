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
        sa(56866);
        sa(7830456);
        sa(7830456);
    _1:
        if(sp()!=0)goto _3;else goto _2;
    _2:
        sp();
        sa(sp()+1L);

        sa(sp()%10000000000L);

        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _3:
        sa(sp()-1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*2L);

        sa(sp()%10000000000L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _1;
}
}
