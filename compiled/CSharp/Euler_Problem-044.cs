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
        long t0,t1,t2;
        long x0=2;
        long x1=1073741824;
        long x2=37;
        long x3=37;
        long x4=37;
        long x5=5;
        long x6=37;
        t0=0;
        sa(2);
        sa(5);
    _1:
        sa(x0-1);
        sa(x0-1);
    _2:
        if(sp()!=0)goto _4;else goto _3;
    _3:
        sp();
        sp();
        sa(sp()+1L);

        sa(sr());
        x0=sr();
        t0=(sr()*3)-1;
        sa(sp()*t0);

        sa(sp()/2L);

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
        sa(x1);
        sa(x1>x4?1:0);
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

        if((t0)!=0)goto _17;else goto _10;
    _10:
        sa(((x3+x5)*24)+1);
        t0=((x3+x5)*24)+1;
        x6=0;
        x4=t0;
        sa(x1);
        sa(x1>x4?1:0);
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
        if((sr()+x6)>x4)goto _19;else goto _20;
    _19:
        x6/=2;
        sa(sp()/4L);

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
        sa(sp()/4L);
        goto _12;
    _21:
        sa(sp()/4L);

        sa(sr()>x4?1:0);
        goto _11;
    _22:
        if((sr()+x6)>x4)goto _23;else goto _24;
    _23:
        x6/=2;
        sa(sp()/4L);

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
        sa(sp()/4L);
        goto _6;
    _25:
        sa(sp()/4L);

        sa(sr()>x4?1:0);
        goto _5;
}
}
