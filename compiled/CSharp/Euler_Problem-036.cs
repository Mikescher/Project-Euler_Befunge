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
        long t0,t1;
        long x0=9990;
        sa(0);
        sa(0);
        sa(999);
        sa(9+x0);
        sa(99);
        sa(99);
    _1:
        if(sp()!=0)goto _2;else goto _3;
    _2:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*10L);

        x0=sp();
        sa((sr()%10)+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/10L);

        sa(sr());
        goto _1;
    _3:
        x0=0;
        sp();
        sa(sr());
        sa(sr());
    _4:
        t0=(sr()%2)+x0;
        sa(sp()/2L);

        sa(sr());

        if(sp()!=0)goto _25;else goto _5;
    _5:
        sp();
        sa(sp()-t0);

        t1=sp();

        if((t1)!=0)goto _6;else goto _24;
    _6:
        sp();
    _7:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _8;else goto _9;
    _8:
        sa(sr());
        t0=sr()*10;
        x0=t0;
        sa((sr()%10)+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/10L);

        sa(sr());
        goto _1;
    _9:
        x0=990;
        sa(999);
        sa(9+x0);
        sa(99);
        sa(99);
    _10:
        if(sp()!=0)goto _11;else goto _12;
    _11:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*10L);

        x0=sp();
        sa((sr()%10)+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/10L);

        sa(sr());
        goto _10;
    _12:
        x0=0;
        sp();
        sa(sr());
        sa(sr());
    _13:
        t0=(sr()%2)+x0;
        sa(sp()/2L);

        sa(sr());

        if(sp()!=0)goto _23;else goto _14;
    _14:
        sp();
        sa(sp()-t0);

        t1=sp();

        if((t1)!=0)goto _15;else goto _22;
    _15:
        sp();
    _16:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _17;else goto _18;
    _17:
        sa(sr());
        t0=(sr()/10)*10;
        x0=t0;
        sa((sr()%10)+x0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/10L);

        sa(sr());
        goto _10;
    _18:
        System.Console.Out.Write(" =");
    _19:
        sa(sp()+sp());

        t0=sp();
        sa(sr());

        if(sp()!=0)goto _20;else goto _21;
    _20:
        sa(sp()+t0);
        goto _19;
    _21:
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());

        t1=sp();
        System.Console.Out.Write(t1+" ");
        return;
    _22:
        sa(sr());
        System.Console.Out.Write("{0} ", (long)(sp()));
        System.Console.Out.Write('\n');
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _16;
    _23:
        t0*=2;
        x0=t0;
        goto _13;
    _24:
        sa(sr());
        System.Console.Out.Write("{0} ", (long)(sp()));
        System.Console.Out.Write('\n');
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _7;
    _25:
        t0*=2;
        x0=t0;
        goto _4;
}
}
