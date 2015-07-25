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
        long x0=10;
        long x1=1;
        long x2=88;
        long x3=1;
        long x4=88;
        sa(10);
        sa(1);
        sa(1);
        sa(1);
    _1:
        t0=((tm(sr(),10))+2)*x1;
        x1=t0;
        sa(td(sp(),10));
        sa(sr());
    _2:
        if(sp()!=0)goto _1;else goto _3;
    _3:
        x2=2;
        sp();
        sa(sr());
        sa(x2);
    _4:
        x4=1;
        sa(sp()*sp());
        sa(sp()*10L);
    _5:
        sa(td(sp(),10));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _6;else goto _13;
    _6:
        sp();
        if(x4!=x1)goto _10;else goto _7;
    _7:
        t0=x2+1;
        x2=x2+1;
        t0=t0-7;
        if((t0)!=0)goto _8;else goto _9;
    _8:
        sa(sr());
        sa(x2);
        goto _4;
    _9:
        System.Console.Out.Write((long)(sp()));
        sp();
        sp();
        return;
    _10:
        sp();
        sa(sp()+1L);
        if(sr()>=x3)goto _11;else goto _12;
    _11:
        sp();
        sa(sp()*10L);
        x0=sr();
        t0=td(sr(),6);
        x3=t0;
        x1=1;
        sa(td(sr(),10));
        sa(sr());
        sa(td(sr()*10,10));
        sa(sr());
        goto _2;
    _12:
        x1=1;
        sa(sr());
        sa(td(sr()*10,10));
        sa(sr());
        goto _2;
    _13:
        t0=((tm(sr(),10))+2)*x4;
        x4=t0;
        goto _5;
}}