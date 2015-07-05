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
        sa(0L);
        sa(1L);
        sa(1L);
        sa(0L);
        sa(5904L);
    _1:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _2:
        if(sp()!=0)goto _13;else goto _3;
    _3:
        sp();
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _12;else goto _4;
    _4:
        sa(sp()*59049L);
    _5:
        sa(sr());
        sa(sr());
        sa(tm(sr(),10L));
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(tm(sr(),10L));
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(tm(sr(),10L));
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(tm(sr(),10L));
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(tm(sr(),10L));
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(tm(sr(),10L));
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(tm(sp(),10L));
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(sr());
        sa(sp()*sp());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()+sp());
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _6;else goto _11;
    _6:
        sa(sp()-1L);
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _7;else goto _5;
    _7:
        sp();
        sp();
    _8:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _9;else goto _10;
    _9:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _8;
    _10:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _11:
        sa(sr());
        goto _6;
    _12:
        sa(sp()+1L);
        sa(sr());
        sa(sr()*59049L);
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _2;
    _13:
        sa(td(sp(),10L));
        goto _1;
}}