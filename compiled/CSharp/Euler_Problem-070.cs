/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADtmFFr3DAMgP+KcO5g2KSxlaTJRHD3svc99sHkjh6HYXTMlNZP1/8+eTvYul5LSmm3B33ESizJsizbL8m2AKU1DXy5+f51v7uFz3fX+xuoS//qev8N"+
                                    "Bgvvy263e+cZl3BxcXz+JypBEARBEARBEARBEARBEIQ341//AT2N73t9rsnZ1A+a0Cbd2YStTQo/KO1cUvf8RpcsYnIOuY8ISmvduuSyt+z6M1D2kaUNuXyH2sEEjzVL"+
                                    "ycmOetSaqLQx8VytJQVq0ejNXG2jbaPtJkDIpu9p8sH5jzrQ4YRmca3UpWpt5GLFdWDRtIbTip6boc7GsD06VnmzKlpniMvzp3/kNdQHGMCvA1XzoWo4l7CaYHykeSVz"+
                                    "Mm0TrQtrFhR4XuKY89MD2OpXUAVfcWkqoMpszPy3JueF0+fo3GuX8CutZ1IuSWeozVQvDOapw0QPN+RS1bxf5Iyn/gljh7HHqGlAPolxy5oBI7KGDa7ui9A08v1gVbHO"+
                                    "ebO0Tse8Vjz07NMJS4bFR+G0X/5tfdmZmvka1dEhmYcbWaJMzxkX5Zq4fDgmdBGHl+T1Awao0RSKGwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<150&&y<47)?g[y*150+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<150&&y<47)g[y*150+x]=v;}
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0,t1,t2;
        gw(1,0,150);
        gw(2,0,35);
        gw(4,0,5250);
        gw(3,0,2);
        gw(1,1,2000);
        gw(2,1,5000);
        gw(2,2,0);
        gw(1,2,1);
        gw(3,1,10000000);
    _1:
        gw(0,3,32);
        gw(1,3,32);
        gw(8,0,1073741824);
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
    _2:
        if(sp()!=0)goto _38;else goto _3;
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
        if(gr(4,0)>gr(3,0))goto _1;else goto _7;
    _7:
        gw(3,0,0);
        sa(gr(1,1));
        sa(gr(1,1));
        sa(gr(1,1));
        gw(4,2,gr(1,1));
    _8:
        sa(tm(sp(),gr(1,0)));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+3L);

        {long v0=sp();t0=gr(sp(),v0);}
        t0-=88;

        if((t0)!=0)goto _9;else goto _12;
    _9:
        sa(sp()+1L);


        if((sr()-gr(2,1))!=0)goto _10;else goto _11;
    _10:
        sa(sr());
        gw(4,2,sp());
        sa(sr());
        sa(sr());
        goto _8;
    _11:
        System.Console.Out.Write(gr(1,2)+" ");
        sp();
        return;
    _12:
        sa(sr()+1);
    _13:
        sa(sr());
        gw(5,2,sp());
        sa(sr());
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+3L);

        {long v0=sp();t0=gr(sp(),v0);}
        t0-=88;

        if((t0)!=0)goto _16;else goto _14;
    _14:
        t0=gr(4,2)*gr(5,2);
        gw(7,2,gr(4,2)*gr(5,2));
        t0=t0>gr(3,1)?1:0;

        if((t0)!=0)goto _17;else goto _15;
    _15:
        t0=gr(7,2)*gr(2,2);
        t1=(gr(4,2)-1)*(gr(5,2)-1);
        gw(8,2,(gr(4,2)-1)*(gr(5,2)-1));
        t1*=gr(1,2);
        t2=t0>t1?1:0;

        if((t2)!=0)goto _16;else goto _18;
    _16:
        sa(sp()+1L);


        if((sr()-gr(2,1))!=0)goto _13;else goto _17;
    _17:
        sp();
        goto _9;
    _18:
        sa(0);
        sa(gr(7,2)%10);
        sa(gr(7,2));
        sa(gr(7,2));
    _19:
        if(sp()!=0)goto _20;else goto _24;
    _20:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(9);
    _21:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _23;else goto _22;
    _22:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/10L);

        sa(sr()%10);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _19;
    _23:
        sa(sp()-1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*9L);
        goto _21;
    _24:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sp();
        sp();
    _25:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _26;else goto _27;
    _26:
        sa(sp()+sp());
        goto _25;
    _27:
        sa(sp()+sp());

        sa(0);
        sa(gr(8,2)%10);
        sa(gr(8,2));
        sa(gr(8,2));
    _28:
        if(sp()!=0)goto _29;else goto _33;
    _29:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(9);
    _30:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _32;else goto _31;
    _31:
        sp();
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/10L);

        sa(sr()%10);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _28;
    _32:
        sa(sp()-1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*9L);
        goto _30;
    _33:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sp();
        sp();
    _34:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _37;else goto _35;
    _35:
        sa(sp()+sp());

        t0=sp();
        sa(sp()-t0);

        t1=sp();

        if((t1)!=0)goto _16;else goto _36;
    _36:
        gw(1,2,gr(7,2));
        gw(2,2,gr(8,2));
        goto _16;
    _37:
        sa(sp()+sp());
        goto _34;
    _38:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+3L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3,0));

        sa(sr()<gr(4,0)?1:0);
        goto _2;
}
}
