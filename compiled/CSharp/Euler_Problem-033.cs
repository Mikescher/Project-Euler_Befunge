/* compiled with BefunCompile v1.0.5 (c) 2015 */
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
        if(((((x3)>(x2)?1:0)!=0)?0:1)!=0)goto _2;else goto _8;
    _2:
        sa(x2-1);
        x2=x2-1;
        sa(sp()-9);
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
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        System.Console.Out.Write((long)(sp()));
        return;
    _5:
        sa(sr());
        x4=sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=x4;sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        if(sp()!=0)goto _5;else goto _4;
    _7:
        x3=99;
        goto _1;
    _8:
        sa(td(x2,10));
        if(sp()!=0)goto _9;else goto _11;
    _9:
        sa((td(x2,10))-(td(x3,10)));
        if(sp()!=0)goto _11;else goto _10;
    _10:
        sa((x2*(td(x3,10)))-(x3*(td(x2,10))));
        if(sp()!=0)goto _11;else goto _21;
    _11:
        sa(td(x2,10));
        if(sp()!=0)goto _12;else goto _14;
    _12:
        sa((td(x2,10))-(tm(x3,10)));
        if(sp()!=0)goto _14;else goto _13;
    _13:
        sa((x2*(td(x3,10)))-(x3*(tm(x2,10))));
        if(sp()!=0)goto _14;else goto _21;
    _14:
        sa(tm(x2,10));
        if(sp()!=0)goto _15;else goto _17;
    _15:
        sa((tm(x2,10))-(td(x3,10)));
        if(sp()!=0)goto _17;else goto _16;
    _16:
        sa((x2*(tm(x3,10)))-(x3*(td(x2,10))));
        if(sp()!=0)goto _17;else goto _21;
    _17:
        sa(tm(x2,10));
        if(sp()!=0)goto _19;else goto _18;
    _18:
        sa(x3-1);
        x3=x3-1;
        sa(sp()-9);
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _2;else goto _1;
    _19:
        sa((tm(x2,10))-(tm(x3,10)));
        if(sp()!=0)goto _18;else goto _20;
    _20:
        sa((x2*(tm(x3,10)))-(x3*(tm(x2,10))));
        if(sp()!=0)goto _18;else goto _21;
    _21:
        x0=x0*x2;
        x1=x1*x3;
        goto _18;
}}