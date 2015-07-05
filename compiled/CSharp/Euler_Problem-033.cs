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
        long x0=1;
        long x1=1;
        long x2=99;
        long x3=99;
        long x4=32;
    _1:
        if(x3<=x2)goto _2;else goto _8;
    _2:
        sa(x2-1L);
        x2=x2-1L;
        sa(sp()-9L);
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _3;else goto _7;
    _3:
        sp();
        sa(x0);
        sa(x1);
        if((x1)!=0)goto _5;else goto _4;
    _4:
        sp();
        sa(x1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}
        System.Console.Out.Write((long)(sp()));
        return;
    _5:
        x4=sr();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),x4));
        sa(sr());
        if(sp()!=0)goto _5;else goto _4;
    _7:
        x3=99L;
        goto _1;
    _8:
        if(td(x2,10L)!=0)goto _20;else goto _9;
    _9:
        if(td(x2,10L)!=0)goto _18;else goto _10;
    _10:
        if(tm(x2,10L)!=0)goto _16;else goto _11;
    _11:
        if(tm(x2,10L)!=0)goto _13;else goto _12;
    _12:
        sa(x3-1L);
        x3=x3-1L;
        sa(sp()-9L);
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _2;else goto _1;
    _13:
        if((tm(x2,10L))!=(tm(x3,10L)))goto _12;else goto _14;
    _14:
        if((x2*(tm(x3,10L)))!=(x3*(tm(x2,10L))))goto _12;else goto _15;
    _15:
        x0=x0*x2;
        x1=x1*x3;
        goto _12;
    _16:
        if((tm(x2,10L))!=(td(x3,10L)))goto _11;else goto _17;
    _17:
        if((x2*(tm(x3,10L)))!=(x3*(td(x2,10L))))goto _11;else goto _15;
    _18:
        if((td(x2,10L))!=(tm(x3,10L)))goto _10;else goto _19;
    _19:
        if((x2*(td(x3,10L)))!=(x3*(tm(x2,10L))))goto _10;else goto _15;
    _20:
        if((td(x2,10L))!=(td(x3,10L)))goto _9;else goto _21;
    _21:
        if((x2*(td(x3,10L)))!=(x3*(td(x2,10L))))goto _9;else goto _15;
}}