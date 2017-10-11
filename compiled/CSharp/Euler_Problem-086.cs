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
        sa((tm(4+(x2*x2),64))>57?1:0);
    _1:
        if(sp()!=0)goto _3;else goto _2;
    _2:
        t0=tm(sr(),16);

        if(t0>9)goto _3;else goto _9;
    _3:
        sp();
    _4:
        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _5;else goto _8;
    _5:
        sp();
        t0=x3+x1;
        x1=x3+x1;
        t0=t0>x0?1:0;

        if((t0)!=0)goto _6;else goto _7;
    _6:
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _7:
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

        sa((tm(sr(),64))>57?1:0);
        goto _1;
    _8:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sp()+(x2*x2));

        sa((tm(sr(),64))>57?1:0);
        goto _1;
    _9:
        if(t0!=2)goto _10;else goto _3;
    _10:
        if(t0!=3)goto _11;else goto _3;
    _11:
        if(t0!=5)goto _12;else goto _3;
    _12:
        if(t0!=6)goto _13;else goto _3;
    _13:
        if(t0!=7)goto _14;else goto _3;
    _14:
        t0-=8;
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _3;else goto _15;
    _15:
        t0=tm(sr(),10);

        if(t0-7==0)goto _3;else goto _16;
    _16:
        if(t0-3==0)goto _3;else goto _17;
    _17:
        t0-=2;
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _3;else goto _18;
    _18:
        if((tm(sr(),3))!=2)goto _19;else goto _3;
    _19:
        x4=0;
        x5=sr();
    _20:
        x6=sr();
        sa(sr());
        t0=x5;
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}

        t1=sp();
        sa(sp()+t1);

        sa(td(sp(),2));


        if(sr()!=x6)goto _26;else goto _21;
    _21:
        sp();

        if((x6*x6)-x5==0)goto _22;else goto _4;
    _22:
        if(sr()>x2)goto _25;else goto _23;
    _23:
        sa((td(sr(),2))+x3);
    _24:
        x3=sp();
        goto _4;
    _25:
        t0=td(sr()+1,2);
        t1=x2;
        sa(t1-t0);
        sa(sp()+1L);

        sa(sp()+x3);
        goto _24;
    _26:
        if(sr()!=x4)goto _27;else goto _21;
    _27:
        x4=x6;
        goto _20;
}
}
