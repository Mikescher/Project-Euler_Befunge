/* compiled with BefunCompile v1.0.4 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACNUMtqw0AM/JUBbS82TkdOFoowJh9i4t72qtOe8vHRuqXkYULnIMTMrjQjNSrNPef81XUdTz4ri/ZmSuepDGTBInUNivQlaRMWaxKCTonHcjjjBZe/"+
                                    "riJNv+2sAgqiuqATmKAKMN39q2uVoehQxrARuzWayUfqVNeL2Gefsyt7DdFb+QjCHkc0JMwcWw6ODioKBlx/PLx63XONvcebPFtEXr4jPI9e3037z5btNny2v4MbijFY"+
                                    "E6oBAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<71&&y<6)?g[y*71+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<71&&y<6)g[y*71+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _2;
    _0:
        if(sp()!=0)goto _4; else goto _5;
    _1:
        if(((gr(gr(0,2),1))-(gr((gr(0,1))-(gr(0,2)),1)))!=0)goto _8;else goto _12;
    _2:
        gw(0,0,1);
        gw(1,0,1);
        gw(0,4,1000);
        goto _10;
    _3:
        gw(0,1,1);
        sa(sp()*sp());
        sa(sr());
        goto _4;
    _4:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        gw(gr(0,1),1,sp());
        gw(0,1,(gr(0,1))+(1));
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        goto _0;
    _5:
        gw(0,2,1);
        sp();
        goto _1;
    _6:
        gw(0,3,sp());
        goto _10;
    _7:
        sp();
        goto _10;
    _8:
        sp();
        goto _10;
    _9:
        sp();
        sp();
        System.Console.Out.Write((long)(gr(0,3)));
        return;
    _10:
        sa((gr(1,0))+(1));
        sa((gr(1,0))+(1));
        gw(1,0,(gr(1,0))+(1));
        sa(gr(0,4));
        {long v0=sp();sa(sp()-v0);}
        sa(gr(0,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _3; else goto _11;
    _11:
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
        if(sp()!=0)goto _3; else goto _9;
    _12:
        sa((gr(0,2))+(1));
        gw(0,2,(gr(0,2))+(1));
        sa(gr(0,1));
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _1; else goto _13;
    _13:
        sa(sr());
        sa(gr(0,3));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _7; else goto _6;
}}