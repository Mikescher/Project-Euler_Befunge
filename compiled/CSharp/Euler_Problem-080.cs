/* transpiled with BefunCompile v1.1.0 (c) 2015 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABACtkrFyhCAQhl+FQ6+RMbdy4kXCMCnyECkYTJEZWioqHz4/RM85c13UUWB32f32h8Q+85t/BzzVP54j6jP2fgTJyxEk4QgSOoLEj7WtWGXuhvTgTrtw"+
                                    "s9rMzlGzNPmq5d/ciU6vXmNrbrjtWq1HoYIbRRd15aearM6ma1BKnPE1ydJIUVotKSIJ3I2k0FZpqv180m0XlXh1baBboCFSv1XeLodxyzqhqK7Bg2Xem3FsrteFHkkH"+
                                    "iqU2CvSqaZobRbI3CgOFr9OsiixABzX9EpNbdPD3WvyNg6JhOpCMin9wiqYSq3dQy2TW4B4d6XgVo2E2I7QndLUJgpq5S8B0rSTPujUJrekg4gfvsiwEdSwiddNTZJu0"+
                                    "pRdWmkGDgPWRBoENwYiVfLKbZCkfFTQSRZoF8oz4yKi/YNTCJBA7cRFKhev+tMvVmJJ3ARu1NsTqPyEJ2aHJk52ZTqJxkrh79wi/Cy0JbRa6nZ/lWMZyN7IuNIpAYz6O"+
                                    "K+TCXDZgPxd+GB4AfwDY6hCc2gQAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<69&&y<18)?g[y*69+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<69&&y<18)g[y*69+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1,t2;
        gw(9,0,0);
        gw(2,0,2);
        sa(2);
    _1:
        sa(100);
        sa(10000-gr(2,0));
    _2:
        if(sp()!=0)goto _3;else goto _27;
    _3:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _5;else goto _4;
    _4:
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sp()-gr(2,0));
        goto _2;
    _5:
        gw(68,1,0);
        gw(68,3,0);
        gw(68,5,0);
        sp();
        sa(sr());
        sa(58);
    _6:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(3);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(5);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());

        if(sp()!=0)goto _35;else goto _7;
    _7:
        sp();
        gw(68,1,sp());
        gw(2,0,0);
        gw(4,0,gr(2,0)*gr(2,0));
        sa(100);
    _8:
        sa(59);
        sa(59);
        sa((gr(68,3)*gr(2,0)*20)+gr(4,0));
        gw(4,0,td((gr(68,3)*gr(2,0)*20)+gr(4,0),100));
    _9:
        sa(tm(sp(),100));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(5);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());

        if(sp()!=0)goto _34;else goto _10;
    _10:
        sp();
        sa(0);
        sa((gr(9,5)-gr(9,1)!=0)?0:1);
    _11:
        if(sp()!=0)goto _12;else goto _15;
    _12:
        sa(sp()+1L);


        if(sr()!=60)goto _13;else goto _14;
    _13:
        sa(sr());
        sa(sr()+9);
        sa(5);
        {long v0=sp();t0=gr(sp(),v0);}
        sa(sp()+9L);

        sa(1);
        {long v0=sp();t1=gr(sp(),v0);}
        sa(t0-t1);
        sa((sp()!=0)?0:1);
        goto _11;
    _14:
        gw(2,0,gr(2,0)+1);
        gw(4,0,gr(2,0)*gr(2,0));
        sp();
        goto _8;
    _15:
        sa(sr());
        sa(sr()+9);
        sa(5);
        {long v0=sp();t0=gr(sp(),v0);}
        sa(sp()+9L);

        sa(1);
        {long v0=sp();t1=gr(sp(),v0);}
        t2=t0>t1?1:0;
        t2=(t2!=0)?0:1;

        if((t2)!=0)goto _14;else goto _16;
    _16:
        gw(2,0,gr(2,0)-1);
        gw(68,5,0);
        gw(4,0,gr(2,0)*gr(2,0));
        gw(6,0,gr(68,1)-gr(4,0));
        gw(7,0,gr(68,3)*gr(2,0)*20);
        sp();
        sa(59);
        sa(59);
    _17:
        t0=0;
    _18:
        if(gr(7,0)<=gr(6,0))goto _19;else goto _33;
    _19:
        gw(4,0,t0);
        sa(gr(6,0)-gr(7,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+8L);

        sa(5);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _21;else goto _20;
    _20:
        sa(sr());
        sa(sr()+9);
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0-=gr(4,0);
        gw(6,0,t0);
        sa(sr()+9);
        sa(3);
        {long v0=sp();t0=gr(sp(),v0);}
        t0*=gr(2,0)*20;
        gw(7,0,t0);
        goto _17;
    _21:
        gw(68,1,gr(68,5));
        sp();
        sa(58);
    _22:
        sa(sr());
        sa(sr()+9);
        sa(5);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());

        if(sp()!=0)goto _32;else goto _23;
    _23:
        gw(9,3,((tm(gr(9,3),10))*10)+(td(gr(10,3),10)));
        sp();
        sa(1);
    _24:
        sa(sr());
        sa(sr());
        sa(sr()+9);
        sa(3);
        {long v0=sp();t0=gr(sp(),v0);}
        t0%=10;
        t0*=10;
        sa(sp()+10L);

        sa(3);
        {long v0=sp();t1=gr(sp(),v0);}
        t1/=10;
        sa(t0+t1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(3);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);
        if(sr()!=59)goto _24;else goto _26;
    _26:
        gw(68,3,((tm(gr(68,3),10))*10)+gr(2,0));
        gw(9,0,gr(2,0)+gr(9,0));
        gw(2,0,0);
        sp();
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _27;else goto _31;
    _27:
        sp();
        sa(sr()+1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-100L);


        if(sp()!=0)goto _29;else goto _30;
    _29:
        sa(sr());
        gw(2,0,sp());
        goto _1;
    _30:
        System.Console.Out.Write(gr(9,0));
        sp();
        return;
    _31:
        gw(4,0,gr(2,0)*gr(2,0));
        goto _8;
    _32:
        sa(sp()-1L);
        goto _22;
    _33:
        gw(6,0,gr(6,0)+100);
        t0++;
        goto _18;
    _34:
        sa(sp()-1L);

        sa(sr());
        sa(sr()+9);
        sa(3);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()*gr(2,0)*20);

        sa(sp()+gr(4,0));

        t0=td(sr(),100);
        gw(4,0,t0);
        goto _9;
    _35:
        sa(sp()-1L);
        goto _6;
}
}
