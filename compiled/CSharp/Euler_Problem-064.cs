/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1;
        long x0=10000;
        long x1=35;
        long x2=35;
        long x3=9;
        long x4=35;
        long x5=35;
        long x6=0;
        long x7=1;
        sa(0);
        sa(10000);
        sa(0);
    _1:
        sa(x0);
        x4=0;
        x1=sr();
    _2:
        x2=sr();
        sa(sr());
        t0=x1;
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}

        t1=sp();
        sa(sp()+t1);

        sa(td(sp(),2));


        if(sr()!=x2)goto _15;else goto _3;
    _3:
        sp();
        sa(x2);

        if((x2*x2)!=x0)goto _12;else goto _4;
    _4:
        sa(0);
    _5:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _11;else goto _6;
    _6:
        sp();
        sa(tm(sp(),2));


        if(sp()!=0)goto _8;else goto _7;
    _7:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _8:
        if(sr()!=2)goto _10;else goto _9;
    _9:
        sp();
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _10:
        x3=9;
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        x0=sp();
        x6=0;
        x7=1;
        goto _1;
    _11:
        sp();
        sa(sp()+1L);
        goto _5;
    _12:
        x5=sr();
        sa(sp()+x6);

        sa(td(sp(),x7));

        t0=(sr()*x7)-x6;
        x6=t0;
    _13:
        if(((x7-1)+x3)!=0)goto _14;else goto _4;
    _14:
        x7=td(x0-(x6*x6),x7);
        x3=0;
        sa(td(x5+x6,x7));
        x6=((td(x5+x6,x7))*x7)-x6;
        goto _13;
    _15:
        if(sr()!=x4)goto _16;else goto _3;
    _16:
        x4=x2;
        goto _2;
}
}
