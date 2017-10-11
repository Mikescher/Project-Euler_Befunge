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
        long t0,t1,t2,t3,t4,t5,t6,t7;
        sa(0);
        sa(1);
        sa(1);
        sa(0);
        sa(5904);
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

        t0=sp();

        if((t0)!=0)goto _12;else goto _4;
    _4:
        sa(sp()*59049L);
    _5:
        sa(sr());
        sa(sr());
        sa(tm(sr(),10));
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t1=sp();
        sa(td(sp(),10));

        sa(tm(sr(),10));
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t2=sp();
        sa(td(sp(),10));

        sa(tm(sr(),10));
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t3=sp();
        sa(td(sp(),10));

        sa(tm(sr(),10));
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t4=sp();
        sa(td(sp(),10));

        sa(tm(sr(),10));
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t5=sp();
        sa(td(sp(),10));

        sa(tm(sr(),10));
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t6=sp();
        sa(td(sp(),10));

        sa(tm(sp(),10));

        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t7=sp();
        t0=t7+t6;
        t6=t5+t0;
        t0=t4+t6;
        t4=t3+t0;
        t0=t2+t4;
        t2=t1+t0;
        sa(sp()-t2);

        t0=sp();

        if((t0)!=0)goto _6;else goto _11;
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
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _11:
        sa(sr());
        goto _6;
    _12:
        sa(sp()+1L);

        sa(sr());
        sa(sr()*59049);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _2;
    _13:
        sa(td(sp(),10));
        goto _1;
}
}
