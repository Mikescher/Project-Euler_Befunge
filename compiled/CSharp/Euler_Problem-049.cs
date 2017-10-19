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
        long t0,t1,t2,t3;
        long x0=4818;
        sa(1488);
        sa(1800);
        sa(1800);
    _1:
        if(((((x0%10)+2)*(((x0/10)%10)+2)*((((x0/10)/10)%10)+2)*((((x0/10)/10)/10)+2))-((((x0+3330)%10)+2)*((((x0+3330)/10)%10)+2)*(((((x0+3330)/10)/10)%10)+2)*(((((x0+3330)/10)/10)/10)+2)))!=0)goto _14;else goto _2;
    _2:
        {long v0=sp();sa(sp()-v0);}

        t0=sp();

        if((t0)!=0)goto _14;else goto _3;
    _3:
        sa(sr());

        if(sr()>9999)goto _13;else goto _4;
    _4:
        sa(sr());

        if((sr()%2)!=0)goto _6;else goto _5;
    _5:
        t0=0;
        sp();
        sp();
        sa(sp()+1L);

        sa(sr());
        sa(sr());
        t0=(sr()%10)+2;
        sa(sp()/10L);

        t1=(sr()%10)+2;
        sa(sp()/10L);

        t2=(sr()%10)+2;
        sa(sp()/10L);

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
    _6:
        if((sr()%3)!=0)goto _7;else goto _5;
    _7:
        x0=sp();
        sa(7);
        sa(x0%7);
    _8:
        if(sp()!=0)goto _9;else goto _5;
    _9:
        if(sr()>(x0/2))goto _12;else goto _10;
    _10:
        t0=sr()-2;
        t1=x0;
        t2=tm(t1,t0);

        if((t2)!=0)goto _11;else goto _5;
    _11:
        t0=x0;
        sa(sp()+6L);

        sa(sr());
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}
        goto _8;
    _12:
        sp();
        sa(sp()+3330L);

        t0=sr()>9999?1:0;
        t1=0;

        if((t0)!=0)goto _13;else goto _4;
    _13:
        sp();
        sa(sr());
        System.Console.Out.Write("{0} ", (long)(sp()));
        System.Console.Out.Write(' ');
        sa(sp()+3330L);

        sa(sr());
        System.Console.Out.Write("{0} ", (long)(sp()));
        System.Console.Out.Write(' ');
        sa(sp()+3330L);

        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _14:
        sp();
        sp();
        sa(sp()+1L);

        sa(sr());
        sa(sr());
        t0=(sr()%10)+2;
        sa(sp()/10L);

        t1=(sr()%10)+2;
        sa(sp()/10L);

        t2=(sr()%10)+2;
        sa(sp()/10L);

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
