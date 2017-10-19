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
        long t0,t1,t2,t3,t4,t5,t6,t7;
        sa(0);
        sa(1);
        sa(1);
        sa(0);
        sa(59049);
        sa(59049);
    _1:
        if(sp()!=0)goto _12;else goto _2;
    _2:
        sp();
        {long v0=sp();sa(sp()-v0);}

        t0=sp();

        if((t0)!=0)goto _11;else goto _3;
    _3:
        sa(sp()*59049L);
    _4:
        sa(sr());
        sa(sr());
        sa(sr()%10);
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t1=sp();
        sa(sp()/10L);

        sa(sr()%10);
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t2=sp();
        sa(sp()/10L);

        sa(sr()%10);
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t3=sp();
        sa(sp()/10L);

        sa(sr()%10);
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t4=sp();
        sa(sp()/10L);

        sa(sr()%10);
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t5=sp();
        sa(sp()/10L);

        sa(sr()%10);
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t6=sp();
        sa(sp()/10L);

        sa(sp()%10L);

        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sr());
        sa(sp()*sp());

        t0=sp();
        sa(sp()*t0);

        t7=sp();
        t0=10;
        t0=t7+t6;
        t6=t5+t0;
        t0=t4+t6;
        t4=t3+t0;
        t0=t2+t4;
        t2=t1+t0;
        sa(sp()-t2);

        t0=sp();

        if((t0)!=0)goto _5;else goto _10;
    _5:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _4;else goto _6;
    _6:
        t0=9;
        sp();
        sp();
    _7:
        sa(sp()+sp());

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _8;else goto _9;
    _8:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _7;
    _9:
        sp();
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _10:
        sa(sr());
        goto _5;
    _11:
        sa(sp()+1L);

        sa(sr());
        sa(sr()*59049);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _1;
    _12:
        sa(sp()/10L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _1;
}
}
