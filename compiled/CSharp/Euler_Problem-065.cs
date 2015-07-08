/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
        gw(79L,0L,48L);
        gw(79L,2L,48L);
        sa(69L);
    _1:
        sa(sr()+9L);
        sa(48L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(0L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()+9L);
        sa(48L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        if(sp()!=0)goto _23;else goto _2;
    _2:
        gw(79L,0L,48L);
        gw(79L,2L,49L);
        gw(4L,0L,0L);
        sp();
        sa(99L);
    _3:
        sa(tm(sr()-1L,3L));
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _22;else goto _4;
    _4:
        sa(sp()-2L);
        if(sp()!=0)goto _21;else goto _5;
    _5:
        gw(2L,0L,1L);
        gw(3L,0L,79L);
    _6:
        sa(79L);
        sa(gr(79L,0L)-48L);
    _7:
        sa(gr(gr(3L,0L),2L));
        gw(gr(3L,0L),0L,gr(gr(3L,0L),2L));
        sa(sp()-48L);
        sa(sp()*gr(2L,0L));
        sa(sp()+sp());
        sa(sp()+gr(4L,0L));
        sa((tm(sr(),10L))+48L);
        gw(gr(3L,0L),2L,sp());
        sa(td(sp(),10L));
        gw(4L,0L,sp());
        if(sr()!=9L)goto _20;else goto _8;
    _8:
        sp();
        sa(sp()-1L);
        if((sr()+1L)!=0)goto _9;else goto _11;
    _9:
        sa(sr());
        if(sp()!=0)goto _3;else goto _10;
    _10:
        gw(2L,0L,2L);
        gw(3L,0L,79L);
        goto _6;
    _11:
        sp();
        sa(0L);
        sa(70L);
        sa(gr(79L,2L)-48L);
        sa(gr(79L,2L)-48L);
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
        if(sp()!=0)goto _16;else goto _17;
    _16:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _17:
        sa(sp()+sp());
        goto _15;
    _18:
        sa(sp()-1L);
        sa(sr()+9L);
        sa(2L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        sa(sr());
        goto _12;
    _19:
        if(sp()!=0)goto _18;else goto _14;
    _20:
        sa(sp()-1L);
        sa(sr());
        gw(3L,0L,sp());
        sa(sr());
        sa(0L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        goto _7;
    _21:
        sa((td(sr()+1L,3L))*2L);
        gw(2L,0L,sp());
        gw(3L,0L,79L);
        goto _6;
    _22:
        gw(2L,0L,1L);
        gw(3L,0L,79L);
        sp();
        goto _6;
    _23:
        sa(sp()-1L);
        goto _1;
}}