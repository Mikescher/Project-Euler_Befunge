/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
        long t0,t1,t2;
        long x0=2;
        long x1=1;
        long x2=0;
        long x3=35;
        long x4=35;
        long x5=35;
        long x6=35;
        long x7=35;
        long x8=35;
        long x9=35;
        sa(3);
        sa(3);
    _1:
        if(sr()-2==0)goto _2;else goto _11;
    _2:
        sp();
        x2=x2+1;
    _4:
        t0=x1+1;
        x1=x1+1;
        t0=t0<(x2*10)?1:0;
        if((t0)!=0)goto _5;else goto _10;
    _5:
        sa(sp()+x0);
        if(tm(x1,4)!=0)goto _6;else goto _9;
    _6:
        sa(sr());
        sa(sr()<2?1:0);
    _7:
        if(sp()!=0)goto _8;else goto _1;
    _8:
        sp();
        goto _4;
    _9:
        x0=x0+2;
        sa(sr());
        sa(sr()<2?1:0);
        goto _7;
    _10:
        System.Console.Out.Write(((td(x1-2,4))*2)+3);
        sp();
        return;
    _11:
        if(tm(sr(),2)==0)goto _8;else goto _12;
    _12:
        if(sr()<9)goto _2;else goto _13;
    _13:
        if(tm(sr(),3)==0)goto _8;else goto _14;
    _14:
        if(tm(sr(),5)==0)goto _8;else goto _15;
    _15:
        x4=1;
    _16:
        sa(sr());
        t0=x4+1;
        x4=x4+1;
        x3=sr();
        sa(sp()-1L);
        t1=0;
    _17:
        if(tm(sr(),2)==0)goto _18;else goto _19;
    _18:
        sa(td(sp(),2));
        t1=t1+1;
        goto _17;
    _19:
        x5=t1;
        x7=x3;
        x6=sp();
        x8=t0;
        x9=1;
        sa(0);
        sa(x6);
        sa((x6!=0)?0:1);
    _20:
        if(sp()!=0)goto _21;else goto _34;
    _21:
        sp();
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _22:
        sa(sr());
        if(sp()!=0)goto _23;else goto _26;
    _23:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sp()*sp());
        sa(tm(sp(),x7));
        t0=td(x9,2);
        x9=td(x9,2);
        t1=x6;
        t2=td(t1,t0);
        t2=tm(t2,2);
        t2=(t2!=0)?0:1;
        if((t2)!=0)goto _24;else goto _25;
    _24:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        goto _22;
    _25:
        sa(sp()*x8);
        sa(tm(sp(),x7));
        goto _24;
    _26:
        sp();
        sa(x5);
        sa(x5);
    _27:
        if(sp()!=0)goto _28;else goto _32;
    _28:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        t0=sp();
        t0=tm(t0,x3);
        t0=t0-1;
        t0=(t0!=0)?0:1;
        t1=(sr()-1!=0)?1:0;
        sa(sp()-x3);
        sa(sp()+1L);
        sa((sp()!=0)?0:1);
        sa((sp()!=0)?0:1);
        sa(t1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        t2=sp();
        t1=t0+t2;
        t1=t1-3;
        if((t1)!=0)goto _31;else goto _29;
    _29:
        sp();
        sp();
        sa(x4);
    _30:
        sp();
        sp();
        goto _4;
    _31:
        sa(sr());
        sa(sp()*sp());
        sa(tm(sp(),x3));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        sa(sr());
        goto _27;
    _32:
        sp();
        sa(sp()-1L);
        sa((sp()!=0)?0:1);
        sa((sp()!=0)?0:1);
        sa(x4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _33;else goto _30;
    _33:
        sa(sp()-3L);
        if(sp()!=0)goto _16;else goto _2;
    _34:
        x9=x9*2;
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),2));
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _20;
}}