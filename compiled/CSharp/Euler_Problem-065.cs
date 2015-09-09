/* compiled with BefunCompile v1.0.8 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADNUjFuwzAM/ApLKUsIJRTtDBEMolNXfyBwhg5aNXny40s3TlI0bge1BXqDcKQE8njiCN57MLjfAfwV/rG+8SETYldZS/EFNR0JGU9cFiIlTbXa8BUL"+
                                    "t1wE+2gMe0ZL+1p9H5T6eO/yvOtGlmBiC2duUhY75zBzKhZ3XzuiKYZmk56mC6dmL1tzlDRvqeVM6XCgjVWihrMUC/btbExYd0RvTqkEN5zjwhnKenvs0brZXvjV6wnU"+
                                    "gSNwEVwCF4yIg+HbPdL3B+vzfu6ip3E+LuNXQHlZGMnmUbDp1WpFoJ988HAlIZ5tlOplNrwBk9ih3GAEAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<14)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<14)g[y*80+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long t0,t1;
        gw(79,0,48);
        gw(79,2,48);
        sa(69);
    _1:
        sa(sr()+9);
        sa(48);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()+9);
        sa(48);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        if(sp()!=0)goto _23;else goto _2;
    _2:
        gw(79,0,48);
        gw(79,2,49);
        gw(4,0,0);
        sp();
        sa(99);
    _3:
        sa(tm(sr()-1,3));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _22;else goto _4;
    _4:
        sa(sp()-2L);
        if(sp()!=0)goto _21;else goto _5;
    _5:
        gw(2,0,1);
        gw(3,0,79);
    _6:
        sa(79);
        sa(gr(79,0)-48);
    _7:
        t0=gr(gr(3,0),2);
        gw(gr(3,0),0,gr(gr(3,0),2));
        t0-=48;
        t0*=gr(2,0);
        sa(sp()+t0);
        t1=sp();
        t1+=gr(4,0);
        t0=(tm(t1,10))+48;
        gw(gr(3,0),2,t0);
        t1/=10;
        gw(4,0,t1);
        if(sr()!=9)goto _20;else goto _8;
    _8:
        sp();
        sa(sp()-1L);
        if((sr()+1)!=0)goto _9;else goto _11;
    _9:
        sa(sr());
        if(sp()!=0)goto _3;else goto _10;
    _10:
        gw(2,0,2);
        gw(3,0,79);
        goto _6;
    _11:
        sp();
        sa(0);
        sa(70);
        sa(gr(79,2)-48);
        sa(gr(79,2)-48);
    _12:
        if(sp()!=0)goto _13;else goto _19;
    _13:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _14:
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _15;else goto _18;
    _15:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _17;else goto _16;
    _16:
        sa(sp()+sp());
        goto _15;
    _17:
        sa(sp()+sp());
        t0=sp();
        System.Console.Out.Write(t0);
        return;
    _18:
        sa(sp()-1L);
        sa(sr()+9);
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        sa(sr());
        goto _12;
    _19:
        if(sp()!=0)goto _18;else goto _14;
    _20:
        sa(sp()-1L);
        sa(sr());
        gw(3,0,sp());
        sa(sr());
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        goto _7;
    _21:
        t0=(td(sr()+1,3))*2;
        gw(2,0,t0);
        gw(3,0,79);
        goto _6;
    _22:
        gw(2,0,1);
        gw(3,0,79);
        sp();
        goto _6;
    _23:
        sa(sp()-1L);
        goto _1;
}}