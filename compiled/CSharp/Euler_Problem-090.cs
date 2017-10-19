/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADtVc1uIyEMfhVPmEqrQbM1zE8yCKFK+wDdYw4R0xtXTpz68GuYIZm/tg+wsdoEbGNsfx9OgOt4vb6/A8sCGwl9qbc6MMAcMATGgV2AKfoLTJsAEq6P"+
                                    "UIz2vL0JLyV3UhaOdkrDaFk9qBfedZXyIjkIchDkQDv1mgxqDCAcDOt4e++Y2xgWAfc3zgE1yB4agD+LMvy2MGb7EthUMKU/ec09Ycs+iFp9lh9QGZToL0bhbeDoFQtj"+
                                    "iVJ4lNIPUdty4dOXnIxdx21wyAdP/7cirpRSqQxjJfApI1uL+R5tEe/LuzZrIj5lORYUWdTAUs6sIFgs++id1NA0O+zuYg+1U5GmnBzCeFn5muNDO3n77ZCuN0rUt1j2"+
                                    "3WDS5+U4TG4YbA6G7PA5YT5ExIkC0O+puZIw8UvpzcEu67OjNPPi2/pshsLOBw0Tj5whp20X9X4br9y+NvIuy4zBUli5U+3E0MXEgqWoYq/L6ref4hUZrdUlX9wtpevr"+
                                    "SL8xbCz3vVUHB+1u4MTyF/AzuQ64e7KQeSO/400aPYOm0LCOJ4/KCdMYibyRD95I4s2sXwZJb5f4RYOAtPyoyC95E3Omd7vgjZ1PSM9d9B4O4h3whi14E1mkF77m5Xb6"+
                                    "e3ptGksXt1sEjzjyBW9m4liKpm4Om3gJQuB967GlmcyHNk7lvk0tWSa5mp0ssJ1l6ieL+Brpinbg0vGOOmpadB06Thdj29NDE2SjAUtrmdaSfESyYLKIZAHahKCttpLy"+
                                    "EQQYEnZDidDSrwOpkCCl8dtpH9NGL2Y3SkCyqBJJNbu1mg5pdof9gUBepZIXrAgL4wovlt0NAUVgCP7o9mPFNoOD2jQbJwxM0zjuVIOujnQv7Rz1fqzePSyduPTjAKcn"+
                                    "0p2rGorPnGuSmTYGe/R4Rj+EJaRD0pFNz62wr0SS20tkSpyyAY6mGukr6bDPv+RlOHDZHDO3QL+DujrBr5Pe1Wg4pRcfU+zgaI2iJ+bO6GTFz5MhvjJS9OgUfX3Q1rSX"+
                                    "SlUVb9Bb9pSnPOUp/6n8A5fdc+wQDgAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<45)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<45)g[y*80+x]=v;}
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0;
        gw(3,3,29);
        gw(2,0,0);
        gw(17,0,0);
        sa(8);
        sa(8);
    _1:
        if(sp()!=0)goto _94;else goto _2;
    _2:
        gw(2,1,0);
        gw(2,2,0);
        gw(13,1,0);
        gw(13,2,0);
        sp();
        sa(9);
        sa(9);
    _3:
        if(sp()!=0)goto _93;else goto _4;
    _4:
        sp();
        sa(9);
        sa(9);
    _5:
        if(sp()!=0)goto _85;else goto _6;
    _6:
        sp();

        if(((gr(2,1)>6?1:0)+(gr(2,2)>6?1L:0L))!=0)goto _7;else goto _13;
    _7:
        gw(17,0,((gr(17,0))!=0)?0:1);
        sa(8);
        sa(8);
        sa(gr(17,0));
    _8:
        if(sp()!=0)goto _9;else goto _10;
    _9:
        sp();
        sp();
        sa(0);
        goto _2;
    _10:
        if(sp()!=0)goto _12;else goto _11;
    _11:
        System.Console.Out.Write(gr(2,0)+" ");
        sp();
        return;
    _12:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        sa(sr());
        sa(((gr(sr()+9,0))!=0)?0:1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+9L);

        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        goto _8;
    _13:
        if(gr(2,1)!=6)goto _84;else goto _14;
    _14:
        sa(2);
    _15:
        if(gr(2,2)!=6)goto _83;else goto _16;
    _16:
        sa(2);
    _17:
        gw(4,0,(((gr(10,1))!=0)?0:1)+gr(13,1));
        gw(5,0,(((gr(10,2))!=0)?0:1)+gr(13,2));
        sa(0);
    _18:
        gw(6,0,0);
        gw(7,0,0);
        gw(6,0,gr(13,1)+(gr(6,0)*2));
        sa(8);
        sa(9);
    _19:
        if(sp()!=0)goto _82;else goto _20;
    _20:
        gw(7,0,gr(13,2)+(gr(7,0)*2));
        sp();
        sa(8);
        sa(9);
    _21:
        if(sp()!=0)goto _81;else goto _22;
    _22:
        sp();
        sa(gr(7,0));
        sa(gr(6,0));

        if(gr(6,0)>gr(7,0))goto _23;else goto _24;
    _23:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _24:
        sa(sp()*1024L);

        sa(sp()+sp());

        t0=sp();
        gw(3,0,t0);
        sa(1279);
        sa(gr(79,15+gr(3,3)));
        sa(gr(79,15+gr(3,3))-gr(3,0));
    _25:
        if(sp()!=0)goto _26;else goto _80;
    _26:
        sa(sp()-35L);


        if(sp()!=0)goto _79;else goto _27;
    _27:
        sa(gr(3,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr()%80);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/80L);

        sa(sp()+gr(3,3));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(2,0,gr(2,0)+1);
    _28:
        sa(sp()+1L);

        sa(sr());

        if(sp()!=0)goto _29;else goto _78;
    _29:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _30;else goto _76;
    _30:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _31;else goto _75;
    _31:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _32;else goto _33;
    _32:
        return;
    _33:
        gw(10,1,1);
        gw(13,1,0);
        gw(10,2,1);
        gw(13,2,0);
        sp();
    _34:
        if((gr(4,0))!=0)goto _36;else goto _35;
    _35:
        gw(10,1,0);
        gw(13,1,1);
        sa(1);
        goto _18;
    _36:
        if((gr(5,0))!=0)goto _37;else goto _74;
    _37:
        sa(sr());

        if(sp()!=0)goto _38;else goto _73;
    _38:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _39;else goto _60;
    _39:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _32;else goto _40;
    _40:
        sp();
        t0=1;
        sa(sr());

        if(sp()!=0)goto _42;else goto _59;
    _42:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _43;else goto _45;
    _43:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _32;else goto _44;
    _44:
        sp();
        gw(17,0,((gr(17,0))!=0)?0:1);
        sa(8);
        sa(8);
        sa(gr(17,0));
        goto _8;
    _45:
        sp();
    _46:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _47:
        if(sp()!=0)goto _48;else goto _44;
    _48:
        sa(gr(sr()+4,1));
    _49:
        if(sp()!=0)goto _58;else goto _50;
    _50:
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}

        if(gr(2,1)!=5)goto _52;else goto _51;
    _51:
        sa(1);
        goto _15;
    _52:
        sa(9);
        sa(gr(13,1));
    _53:
        if(sp()!=0)goto _54;else goto _57;
    _54:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _55;else goto _56;
    _55:
        sa(gr(sr()+4,1));
        goto _53;
    _56:
        t0=2;
        sp();
        goto _46;
    _57:
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(0);
        goto _15;
    _58:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _47;
    _59:
        sp();
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _54;
    _60:
        sp();
    _61:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _62;else goto _40;
    _62:
        sa(gr(sr()+4,2));
    _63:
        if(sp()!=0)goto _72;else goto _64;
    _64:
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}

        if(gr(2,2)!=5)goto _66;else goto _65;
    _65:
        sa(1);
        goto _17;
    _66:
        sa(9);
        sa(gr(13,2));
    _67:
        if(sp()!=0)goto _68;else goto _71;
    _68:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _69;else goto _70;
    _69:
        sa(gr(sr()+4,2));
        goto _67;
    _70:
        t0=2;
        sp();
        goto _61;
    _71:
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(0);
        goto _17;
    _72:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _62;else goto _40;
    _73:
        sp();
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _68;
    _74:
        gw(10,2,0);
        t0=0;
        gw(13,2,1);
        sa(-1);
        goto _18;
    _75:
        gw(10,1,1);
        gw(13,1,0);
        sp();
        goto _36;
    _76:
        sp();

        if((gr(4,0)+gr(5,0))!=0)goto _34;else goto _77;
    _77:
        gw(10,1,0);
        gw(13,1,1);
        gw(10,2,0);
        gw(13,2,1);
        sa(2);
        goto _18;
    _78:
        gw(10,2,1);
        gw(13,2,0);
        sp();
        goto _37;
    _79:
        sa(sp()-1L);

        sa(sr());
        sa(sr()%80);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/80L);

        sa(sp()+gr(3,3));

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr()-gr(3,0));
        goto _25;
    _80:
        sp();
        sp();
        goto _28;
    _81:
        gw(7,0,gr(sr()+4,2)+(gr(7,0)*2));
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _21;
    _82:
        gw(6,0,gr(sr()+4,1)+(gr(6,0)*2));
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _19;
    _83:
        sa(9);
        sa(gr(13,2));
        goto _63;
    _84:
        sa(9);
        sa(gr(13,1));
        goto _49;
    _85:
        sa(sr());

        if((gr(sr()+8,0))!=0)goto _90;else goto _86;
    _86:
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sp()/10L);

        gw(2,2,(((gr(sr()+4,2))!=0)?0:1)+gr(2,2));
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sp()*sp());

        sa(sp()%10L);


        if(sr()!=9)goto _89;else goto _87;
    _87:
        gw(2,1,(((gr(10,1))!=0)?0:1)+gr(2,1));
        gw(10,1,1);
        sp();
    _88:
        t0=6;
        sa(sp()-1L);

        sa(sr());
        goto _5;
    _89:
        gw(2,1,(((gr(sr()+4,1))!=0)?0:1)+gr(2,1));
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _88;
    _90:
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(sp()/10L);

        gw(2,1,(((gr(sr()+4,1))!=0)?0:1)+gr(2,1));
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sp()*sp());

        sa(sp()%10L);


        if(sr()!=9)goto _92;else goto _91;
    _91:
        gw(2,2,(((gr(10,2))!=0)?0:1)+gr(2,2));
        gw(10,2,1);
        sp();
        goto _88;
    _92:
        gw(2,2,(((gr(sr()+4,2))!=0)?0:1)+gr(2,2));
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _88;
    _93:
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _3;
    _94:
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _1;
}
}
