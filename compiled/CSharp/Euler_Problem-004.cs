/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0;
        gw(0,0,1);
        gw(1,0,1);
        gw(0,4,1000);
    _1:
        t0=gr(1,0)+1;
        sa(gr(1,0)+1);
        gw(1,0,gr(1,0)+1);
        t0-=gr(0,4);
        sa(gr(0,0));

        if((t0)!=0)goto _3;else goto _2;
    _2:
        sa(sp()+1L);

        sa(sr());
        gw(0,0,sp());
        gw(1,0,1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sp();
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if((sr()-gr(0,4))!=0)goto _3;else goto _12;
    _3:
        gw(0,1,1);
        sa(sp()*sp());

        sa(sr());
    _4:
        gw(gr(0,1),1,sr()%10);
        gw(0,1,gr(0,1)+1);
        sa(sp()/10L);

        sa(sr());
        if(sp()!=0)goto _4;else goto _6;
    _6:
        gw(0,2,1);
        sp();
    _7:
        if((gr(gr(0,2),1)-gr(gr(0,1)-gr(0,2),1))!=0)goto _10;else goto _8;
    _8:
        t0=gr(0,2)+1;
        gw(0,2,gr(0,2)+1);
        t0-=gr(0,1);

        if((t0)!=0)goto _7;else goto _9;
    _9:
        if(sr()<gr(0,3))goto _10;else goto _11;
    _10:
        sp();
        goto _1;
    _11:
        gw(0,3,sp());
        sa(0);
        goto _10;
    _12:
        System.Console.Out.Write(gr(0,3)+" ");
        sp();
        sp();
        return;
}
}
