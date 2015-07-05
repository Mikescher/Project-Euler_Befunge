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
        long x0=9990;
        sa(0L);
        sa(0L);
        sa(999L);
        sa(9L+x0);
        sa(99L);
    _1:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*10L);
        x0=sp();
        sa((tm(sr(),10L))+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(sr());
    _2:
        if(sp()!=0)goto _1;else goto _3;
    _3:
        x0=0L;
        sp();
        sa(sr());
        sa(sr());
    _4:
        sa((tm(sr(),2L))+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),2L));
        sa(sr());
        if(sp()!=0)goto _25;else goto _5;
    _5:
        sp();
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _24;else goto _6;
    _6:
        sp();
    _7:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _8;else goto _9;
    _8:
        sa(sr());
        sa(sr()*10L);
        x0=sp();
        sa((tm(sr(),10L))+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(sr());
        goto _2;
    _9:
        x0=990L;
        sa(999L);
        sa(9L+x0);
        sa(99L);
    _10:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*10L);
        x0=sp();
        sa((tm(sr(),10L))+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(sr());
    _11:
        if(sp()!=0)goto _10;else goto _12;
    _12:
        x0=0L;
        sp();
        sa(sr());
        sa(sr());
    _13:
        sa((tm(sr(),2L))+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),2L));
        sa(sr());
        if(sp()!=0)goto _23;else goto _14;
    _14:
        sp();
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _22;else goto _15;
    _15:
        sp();
    _16:
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _21;else goto _17;
    _17:
        sa(61L);
        System.Console.Out.Write(' ');
        System.Console.Out.Write((char)(sp()));
    _18:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _20;else goto _19;
    _19:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _20:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _18;
    _21:
        sa(sr());
        sa((td(sr(),10L))*10L);
        x0=sp();
        sa((tm(sr(),10L))+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10L));
        sa(sr());
        goto _11;
    _22:
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write('\n');
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _16;
    _23:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*2L);
        x0=sp();
        goto _13;
    _24:
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write('\n');
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _7;
    _25:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*2L);
        x0=sp();
        goto _4;
}}