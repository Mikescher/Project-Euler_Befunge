/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long x0=1073741824;
        long x1=2;
        long x2=37;
        long x3=37;
        long x4=37;
        long x5=5;
        long x6=37;
        sa(2L);
        sa(5L);
    _1:
        sa(x1-1L);
        sa(x1-1L);
    _2:
        if(sp()!=0)goto _4;else goto _3;
    _3:
        sp();
        sp();
        sa(sp()+1L);
        sa(sr());
        x1=sr();
        sa((sr()*3L)-1L);
        sa(sp()*sp());
        sa(td(sp(),2L));
        x5=sr();
        goto _1;
    _4:
        x2=sr();
        sa((sr()*3L)-1L);
        sa(sp()*sp());
        sa(td(sp(),2L));
        x3=sr();
        x6=0L;
        {long v0=sp();sa(sp()-v0);}
        sa(sp()*24L);
        sa(sp()+1L);
        x4=sr();
        sa(x0);
        sa(x0>x4?1:0);
    _5:
        if(sp()!=0)goto _25;else goto _6;
    _6:
        sa(sr());
        if(sp()!=0)goto _22;else goto _7;
    _7:
        sp();
        sa(sp()-(x6*x6));
        sa(x6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _21;else goto _8;
    _8:
        sa(tm(sp(),6L));
        sa(sp()-5L);
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _9;else goto _15;
    _9:
        sa(((x3+x5)*24L)+1L);
        sa(((x3+x5)*24L)+1L);
        x6=0L;
        x4=sp();
        sa(x0);
        sa(x0>x4?1:0);
    _10:
        if(sp()!=0)goto _20;else goto _11;
    _11:
        sa(sr());
        if(sp()!=0)goto _17;else goto _12;
    _12:
        sp();
        sa(sp()-(x6*x6));
        sa(x6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _16;else goto _13;
    _13:
        sa(tm(sp(),6L));
        sa(sp()-5L);
        if(sp()!=0)goto _15;else goto _14;
    _14:
        sp();
        System.Console.Out.Write((long)(x5-x3));
        return;
    _15:
        sa(x5);
        sa(x2-1L);
        sa(x2-1L);
        goto _2;
    _16:
        sp();
        goto _15;
    _17:
        if((sr()+x6)<=x4)goto _19;else goto _18;
    _18:
        x6=td(x6,2L);
        sa(td(sp(),4L));
        sa(sr());
        if(sp()!=0)goto _17;else goto _12;
    _19:
        sa(sr()+x6);
        sa(x4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x4=sp();
        sa((sr()*2L)+x6);
        x6=sp();
        x6=td(x6,2L);
        sa(td(sp(),4L));
        goto _11;
    _20:
        sa(td(sp(),4L));
        sa(sr()>x4?1:0);
        goto _10;
    _21:
        sp();
        goto _15;
    _22:
        if((sr()+x6)<=x4)goto _24;else goto _23;
    _23:
        x6=td(x6,2L);
        sa(td(sp(),4L));
        sa(sr());
        if(sp()!=0)goto _22;else goto _7;
    _24:
        sa(sr()+x6);
        sa(x4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x4=sp();
        sa((sr()*2L)+x6);
        x6=sp();
        x6=td(x6,2L);
        sa(td(sp(),4L));
        goto _6;
    _25:
        sa(td(sp(),4L));
        sa(sr()>x4?1:0);
        goto _5;
}}