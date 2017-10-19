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
        long x1=1;
        long x2=88;
        long x3=1;
        long x4=88;
        sa(10);
        sa(1);
        sa(1);
        sa(1);
        sa(1);
    _1:
        if(sp()!=0)goto _12;else goto _2;
    _2:
        x2=2;
        sp();
        sa((sr()*x2*10)/10);
        x4=1;
    _3:
        sa(sr());

        if(sp()!=0)goto _11;else goto _4;
    _4:
        sp();

        if((x4-x1)!=0)goto _8;else goto _5;
    _5:
        t0=x2-6;
        x2++;

        if((t0)!=0)goto _7;else goto _6;
    _6:
        System.Console.Out.Write("{0} ", (long)(sp()));
        sp();
        sp();
        return;
    _7:
        sa((sr()*x2*10)/10);
        x4=1;
        goto _3;
    _8:
        sp();
        sa(sp()+1L);


        if(sr()<x3)goto _10;else goto _9;
    _9:
        sp();
        sa(sp()*10L);

        t0=sr()/6;
        x3=t0;
        x1=1;
        sa(sr()/10);
        sa(sr());
        sa((sr()*10)/10);
        sa(sr());
        goto _1;
    _10:
        x1=1;
        sa(sr());
        sa((sr()*10)/10);
        sa(sr());
        goto _1;
    _11:
        t0=((sr()%10)+2)*x4;
        x4=t0;
        sa(sp()/10L);
        goto _3;
    _12:
        t0=((sr()%10)+2)*x1;
        x1=t0;
        sa(sp()/10L);

        sa(sr());
        goto _1;
}
}
