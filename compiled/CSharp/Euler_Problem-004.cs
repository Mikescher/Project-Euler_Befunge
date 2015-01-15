/* compiled with BefunCompile v1.0.2 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACNUMtqw0AM/JUBbS82TkdOFoowJh9i4t72qtOe8vHRuqXkYULnIMTMrjQjNSrNPef81XUdTz4ri/ZmSuepDGTBInUNivQlaRMWaxKCTonHcjjjBZe/"+
                                    "riJNv+2sAgqiuqATmKAKMN39q2uVoehQxrARuzWayUfqVNeL2Gefsyt7DdFb+QjCHkc0JMwcWw6ODioKBlx/PLx63XONvcebPFtEXr4jPI9e3037z5btNny2v4MbijFY"+
                                    "E6oBAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=o.Skip(1).ToArray();for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<71&&y<6)?g[y*71+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<71&&y<6)g[y*71+x]=v;}
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
        goto _6;
    _0:
        if(sp()!=0)goto _8; else goto _16;
    _1:
        if(sp()!=0)goto _9; else goto _10;
    _2:
        if(sp()!=0)goto _5; else goto _12;
    _3:
        if(sp()!=0)goto _14; else goto _13;
    _4:
        if(sp()!=0)goto _8; else goto _17;
    _5:
        if(((gr(gr(0,2),1))-(gr((gr(0,1))-(gr(0,2)),1)))!=0)goto _15;else goto _11;
    _6:
        gw(0,0,1);
        gw(1,0,1);
        gw(0,4,1000);
        goto _7;
    _7:
        sa((gr(1,0))+(1));
        sa((gr(1,0))+(1));
        gw(1,0,(gr(1,0))+(1));
        sa(gr(0,4));
        {long v0=sp();sa(sp()-v0);}
        sa(gr(0,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _0;
    _8:
        gw(0,1,1);
        sa(sp()*sp());
        sa(sr());
        goto _9;
    _9:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        gw(gr(0,1),1,sp());
        gw(0,1,(gr(0,1))+(1));
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _1;
    _10:
        gw(0,2,1);
        sp();
        goto _5;
    _11:
        sa((gr(0,2))+(1));
        gw(0,2,(gr(0,2))+(1));
        sa(gr(0,1));
        {long v0=sp();sa(sp()-v0);}
        goto _2;
    _12:
        sa(sr());
        sa(gr(0,3));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _3;
    _13:
        gw(0,3,sp());
        goto _7;
    _14:
        sp();
        goto _7;
    _15:
        sp();
        goto _7;
    _16:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        gw(0,0,sp());
        gw(1,0,1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sp();
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(gr(0,4));
        {long v0=sp();sa(sp()-v0);}
        goto _4;
    _17:
        sp();
        sp();
        System.Console.Out.Write((long)(gr(0,3)));
        return;
}}