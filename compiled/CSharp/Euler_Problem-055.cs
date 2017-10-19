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
        long x0=32;
        long x1=32;
        sa(0);
        sa(10000);
        sa(10000);
        sa(0);
        sa(10000);
        sa(0);
    _1:
        if(sp()!=0)goto _3;else goto _2;
    _2:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*10L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        t0=sr()%10;
        x1=t0;
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+x1);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/10L);

        sa(sr());
        sa((sp()!=0)?0:1);
        goto _1;
    _3:
        sp();
        sa(sp()+sp());

        sa(24);
        sa(0);
    _4:
        if(sp()!=0)goto _5;else goto _9;
    _5:
        sp();
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _6:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _8;else goto _7;
    _7:
        sp();
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _8:
        sa(sr());
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _1;
    _9:
        t0=0;
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sr());
    _10:
        sa(sr());

        if(sp()!=0)goto _14;else goto _11;
    _11:
        x0=t0;
        sp();
        sa(sp()-t0);

        t1=sp();

        if((t1)!=0)goto _12;else goto _13;
    _12:
        sa(sr());
        sp();
        sa(sp()+x0);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);
        goto _4;
    _13:
        sp();
        sp();
        goto _6;
    _14:
        t0*=10;
        t1=sr()%10;
        x1=t1;
        t0+=x1;
        sa(sp()/10L);
        goto _10;
}
}
