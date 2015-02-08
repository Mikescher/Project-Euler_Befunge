/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
        goto _7;
    _0:
        if(sp()!=0)goto _9; else goto _10;
    _1:
        if(sp()!=0)goto _32; else goto _11;
    _2:
        if(sp()!=0)goto _24; else goto _14;
    _3:
        if(sp()!=0)goto _25; else goto _26;
    _4:
        if(sp()!=0)goto _18; else goto _19;
    _5:
        if(sp()!=0)goto _15; else goto _20;
    _6:
        if(sp()!=0)goto _31; else goto _30;
    _7:
        gw(1,0,1000);
        gw(2,0,150);
        gw(0,0,150000);
        gw(3,0,2);
        gw(0,3,32);
        gw(1,3,32);
        goto _8;
    _8:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3),88);
        sa((gr(3,0))+(gr(3,0)));
        sa((gr(0,0))>((gr(3,0))+(gr(3,0)))?1:0);
        goto _0;
    _9:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(3,0));
        sa(sp()+sp());
        sa(sr());
        sa(gr(0,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _0;
    _10:
        sp();
        goto _11;
    _11:
        sa((gr(3,0))+(1));
        gw(3,0,(gr(3,0))+(1));
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(32);
        {long v0=sp();sa(sp()-v0);}
        goto _1;
    _12:
        gw(3,0,1);
        gw(4,0,0);
        goto _33;
    _13:
        gw(5,0,(gr(4,0))-(1));
        gw(1,2,2);
        gw(2,2,2);
        sp();
        sa(2);
        sa(0);
        goto _2;
    _14:
        sa(sr());
        sa(1);
        sa(sp()+sp());
        sa(sr());
        gw(0,1,sp());
        gw(3,1,sp());
        gw(1,1,1);
        sa(0);
        sa(gr(tm(0,gr(1,0)),(td(0,gr(1,0)))+(3)));
        sa(((gr(tm(0,gr(1,0)),(td(0,gr(1,0)))+(3)))*(gr(tm(0,gr(1,0)),(td(0,gr(1,0)))+(3))))>(gr(0,1))?1:0);
        goto _5;
    _15:
        gw(2,2,(gr(1,1))*(2));
        sp();
        sp();
        goto _36;
    _16:
        sa(sr());
        sa(1);
        sa(sp()+sp());
        sa(sp()*sp());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        System.Console.Out.Write((long)(sp()));
        return;
    _17:
        sa(1);
        sa(sp()+sp());
        sa(1);
        goto _4;
    _18:
        sa(sr());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _2;
    _19:
        sa(sr());
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(gr(0,1));
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _5;
    _20:
        gw(2,1,1);
        goto _37;
    _21:
        gw(2,1,(gr(2,1))+(1));
        sa(sr());
        sa(gr(3,1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        gw(3,1,sp());
        goto _37;
    _22:
        gw(2,2,gr(1,1));
        sp();
        sp();
        goto _36;
    _23:
        sp();
        sa(1);
        sa(sp()+sp());
        sa(0);
        goto _4;
    _24:
        sa(sr());
        sa(1);
        sa(sp()+sp());
        sa(2);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(sr());
        gw(0,1,sp());
        gw(3,1,sp());
        gw(1,1,1);
        sa(0);
        sa(gr(tm(0,gr(1,0)),(td(0,gr(1,0)))+(3)));
        sa(((gr(tm(0,gr(1,0)),(td(0,gr(1,0)))+(3)))*(gr(tm(0,gr(1,0)),(td(0,gr(1,0)))+(3))))>(gr(0,1))?1:0);
        goto _3;
    _25:
        gw(1,2,(gr(1,1))*(2));
        sp();
        sp();
        goto _36;
    _26:
        gw(2,1,1);
        goto _34;
    _27:
        gw(2,1,(gr(2,1))+(1));
        sa(sr());
        sa(gr(3,1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        gw(3,1,sp());
        goto _34;
    _28:
        gw(1,2,gr(1,1));
        sp();
        sp();
        goto _36;
    _29:
        sp();
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        sa(gr(0,1));
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _3;
    _30:
        gw(3,0,(gr(3,0))+(1));
        goto _33;
    _31:
        gw(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3),gr(3,0));
        gw(4,0,(gr(4,0))+(1));
        gw(3,0,(gr(3,0))+(1));
        goto _33;
    _32:
        sa((gr(0,0))>(gr(3,0))?1:0);
        if(sp()!=0)goto _8; else goto _12;
    _33:
        sa((gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3)))-(32));
        sa((((gr(0,0))>(gr(3,0))?1:0)!=0)?0:1);
        if(sp()!=0)goto _13; else goto _6;
    _34:
        sa(sr());
        sa(gr(3,1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _27; else goto _35;
    _35:
        gw(1,1,(gr(1,1))*(gr(2,1)));
        sa((gr(3,1))-(1));
        if(sp()!=0)goto _29; else goto _28;
    _36:
        sa(((gr(1,2))*(gr(2,2)))>(500)?1:0);
        if(sp()!=0)goto _16; else goto _17;
    _37:
        sa(sr());
        sa(gr(3,1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _21; else goto _38;
    _38:
        gw(1,1,(gr(1,1))*(gr(2,1)));
        sa((gr(3,1))-(1));
        if(sp()!=0)goto _23; else goto _22;
}}