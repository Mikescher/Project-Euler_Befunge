/* compiled with BefunCompile v1.0 (c) 2015 */
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
        long x0=32;
        long x1=32;
        long x2=32;
        long x3=32;
        long x4=32;
        goto _17;
    _0:
        if(sp()!=0)goto _20; else goto _19;
    _1:
        if(sp()!=0)goto _21; else goto _22;
    _2:
        if(sp()!=0)goto _24; else goto _28;
    _3:
        if(sp()!=0)goto _28; else goto _25;
    _4:
        if(sp()!=0)goto _29; else goto _31;
    _5:
        if(sp()!=0)goto _31; else goto _30;
    _6:
        if(sp()!=0)goto _32; else goto _34;
    _7:
        if(sp()!=0)goto _34; else goto _33;
    _8:
        if(sp()!=0)goto _35; else goto _27;
    _9:
        if(sp()!=0)goto _27; else goto _36;
    _10:
        if(sp()!=0)goto _18; else goto _15;
    _11:
        if(sp()!=0)goto _27; else goto _26;
    _12:
        if(sp()!=0)goto _34; else goto _26;
    _13:
        if(sp()!=0)goto _31; else goto _26;
    _14:
        if(sp()!=0)goto _28; else goto _26;
    _15:
        if(((((((x3)>(x2))?1:0))!=0)?0:1)!=0)goto _18;else goto _23;
    _16:
        if((x1)!=0)goto _21;else goto _22;
    _17:
        x0=1;
        x1=1;
        x2=99;
        x3=99;
        goto _15;
    _18:
        sa(((x2)-(1)));
        x2=((x2)-(1));
        sa(9);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _0;
    _19:
        x3=99;
        goto _15;
    _20:
        sp();
        sa(x0);
        sa(x1);
        goto _16;
    _21:
        sa(sr());
        x4=sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(x4);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        goto _1;
    _22:
        sp();
        sa(x1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        System.Console.Out.WriteLine((long)(sp()));
        return;
    _23:
        sa(td(x2,10));
        goto _2;
    _24:
        sa(((td(x2,10))-(td(x3,10))));
        goto _3;
    _25:
        sa(((((x2)*(td(x3,10))))-(((x3)*(td(x2,10))))));
        goto _14;
    _26:
        x0=((x0)*(x2));
        x1=((x1)*(x3));
        goto _27;
    _27:
        sa(((x3)-(1)));
        x3=((x3)-(1));
        sa(9);
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        goto _10;
    _28:
        sa(td(x2,10));
        goto _4;
    _29:
        sa(((td(x2,10))-(tm(x3,10))));
        goto _5;
    _30:
        sa(((((x2)*(td(x3,10))))-(((x3)*(tm(x2,10))))));
        goto _13;
    _31:
        sa(tm(x2,10));
        goto _6;
    _32:
        sa(((tm(x2,10))-(td(x3,10))));
        goto _7;
    _33:
        sa(((((x2)*(tm(x3,10))))-(((x3)*(td(x2,10))))));
        goto _12;
    _34:
        sa(tm(x2,10));
        goto _8;
    _35:
        sa(((tm(x2,10))-(tm(x3,10))));
        goto _9;
    _36:
        sa(((((x2)*(tm(x3,10))))-(((x3)*(tm(x2,10))))));
        goto _11;
}}