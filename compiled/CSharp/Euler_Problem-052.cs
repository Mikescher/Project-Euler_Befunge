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
        long x0=10;
        long x1=1;
        long x2=88;
        long x3=1;
        long x4=88;
        sa(10L);
        sa(1L);
        sa(1L);
        sa(1L);
    _1:
        sa(((tm(sr(),10L))+2L)*x1);
        x1=sp();
        sa(td(sp(),10L));
        sa(sr());
    _2:
        if(sp()!=0)goto _1;else goto _3;
    _3:
        x2=2L;
        sp();
        sa(sr());
        sa(x2);
    _4:
        x4=1L;
        sa(sp()*sp());
        sa(sp()*10L);
    _5:
        sa(td(sp(),10L));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _6;else goto _13;
    _6:
        sp();
        if(x4!=x1)goto _7;else goto _10;
    _7:
        sp();
        sa(sp()+1L);
        if(sr()>=x3)goto _8;else goto _9;
    _8:
        sp();
        sa(sp()*10L);
        x0=sr();
        sa(td(sr(),6L));
        x3=sp();
        x1=1L;
        sa(td(sr(),10L));
        sa(sr());
        sa(td(sr()*10L,10L));
        sa(sr());
        goto _2;
    _9:
        x1=1L;
        sa(sr());
        sa(td(sr()*10L,10L));
        sa(sr());
        goto _2;
    _10:
        sa(x2+1L);
        x2=x2+1L;
        sa(sp()-7L);
        if(sp()!=0)goto _11;else goto _12;
    _11:
        sa(sr());
        sa(x2);
        goto _4;
    _12:
        System.Console.Out.Write((long)(sp()));
        sp();
        sp();
        return;
    _13:
        sa(((tm(sr(),10L))+2L)*x4);
        x4=sp();
        goto _5;
}}