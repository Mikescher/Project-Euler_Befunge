/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0,t1;
        gw(1,0,1000);
        gw(2,0,150);
        gw(0,0,150000);
        gw(3,0,2);
        gw(0,3,32);
        gw(1,3,32);
    _1:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
    _2:
        if(sp()!=0)goto _35;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3,0)+1);
        sa(gr(3,0)+1);
        gw(3,0,gr(3,0)+1);
        sa(tm(sp(),gr(1,0)));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+3L);

        {long v0=sp();t0=gr(sp(),v0);}
        t0-=32;
        if((t0)!=0)goto _6;else goto _4;
    _6:
        if(gr(0,0)>gr(3,0))goto _1;else goto _7;
    _7:
        gw(3,0,1);
        gw(4,0,0);
    _8:
        t0=gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3)-32;

        if(gr(0,0)>gr(3,0))goto _32;else goto _9;
    _9:
        gw(5,0,gr(4,0)-1);
        gw(1,2,2);
        gw(2,2,2);
        sa(2);
        sa(0);
    _10:
        if(sp()!=0)goto _23;else goto _11;
    _11:
        sa(sr()+1);
        sa(sr());
        gw(0,1,sp());
        gw(3,1,sp());
        gw(1,1,1);
        sa(0);
        sa(gr(0,3));
        sa((gr(0,3)*gr(0,3))>gr(0,1)?1:0);
    _12:
        if(sp()!=0)goto _22;else goto _13;
    _13:
        gw(2,1,1);
    _14:
        t0=gr(3,1);
        sa(sr());
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}

        t1=sp();

        if((t1)!=0)goto _15;else goto _21;
    _15:
        gw(1,1,gr(1,1)*gr(2,1));

        if(gr(3,1)!=1)goto _16;else goto _17;
    _16:
        sp();
        sa(sp()+1L);

        sa(sr());
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+3L);

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa((sp()>gr(0,1))?1:0);
        goto _12;
    _17:
        gw(2,2,gr(1,1));
        sp();
        sp();
    _18:
        if((gr(1,2)*gr(2,2))>500)goto _20;else goto _19;
    _19:
        sa(sp()+1L);

        sa(sr()%2);
        goto _10;
    _20:
        t0=1;
        t1=1;
        t0=sr()+1;
        sa(sp()*t0);

        t1=sp();
        t1/=2;
        System.Console.Out.Write(t1+" ");
        return;
    _21:
        gw(2,1,gr(2,1)+1);
        t0=gr(3,1);
        sa(sr());
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}

        t1=sp();
        gw(3,1,t1);
        goto _14;
    _22:
        gw(2,2,gr(1,1)*2);
        sp();
        sp();
        goto _18;
    _23:
        sa((sr()+1)/2);
        sa(sr());
        gw(0,1,sp());
        gw(3,1,sp());
        gw(1,1,1);
        sa(0);
        sa(gr(0,3));
        sa((gr(0,3)*gr(0,3))>gr(0,1)?1:0);
    _24:
        if(sp()!=0)goto _31;else goto _25;
    _25:
        gw(2,1,1);
    _26:
        t0=gr(3,1);
        sa(sr());
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}

        t1=sp();

        if((t1)!=0)goto _27;else goto _30;
    _27:
        gw(1,1,gr(1,1)*gr(2,1));

        if(gr(3,1)!=1)goto _28;else goto _29;
    _28:
        sp();
        sa(sp()+1L);

        sa(sr());
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+3L);

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa((sp()>gr(0,1))?1:0);
        goto _24;
    _29:
        gw(1,2,gr(1,1));
        sp();
        sp();
        goto _18;
    _30:
        gw(2,1,gr(2,1)+1);
        t0=gr(3,1);
        sa(sr());
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(td(sp(),v0));}

        t1=sp();
        gw(3,1,t1);
        goto _26;
    _31:
        gw(1,2,gr(1,1)*2);
        sp();
        sp();
        goto _18;
    _32:
        if((t0)!=0)goto _33;else goto _34;
    _33:
        gw(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3,gr(3,0));
        gw(4,0,gr(4,0)+1);
        gw(3,0,gr(3,0)+1);
        goto _8;
    _34:
        gw(3,0,gr(3,0)+1);
        goto _8;
    _35:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+3L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3,0));

        sa(sr()<gr(0,0)?1:0);
        goto _2;
}
}
