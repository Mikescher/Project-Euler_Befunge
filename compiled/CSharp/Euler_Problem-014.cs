/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
        long t0;
        long x0=0;
        long x1=32;
        sa(4);
        sa(1);
        sa(2);
    _1:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sr()!=1)goto _11;else goto _2;
    _2:
        sp();
        if(sr()<x0)goto _3;else goto _10;
    _3:
        sp();
    _4:
        if(sr()<=1000000)goto _6;else goto _5;
    _5:
        System.Console.Out.Write(x1);
        t0=x0;
        System.Console.Out.Write(" :");
        System.Console.Out.Write(t0);
        return;
    _6:
        sa(sp()+1L);
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),2));
    _7:
        if(sp()!=0)goto _9;else goto _8;
    _8:
        sa(td(sp(),2));
        goto _1;
    _9:
        sa(sp()*3L);
        sa(sp()+1L);
        goto _1;
    _10:
        x0=sp();
        x1=sr();
        goto _4;
    _11:
        sa(td(sp(),1));
        sa(tm(sr(),2));
        goto _7;
}}