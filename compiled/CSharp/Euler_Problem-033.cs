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
        long t0;
        long x0=1;
        long x1=1;
        long x2=99;
        long x3=99;
        long x4=32;
    _1:
        if(x3>x2)goto _8;else goto _2;
    _2:
        t0=x2-10;
        x2--;

        if((t0)!=0)goto _7;else goto _3;
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

        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _5:
        x4=sr();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),x4));

        sa(sr());
        if(sp()!=0)goto _5;else goto _4;
    _7:
        x3=99;
        goto _1;
    _8:
        if((x2/10)!=0)goto _20;else goto _9;
    _9:
        if((x2/10)!=0)goto _18;else goto _10;
    _10:
        if((x2%10)!=0)goto _16;else goto _11;
    _11:
        if((x2%10)!=0)goto _13;else goto _12;
    _12:
        t0=x3-10;
        x3--;

        if((t0)!=0)goto _1;else goto _2;
    _13:
        if(((x2%10)-(x3%10))!=0)goto _12;else goto _14;
    _14:
        if(((x2*(x3%10))-(x3*(x2%10)))!=0)goto _12;else goto _15;
    _15:
        x0*=x2;
        x1*=x3;
        goto _12;
    _16:
        if(((x2%10)-(x3/10))!=0)goto _11;else goto _17;
    _17:
        if(((x2*(x3%10))-(x3*(x2/10)))!=0)goto _11;else goto _15;
    _18:
        if(((x2/10)-(x3%10))!=0)goto _10;else goto _19;
    _19:
        if(((x2*(x3/10))-(x3*(x2%10)))!=0)goto _10;else goto _15;
    _20:
        if(((x2/10)-(x3/10))!=0)goto _9;else goto _21;
    _21:
        if(((x2*(x3/10))-(x3*(x2/10)))!=0)goto _9;else goto _15;
}
}
