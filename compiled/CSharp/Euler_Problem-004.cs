/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
        gw(0L,0L,1L);
        gw(1L,0L,1L);
        gw(0L,4L,1000L);
    _1:
        sa(gr(1L,0L)+1L);
        sa(gr(1L,0L)+1L);
        gw(1L,0L,gr(1L,0L)+1L);
        sa(sp()-gr(0L,4L));
        sa(gr(0L,0L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _4;else goto _2;
    _2:
        sa(sp()+1L);
        sa(sr());
        gw(0L,0L,sp());
        gw(1L,0L,1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sp();
        sa(1L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sr()!=gr(0L,4L))goto _4;else goto _3;
    _3:
        sp();
        sp();
        System.Console.Out.Write((long)(gr(0L,3L)));
        return;
    _4:
        gw(0L,1L,1L);
        sa(sp()*sp());
        sa(sr());
    _5:
        sa(tm(sr(),10L));
        gw(gr(0L,1L),1L,sp());
        gw(0L,1L,gr(0L,1L)+1L);
        sa(td(sp(),10L));
        sa(sr());
        if(sp()!=0)goto _5;else goto _7;
    _7:
        gw(0L,2L,1L);
        sp();
    _8:
        if(gr(gr(0L,2L),1L)!=gr(gr(0L,1L)-gr(0L,2L),1L))goto _13;else goto _9;
    _9:
        sa(gr(0L,2L)+1L);
        gw(0L,2L,gr(0L,2L)+1L);
        sa(sp()-gr(0L,1L));
        if(sp()!=0)goto _8;else goto _10;
    _10:
        if(sr()<gr(0L,3L))goto _11;else goto _12;
    _11:
        sp();
        goto _1;
    _12:
        gw(0L,3L,sp());
        goto _1;
    _13:
        sp();
        goto _1;
}}