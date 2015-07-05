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
        long x0=1152921504606846976;
        long x1=991873;
        long x2=0;
        sa(144L);
        sa(991873L);
    _1:
        sa(x0);
        sa(x0>x1?1:0);
    _2:
        if(sp()!=0)goto _12;else goto _3;
    _3:
        sa(sr());
        if(sp()!=0)goto _9;else goto _4;
    _4:
        sp();
        sa(sp()-(x2*x2));
        if((tm(x2,6L))-5L==0)goto _5;else goto _8;
    _5:
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _7;else goto _6;
    _6:
        x2=0L;
        sa(sp()+1L);
        sa(sr());
        sa((sr()*2L)-1L);
        sa(sp()*sp());
        sa(sp()*24L);
        sa(sp()+1L);
        x1=sr();
        goto _1;
    _7:
        sa((sr()*2L)-1L);
        sa(sp()*sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _8:
        x2=0L;
        sp();
        sa(sp()+1L);
        sa(sr());
        sa((sr()*2L)-1L);
        sa(sp()*sp());
        sa(sp()*24L);
        sa(sp()+1L);
        x1=sr();
        goto _1;
    _9:
        if((sr()+x2)<=x1)goto _11;else goto _10;
    _10:
        x2=td(x2,2L);
        sa(td(sp(),4L));
        sa(sr());
        if(sp()!=0)goto _9;else goto _4;
    _11:
        sa(sr()+x2);
        sa(x1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x1=sp();
        sa((sr()*2L)+x2);
        x2=sp();
        x2=td(x2,2L);
        sa(td(sp(),4L));
        goto _3;
    _12:
        sa(td(sp(),4L));
        sa(sr()>x1?1:0);
        goto _2;
}}