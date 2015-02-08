/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
        long x0=37;
        long x1=37;
        long x2=37;
        long x3=37;
        long x4=37;
        long x5=37;
        long x6=37;
        goto _3;
    _0:
        if(sp()!=0)goto _6; else goto _5;
    _1:
        if(sp()!=0)goto _7; else goto _16;
    _2:
        if(sp()!=0)goto _10; else goto _19;
    _3:
        x0=1073741824;
        x1=2;
        x5=5;
        sa(2);
        sa(5);
        goto _4;
    _4:
        sa((x1)-(1));
        sa((x1)-(1));
        goto _0;
    _5:
        sp();
        sp();
        sa(sp()+(1));
        sa(sr());
        sa(sr());
        x1=sp();
        sa(sr());
        sa(sp()*(3));
        sa(sp()-(1));
        sa(sp()*sp());
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        x5=sp();
        goto _4;
    _6:
        sa(sr());
        x2=sp();
        sa(sr());
        sa(sp()*(3));
        sa(sp()-(1));
        sa(sp()*sp());
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        x3=sp();
        x6=0;
        {long v0=sp();sa(sp()-v0);}
        sa(sp()*(24));
        sa(sp()+(1));
        sa(sr());
        x4=sp();
        sa(x0);
        sa((x0)>(x4)?1:0);
        goto _1;
    _7:
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=x4;sa((sp()>v0)?1:0);}
        goto _1;
    _8:
        sa(x5);
        sa((x2)-(1));
        sa((x2)-(1));
        goto _0;
    _9:
        sa((((x3)+(x5))*(24))+(1));
        sa((((x3)+(x5))*(24))+(1));
        x6=0;
        x4=sp();
        sa(x0);
        sa((x0)>(x4)?1:0);
        goto _2;
    _10:
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        {long v0=x4;sa((sp()>v0)?1:0);}
        goto _2;
    _11:
        sp();
        System.Console.Out.Write((long)((x5)-(x3)));
        return;
    _12:
        sp();
        goto _8;
    _13:
        sa(sr());
        sa(sp()+(x6));
        sa(x4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x4=sp();
        sa(sr());
        sa(sp()*(2));
        sa(sp()+(x6));
        x6=sp();
        x6=td(x6,2);
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        goto _19;
    _14:
        sp();
        goto _8;
    _15:
        sa(sr());
        sa(sp()+(x6));
        sa(x4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x4=sp();
        sa(sr());
        sa(sp()*(2));
        sa(sp()+(x6));
        x6=sp();
        x6=td(x6,2);
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        goto _16;
    _16:
        sa(sr());
        if(sp()!=0)goto _24; else goto _17;
    _17:
        sp();
        sa(sp()-((x6)*(x6)));
        sa(x6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _14; else goto _18;
    _18:
        {long v0=6;sa((v0==0)?0:(sp()%v0));}
        sa(sp()-(5));
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _9; else goto _8;
    _19:
        sa(sr());
        if(sp()!=0)goto _22; else goto _20;
    _20:
        sp();
        sa(sp()-((x6)*(x6)));
        sa(x6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _12; else goto _21;
    _21:
        {long v0=6;sa((v0==0)?0:(sp()%v0));}
        sa(sp()-(5));
        if(sp()!=0)goto _8; else goto _11;
    _22:
        sa(sr());
        sa(sp()+(x6));
        {long v0=x4;sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _13; else goto _23;
    _23:
        x6=td(x6,2);
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        if(sp()!=0)goto _22; else goto _20;
    _24:
        sa(sr());
        sa(sp()+(x6));
        {long v0=x4;sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _15; else goto _25;
    _25:
        x6=td(x6,2);
        {long v0=4;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        if(sp()!=0)goto _24; else goto _17;
}}