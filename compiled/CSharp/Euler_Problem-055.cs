/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
        long x0=32;
        long x1=32;
        sa(0);
        sa(10000);
        sa(10000);
        sa(0);
        sa(10000);
    _1:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*10L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        t0=tm(sr(),10);
        x1=t0;
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+x1);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),10));

        sa(sr());
        sa((sp()!=0)?0:1);
    _2:
        if(sp()!=0)goto _3;else goto _1;
    _3:
        sp();
        sa(sp()+sp());

        sa(24);
    _4:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sr());
        t0=0;
    _5:
        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _6;else goto _13;
    _6:
        sp();
        x0=t0;
        sa(sp()-t0);

        t1=sp();

        if((t1)!=0)goto _7;else goto _12;
    _7:
        sa(sr());
        sp();
        sa(sp()+x0);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _8;else goto _4;
    _8:
        sp();
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _9:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _10;else goto _11;
    _10:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _11:
        sa(sr());
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _2;
    _12:
        sp();
        sp();
        goto _9;
    _13:
        t0*=10;
        t1=tm(sr(),10);
        x1=t1;
        t0+=x1;
        sa(td(sp(),10));
        goto _5;
}
}
