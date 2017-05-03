/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
        long t0,t1,t2,t3;
        long x0=4818;
        sa(1488);
        sa(1800);
        sa(1800);
    _1:
        if((((tm(x0,10))+2)*((tm(td(x0,10),10))+2)*((tm(td(td(x0,10),10),10))+2)*((td(td(td(x0,10),10),10))+2))!=(((tm(x0+3330,10))+2)*((tm(td(x0+3330,10),10))+2)*((tm(td(td(x0+3330,10),10),10))+2)*((td(td(td(x0+3330,10),10),10))+2)))goto _15;else goto _2;
    _2:
        {long v0=sp();sa(sp()-v0);}

        t0=sp();
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _3;else goto _15;
    _3:
        sa(sr());
    _4:
        if(sr()>9999)goto _14;else goto _5;
    _5:
        sa(sr());

        if(tm(sr(),2)==0)goto _6;else goto _7;
    _6:
        sp();
        sp();
        sa(sp()+1L);

        sa(sr());
        sa(sr());
        t0=(tm(sr(),10))+2;
        sa(td(sp(),10));

        t1=(tm(sr(),10))+2;
        sa(td(sp(),10));

        t2=(tm(sr(),10))+2;
        sa(td(sp(),10));

        sa(sp()+2L);

        sa(t2);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*sp());

        t3=sp();
        t2=t1*t3;
        sa(t0*t2);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+3330L);

        x0=sp();
        sa(sr());
        goto _1;
    _7:
        if(tm(sr(),3)==0)goto _6;else goto _8;
    _8:
        x0=sp();
        sa(7);
        sa((tm(x0,7)!=0)?0:1);
    _9:
        if(sp()!=0)goto _6;else goto _10;
    _10:
        if(sr()>(td(x0,2)))goto _13;else goto _11;
    _11:
        t0=sr()-2;
        t1=x0;
        t2=tm(t1,t0);

        if((t2)!=0)goto _12;else goto _6;
    _12:
        sa(sp()+6L);

        sa(sr());
        t0=x0;
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}

        sa((sp()!=0)?0:1);
        goto _9;
    _13:
        sp();
        sa(sp()+3330L);
        goto _4;
    _14:
        sp();
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write(' ');
        sa(sp()+3330L);

        sa(sr());
        System.Console.Out.Write((long)(sp()));
        System.Console.Out.Write(' ');
        sa(sp()+3330L);

        System.Console.Out.Write((long)(sp()));
        return;
    _15:
        sp();
        sp();
        sa(sp()+1L);

        sa(sr());
        sa(sr());
        t0=(tm(sr(),10))+2;
        sa(td(sp(),10));

        t1=(tm(sr(),10))+2;
        sa(td(sp(),10));

        t2=(tm(sr(),10))+2;
        sa(td(sp(),10));

        sa(sp()+2L);

        sa(t2);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*sp());

        t3=sp();
        t2=t1*t3;
        sa(t0*t2);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+3330L);

        x0=sp();
        sa(sr());
        goto _1;
}
}
