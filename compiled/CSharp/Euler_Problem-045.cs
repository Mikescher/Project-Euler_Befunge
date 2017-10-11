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
        long t0,t1,t2;
        long x0=1152921504606846976;
        long x1=991873;
        long x2=0;
        sa(144);
        sa(991873);
    _1:
        sa(x0);
        sa(x0>x1?1:0);
    _2:
        if(sp()!=0)goto _13;else goto _3;
    _3:
        sa(sr());
    _4:
        if(sp()!=0)goto _10;else goto _5;
    _5:
        sp();
        sa(sp()-(x2*x2));


        if((tm(x2,6))-5==0)goto _6;else goto _9;
    _6:
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _8;else goto _7;
    _7:
        x2=0;
        sa(sp()+1L);

        sa(sr());
        t0=(sr()*2)-1;
        sa(sp()*t0);

        sa(sp()*24L);

        sa(sp()+1L);

        x1=sr();
        goto _1;
    _8:
        t0=(sr()*2)-1;
        sa(sp()*t0);

        t1=sp();
        System.Console.Out.Write(t1+" ");
        return;
    _9:
        x2=0;
        sp();
        sa(sp()+1L);

        sa(sr());
        t0=(sr()*2)-1;
        sa(sp()*t0);

        sa(sp()*24L);

        sa(sp()+1L);

        x1=sr();
        goto _1;
    _10:
        if((sr()+x2)<=x1)goto _12;else goto _11;
    _11:
        x2/=2;
        sa(td(sp(),4));

        sa(sr());
        goto _4;
    _12:
        t0=sr()+x2;
        t1=x1;
        t2=t1-t0;
        x1=t2;
        t0=(sr()*2)+x2;
        x2=t0;
        x2/=2;
        sa(td(sp(),4));
        goto _3;
    _13:
        sa(td(sp(),4));

        sa(sr()>x1?1:0);
        goto _2;
}
}
