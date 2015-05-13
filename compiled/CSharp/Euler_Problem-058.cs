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
        long x0=35;
        long x1=35;
        long x2=35;
        long x3=35;
        long x4=35;
        long x5=35;
        long x6=35;
        long x7=35;
        long x8=35;
        long x9=35;
        goto _0;
    _0:
        x0=2;
        x1=1;
        x2=0;
        sa(3);
        sa(3);
        sa(0);
    _1:
        if(sp()!=0)goto _37; else goto _2;
    _2:
        sa(sr());
        sa(sp()-(2));
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _38; else goto _3;
    _3:
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _37; else goto _4;
    _4:
        sa(sr());
        sa(9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _38; else goto _5;
    _5:
        sa(sr());
        {long v0=3;sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _37; else goto _6;
    _6:
        sa(sr());
        {long v0=5;sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _37; else goto _7;
    _7:
        x4=1;
        sa(-2);
    _8:
        if(sp()!=0)goto _9; else goto _36;
    _9:
        sa(sr());
        sa((x4)+(1));
        x4=(x4)+(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        x3=sp();
        sa(sp()-(1));
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _10:
        sa(sr());
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _35; else goto _11;
    _11:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        x5=sp();
        x7=x3;
        x6=sp();
        x8=sp();
        x9=1;
        sa(0);
        sa(x6);
        sa(((x6)!=0)?0:1);
    _12:
        if(sp()!=0)goto _13; else goto _34;
    _13:
        sp();
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _14:
        sa(sr());
        if(sp()!=0)goto _15; else goto _18;
    _15:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sp()*sp());
        {long v0=x7;sa((v0==0)?0:(sp()%v0));}
        sa(td(x9,2));
        x9=td(x9,2);
        sa(x6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        {long v0=2;sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _16; else goto _17;
    _16:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-(1));
        goto _14;
    _17:
        sa(sp()*(x8));
        {long v0=x7;sa((v0==0)?0:(sp()%v0));}
        goto _16;
    _18:
        sp();
        sa(x5);
        sa(x5);
    _19:
        if(sp()!=0)goto _20; else goto _33;
    _20:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        {long v0=x3;sa((v0==0)?0:(sp()%v0));}
        sa(sp()-(1));
        sa((sp()!=0)?0:1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sp()-(1));
        sa((sp()!=0)?0:1);
        sa((sp()!=0)?0:1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-(x3));
        sa(sp()+(1));
        sa((sp()!=0)?0:1);
        sa((sp()!=0)?0:1);
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()-(3));
        if(sp()!=0)goto _32; else goto _21;
    _21:
        sp();
        sp();
        sa(x4);
        sa(0);
    _22:
        if(sp()!=0)goto _31; else goto _23;
    _23:
        sp();
        sp();
        sa(0);
    _24:
        if(sp()!=0)goto _30; else goto _25;
    _25:
        sa((x1)+(1));
        x1=(x1)+(1);
        sa((x2)*(10));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _26; else goto _29;
    _26:
        sa(sp()+(x0));
        sa(tm(x1,4));
        if(sp()!=0)goto _27; else goto _28;
    _27:
        sa(sr());
        sa(sr());
        sa(2);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _1;
    _28:
        x0=(x0)+(2);
        sa(sr());
        sa(sr());
        sa(2);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _1;
    _29:
        sp();
        System.Console.Out.Write((long)(((td((x1)-(2),4))*(2))+(3)));
        return;
    _30:
        x2=(x2)+(1);
        goto _25;
    _31:
        sa(sp()-(3));
        goto _8;
    _32:
        sa(sr());
        sa(sp()*sp());
        {long v0=x3;sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-(1));
        sa(sr());
        goto _19;
    _33:
        sp();
        sa(sp()-(1));
        sa((sp()!=0)?0:1);
        sa((sp()!=0)?0:1);
        sa(x4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()!=0)?0:1);
        goto _22;
    _34:
        x9=(x9)*(2);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+(1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _12;
    _35:
        {long v0=2;sa((v0==0)?0:(sp()/v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+(1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _10;
    _36:
        sp();
        sa(1);
        goto _24;
    _37:
        sp();
        sa(0);
        goto _24;
    _38:
        sp();
        sa(1);
        goto _24;
}}