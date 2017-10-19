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
        long x0=1000000;
        long x1=0;
        long x2=1;
        long x3=0;
        long x4=35;
        long x5=35;
        long x6=35;
        sa(1);
        sa(2);
        sa(4+(x2*x2));
        sa(((4+(x2*x2))%64)>57?1:0);
    _1:
        if(sp()!=0)goto _31;else goto _2;
    _2:
        sa(sr()%16);

        if(sr()>9)goto _3;else goto _15;
    _3:
        sp();
    _4:
        sp();
        sa(0);
    _5:
        if(sp()!=0)goto _11;else goto _6;
    _6:
        sa(sr());

        if(sp()!=0)goto _10;else goto _7;
    _7:
        t0=x3+x1;
        x1=x3+x1;
        t0=t0>x0?1:0;
        sp();

        if((t0)!=0)goto _8;else goto _9;
    _8:
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _9:
        sa(sp()+1L);

        sa(sr());
        x2=sr();
        x3=0;
        sa(sp()*2L);

        sa(sp()+1L);

        sa(sp()-1L);

        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sp()+(x2*x2));

        sa((sr()%64)>57?1:0);
        goto _1;
    _10:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sp()+(x2*x2));

        sa((sr()%64)>57?1:0);
        goto _1;
    _11:
        if(sr()>x2)goto _14;else goto _12;
    _12:
        sa((sr()/2)+x3);
    _13:
        x3=sp();
        t0=1;
        goto _6;
    _14:
        t0=(sr()+1)/2;
        t1=x2;
        sa((t1-t0)+1+x3);
        goto _13;
    _15:
        if(sr()!=2)goto _16;else goto _3;
    _16:
        if(sr()!=3)goto _17;else goto _3;
    _17:
        if(sr()!=5)goto _18;else goto _3;
    _18:
        if(sr()!=6)goto _19;else goto _3;
    _19:
        if(sr()!=7)goto _20;else goto _3;
    _20:
        sa(sp()-8L);


        if(sp()!=0)goto _21;else goto _31;
    _21:
        sa(sr()%10);

        if(sr()!=7)goto _22;else goto _3;
    _22:
        if(sr()!=3)goto _23;else goto _3;
    _23:
        sa(sp()-2L);


        if(sp()!=0)goto _25;else goto _24;
    _24:
        sa(0);
        goto _3;
    _25:
        if((sr()%3)!=2)goto _26;else goto _4;
    _26:
        x4=0;
        x5=sr();
    _27:
        x6=sr();
        t0=x5;
        sa(sr());
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}

        t1=sp();
        sa(sp()+t1);

        sa(sp()/2L);


        if((sr()-x6)!=0)goto _29;else goto _28;
    _28:
        sp();
        sa(((x6*x6)-x5!=0)?0:1);
        goto _5;
    _29:
        if((sr()-x4)!=0)goto _30;else goto _28;
    _30:
        x4=x6;
        goto _27;
    _31:
        t0=2;
        goto _4;
}
}
