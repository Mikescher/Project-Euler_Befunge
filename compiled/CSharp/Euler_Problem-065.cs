/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0,t1;
        gw(79,0,48);
        gw(79,2,48);
        sa(70);
        sa(70);
    _1:
        if(sp()!=0)goto _24;else goto _2;
    _2:
        gw(79,0,48);
        gw(79,2,49);
        gw(4,0,0);
        sp();
        sa(99);
        sa(99);
    _3:
        if(sp()!=0)goto _4;else goto _23;
    _4:
        sa((sr()-1)%3);
        sa(sr());

        if(sp()!=0)goto _5;else goto _22;
    _5:
        sa(sp()-2L);


        if(sp()!=0)goto _21;else goto _6;
    _6:
        gw(2,0,1);
    _7:
        gw(3,0,79);
        sa(79);
        sa(gr(79,0)-48);
    _8:
        t0=gr(gr(3,0),2)-48;
        gw(gr(3,0),0,gr(gr(3,0),2));
        t0*=gr(2,0);
        sa(sp()+t0);

        t1=sp();
        t1+=gr(4,0);
        gw(gr(3,0),2,(t1%10)+48);
        t1/=10;
        gw(4,0,t1);

        if(sr()!=9)goto _20;else goto _9;
    _9:
        sp();
        sa(sp()-1L);


        if(sr()!=-1)goto _19;else goto _10;
    _10:
        sp();
        sa(0);
        sa(70);
        sa(gr(79,2)-48);
        sa(gr(79,2)-48);
    _11:
        if(sp()!=0)goto _12;else goto _18;
    _12:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _13:
        sa(sr());

        if(sp()!=0)goto _17;else goto _14;
    _14:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _15;else goto _16;
    _15:
        sa(sp()+sp());
        goto _14;
    _16:
        sa(sp()+sp());

        t0=sp();
        System.Console.Out.Write(t0+" ");
        return;
    _17:
        sa(sp()-1L);

        sa(gr(sr()+9,2)-48);
        sa(sr());
        goto _11;
    _18:
        if(sp()!=0)goto _17;else goto _13;
    _19:
        sa(sr());
        goto _3;
    _20:
        sa(sp()-1L);

        sa(sr());
        gw(3,0,sp());
        sa(sr());
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        goto _8;
    _21:
        gw(2,0,((sr()+1)/3)*2);
        goto _7;
    _22:
        gw(2,0,1);
        sp();
        goto _7;
    _23:
        gw(2,0,2);
        goto _7;
    _24:
        sa(sp()-1L);

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
        goto _1;
}
}
