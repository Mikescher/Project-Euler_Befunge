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
        long x0=1073741824;
        long x1=2;
        long x2=37;
        long x3=37;
        long x4=37;
        long x5=5;
        long x6=37;
        sa(2);
        sa(5);
    _1:
        sa(x1-1);
        sa(x1-1);
    _2:
        if(sp()!=0)goto _4;else goto _3;
    _3:
        sp();
        sp();
        sa(sp()+1L);

        sa(sr());
        x1=sr();
        t0=(sr()*3)-1;
        sa(sp()*t0);

        sa(td(sp(),2));

        x5=sr();
        goto _1;
    _4:
        x2=sr();
        t0=(sr()*3)-1;
        sa(sp()*t0);

        t1=sp();
        t1/=2;
        x3=t1;
        x6=0;
        sa(sp()-t1);

        sa(sp()*24L);

        sa(sp()+1L);

        x4=sr();
        sa(x0);
        sa(x0>x4?1:0);
    _5:
        if(sp()!=0)goto _25;else goto _6;
    _6:
        sa(sr());
    _7:
        if(sp()!=0)goto _22;else goto _8;
    _8:
        sp();
        sa(sp()-(x6*x6));

        t0=x6;

        if(sp()!=0)goto _17;else goto _9;
    _9:
        t0%=6;
        t0-=5;
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _10;else goto _17;
    _10:
        sa(((x3+x5)*24)+1);
        t0=((x3+x5)*24)+1;
        x6=0;
        x4=t0;
        sa(x0);
        sa(x0>x4?1:0);
    _11:
        if(sp()!=0)goto _21;else goto _12;
    _12:
        sa(sr());
    _13:
        if(sp()!=0)goto _18;else goto _14;
    _14:
        sp();
        sa(sp()-(x6*x6));

        t0=x6;

        if(sp()!=0)goto _17;else goto _15;
    _15:
        t0%=6;
        t0-=5;

        if((t0)!=0)goto _17;else goto _16;
    _16:
        System.Console.Out.Write(x5-x3+" ");
        sp();
        return;
    _17:
        sa(x5);
        sa(x2-1);
        sa(x2-1);
        goto _2;
    _18:
        if((sr()+x6)<=x4)goto _20;else goto _19;
    _19:
        x6/=2;
        sa(td(sp(),4));

        sa(sr());
        goto _13;
    _20:
        t0=sr()+x6;
        t1=x4;
        t2=t1-t0;
        x4=t2;
        t0=(sr()*2)+x6;
        x6=t0;
        x6/=2;
        sa(td(sp(),4));
        goto _12;
    _21:
        sa(td(sp(),4));

        sa(sr()>x4?1:0);
        goto _11;
    _22:
        if((sr()+x6)<=x4)goto _24;else goto _23;
    _23:
        x6/=2;
        sa(td(sp(),4));

        sa(sr());
        goto _7;
    _24:
        t0=sr()+x6;
        t1=x4;
        t2=t1-t0;
        x4=t2;
        t0=(sr()*2)+x6;
        x6=t0;
        x6/=2;
        sa(td(sp(),4));
        goto _6;
    _25:
        sa(td(sp(),4));

        sa(sr()>x4?1:0);
        goto _5;
}
}
