/* transpiled with BefunCompile v1.1.0 (c) 2015 */
public static class Program
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3HLMPOQi0PdxvZLqX92LstCUbPD5c2mz7TcAk47DTRokjz76XnzlZNVGhq/377rObftueqa2e6B+pd9Ro9snjif/v5vV/+rc7m3/S"+
                                    "/Gdn1/2duD0oz6c+++BkS7FalwIiwbsHNiZ7f21e2S2V9fXk1I+ldXVrJ0XsCHme+Kb+QtYnU851n0N59Ewj92+bd27q4U7TZ/o3s2R1nauLpdrSF8/1vpb9ZdYy7olT"+
                                    "f/k5F7WuTSsKua2XeSLbelVp3dZX9f8YrET1bz7QZmAAAOh0xyzxAAAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<104&&y<108)?g[y*104+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<104&&y<108)g[y*104+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1;
        gw(3,0,100);
        sa(1);
        sa(1>gr(3,0)?1:0);
    _1:
        if(sp()!=0)goto _9;else goto _2;
    _2:
        sa(sr());
        gw(5,0,sp());
        gw(6,0,0);
        sa(1);
        sa((1-gr(5,0)!=0)?0:1);
    _3:
        if(sp()!=0)goto _8;else goto _4;
    _4:
        sa(sr());
        sa(sr());
        sa(sr());
        sa(sr());
        t0=gr(5,0);
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}

        t1=sp();
        sa((sp()>t1)?1:0);

        t0=sp();

        if((t0)!=0)goto _5;else goto _7;
    _5:
        sa(sr());
        t0=gr(5,0);
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}

        sa(sp()+3L);
    _6:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        t0=gr(5,0);
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}

        sa(sp()+3L);

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()+gr(6,0));

        sa(sr());
        gw(6,0,sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+3L);

        sa(gr(5,0)+3);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);

        sa((sr()-gr(5,0)!=0)?0:1);
        goto _3;
    _7:
        sa(sr()+3);
        goto _6;
    _8:
        sp();
        sa(sr());
        sa(gr(6,0)+1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+3L);

        sa(sr());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);

        sa(sr()>gr(3,0)?1:0);
        goto _1;
    _9:
        sa(sp()+1L);

        sa(sr()+1);
        {long v0=sp();t0=gr(sp(),v0);}
        System.Console.Out.Write(t0);
        return;
}
}
