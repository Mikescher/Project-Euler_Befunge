/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3/fMvG0iwP1iftOvdpIwrZdu8TVxjdhQ/CZjKNUNpoaIOi+3HhxvLJZhD/jmbf7NpN9koo20bsf963mbus1mi8/bUfn716OjuDz/+"+
                                    "Pj16u+DSuvnxcXv4NNkZGB5s6GMYbOCHOtOB8zdaAx5dWG7J9/XJlrlzrj0T+pVoenyL3br2jVu38j1vr4vaYb7s6OmjNyPv92pOS5wofndG8sskncqOVEGxZBkvqVNn"+
                                    "o8vieyZkna+Qyp6vyVO4Tvns8ddVEbx/Y9wtOA3Pba2VlpN5O6921/vD+39UOfzIuvSv43zzj5vPMqIfV/YZzsn/drdo7qfqdsZ/8zR15unt63kYtP5wCH+tRLTU+u3h"+
                                    "tdky+tHZr45LPYx/vq2lbXdacN66VdfXtq0X3GO+qbmlzfqNuNdv/19bTP4+nDbz2JXnV02OhbSFBHmp+j1OV/1lUWZ49nbUkeVzTpnwZcbJx9+//+1W0KziWbuvtM24"+
                                    "3Fkk927O64r9p176eh7Osl2eqKP5vTQq/SPv9pvzmP4eO3J36pxzu22Wb4mZl7/Obp/9mk5+drOnE4L1LJ8HZX+r+fNWqdqr8lzlu1v97+5uyz2wfN/W5fejDjOzf1d+"+
                                    "/bp2puzbwwffXv728NZFO5k74W+3Tp/9u8D6d8GH+zevtO6ptdgRv+zppms/Y+Nsa0peuDN++3Xtf8T/Gamd6epvVUMv8rV/EJzH6jhBYAYTAwDFa1uflwIAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<1000&&y<170)?g[y*1000+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<1000&&y<170)g[y*1000+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,1000L);
        gw(2L,0L,150L);
        gw(0L,0L,150000L);
        gw(3L,0L,2L);
        gw(0L,3L,32L);
        gw(1L,3L,32L);
    _1:
        gw(tm(gr(3L,0L),gr(1L,0L)),(td(gr(3L,0L),gr(1L,0L)))+3L,88L);
        sa(gr(3L,0L)+gr(3L,0L));
        sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
    _2:
        if(sp()!=0)goto _34;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-32L);
        if(sp()!=0)goto _6;else goto _4;
    _6:
        if(gr(0L,0L)>gr(3L,0L))goto _1;else goto _7;
    _7:
        gw(3L,0L,1L);
        gw(4L,0L,0L);
    _8:
        sa(gr(tm(gr(3L,0L),gr(1L,0L)),(td(gr(3L,0L),gr(1L,0L)))+3L)-32L);
        if(gr(0L,0L)<=gr(3L,0L))goto _9;else goto _31;
    _9:
        gw(5L,0L,gr(4L,0L)-1L);
        gw(1L,2L,2L);
        gw(2L,2L,2L);
        sp();
        sa(2L);
    _10:
        sa(sr()+1L);
        sa(sr());
        gw(0L,1L,sp());
        gw(3L,1L,sp());
        gw(1L,1L,1L);
        sa(0L);
        sa(gr(0L,3L));
        sa((gr(0L,3L)*gr(0L,3L))>gr(0L,1L)?1:0);
    _11:
        if(sp()!=0)goto _30;else goto _12;
    _12:
        gw(2L,1L,1L);
    _13:
        sa(sr());
        sa(gr(3L,1L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _29;else goto _14;
    _14:
        gw(1L,1L,gr(1L,1L)*gr(2L,1L));
        if(gr(3L,1L)!=1L)goto _15;else goto _16;
    _15:
        sp();
        sa(sp()+1L);
        sa(sr());
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa((sp()>gr(0L,1L))?1:0);
        goto _11;
    _16:
        gw(2L,2L,gr(1L,1L));
        sp();
        sp();
    _17:
        if((gr(1L,2L)*gr(2L,2L))>500L)goto _28;else goto _18;
    _18:
        sa(sp()+1L);
        if(tm(sr(),2L)!=0)goto _19;else goto _10;
    _19:
        sa(td(sr()+1L,2L));
        sa(sr());
        gw(0L,1L,sp());
        gw(3L,1L,sp());
        gw(1L,1L,1L);
        sa(0L);
        sa(gr(0L,3L));
        sa((gr(0L,3L)*gr(0L,3L))>gr(0L,1L)?1:0);
    _20:
        if(sp()!=0)goto _27;else goto _21;
    _21:
        gw(2L,1L,1L);
    _22:
        sa(sr());
        sa(gr(3L,1L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _26;else goto _23;
    _23:
        gw(1L,1L,gr(1L,1L)*gr(2L,1L));
        if(gr(3L,1L)!=1L)goto _24;else goto _25;
    _24:
        sp();
        sa(sp()+1L);
        sa(sr());
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa((sp()>gr(0L,1L))?1:0);
        goto _20;
    _25:
        gw(1L,2L,gr(1L,1L));
        sp();
        sp();
        goto _17;
    _26:
        gw(2L,1L,gr(2L,1L)+1L);
        sa(sr());
        sa(gr(3L,1L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}
        gw(3L,1L,sp());
        goto _22;
    _27:
        gw(1L,2L,gr(1L,1L)*2L);
        sp();
        sp();
        goto _17;
    _28:
        sa(sr()+1L);
        sa(sp()*sp());
        sa(td(sp(),2L));
        System.Console.Out.Write((long)(sp()));
        return;
    _29:
        gw(2L,1L,gr(2L,1L)+1L);
        sa(sr());
        sa(gr(3L,1L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}
        gw(3L,1L,sp());
        goto _13;
    _30:
        gw(2L,2L,gr(1L,1L)*2L);
        sp();
        sp();
        goto _17;
    _31:
        if(sp()!=0)goto _32;else goto _33;
    _32:
        gw(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+3L,gr(3L,0L));
        gw(4L,0L,gr(4L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        goto _8;
    _33:
        gw(3L,0L,gr(3L,0L)+1L);
        goto _8;
    _34:
        sa(sr());
        sa(32L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3L,0L));
        sa(sr()<gr(0L,0L)?1:0);
        goto _2;
}}