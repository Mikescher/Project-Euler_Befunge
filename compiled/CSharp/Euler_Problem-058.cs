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
        sa(3L);
        sa(3L);
    _1:
        if(sr()-2L==0)goto _2;else goto _11;
    _2:
        sp();
    _3:
        x2=x2+1L;
    _4:
        sa(x1+1L);
        x1=x1+1L;
        sa((sp()<(x2*10L))?1:0);
        if(sp()!=0)goto _5;else goto _10;
    _5:
        sa(sp()+x0);
        if(tm(x1,4L)!=0)goto _6;else goto _9;
    _6:
        sa(sr());
        sa(sr()<2L?1:0);
    _7:
        if(sp()!=0)goto _8;else goto _1;
    _8:
        sp();
        goto _4;
    _9:
        x0=x0+2L;
        sa(sr());
        sa(sr()<2L?1:0);
        goto _7;
    _10:
        sp();
        System.Console.Out.Write((long)(((td(x1-2L,4L))*2L)+3L));
        return;
    _11:
        if(tm(sr(),2L)==0)goto _8;else goto _12;
    _12:
        if(sr()<9L)goto _2;else goto _13;
    _13:
        if(tm(sr(),3L)==0)goto _8;else goto _14;
    _14:
        if(tm(sr(),5L)==0)goto _8;else goto _15;
    _15:
        x4=1L;
    _16:
        sa(sr());
        sa(x4+1L);
        x4=x4+1L;
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        x3=sr();
        sa(sp()-1L);
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _17:
        if(tm(sr(),2L)==0)goto _35;else goto _18;
    _18:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        x5=sp();
        x7=x3;
        x6=sp();
        x8=sp();
        x9=1L;
        sa(0L);
        sa(x6);
        sa((x6!=0)?0:1);
    _19:
        if(sp()!=0)goto _20;else goto _34;
    _20:
        sp();
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _21:
        sa(sr());
        if(sp()!=0)goto _22;else goto _25;
    _22:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sp()*sp());
        sa(tm(sp(),x7));
        sa(td(x9,2L));
        x9=td(x9,2L);
        sa(x6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}
        sa(tm(sp(),2L));
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _23;else goto _24;
    _23:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        goto _21;
    _24:
        sa(sp()*x8);
        sa(tm(sp(),x7));
        goto _23;
    _25:
        sp();
        sa(x5);
        sa(x5);
    _26:
        if(sp()!=0)goto _27;else goto _31;
    _27:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(tm(sp(),x3));
        sa(sp()-1L);
        sa((sp()!=0)?0:1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sr()-1L!=0)?1:0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-x3);
        sa(sp()+1L);
        sa((sp()!=0)?0:1);
        sa((sp()!=0)?0:1);
        sa(sp()+sp());
        sa(sp()+sp());
        sa(sp()-3L);
        if(sp()!=0)goto _30;else goto _28;
    _28:
        sp();
        sp();
        sa(x4);
    _29:
        sp();
        sp();
        goto _4;
    _30:
        sa(sr());
        sa(sp()*sp());
        sa(tm(sp(),x3));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        sa(sr());
        goto _26;
    _31:
        sp();
        sa(sp()-1L);
        sa((sp()!=0)?0:1);
        sa((sp()!=0)?0:1);
        sa(x4);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _32;else goto _29;
    _32:
        sa(sp()-3L);
        if(sp()!=0)goto _16;else goto _33;
    _33:
        sp();
        goto _3;
    _34:
        x9=x9*2L;
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),2L));
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _19;
    _35:
        sa(td(sp(),2L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _17;
}}