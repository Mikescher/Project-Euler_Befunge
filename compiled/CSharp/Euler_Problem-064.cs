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
        long t0,t1,t2;
        long x0=10000;
        long x1=35;
        long x2=35;
        long x3=9;
        long x4=35;
        long x5=35;
        long x6=35;
        long x7=35;
        sa(0);
        sa(10000);
        sa(0);
    _1:
        x1=0;
        t0=1;
        x6=1;
        sa(x0);
        sa(x0);
        t0=x0;
        t2=x0;
        x2=0;
        x7=t0;
        x4=t2;
    _2:
        t0=x7;
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}

        t1=sp();
        sa(sp()+t1);

        sa(sp()/2L);


        if((sr()-x4)!=0)goto _15;else goto _3;
    _3:
        sp();
        sa(x4);

        if(((x4*x4)-x0)!=0)goto _12;else goto _4;
    _4:
        sa(0);
    _5:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _11;else goto _6;
    _6:
        sp();
        sa(sp()%2L);


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
        goto _1;
    _11:
        sp();
        sa(sp()+1L);
        goto _5;
    _12:
        x5=sr();
        sa(sp()+x1);

        sa(td(sp(),x6));

        x1=(sr()*x6)-x1;
    _13:
        if(((x6-1)+x3)!=0)goto _14;else goto _4;
    _14:
        x6=td(x0-(x1*x1),x6);
        x3=0;
        sa(td(x5+x1,x6));
        x1=((td(x5+x1,x6))*x6)-x1;
        goto _13;
    _15:
        if((sr()-x2)!=0)goto _16;else goto _3;
    _16:
        x2=x4;
        x4=sr();
        sa(sr());
        goto _2;
}
}
