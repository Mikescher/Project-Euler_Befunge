/* compiled with BefunCompile v1.0.2 (c) 2015 */
public static class Program 
{
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
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
        goto _13;
    _0:
        if(sp()!=0)goto _16; else goto _15;
    _1:
        if(sp()!=0)goto _35; else goto _17;
    _2:
        if(sp()!=0)goto _18; else goto _20;
    _3:
        if(sp()!=0)goto _34; else goto _19;
    _4:
        if(sp()!=0)goto _18; else goto _20;
    _5:
        if(sp()!=0)goto _33; else goto _21;
    _6:
        if(sp()!=0)goto _23; else goto _22;
    _7:
        if(sp()!=0)goto _32; else goto _24;
    _8:
        if(sp()!=0)goto _25; else goto _27;
    _9:
        if(sp()!=0)goto _31; else goto _26;
    _10:
        if(sp()!=0)goto _25; else goto _27;
    _11:
        if(sp()!=0)goto _28; else goto _29;
    _12:
        if(sp()!=0)goto _22; else goto _30;
    _13:
        x0=1073741824;
        x1=2;
        x5=5;
        sa(2);
        sa(5);
        goto _14;
    _14:
        sa((x1)-(1));
        sa((x1)-(1));
        goto _0;
    _15:
        sp();
        sp();
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(sr());
        x1=sp();
        sa(sr());
        sa(3);
        sa(sp()*sp());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sp()*sp());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        x5=sp();
        goto _14;
    _16:
        sa(sr());
        x2=sp();
        sa(sr());
        sa(3);
        sa(sp()*sp());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sp()*sp());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        x3=sp();
        x6=0;
        {long v0=sp();sa(sp()-v0);}
        sa(24);
        sa(sp()*sp());
        sa(1);
        sa(sp()+sp());
        sa(sr());
        x4=sp();
        sa(x0);
        sa((x0)>(x4)?1:0);
        goto _1;
    _17:
        sa(sr());
        goto _2;
    _18:
        sa(sr());
        sa(x6);
        sa(sp()+sp());
        sa(x4);
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        goto _3;
    _19:
        x6=td(x6,2);
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _4;
    _20:
        sp();
        sa((x6)*(x6));
        {long v0=sp();sa(sp()-v0);}
        sa(x6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _5;
    _21:
        sa(6);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(5);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _6;
    _22:
        sa(x5);
        sa((x2)-(1));
        sa((x2)-(1));
        goto _0;
    _23:
        sa((((x3)+(x5))*(24))+(1));
        sa((((x3)+(x5))*(24))+(1));
        x6=0;
        x4=sp();
        sa(x0);
        sa((x0)>(x4)?1:0);
        goto _7;
    _24:
        sa(sr());
        goto _8;
    _25:
        sa(sr());
        sa(x6);
        sa(sp()+sp());
        sa(x4);
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        goto _9;
    _26:
        x6=td(x6,2);
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _10;
    _27:
        sp();
        sa((x6)*(x6));
        {long v0=sp();sa(sp()-v0);}
        sa(x6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _11;
    _28:
        sp();
        goto _22;
    _29:
        sa(6);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(5);
        {long v0=sp();sa(sp()-v0);}
        goto _12;
    _30:
        sp();
        System.Console.Out.Write((long)((x5)-(x3)));
        return;
    _31:
        sa(sr());
        sa(x6);
        sa(sp()+sp());
        sa(x4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x4=sp();
        sa(sr());
        sa(2);
        sa(sp()*sp());
        sa(x6);
        sa(sp()+sp());
        x6=sp();
        x6=td(x6,2);
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        goto _24;
    _32:
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(x4);
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _7;
    _33:
        sp();
        goto _22;
    _34:
        sa(sr());
        sa(x6);
        sa(sp()+sp());
        sa(x4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        x4=sp();
        sa(sr());
        sa(2);
        sa(sp()*sp());
        sa(x6);
        sa(sp()+sp());
        x6=sp();
        x6=td(x6,2);
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        goto _17;
    _35:
        sa(4);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa(x4);
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _1;
}}